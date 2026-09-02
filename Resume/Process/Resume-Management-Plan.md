# Resume Management Plan

## Decision

`Resume/resume-bank` is now the active resume system. Its editable sources are the two JavaScript generators, not the Markdown or Word files:

- `build.js` owns the master resume and five targeted resumes.
- `capability.js` separately owns the consulting capabilities statement.
- `tomd.py` reads the seven generated Word files and produces readable Markdown and plain-text copies.

The earlier Markdown-first files under `Resume/source` represent a different workflow and should not be updated in parallel. Archive them after the new bank can be rebuilt locally and its content has been verified.

## How It Works

```text
build.js ---------------------------------> 6 DOCX files
  shared contact, credentials, bullets
  variant summaries, skills, bullet keys

capability.js ----------------------------> 1 DOCX file
  independently maintained content

7 DOCX files -> tomd.py -> 7 Markdown views + 7 TXT exports

PDF generation: not implemented
```

`build.js` reduces drift by storing reusable content in named objects such as `B`, `COMMERCIAL`, `REC`, and `ACC`. Each entry in `VARIANTS` selects and orders the keys appropriate to that audience. The `MASTER` entry is another generated variant; it is not a database that automatically drives the others.

The capabilities statement does not use those shared objects. Contact details, credentials, awards, and claims that appear in both generators must currently be updated in both places.

## Current Status

The bank contains the expected seven DOCX files and seven TXT files. It also contains seven Markdown views: the master at the bank root and six files under `exports/md`. The PDF folder is empty.

The package is not locally reproducible yet:

- All scripts are hard-coded to the temporary Linux path `/mnt/data` instead of the repository.
- The `docx` Node package is not installed and no `package.json` or lock file records its version.
- Pandoc is not installed on this Windows computer.
- There is no single command that runs both generators and the conversion step.
- `tomd.py` does not generate PDFs.
- Generated Markdown front matter incorrectly says to edit Markdown.
- Generated role headers are plain text rather than Markdown headings, so Markdown is useful for review and Git diffs but should not be treated as lossless source.

## Content Update Workflow

1. Record evidence for any new metric, award, credential, or customer claim.
2. Add reusable resume wording once to the appropriate named object in `build.js`.
3. Add its key to each relevant `VARIANTS` list and update any variant-specific summary or skills text.
4. Update `capability.js` separately when the change belongs in the capabilities statement.
5. Run the complete local build to recreate DOCX, Markdown, and TXT outputs.
6. Review Git diffs in the generated Markdown to confirm wording and variant placement.
7. Open every changed DOCX and verify layout, page count, headings, bullets, and links.
8. Generate PDF only when requested and visually compare it with the DOCX.
9. Commit the generator changes and generated Markdown views. Keep routine DOCX, TXT, and PDF outputs out of Git unless preserving an exact submitted copy is required.

## Required Build Repair

Before relying on this workflow:

1. Replace every `/mnt/data` path with paths derived from each script's directory.
2. Add `package.json` and `package-lock.json` with the `docx` dependency.
3. Add one Windows-friendly build command that runs `build.js`, `capability.js`, and `tomd.py` in order.
4. Make all outputs write directly to `exports/docx`, `exports/md`, `exports/txt`, and `exports/pdf`.
5. Correct generated front matter to say that JavaScript is authoritative and Markdown is read-only.
6. Add DOCX validation and a check that all seven outputs exist in each required format.
7. Add a PDF conversion step only if PDF is part of the normal deliverable.

## Git Policy

Commit the JavaScript and Python sources, dependency manifests, build command, README, and generated Markdown views. Keep the repository private because the files contain personal contact information and named customer work. Keep confidential evidence outside Git or commit only a redacted pointer to its approved location.

## Bottom Line

The new design is stronger than maintaining seven resumes independently because shared bullet keys control reuse and ordering. However, the previous AI overstated it: `build.js` is authoritative for six documents, while `capability.js` is a second source for the seventh. The copied package demonstrates the intended output but cannot currently reproduce it on this Windows computer without the build repairs above.