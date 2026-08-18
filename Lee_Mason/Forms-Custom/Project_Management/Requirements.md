# Requirements: RE Tracking Prospect Sales Brief Intake Solution

## Source and Review Notes

This requirements document is based on the reviewed `RE Tracking Prospect_Sales Brief.pdf` content and the current solution discussion. The requested local file `C:\_Repo\Customers\Azeeki\Lee_Mason\Forms-Custom\Meetings.md` was not accessible from this Copilot environment, and an exact matching enterprise file was not found. Items below should be validated against that file once available in the active workspace or uploaded.

## Conversation Summary

The customer has an existing PDF-based intake document named `RE Tracking Prospect_Sales Brief.pdf`. The business need is to replace or supplement the PDF with a Microsoft-based data entry experience that allows users to submit prospect tracking information and notify a distribution list by email.

The initial options discussed were Microsoft Forms, SharePoint Lists/forms, Power Apps, Power Automate, Power Pages, Dataverse/Dynamics 365, and Teams-based app experiences. The preferred direction depends on whether the customer needs a simple intake form only or a more durable business process with tracking, routing, ownership, and follow-up.

Given the form content, the solution needs more than a basic survey if the submitted records must be reviewed, updated, assigned, tracked, or acted on by multiple people. Microsoft Forms is the fastest option for basic collection, but SharePoint List-backed storage is a better fit if the customer needs record management and workflow. Power Apps can improve the user experience, but depending on connectors and data sources, may introduce licensing considerations.

The customer reportedly has Microsoft 365 E3 with add-ons. Under Microsoft 365 E3, the safest low-cost path is to use Microsoft Forms, SharePoint Online/Microsoft Lists, Outlook/Exchange email, and Power Automate with standard Microsoft 365 connectors. Premium Power Platform capabilities, custom connectors, full Dataverse custom apps, Power Pages, AI Builder, RPA, or premium connectors may require additional licensing.

## Business Objective

Create a structured digital intake process for the Real Estate Tracking Prospect Sales Brief that allows users to submit prospect data, store the data in a manageable system, notify a distribution list, and support follow-up actions by internal teams.

## Recommended Solution Direction

### Primary Recommendation

Use **SharePoint Online / Microsoft Lists as the system of record** with a **customized list form** and **Power Automate using standard connectors** for notifications.

This keeps the solution within the likely Microsoft 365 E3 capability set if only standard connectors are used, while giving the customer structured data storage, list views, ownership, status tracking, and reporting options.

### Optional Enhancement

Use **Power Apps customized form** only if the default Microsoft List form is not sufficient for user experience, conditional sections, validation, or guided entry. Confirm licensing before positioning this as the default, especially if premium connectors, Dataverse, or external data sources are involved.

### When Microsoft Forms Is Appropriate

Microsoft Forms is appropriate if the requirement is simple submission only, with limited post-submission tracking. It can be embedded on a SharePoint page and paired with Power Automate to write responses to a SharePoint List and send an email notification.

### When Microsoft Forms Is Not Ideal

Microsoft Forms is less ideal if the process requires assignment, status changes, team review, record updates, approvals, audit history, or operational reporting beyond basic response export.

## Functional Requirements

### Intake Form Requirements

1. The solution shall provide a browser-based data entry form for the RE Tracking Prospect Sales Brief.
2. The form shall capture general prospect information, including:
   - Submission Date
   - Company
   - Location / City / State
   - Asset Size
3. The form shall capture prospect portfolio characteristics for:
   - Residential
   - Equities
   - Commercial
   - Automobiles
   - BPP / Equipment
   - C&I
4. The form shall capture portfolio metrics such as:
   - Number of loans
   - Number of originations per month
   - Escrow percentage
   - Flood properties
   - Blanket potential
   - Force placement
5. The form shall capture lender-placed hazard information, including:
   - Current carrier
   - Number of active policies
   - Earned premium for the last 12 months
   - Earned premium for the previous 12 months
6. The form shall capture lender-placed flood information, including:
   - Current carrier
   - Number of active policies
   - Earned premium for the last 12 months
   - Earned premium for the previous 12 months
7. The form shall capture whether the prospect is a current L&M client.
8. The form shall capture product and annual premium information for applicable products such as:
   - Order Up
   - Blanket Hazard
   - LSI / VSI
9. The form shall capture requested proposal date.
10. The form shall include a notes/comments field for additional background or pricing deviation context.
11. The form shall include an acknowledgment or attestation section.
12. The form shall support required fields where the business process requires complete data before submission.
13. The form shall support Yes/No style fields for questions such as blanket potential, force placement, and standard pricing.
14. The form shall support currency, number, date, and text field types.

### Storage Requirements

1. Submitted data shall be stored in a structured repository rather than only in email.
2. The storage repository should support filtering, sorting, searching, export, and basic reporting.
3. The storage repository should support item-level review and updates after submission.
4. The storage repository should support status tracking, such as:
   - Submitted
   - Under Review
   - Assigned
   - Proposal Needed
   - Proposal Complete
   - Closed
5. The storage repository should support ownership or assignment of submitted records.
6. The solution should preserve submission history to support audit and follow-up.

### Notification and Workflow Requirements

1. The solution shall send an email notification to a distribution list when a new submission is created.
2. The notification email should include key submitted values and a link to the submitted record.
3. The workflow should support routing to a reviewer or owner if the customer defines an intake owner.
4. The workflow should be implemented using Power Automate if available and licensed for the needed connectors.
5. The initial workflow should use standard Microsoft 365 connectors where possible.
6. The workflow should avoid premium connectors unless the customer confirms licensing.

### User Experience Requirements

1. Users should be able to access the form from a SharePoint page, Teams tab, or direct link.
2. The form should be usable in a browser without requiring users to edit a PDF.
3. The form should use sections or grouping to mirror the original PDF structure.
4. The form should minimize user confusion by grouping related insurance and portfolio fields together.
5. The form should use choice/dropdown fields where values are constrained.
6. The form should use date pickers for date fields.
7. The form should use validation for numbers, percentages, and currency values where possible.

### Security and Governance Requirements

1. Access to submit records shall be limited to the intended user audience.
2. Access to view and process submitted records shall be limited to authorized reviewers.
3. The solution should use Microsoft 365 groups, SharePoint groups, or Entra ID groups where appropriate.
4. The customer must confirm whether external users need to submit forms.
5. If external users are required, the licensing and security model must be reassessed.
6. The customer must confirm whether sensitive customer or prospect data is included.
7. The solution should follow the customer tenant’s data loss prevention and Power Platform governance policies.

### Reporting Requirements

1. The solution should allow users to view submitted records in SharePoint/Microsoft Lists.
2. The solution should allow export to Excel if needed.
3. If reporting becomes important, the solution should support Power BI reporting against the SharePoint List or another approved data source.

## Licensing and Capability Assessment

### Likely Included with Microsoft 365 E3

The following are generally aligned with Microsoft 365 E3 capabilities, subject to the customer's tenant configuration and enabled service plans:

- SharePoint Online sites, pages, libraries, and lists
- Microsoft Lists
- Microsoft Forms for surveys, polls, forms, and quizzes
- Exchange Online / Outlook email and distribution lists
- Teams integration, if Teams is included/enabled in their E3 plan or add-ons
- Power Apps for Microsoft 365 for canvas apps in the Microsoft 365 context using standard connectors
- Power Automate for Microsoft 365 for flows using standard connectors

### Capabilities That May Require Additional Licensing

The following may require additional licensing or validation before recommending:

- Power Apps Premium if the app uses premium connectors, custom connectors, full Dataverse, or standalone premium scenarios
- Power Automate Premium if flows use premium connectors, custom connectors, attended RPA, AI Builder, or other premium capabilities
- Power Automate Process if the customer wants to license a business process/flow centrally instead of licensing each user, or if service-principal/process-style execution is needed
- Full Dataverse custom apps, model-driven apps, or production/sandbox Dataverse environments for custom apps
- Power Pages for external-facing authenticated or anonymous portal users
- Dynamics 365 / Customer Voice if the need becomes a formal CRM/survey/customer engagement process
- Copilot Studio if conversational intake or bot-based workflow is required
- AI Builder if document processing, form recognition, prediction, or AI extraction is required

## Evaluation of Earlier Recommendations

### Earlier Recommendation: Microsoft List + Power Apps Form + Power Automate

Updated evaluation: This remains the best functional architecture if the customer needs a polished form and workflow-backed record management. However, because the customer has E3, position this carefully. Use Microsoft Lists and Power Automate standard connectors as the baseline. Add Power Apps only if the default list form is not sufficient and confirm that the app uses only standard connectors unless premium licensing is approved.

### Earlier Recommendation: Microsoft Forms + Power Automate + SharePoint List

Updated evaluation: This is the fastest proof-of-concept and likely fits within E3 if standard connectors are used. It is a good option if the customer wants quick intake, email notification, and basic storage. It is weaker for long-running business process management unless responses are written to a SharePoint List and tracked there.

### Earlier Recommendation: SharePoint List Form Only

Updated evaluation: This may be the best licensing-safe recommendation. It gives the customer structured data, views, permissions, item links, and basic form entry without requiring premium Power Platform features. The tradeoff is a less polished user experience than a custom Power Apps form.

### Earlier Recommendation: Power Pages

Updated evaluation: Do not recommend as the default unless external unauthenticated or authenticated portal access is required. Power Pages usually introduces additional licensing and governance considerations.

### Earlier Recommendation: Dynamics 365 / Dataverse

Updated evaluation: Do not recommend as the default for this PDF intake process unless the customer already owns Dynamics 365/Dataverse licensing or the process is part of a broader sales/CRM workflow. Full custom Dataverse apps generally require premium licensing.

### Earlier Recommendation: Teams App + Power Apps

Updated evaluation: This can be useful if users live in Teams, but the licensing guidance is the same as Power Apps. It should be treated as a user experience option, not the baseline architecture.

## Proposed Solution Options

### Option A: Licensing-Safe Baseline

**SharePoint List + default/customized List form + Power Automate standard connectors**

Best for:
- E3-first implementation
- Internal users
- Structured record storage
- Email notifications to DL
- Basic status tracking
- Minimal licensing risk

Potential limitations:
- Default form UX is basic
- Advanced conditional logic may be limited
- Complex validation may require Power Apps customization

### Option B: Fastest Intake Prototype

**Microsoft Forms + Power Automate + SharePoint List**

Best for:
- Fast proof of concept
- Simple form submission
- Friendly end-user experience
- DL notification

Potential limitations:
- Forms is not a full workflow system
- Post-submission updates are managed outside Forms
- More manual work may be needed to keep the List as the system of record

### Option C: Best Business Process UX

**Microsoft List + Power Apps customized form + Power Automate**

Best for:
- Guided user experience
- Conditional sections
- Better validation
- Cleaner UI
- More process maturity

Potential limitations:
- Must validate Power Apps licensing
- Premium connectors or Dataverse would require additional licensing
- Requires more governance and ownership planning

### Option D: External Portal Scenario

**Power Pages + Dataverse + Power Automate**

Best for:
- External submitters
- Portal-style experience
- Authenticated customer access

Potential limitations:
- Additional licensing likely required
- More complex governance and implementation
- Overkill for a simple internal intake process

## Recommended Next Steps

1. Confirm whether submitters are internal users only or external/customer users.
2. Confirm whether the customer has Teams enabled as part of E3 or through a Teams add-on.
3. Confirm whether Power Apps for Microsoft 365 and Power Automate for Microsoft 365 service plans are enabled for the users.
4. Confirm whether premium connectors, Dataverse, or external data sources are required.
5. Build a SharePoint List schema from the PDF fields.
6. Create a baseline SharePoint List form and validate whether the default UX is acceptable.
7. Create a Power Automate standard-connector flow that sends an email to the DL when a new item is created.
8. If UX is not acceptable, evaluate a Power Apps customized form using only standard connectors.
9. Validate security groups for submitters, reviewers, and site/list owners.
10. Document the final licensing position before presenting the architecture to the customer.

## Open Questions

1. Who will submit the intake form: internal staff, external customers, or both?
2. Does the customer require anonymous submission?
3. Is the DL internal only, or does it include external recipients?
4. Does the customer need attachments?
5. Does the customer need approval steps or only notification?
6. Does the customer need item assignment and status tracking?
7. Does the customer need reporting or dashboards?
8. Does the customer already use Power Automate?
9. Are Power Platform DLP policies already configured?
10. Are Power Apps and Power Automate service plans enabled in their E3 tenant?
11. Are any add-ons already purchased that include Power Apps Premium, Power Automate Premium, Dataverse, Power Pages, or Dynamics 365?
12. Is the PDF intended to remain as an output document, or is the goal only to capture data digitally?

## Action Items

| # | Action Item | Owner | Notes |
|---|-------------|-------|-------|
| 1 | Validate exact Microsoft 365 E3 add-ons and enabled service plans | Customer Admin / Microsoft Team | Confirm Power Apps, Power Automate, Teams, and any premium add-ons |
| 2 | Confirm submitter audience | Customer | Internal only vs external users drives licensing and architecture |
| 3 | Confirm workflow expectations | Customer | Email only, approval, status tracking, or assignment |
| 4 | Confirm DL address and notification content | Customer | Needed for Power Automate notification design |
| 5 | Build SharePoint List column schema from PDF | Eric / Microsoft Team | Use PDF fields as first-pass schema |
| 6 | Create proof-of-concept SharePoint List | Eric / Customer Tenant Owner | Prefer customer tenant for realistic validation |
| 7 | Create standard Power Automate notification flow | Eric / Customer Tenant Owner | Use SharePoint and Outlook standard connectors if possible |
| 8 | Test default list form UX | Customer Users | Determine if Power Apps customization is necessary |
| 9 | Assess whether Power Apps customized form is needed | Eric / Customer | Only after baseline List form review |
| 10 | Document final licensing assumptions | Eric / Customer Admin | Avoid recommending premium functions without license confirmation |

## Final Architecture Recommendation

Start with **SharePoint Online / Microsoft Lists + default or lightly customized list form + Power Automate using standard Microsoft 365 connectors**.

This is the best balance of capability, workflow support, data persistence, and licensing safety for a customer with Microsoft 365 E3. If the customer later confirms premium Power Platform licensing or needs a more guided interface, add a Power Apps customized form. Avoid Power Pages, full Dataverse, or Dynamics 365 unless the requirements expand into external access, CRM integration, or enterprise-grade process management.
