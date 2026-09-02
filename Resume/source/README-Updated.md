# Resume Package - Eric Parvin
Updated 2026-09-02 with corrected KPMG framing.

## Structure
```
docx/   Word documents - upload to job portals
md/     Markdown source - readable on GitHub, tracked in git
txt/    ASCII plain text - paste into recruiter portal fields
build.js       Generates the six resumes in all three formats
capability.js  Generates the capabilities statement in all three formats
```

## KPMG correction applied
The engagement now leads with the enterprise-consolidation outcome:

**Bullet 1** - Architected a Fabric data warehouse consolidating Azure DevOps work item
and test data across all team projects into a single enterprise reporting platform,
replacing fragmented project-by-project reporting with organization-wide visibility
into delivery, quality, and test coverage.

**Bullet 2** - Enabled near-real-time reporting through medallion-layer pipelines,
incremental refresh, and capacity optimization: 7+ hours to 30 minutes against a
15-minute freshness requirement.

The refresh improvement is now positioned as a supporting outcome of the architecture,
not the headline achievement.

## Which document to send
| Situation | File |
|---|---|
| Fabric / data platform architect role | Fabric_Architect |
| Power BI / analytics role | PowerBI_Consultant |
| AI / Copilot / agentic role | AI_Enablement |
| DevOps / delivery analytics role | DevOps_Analytics |
| Staffing agency or recruiter | Consulting_Profile |
| Direct client conversation | Consulting_Capabilities_Statement |
| Your own reference | MASTER - never send |

## Regenerating
```bash
NODE_PATH=/path/to/node_modules node build.js
NODE_PATH=/path/to/node_modules node capability.js
```
Content lives in build.js as named bullet objects. Edit once, rebuild, and all three
formats regenerate consistently. Never edit the docx, md, or txt files by hand.
