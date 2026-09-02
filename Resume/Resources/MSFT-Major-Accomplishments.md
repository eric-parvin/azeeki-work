# Career Highlights — Eric Parvin
**Senior Cloud Solution Architect | Microsoft, October 2007 – 2026 (18 years)**
Compiled September 2, 2026 for LinkedIn, resume, and portfolio use.

> **How to use this file.** Everything here is written in public, externally shareable terms. Internal program names, account identifiers, and internal-only performance metrics have been translated or omitted. Each entry notes the evidence behind it so you can defend the claim in an interview. Items marked *directional* describe scope without asserting an unverified result.

---

## Theme 1 — Enterprise Data Platform Modernization (Microsoft Fabric)

### Engineering analytics warehouse for a global professional services firm (KPMG Global Audit)
**Timeframe:** FY25 – 2026 | **Product area:** Microsoft Fabric, Power BI, Azure DevOps

- Led end-to-end design, build, and go-live of a Fabric data warehouse consolidating Azure DevOps work-item data into purpose-built warehouses aligned to reporting consumption needs.
- Architected a scalable medallion-layer pipeline (bronze, silver, gold) replacing a legacy SQL Server solution and a fragile PowerShell extraction process that required manual intervention.
- Implemented incremental refresh supporting multiple daily updates, plus capacity optimization to reduce compute consumption on a mid-tier Fabric capacity.

**Measurable outcomes**
- **Reduced end-to-end data refresh time from over 7 hours to 30 minutes** — roughly a 93% reduction — enabling near-real-time reporting against a 15-minute data-freshness requirement.
- **Eliminated a manual extraction dependency** that had caused recurring delays for a distributed engineering team.
- **Drove platform expansion:** the customer planned to onboard 10 additional engineering team projects and increase Fabric capacity following delivery.
- Multi-month engagement spanning architecture through production readiness, delivered under a 300-hour contracted engagement.

*Evidence: manager-reviewed performance summary (Q4 2026); project charter; engagement close-out summary.*

**LinkedIn-ready phrasing:**
> Cut enterprise engineering-analytics refresh time from 7+ hours to 30 minutes by re-architecting a legacy SQL Server reporting stack into a medallion-layer Microsoft Fabric warehouse — enabling near-real-time delivery insight for a global audit organization.

---

### Governance-first Fabric adoption program for a university foundation (UConn Foundation)
**Timeframe:** 2026 | **Product area:** Microsoft Fabric, Power BI, Fabric SQL, Purview

- Built a phased 30-60-90 implementation plan and prioritized backlog covering tenant configuration, capacity strategy, workspace design, identity and access controls, lifecycle management, and modernization sequencing.
- Scoped parallel workstreams: semantic modeling, legacy paginated-report migration, ETL modernization, source-system coexistence strategy, CI/CD with approval gates, cataloging and data-protection controls, and a self-service operating model.

**Measurable outcomes**
- Delivered a **proof of concept for write-back from Power BI to a Fabric SQL database** using Python user-defined functions and a mobile-optimized report for constituent contact capture.
- **The demonstration became the primary driver for the customer standing up a paid Fabric capacity** — a direct, attributable platform-adoption outcome.
- Established a repeatable governance and sequencing framework reused across subsequent engagements.

*Evidence: implementation plan and backlog deck; monthly delivery review notes; 1:1 impact record.*

**LinkedIn-ready phrasing:**
> Designed a governance-first Microsoft Fabric adoption roadmap for a higher-education foundation, and delivered a Power BI write-back proof of concept that directly triggered the customer's first production Fabric capacity.

---

## Theme 2 — Engineering Delivery Analytics (Azure DevOps)

### Reusable DevOps reporting architecture and reference patterns
**Timeframe:** 2024 – 2026 | **Product area:** Azure DevOps, Power BI, Microsoft Fabric

- Recognized internally as a subject-matter expert in Azure DevOps reporting; engaged by the Azure DevOps product group to build enterprise-scale DevOps analytics for a strategic customer.
- Developed reusable ingestion and modeling patterns covering work items, sprints, releases, quality, and engineering operations using OData and REST APIs, Fabric pipelines, warehouse modeling, incremental watermark processing, and Power BI semantic models.
- Compared and documented trade-offs between built-in analytics views and API-based extraction, including parameterized queries and sliding date windows to improve refresh performance at scale.

**Measurable outcomes**
- Produced a **standardized, deployable reporting data model** that reduced report-development rework and improved consistency across teams.
- Authored a **public technical blog series and companion public code repository** to share the patterns beyond individual engagements.
- Contributed to updating a packaged service offering so other architects could deliver the same solution.

*Evidence: reference architecture and phased plan; blog and repository work; product-group engagement correspondence.*

---

### Sprint and delivery metrics standardization for an engineering software company (Bentley Systems)
**Timeframe:** 2026 | **Product area:** Azure DevOps, Jira, Power BI

- Diagnosed a core reporting problem: identical work-item states carried different meanings across teams, making state-based reporting unreliable at the organizational level.
- Drove consensus on reporting keyed to **state categories rather than individual state names**, preserving team-level workflow flexibility while producing organizationally consistent metrics.
- Designed supplemental measures distinguishing development-complete work from fully deployed work, including aging thresholds for items awaiting build, test, or release.
- Defined treatment rules for planned versus unplanned work when items move between sprints.

**Measurable outcomes**
- **Replaced manual PowerShell metric extraction with automated Power BI reporting** across two work-tracking systems.
- Delivered a reporting framework that scales across teams with differing workflow definitions — the blocker that had prevented org-wide delivery metrics.

*Evidence: checkpoint review summaries; decision-confirmation correspondence, August 2026.*

**LinkedIn-ready phrasing:**
> Solved a cross-team delivery-metrics problem by shifting reporting from team-specific work-item states to normalized state categories — giving a global engineering organization consistent sprint and release metrics without forcing workflow standardization.

---

## Theme 3 — AI-First Delivery and Copilot Enablement

### Custom AI agent skills and prompt libraries for analytics engineering
**Timeframe:** 2025 – 2026 | **Product area:** GitHub Copilot, Microsoft Fabric, Power BI

- Authored **custom AI agent skills, agent instructions, and reusable prompt libraries** that encode delivery methodology into repeatable automation — including skills supporting BI platform migration assessment, semantic model review, and report conversion analysis.
- Applied agent-mode and CLI-based AI tooling with model-context-protocol servers to inspect, generate, and validate semantic models and report definitions through natural-language intent.
- Used AI-assisted analysis to review customer semantic models and produce best-practice recommendations and remediation guidance.
- Applied AI-assisted assessment tooling to legacy .NET application portfolios to accelerate modernization scoping and risk identification.

**Measurable outcomes**
- Compressed assessment and inventory work that traditionally takes weeks into a **repeatable, automated workflow**.
- Produced reusable engineering assets shared with peers rather than one-off customer deliverables.

*Evidence: 1:1 impact notes, August 2026; skilling plan; modernization workshop participation.*

**LinkedIn-ready phrasing:**
> Built custom AI agent skills and prompt libraries that turn migration assessment and semantic-model review from manual, weeks-long analysis into repeatable automation — an AI-first delivery model rather than AI as an add-on.

---

### AI-ready analytics and conversational access to engineering data
**Timeframe:** 2026 | **Product area:** Microsoft Fabric, data agents, semantic modeling

- Designed a four-phase progression from data warehousing into AI-enabled analytics: governed warehouse → standardized semantic model → conversational intelligence layer → productized and scaled offering.
- Specified a governed domain ontology and a **Fabric data agent** grounded in it, translating natural-language questions into structured queries with business-ready responses.
- Defined a prompt framework covering real scenarios — delivery velocity trends, sprint risk, and bottleneck identification — with an extensibility pattern applicable to pipelines, testing, and releases.

**Measurable outcomes (directional — design and roadmap stage)**
- Framework targeted **faster insight generation for delivery teams** and **reduced dependency on manual report building**.
- Positioned as reusable intellectual property applicable across multiple customers.

*Evidence: phased approach document; engagement close-out and next-phase recommendation.*

---

### AI-driven personal and engagement operating model
**Timeframe:** 2025 – 2026 | **Product area:** Microsoft 365 Copilot, collaborative work management

- Redesigned day-to-day delivery operations around AI: automated weekly status synthesis, action-item extraction, customer-facing summaries, and executive reporting across a multi-workspace tracking system.
- Advised a large public-sector transportation organization on **Copilot adoption reporting in Power BI** to make usage and value visible to leadership.

*Evidence: work-management system design; customer engagement records.*

---

## Theme 4 — Application and DevOps Modernization

### DevOps standardization program for a municipal government agency (Los Angeles Dept. of Building and Safety)
**Timeframe:** 2026 | **Product area:** Azure DevOps, GitHub, Azure App Service, Azure Monitor

- Led a structured modernization agenda across five workstreams: source-control and release strategy, deployment standards, incident management and monitoring, application platform modernization, and AI-assisted development enablement.
- Defined a recommended hybrid GitHub + Azure DevOps operating model and a phased plan to migrate legacy centralized version control to Git.
- Established CI/CD practices including YAML pipeline conversion, pull-request validation, branch policies, and guardrails to prevent broken builds.
- Designed end-to-end observability using platform monitoring, application telemetry, and log analytics with automated alerting for performance, error, and security anomalies.
- Introduced feature-flag management and zero-downtime deployment options using deployment slots.

**Measurable outcomes (directional)**
- Converted an ambiguous multi-year modernization backlog into a **prioritized, sequenced delivery plan with defined ownership**.
- Established incident workflow with clear escalation paths where none had been formalized.

*Evidence: agreed outcomes and next-steps correspondence, January 2026.*

---

### Application performance and platform engineering (earlier tenure)
**Timeframe:** 2007 – 2017 | **Product area:** .NET, IIS, Azure DevOps predecessors, healthcare data platform

- Led performance-tuning initiatives for large-scale healthcare data platform deployments, **improving application response times by more than 25%**.
- Built a support-case tracking and analytics solution that gave leadership visibility into case trends and team workload.
- Reverse-engineered and documented undocumented platform components using low-level diagnostic tooling, creating support-readiness material adopted by the broader engineering organization.
- Delivered certified application and web-platform health checks for Fortune 500 and federal government environments.
- Led the transition of a product support function into a new business group.

*Evidence: role history; recognition awards for support-readiness contributions and transition leadership.*

---

## Theme 5 — Customer Enablement and Technical Training

### Instructor-led workshop delivery
**Timeframe:** 2014 – 2026 | **Product area:** Power BI, Microsoft Fabric, Azure DevOps

- Accredited by Microsoft to scope and deliver customer-facing paid service engagements across Power BI analytics, developer-velocity planning, DevOps onboarding and assessment, intelligent applications and app modernization, Azure PaaS, and .NET/web-platform code review — accreditation requires demonstrated technical depth and delivery readiness per offering.
- Designed and delivered **multi-day instructor-led training with hands-on labs** for an academic medical center and a state labor agency, covering DevOps reporting, data shaping, report design and calculations, publishing, and report lifecycle management.
- Created reusable workshop decks, lab guides, instructor talking points, and student communications.

**Measurable outcomes**
- Enabled customer teams to build and operate solutions independently, reducing ongoing dependency on external support.
- Training assets became reusable delivery IP rather than single-engagement material.

*Evidence: delivery accreditation record; workshop calendars and attendance; course materials.*

---

### Complex semantic modeling for survey analytics (UNC School of Medicine)
**Timeframe:** 2026 | **Product area:** Power BI, SQL Server

- Designed a multi-year survey analytics semantic model handling a genuinely hard problem: **survey questions that change wording and numbering year over year** while still requiring valid longitudinal comparison.
- Built version-aware question keys, conformed dimensions, question-group structures, and benchmark mappings, with SQL validation queries reconciling report output against source data.

**Measurable outcomes**
- Enabled **trustworthy year-over-year reporting** where question drift had previously made comparisons unreliable.
- Established validation practices ensuring report figures matched source-of-truth data.

*Evidence: model design work; validation query set.*

---

## Theme 6 — Leadership, Culture, and Community

### Founded and ran a peer recognition program
**Timeframe:** 2024 – 2025 | **Scope:** ~500-person business unit

- Designed, launched, and operated a monthly peer-recognition program from scratch — including the nomination mechanism, communications, selection process, award fulfillment, and payroll compliance handling.
- Authored the launch communication and monthly winner announcements with themed award cycles.

**Measurable outcomes**
- Sustained **roughly 20–30 nominations per month covering ~27 unique recipients**, from a standing start.
- Program ran continuously for over a year and was adopted as a standing element of the organization's culture practices.

*Evidence: program launch communication, August 2024; monthly participation statistics; winner correspondence.*

**LinkedIn-ready phrasing:**
> Founded and ran a peer-recognition program for a ~500-person organization, sustaining 20–30 nominations monthly and turning informal appreciation into a durable culture practice.

---

### Recognition received
- **100% Attainment Award (2026)** — awarded to individuals reaching full weighted attainment against annual performance targets.
- **"Boots on the Ground" business-unit award (April 2024)** — leadership recognition for customer delivery contribution.
- **Support-readiness excellence award** and **leadership award for business-group transition** (earlier tenure).
- Sustained **75% billable utilization over five years** — among the highest contract consumption on the team.
- Scoped, sold, and delivered **four contracted Fabric advisory engagements totaling 1,800 hours**; managed **six concurrent engagements** in the most recent year spanning Fabric, Power BI, DevOps, .NET, and Azure services.

---

## Cross-cutting scale statement

Across an 18-year Microsoft tenure, supported **hundreds of enterprise, state and local government, federal, and Department of Defense customers**, spanning application development and support engineering through cloud solution architecture in data, AI, and application modernization.

---

## Portfolio assets available

| Asset | Type | Shareable |
|---|---|---|
| DevOps-to-Fabric reporting blog series | Public technical writing | Yes |
| Public code repository of reference examples | Public GitHub | Yes |
| Reference architecture for engineering analytics | Diagram / write-up | Sanitize first |
| Power BI and Fabric workshop curriculum | Training material | Rebuild independently |
| Custom AI agent skills and prompt libraries | Code / methodology | Rebuild independently |
| Semantic modeling patterns for longitudinal survey data | Design write-up | Yes, anonymized |

---

## Notes and cautions

1. **Customer naming.** Named customers appear above because you approved it for resume use. For public LinkedIn posts, consider generic descriptors ("a global professional services firm," "a public university foundation") unless you have explicit permission.
2. **Rebuild, don't take.** Training decks, code, and prompt libraries created during employment belong to the employer. Rebuild them independently before using them commercially.
3. **Verify before publishing.** The 7-hour-to-30-minute and 25% performance figures come from documented reviews. Keep the source references so you can substantiate them.
4. **Translated terms.** Internal program names have been converted to public equivalents — contracted advisory engagements, packaged service offerings, delivery accreditations. Avoid internal acronyms in external materials.
5. **Omitted deliberately.** Internal-only revenue, consumption, and attainment metrics tied to Microsoft's financial reporting are not included; the utilization and hours figures above are the safe, portable versions.
