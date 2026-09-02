# Eric Parvin - Portfolio Site

Static HTML/CSS portfolio. No JavaScript, no build step, no dependencies.

```
index.html                  Home: about, case study cards, skills, contact
style.css                   All styling
.nojekyll                   Tells GitHub Pages to serve files as-is
case-studies/
  enterprise-devops-analytics.html
  fabric-governance-roadmap.html
  cross-team-delivery-metrics.html
  longitudinal-survey-model.html
  ai-assisted-migration.html
  technical-enablement.html
```

---

## Deploy to GitHub Pages

### 1. Create the repository

Go to github.com and create a new **public** repository.

- To publish at `https://<username>.github.io`, name it exactly `<username>.github.io`
- To publish at `https://<username>.github.io/portfolio`, name it anything (e.g. `portfolio`)

Do not initialize with a README - you already have files.

### 2. Push the files

From the folder containing `index.html`:

```bash
git init
git branch -M main
git add .
git commit -m "Portfolio site"
git remote add origin https://github.com/<username>/<repo>.git
git push -u origin main
```

### 3. Turn on Pages

In the repository: **Settings** -> **Pages** (left sidebar)

- **Source:** Deploy from a branch
- **Branch:** `main`, folder `/ (root)`
- Click **Save**

Your site goes live in one to two minutes. Refresh the Settings > Pages screen to see the URL.

### 4. Verify

Open the URL. Check that:

- The home page loads with styling applied
- All six case study links work
- Navigation from a case study back to the home page works
- It looks right on your phone

---

## Updating content

Edit the HTML directly - it is plain markup with no templating.

```bash
git add .
git commit -m "Update case study"
git push
```

Changes appear within a minute or two.

---

## Custom domain (optional)

If you own a domain such as `parvski.com`:

1. In **Settings** -> **Pages** -> **Custom domain**, enter your domain and save.
   This creates a `CNAME` file in the repository.
2. At your DNS provider, add:

   **Apex domain** (`parvski.com`) - four `A` records:
   ```
   185.199.108.153
   185.199.109.153
   185.199.110.153
   185.199.111.153
   ```

   **Subdomain** (`www.parvski.com`) - one `CNAME` record pointing to
   `<username>.github.io`

3. Wait for DNS to propagate, then tick **Enforce HTTPS**.

---

## Notes

- **`.nojekyll`** prevents GitHub from running Jekyll processing. Harmless to keep, occasionally
  necessary. Leave it.
- **Public repository.** GitHub Pages requires public repos on free accounts. The site content is
  public anyway - just do not commit anything private alongside it.
- **No analytics included.** If you want visitor tracking, add a privacy-respecting service such as
  Plausible or GoatCounter with a single script tag before `</body>`.

---

## Content and confidentiality

All client names are withheld and described generically ("a global professional services firm,"
"an academic medical center"). Each case study carries an explicit note confirming no proprietary
data, code, or confidential business information is represented.

Before publishing, confirm you are comfortable with:

- The engagement descriptions, even anonymized - some are identifiable from context if a reader
  knows your background
- The specific metrics cited (7 hours to 30 minutes, 75% utilization, 1,800 hours)
- Your contact details being publicly crawlable

If any client relationship is sensitive, generalize that case study further or remove it.

## What is in it

PageAngleEnterprise engineering analyticsConsolidating work item and test data across a fragmented DevOps org — leads with the unification outcome, refresh time secondGovernance-first Fabric roadmapSequencing and ownership decisions before they get expensiveCross-team delivery metricsThe state-category insight — consistent metrics without forcing workflow changeLongitudinal survey modelVersion-aware modeling when questions change annuallyAI-assisted migrationCustom agent skills, with human review positioned as a featureTechnical enablementCapability transfer as the point of the engagement

Design decisions worth noting

"Open to contract work" is a subtle pill at the top of the hero with a small teal dot — present without shouting.

Every case study leads with the problem, in enough detail that a technical reader recognizes it. The Problem sections run longer than typical portfolio copy because that's what demonstrates judgment; anyone can list technologies.

NDA safety is layered. Generic client descriptors, a footer note site-wide, and a per-page note confirming no proprietary data or code is represented. The AI and training pages additionally state that tooling and curriculum would be rebuilt independently for commercial work.
