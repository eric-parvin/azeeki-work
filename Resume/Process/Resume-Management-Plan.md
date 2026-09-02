# Resume Management Plan

## Decision

Use Markdown as the editable source in a private GitHub repository. Generate Word, PDF, and plain-text files from Markdown. Do not maintain Word or text as parallel sources.

This gives Git useful wording diffs, keeps AI-assisted edits reviewable, and prevents the formats from drifting apart. Word remains the normal submission format; plain text is for portal paste fields; PDF is produced only when requested.

## Current Assessment

The content in `Resume/source/MASTER.md` and `Resume/source/variants/` can be managed as Markdown. The ATS-friendly, single-column structure maps well to generated Word documents.

The current workflow is not runnable as written:

- The script targets `Resume/exports`, while the existing folders are under `Resume/source/exports`.
- The script claims to create PDF files but contains no PDF conversion step.
- This Windows computer has PowerShell and Python, but not Bash or Pandoc.
- The process folder contains duplicate and conflicting guidance about the source of truth and whether rates belong in a resume.

## Target Structure

```text
Resume/
  README.md
  source/
    MASTER.md
    variants/
      fabric-architect.md
      powerbi-consultant.md
      ai-enablement.md
      devops-analytics.md
      consulting-profile.md
      capabilities-statement.md
  templates/
    reference.docx
  scripts/
    build.ps1
  exports/                 Generated; do not edit or commit
  sent/
    source/                Tailored Markdown committed to Git
  evidence/                Sources for metrics and claims
  Process/
    Resume-Management-Plan.md
    archive/               Superseded AI-generated instructions
```

## Routine Workflow

1. Capture new skills, engagements, credentials, and measurable results in the evidence record.
2. Update `MASTER.md` first and commit the change.
3. Copy only relevant, verified changes into the appropriate variants and commit them.
4. For an application, copy the closest variant into `sent/source/` and tailor that copy to the job description.
5. Run `build.ps1` to generate DOCX, TXT, and, when needed, PDF files.
6. Open the generated DOCX and verify page count, bullets, headings, links, and ATS-friendly layout before sending.
7. Commit the tailored Markdown and tag the commit with the company, role, and date. Store the exact submitted DOCX or PDF in personal OneDrive if an immutable copy is needed.

## Git Policy

Commit Markdown sources, the build script, the Word reference template, and concise process documentation. Do not commit routine files under `exports/`; DOCX files are binary and TXT files are reproducible, so neither provides useful Git history.

Keep the repository private because the resumes contain personal contact information and named customer work. Keep evidence containing customer-confidential material outside Git or store only a redacted reference to its location.

## One-Time Cleanup

1. Revise `Resume/README.md` to match this plan.
2. Replace `source/build.sh` with a Windows-first `build.ps1` and install Pandoc.
3. Add a styled, ATS-safe `reference.docx` so regenerated Word files have stable formatting.
4. Add `exports/` to `.gitignore` and test a full build from a clean checkout.
5. Move the other process drafts to `Process/archive/`; keep this file as the authoritative process.

## Bottom Line

The Markdown approach is manageable and better than version-controlling Word and text alone, but the repository needs the one-time cleanup above before it is dependable. The key rule is simple: edit Markdown, generate delivery formats, and never edit generated files.