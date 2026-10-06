# Technology Options and Import Workbook Review

**Project:** Lee Mason – RE Tracking Prospect Sales Brief intake
**Prepared:** October 1, 2026
**Inputs reviewed:** `Requirements.md`, `Recommendation.md`, `PoC_Implementation_Steps.md`, `Tracking_Prospect_SharePoint_List_Import.xlsx`

## Summary

A Microsoft 365 Family subscription can't build the solution in the requirements. The import workbook covers every field from the PDF, but it doesn't have the columns needed to track records after they're submitted.

## 1. What Microsoft 365 Family Gives You

| Capability in the requirements | M365 Family | Notes |
|---|---|---|
| Microsoft Lists | ✅ Personal Lists, stored in OneDrive | Good for prototyping columns, views and the form layout. Not a SharePoint site, so there are no groups, no item-level permissions and no shared team list. |
| Microsoft Forms | ✅ | Fine for a quick intake mockup. |
| Power Automate cloud flows (the email to the distribution list) | ❌ | Microsoft has ended support for personal accounts. A work or school account is now required. |
| Power Apps custom form | ❌ | Needs a work or school account. |
| SharePoint site, groups, "List from Excel" into a site | ❌ | Not included in consumer plans. |

## 2. Options

### Option 1 – Microsoft 365 Business Basic for Azeeki (recommended)

- About $6 per user per month, with a free trial.
- Gives you a real tenant with SharePoint, Lists, Forms, and Power Automate and Power Apps with standard connectors.
- That's the same set of tools as the customer's E3/A3 licence, so the PoC shows exactly what Lee Mason will get.
- Azeeki needs a business tenant regardless.

### Option 2 – Build it in Lee Mason's tenant

- `PoC_Implementation_Steps.md` already prefers this.
- Ask for a guest account or a test account on their Sales and Marketing site.
- You test against their real DLP policies, service plans and permissions.

### Option 3 – Prototype on M365 Family only

- Build a personal List from the workbook to settle the columns and form layout, then rebuild it in a business tenant.
- You can't demo the distribution-list email or the permissions model this way. Use it only for a schema walkthrough.

## 3. Workbook vs. Requirements

### What's covered

- All 50 columns map to intake requirements 1–14:
  - General prospect info
  - Residential, Equities and Commercial portfolio metrics
  - Automobiles, BPP/Equipment and C&I collateral
  - Lender-placed hazard and flood, for residential and commercial
  - Current L&M client
  - Order Up, Blanket Hazard and LSI/VSI premiums
  - Requested proposal date
  - Additional notes and pricing deviation notes
  - Standard pricing
  - Acknowledgment signature
- The Excel table `ProspectSalesBriefImport` (A1:AX2) exists, and the number formats are set up correctly (date, currency, whole number, percentage).

### Gaps and recommended changes

| # | Issue | Requirement | Recommendation |
|---|---|---|---|
| 1 | No tracking columns | Storage 4–5 | Add **Status**, a Choice column (Submitted, Under Review, Assigned, Proposal Needed, Proposal Complete, Closed) that defaults to Submitted. Add **Assigned To**, a Person column. Optionally add **Reviewer Notes**, multiple lines of text. Add these by hand after the import, because a Person column can't come in from Excel. |
| 2 | No Choice columns | UX 5 | Make the four **Current Carrier** fields Choice columns. Split **Location (City, State)** into **City** (text) and **State** (Choice). |
| 3 | Title column | List mechanics | Every List needs a Title column. Map **Company** to Title during the import, or you'll get an empty Title column. |
| 4 | Required fields not decided | Intake 12 | All but two columns are marked "Confirm with customer." Settle this in the field-map sign-off (step 2 of the PoC). |
| 5 | Signature is free text | Intake 11 | Use a Yes/No **"I acknowledge"** column, and rely on **Created By** and **Created** as the record of who signed and when. |
| 6 | Submission Date duplicates Created | Storage 6 | Either default it to Today or drop it and use **Created**. |
| 7 | Special characters in column names (`&`, `/`, `( )`, `,`) | Notification 4 | They become encoded internal names like `C_x0026_I...`, which are awkward to use in Power Automate. Create the columns with clean names first (e.g. `CandI_ForcePlacement`), then rename the display names. |
| 8 | Percentage entry | UX 7 | Escrow values are stored as decimals (0.65). In the List, use a Number column with **Show as percentage** turned on, or users typing "65" will get 6500%. |

## 4. Documentation Inconsistency

`Requirements.md` says the customer has **Microsoft 365 E3**, but `PoC_Implementation_Steps.md` is written for **Education A3**. The licensing conclusions are the same for this solution, but confirm the real SKU before you send either document to the customer.

## Sources

- [Power Automate on personal account – Microsoft Q&A](https://learn.microsoft.com/en-us/answers/questions/5443592/power-automate-on-personal-account)
- [End of Support for Personal Accounts in Power Automate](https://evenaut.com/whats-new/end-of-support-for-personal-accounts-in-power-automate/)
- [Power Automate with Forms for cloud flows – Microsoft Q&A](https://learn.microsoft.com/en-us/answers/questions/5383602/id-like-to-utilize-power-automate-functions-such-a)
