import re
import urllib.request
import urllib.error
import subprocess

filepath = r'Lee_Mason\Forms-Custom\Project_Management\Project_Tracking.md'

print("--- Running git diff --check ---")
result_git = subprocess.run(['git', 'diff', '--check'], capture_output=True, text=True)
print("STDOUT:", result_git.stdout)
print("STDERR:", result_git.stderr)
print("Exit Code:", result_git.returncode)

# Since the file is untracked, we should also check git diff with standard flags or staging git diff --check
# Let's stage it temporarily to run git diff --check on it, then restore it
subprocess.run(['git', 'add', filepath])
print("--- Running git diff --cached --check ---")
result_git_cached = subprocess.run(['git', 'diff', '--cached', '--check'], capture_output=True, text=True)
print("STDOUT:", result_git_cached.stdout)
print("STDERR:", result_git_cached.stderr)
print("Exit Code:", result_git_cached.returncode)
subprocess.run(['git', 'reset', filepath])

print("\n--- Parsing Markdown File ---")
with open(filepath, 'r', encoding='utf-8') as f:
    lines = f.readlines()

errors = []

# 1. Consistent column counts in Markdown tables
print("Checking markdown tables...")
in_table = False
table_cols = 0
table_start_line = 0

for idx, line in enumerate(lines):
    line_stripped = line.strip()
    if line_stripped.startswith('|') and line_stripped.endswith('|'):
        # It's a table row
        # Count cells (columns)
        # Note: escaping needs to be accounted for, but splitting by | works for basic checks
        # Let's clean escaping \| first
        temp_line = line_stripped[1:-1].replace('\\|', '___')
        cols = len(temp_line.split('|'))
        if not in_table:
            in_table = True
            table_cols = cols
            table_start_line = idx + 1
            print(f"Table found starting at line {table_start_line} with {table_cols} columns.")
        else:
            # Check if this is a separator row (contains only dashes, colons, spaces, pipes)
            is_separator = all(c in '-: |' for c in temp_line)
            if not is_separator and cols != table_cols:
                errors.append(f"Table starting at line {table_start_line} has inconsistent columns at line {idx+1}: expected {table_cols}, got {cols}")
    else:
        if in_table:
            print(f"Table ending. Checked lines {table_start_line} to {idx}")
            in_table = False

# 2. Check for malformed markdown links
# A markdown link is like [text](url). Malformed ones might look like [text(url), [text] (url), [text](url, [text])url, etc.
# Also check for empty links like []() or missing parenthesis/brackets
print("\nChecking for malformed Markdown links...")
full_txt = "".join(lines)

# Find instances of [ or ] or ( or ) that look like broken links
# E.g., unbalanced brackets or parenthesis in potential link context, or spaces between bracket and parenthesis
# Let's find matches for:
# - [something] (something) -> space between is technically not a standard markdown link in some renderers, but let's see.
# - unbalanced [] or () or links starting with [ but not closed/followed properly
# Let's do a regex search for potential broken markdown links.
# Pattern for space between [text] and (link):
space_links = re.findall(r'\[[^\]]+\]\s+\([^)]+\)', full_txt)
for sl in space_links:
    errors.append(f"Malformed link (space between bracket and parenthesis): {sl}")

# Standard link regex
links = re.findall(r'\[([^\]]*)\]\(([^)]*)\)', full_txt)

# Find unclosed links or suspicious markdown patterns
# Check lines that contain [ but no matching ]( or similar
for idx, line in enumerate(lines):
    # If the line has [ followed by text but missing closing, etc.
    # We can count brackets and parentheses.
    open_b = line.count('[')
    close_b = line.count(']')
    open_p = line.count('(')
    close_p = line.count(')')
    if open_b != close_b:
        errors.append(f"Line {idx+1}: Unbalanced brackets '[' or ']': {line.strip()}")
    # check for link parentheses balance if it contains local markdown pattern
    if '](' in line:
        # there should be matching parens
        if line.count('](') > (line.count(')') - line.count('](')):
            # This is a heuristic test, let's be careful. Let's just flag if overall parens are unbalanced
            pass

# 3. Extract and verify learn.microsoft.com links
print("\nExtracting and verifying learn.microsoft.com links...")
microsoft_links = []
for title, url in links:
    if 'learn.microsoft.com' in url:
        microsoft_links.append((title, url))

import urllib.request

user_agent = 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36'

for title, url in microsoft_links:
    print(f"Testing URL: {url} ({title})")
    try:
        # Build Request to handle user-agent to prevent blocks
        req = urllib.request.Request(url, headers={'User-Agent': user_agent})
        with urllib.request.urlopen(req, timeout=10) as response:
            final_url = response.geturl()
            status = response.getcode()
            print(f"  Response Status: {status}")
            print(f"  Final Resolved URL: {final_url}")
            
            # "...without redirecting to unrelated content..."
            # Check if redirect happened
            # If the path changes significantly (e.g., redirect to generic homepage/error page)
            if final_url != url:
                # Some redirection is normal (e.g., adding locale like en-us)
                # But redirecting to learn.microsoft.com/en-us/ or error page is a failure
                url_clean = url.split('#')[0].rstrip('/')
                final_clean = final_url.split('#')[0].rstrip('/')
                # If they redirect to error page or main portal page
                if 'error' in final_clean or final_clean == 'https://learn.microsoft.com/en-us' or final_clean == 'https://learn.microsoft.com':
                    errors.append(f"Link redirecting to unrelated/error page: {url} -> {final_url}")
                else:
                    print(f"  Acceptable redirect: {url} -> {final_url}")
    except urllib.error.HTTPError as e:
        errors.append(f"HTTP Link Failure: {url} returned status {e.code}")
    except urllib.error.URLError as e:
        errors.append(f"URL Link Failure: {url} error: {e.reason}")
    except Exception as e:
        errors.append(f"Link Error: {url} general failure: {str(e)}")

print("\n--- Validation Summary ---")
if errors:
    print("FAIL")
    for err in errors:
        print(f"ERROR: {err}")
else:
    print("PASS")
