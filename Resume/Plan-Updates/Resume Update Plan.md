# Resume Update Plan — Eric Parvin
**Prepared:** September 2, 2026
**Purpose:** Review and approve before new resume versions are created.

---

## 1. What I reviewed

| Item | Source | Role in the plan |
|---|---|---|
| `Eric Parvin Resume.docx` | Attached | Legacy version. Broad "cloud architect" positioning, single Microsoft block from 2017, no certifications section. |
| `Eric_Parvin_Resume_2026-09-01.docx` | Attached | Current version. Much stronger content and role separation, but built with tables and decorative bullets. |
| Microsoft Learn active certifications | Attached screenshot | Verified certification facts. Resolves the open item flagged in the skills workbook. |
| Technology & Skills Inventory + Reference Projects | Prior workbook | Source of new content and evidence. |

---

## 2. Certifications — now verified

These are confirmed **active** and should be added. Neither resume currently has a certifications section at all.

| Certification | Earned | Expires |
|---|---|---|
| Microsoft Certified: Fabric Analytics Engineer Associate (DP-600) | Aug 18, 2025 | Aug 18, 2027 |
| Microsoft Certified: Azure AI Fundamentals (AI-900) | Feb 27, 2026 | — |
| Microsoft Certified: Power Platform Fundamentals (PL-900) | Dec 21, 2021 | — |
| Microsoft Certified: Azure Fundamentals (AZ-900) | Feb 6, 2019 | — |
| Microsoft Certified Professional | Dec 8, 2017 | — |

**Decisions to confirm:**
- **DP-600 is the headline.** Recommend placing it in the professional summary and in the header credential line, not buried at the bottom.
- **AI-900 (Feb 2026) is recent and on-trend.** Include prominently.
- **AZ-900 / PL-900 / MCP are dated fundamentals.** Recommend listing them in a compact single line rather than as full entries, so they support rather than dilute.
- **Do not claim DP-700, PL-300, or GH-300.** They appear in your skilling plans but are not active certifications.

---

## 3. Format assessment

### `Eric_Parvin_Resume_2026-09-01.docx` — strong content, risky construction

**What works and should be kept:**
- Role separation into Data & AI (2025–present), Application Innovation (2023–2025), and Azure DevOps & App Dev (2017–2023). This is a significant improvement and shows current relevance.
- Four-bucket Core Expertise grouping (Data & AI / Azure Apps / DevOps / Delivery).
- Compressed pre-2007 history under "Additional Technology & Leadership Experience."
- Specific, current terminology: OneLake, Direct Lake, Dataflow Gen2, incremental watermark patterns, semantic models, Fabric Data Agents.

**What must change:**

| Issue | Why it matters | Fix |
|---|---|---|
| Core Expertise and every job header are **Word tables** | Tables are a leading cause of parse failure; content can be dropped or scrambled | Convert to single-column text. Job header on one line: `Title \| Company \| Location \| Dates` |
| Bullets are literal `•` characters inside colored spans | Not recognized as list items by parsers | Use native Word list bullets |
| Footer line with name/title repeated | Header/footer text is frequently ignored or mis-parsed | Remove |
| No certifications section | Loses verified, searchable keywords (DP-600, AI-900) | Add dedicated section |
| No metrics anywhere except the 25% Amalga item | Quantified impact is the top differentiator for architect resumes | Add 4–6 real numbers (see §5) |
| No portfolio links | Blog series, public repo, and training assets are proof | Add a Portfolio line in the header |
| Microsoft tenure is fragmented across role blocks | ATS may compute tenure incorrectly | Add a single `Microsoft \| Oct 2007 – 2026` parent line, then roles beneath |
| Length | Currently runs long | Target 2 pages for sent versions |

### `Eric Parvin Resume.docx` — retire as a sent document

- Summary contains typos (`processe`, doubled spacing) and reads as generic keyword prose.
- Understates tenure: shows Microsoft starting March 2017.
- Core Competencies is a single bullet-separated paragraph, harder to parse than grouped categories.
- **Recommendation:** harvest its detail into the MASTER file, then retire it. Do not send.

---

## 4. Content gaps to close

Available in your workbook but missing from both resumes:

1. **AI and GitHub Copilot work** — Copilot skills used for semantic-model analysis, prompt and instruction design, agentic/MCP workflows, App Modernization assessment of legacy .NET. Only one passing mention exists today.
2. **Named, anonymized customer outcomes** — the ADO-to-Fabric warehouse, the Power BI write-back proof of concept that drove an F2 capacity, the multi-day training deliveries.
3. **Training and enablement as a distinct capability** — multi-day instructor-led Power BI and ADO workshops with labs. This is a marketable service line, especially for consulting.
4. **Reusable IP** — blog series, public repository, reference architectures.
5. **Certifications** — see §2.

---

## 5. Metrics to insert (please confirm or correct)

I will not invent numbers. Confirm these before I write them in:

| Claim | Draft figure | Status |
|---|---|---|
| KPMG ADO reporting refresh time before the Fabric warehouse | 8+ hours | From your project notes — confirm |
| Refresh cadence after | Every 30 minutes during business hours | From your project notes — confirm |
| Contracted delivery hours | 300-hour EDE contract | From your notes — confirm OK to cite |
| Amalga performance improvement | 25%+ | Already on resume |
| Training delivered | Number of sessions / participants | **Need from you** |
| Customers advised | Approximate count over the period | **Need from you** |
| DOJ team size | 10 members | Already on resume |

---

## 6. Proposed structure for every version

```
ERIC PARVIN
[Targeted title line]
Charlotte, NC Metro | (703) 439-9798 | eric@parvski.com | LinkedIn | GitHub | Blog
Microsoft Certified: Fabric Analytics Engineer Associate (DP-600) | Azure AI Fundamentals

SUMMARY               3–4 lines, includes DP-600 and one quantified outcome
CORE TECHNOLOGIES     4 grouped lines, no table
CERTIFICATIONS        Active only, with dates
PROFESSIONAL EXPERIENCE
  Microsoft | Oct 2007 – 2026
    [role blocks, single-column headers, native bullets]
EARLIER EXPERIENCE    Condensed, 1 line each
EDUCATION
```

Section headings stay standard: Summary, Core Technologies, Certifications, Professional Experience, Education.

---

## 7. Build sequence

| Step | Deliverable | Notes |
|---|---|---|
| 1 | **MASTER** (unsent, unlimited length) | Everything, including all projects and metrics |
| 2 | **V1-FABRIC** | Fabric / data platform architect. Lead with DP-600. |
| 3 | **V2-POWERBI** | Power BI, semantic modeling, migration, enablement |
| 4 | **V3-AI** | GitHub Copilot, Copilot in Fabric/Power BI, AI-ready data. Lead with AI-900 + DP-600. |
| 5 | **V4-DEVOPS** | ADO reporting and delivery analytics |
| 6 | **V5-CONSULT** | Azeeki consulting profile — outcome and rate anchored |

Each sent version also gets a text-based PDF and a `.txt` copy for portal paste fields.

---

## 8. Decisions I need from you

1. **Location:** "Marvin, NC" (old) or "Charlotte, NC Metro" (new)? Recommend Charlotte metro for search visibility.
2. **Metrics:** confirm the figures in §5, and supply training/customer counts.
3. **Customer naming:** anonymize ("a Big Four professional services firm," "a large public university system") or name directly?
4. **Which variant first?**
5. **End date for Microsoft:** confirm what to display.
6. **Portfolio links:** confirm the public GitHub repo and blog URLs to include.
7. **AZ-900 / PL-900 / MCP:** compact line, or omit the 2017 MCP entirely?

---

## 9. What I will NOT do

- Claim DP-700, PL-300, GH-300, or AZ-204.
- State outcomes for engagements marked *discovery* or *outcome not evidenced* in the Reference Projects sheet.
- Invent metrics, headcounts, or dollar figures.
