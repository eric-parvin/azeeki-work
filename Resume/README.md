# Resume Repository — Eric Parvin

Markdown is the source of truth. Word, PDF, and plain-text files are **generated artifacts** — never edit them directly.

```
source/
  MASTER.md                          Edit here first. Never submitted.
  variants/
    fabric-architect.md
    powerbi-consultant.md
    ai-enablement.md
    devops-analytics.md
    consulting-profile.md
    capabilities-statement.md
  build.sh                           Regenerates all exports
exports/
  docx/    Word files for upload
  txt/     Plain text for recruiter portal paste fields
  pdf/     Text-based PDFs when a PDF is requested
sent/      Tailored copies actually submitted, one per application
reference/ Variant guide, maintenance process, certification record
evidence/  Every metric with its source
```

---

## Which document to send

| Situation | Source file |
|---|---|
| Fabric / data platform architect role | `variants/fabric-architect.md` |
| Power BI / analytics / semantic modeling role | `variants/powerbi-consultant.md` |
| AI, Copilot, or agentic engineering role | `variants/ai-enablement.md` |
| DevOps / delivery analytics role | `variants/devops-analytics.md` |
| Staffing agency or vendor recruiter | `variants/consulting-profile.md` |
| Direct conversation with a prospective client | `variants/capabilities-statement.md` |
| Your own reference | `MASTER.md` — **never send** |

---

## Building exports

```bash
./source/build.sh                    # all documents
./source/build.sh fabric-architect   # a single variant
```

Requires `pandoc` and `python3`.

The script generates DOCX and a normalized ASCII TXT for each source file, strips YAML front matter from the text version, and warns if any non-ASCII characters survive.

---

## Editing rules

1. **MASTER first, always.** Add new content to `MASTER.md`, then propagate to the relevant variants. MASTER is the database; variants are views.
2. **Never edit files in `exports/`.** They are overwritten on every build.
3. **Never claim an unearned credential.** Active only: DP-600, AI-900, PL-900, AZ-900, MCP.
4. **Never state an outcome the evidence does not support.** Check `evidence/metrics.md` and the Reference Projects sheet before adding a number.
5. **No rate on any document.** Keep rate guidance private and discuss it in conversation.
6. **Tailor on a copy.** Copy the variant into `sent/`, tailor there, commit, tag. Never tailor the stored variant.

---

## Front matter

Each source file carries YAML front matter recording the document type, audience, and last-updated date. Pandoc strips it from the plain-text export automatically. Update `last_updated` when you make a substantive change.

---

## Per-application workflow

```bash
cp source/variants/fabric-architect.md sent/2026-09-15-acme-data-architect.md
# tailor: swap in MASTER bullets that match the posting, mirror its terminology
./build.sh                                     # regenerate exports
git add . && git commit -m "sent: Acme Corp senior data architect"
git tag -a sent/2026-09-15-acme -m "Acme Corp - Senior Data Architect - fabric variant"
```

Tagging means `git show sent/2026-09-15-acme` reproduces exactly what they read.

---

## Before every submission

- [ ] Single column, standard headings, native bullets in the generated DOCX
- [ ] Terminology mirrors the posting, acronym and spelled-out form on first use
- [ ] Every number is defensible with a source
- [ ] Certifications current — DP-600 expires **August 2027**
- [ ] Logged in the Application Tracker

---

## Repository must stay private

These files contain a home metro, phone number, personal email, and named customers. Keep the repository private and use a personal GitHub account, not an enterprise-linked one.
