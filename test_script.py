with open(r'Lee_Mason\Forms-Custom\Project_Management\Project_Tracking.md', 'r', encoding='utf-8') as f:
    text = f.read()

import re

# Find all links
links = re.findall(r'\[([^\]]*)\]\(([^)]*)\)', text)
print(f'Total links found: {len(links)}')
for title, url in links[:10]:
    print(f'Title: {title} | URL: {url}')
