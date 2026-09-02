#!/usr/bin/env bash
# Regenerate all export formats from the Markdown source files.
# Usage:  ./build.sh          (build everything)
#         ./build.sh fabric-architect   (build one variant)
set -euo pipefail

ROOT="$(cd "$(dirname "$0")" && pwd)"
OUT_DOCX="$ROOT/../exports/docx"
OUT_TXT="$ROOT/../exports/txt"
OUT_PDF="$ROOT/../exports/pdf"
mkdir -p "$OUT_DOCX" "$OUT_TXT" "$OUT_PDF"

# Markdown source  ->  output basename
declare -A MAP=(
  ["MASTER.md"]="Parvin_Eric_MASTER_Resume"
  ["variants/fabric-architect.md"]="Parvin_Eric_Fabric_Architect_Resume"
  ["variants/powerbi-consultant.md"]="Parvin_Eric_PowerBI_Consultant_Resume"
  ["variants/ai-enablement.md"]="Parvin_Eric_AI_Enablement_Resume"
  ["variants/devops-analytics.md"]="Parvin_Eric_DevOps_Analytics_Resume"
  ["variants/consulting-profile.md"]="Parvin_Eric_Consulting_Profile"
  ["variants/capabilities-statement.md"]="Parvin_Eric_Consulting_Capabilities_Statement"
)

build_one () {
  local src="$1" base="$2"
  echo "  $src"

  # DOCX - single column, standard headings, native bullets (ATS safe)
  pandoc "$src" \
    --from=markdown \
    --to=docx \
    --standalone \
    -V papersize=letter \
    -o "$OUT_DOCX/$base.docx"

  # Plain text - for recruiter portal paste fields
  pandoc "$src" \
    --from=markdown \
    --to=plain \
    --wrap=none \
    -o "$OUT_TXT/$base.raw.txt"

  # Strip YAML front matter and normalize to ASCII
  python3 - "$OUT_TXT/$base.raw.txt" "$OUT_TXT/$base.txt" <<'PY'
import sys, re
src, dst = sys.argv[1], sys.argv[2]
s = open(src, encoding='utf-8').read()
s = re.sub(r'\A-{3,}.*?-{3,}\n', '', s, flags=re.S)   # drop front matter
for a, b in {'\u2014': ' - ', '\u2013': '-', '\u2019': "'", '\u2018': "'",
             '\u201c': '"', '\u201d': '"', '\u2022': '-', '\u00a0': ' ',
             '\u2026': '...'}.items():
    s = s.replace(a, b)
s = re.sub(r'(?m)^\s{4,}(?=\S)', '  ', s)
s = re.sub(r'\n{3,}', '\n\n', s).strip() + '\n'
bad = sorted({c for c in s if ord(c) > 126})
if bad:
    print(f'    WARNING non-ascii remaining: {bad}')
open(dst, 'w', encoding='utf-8').write(s)
PY
  rm -f "$OUT_TXT/$base.raw.txt"
}

if [ $# -gt 0 ]; then
  for key in "${!MAP[@]}"; do
    if [[ "$key" == *"$1"* ]]; then build_one "$ROOT/$key" "${MAP[$key]}"; fi
  done
else
  echo "Building all documents..."
  for key in "${!MAP[@]}"; do
    build_one "$ROOT/$key" "${MAP[$key]}"
  done
fi

echo
echo "Done."
echo "  DOCX -> $OUT_DOCX"
echo "  TXT  -> $OUT_TXT"
echo
echo "Before sending: open the DOCX and confirm single column, standard"
echo "headings, and native bullets. Run the ATS Checklist in the toolkit."
