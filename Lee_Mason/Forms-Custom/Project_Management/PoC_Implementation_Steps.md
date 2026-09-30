# Prospect Sales Brief SharePoint PoC

## Recommendation

Build the proof of concept (PoC) in the existing Sales and Marketing SharePoint site using a Microsoft List, its standard SharePoint form, saved views, and a Power Automate cloud flow that emails the designated distribution list. Keep the first version internal and use SharePoint and Outlook standard connectors only.

This is enough to demonstrate the complete intake and follow-up process without introducing Dataverse, external portals, or a premium connector. Treat a Power Apps-customized form as an optional comparison only if the standard list form fails the pilot usability test.

## What A3 Can Cover

Microsoft's Education licensing tables list SharePoint Plan 2, Power Apps for Microsoft 365, and Power Automate for Microsoft 365 for A3. The intended list, standard form, and a simple SharePoint-to-Outlook notification flow are therefore a reasonable A3 PoC, subject to the customer's assigned SKU, enabled service plans, and tenant policies.

| Capability | PoC status | Boundary |
|---|---|---|
| SharePoint List, columns, standard form, views, and permissions | In scope | Internal users in the existing tenant/site |
| Power Automate create-item email notification | In scope | Keep to standard SharePoint and Outlook connectors; use a customer-owned flow connection |
| Power Apps customized list form | Optional pilot comparison | Confirm Power Apps for Microsoft 365 is enabled and keep the app within Microsoft 365 data/standard connector use rights |
| External or anonymous intake | Out of scope | Requires a separate security and licensing design; Power Pages is not part of this PoC |
| Premium/custom connectors, full Dataverse app, AI Builder, CRM integration, or advanced automation | Out of scope | Reassess licensing, architecture, governance, and support before adding |
| Power BI dashboard | Out of scope | Basic SharePoint views and Excel export are sufficient for the PoC; validate reporting licenses separately |

The exact product may be **Microsoft 365 Education A3** or **Office 365 Education A3**. Confirm the assigned license and that SharePoint Online, Power Apps for Microsoft 365, and Power Automate for Microsoft 365 service plans are enabled for the people building and using the solution. A3 does not mean every Power Platform feature is included. Do not infer that premium connectors, full Dataverse, or Power Pages are covered.

## PoC Outcome

At the end of the PoC, a small group of internal producers can submit a prospect brief; reviewers can find, assign, and update the record in SharePoint; and the designated distribution list receives an email with a link to it. The team can evaluate whether the standard list form is usable before deciding whether a Power Apps customization is justified.

## Implementation Steps

### 1. Confirm the tenant and build location

- Open the Sales and Marketing SharePoint site and confirm that it is the approved location for prospect data and the PoC list.
- Ask the Microsoft 365/Power Platform administrator to confirm the exact A3 SKU, enabled service plans, Power Automate availability, and any environment or DLP restrictions.
- Identify the business owner, site/list owner, flow owner, reviewer, pilot submitters, and the notification distribution list.
- Agree how the pilot will be separated from production. Use a clearly named pilot list and do not replace the existing PDF process until acceptance.

**Exit check:** The site owner approves the location; required users can access it; the administrator confirms that standard SharePoint and Outlook connectors are permitted.

### 2. Approve the field map and process

- Compare the [SharePoint list import workbook](../Resources/Tracking_Prospect_SharePoint_List_Import.xlsx) with the [source Prospect Sales Brief](../Resources/Tracking%20Prospect_Sales%20Brief.pdf), field by field.
- Confirm field labels, data types, allowed choices, required versus optional fields, and whether every source field is needed at initial submission. Keep required fields to the minimum needed to start follow-up.
- Confirm the status values, assignment owner, submitter edit rights, reviewer actions, attachment needs, retention expectations, and whether submitters may see all records or only their own.
- Approve the final field map before building the list. Do not rely on a PDF/Word form import to infer numeric, currency, or percentage fields correctly.

**Exit check:** Business owner signs off on the schema and process decisions.

### 3. Set up pilot access

- Use existing Microsoft 365, Entra ID, or SharePoint groups where possible. Define separate submitter, reviewer, and owner roles.
- Grant only the permissions needed for each role. Decide whether submitters can read/edit only their own items or all items; configure list item-level settings accordingly.
- Do not treat a filtered or hidden view as a security boundary. Verify access using a submitter and reviewer test account.
- Confirm the list will not expose sensitive prospect data to broad site membership. Check the site's sharing and retention policies with its owner.

### 4. Create and configure the pilot list

- Create a Microsoft List on the approved site from the approved field map. Give it a clear pilot name, such as `Prospect Sales Brief - PoC`.
- Use appropriate SharePoint column types: date, choice, Yes/No, number, currency, single-line text, or multiple-lines of text. Configure percentage, currency, and number precision deliberately.
- Add or confirm process fields such as Status, Assigned To, and follow-up notes only after the business owner approves them. Use SharePoint's Created, Created By, Modified, and Modified By fields for basic record history.
- Arrange the built-in form into logical sections that mirror the source brief. Add concise descriptions and sensible defaults; avoid making nonessential fields required.
- Leave list attachments off unless the business owner confirms a need and the site owner approves how those files will be secured and retained.

### 5. Add reviewer views

Create a small set of views that support real work without duplicating data:

- **All submissions:** sortable list for authorized reviewers.
- **My submissions:** records created by the current user, if useful to submitters.
- **Active follow-up:** exclude closed records and show status, assigned owner, company, and submission date.
- **Proposal needed:** filter to the approved status or proposal-needed flag.

Use the approved status choices (for example, Submitted, Under Review, Assigned, Proposal Needed, Proposal Complete, and Closed). Keep the set small enough that staff can apply it consistently.

### 6. Build the notification flow

- Create a Power Automate automated cloud flow using the SharePoint **When an item is created** trigger for the pilot list.
- Add an Outlook **Send an email (V2)** action addressed to the confirmed distribution list.
- Include a short, approved summary of the new submission and a direct link to the SharePoint item. Avoid putting sensitive or unnecessary prospect details in email.
- Keep the flow to standard connectors. Use a customer-owned connection, assign an appropriate backup/co-owner, and document who will maintain it.
- Test with an internal test record. Confirm the recipient, message content, item link, and that failures are visible to the flow owner.

### 7. Run the PoC tests and user review

Use test data, not live prospect information, until access and retention decisions are approved. Test at least:

- A normal submission, required-field validation, dates, numeric/currency values, choices, and long notes.
- Submitter and reviewer access, including attempts to view or edit records outside each role's permission.
- The all-submissions and follow-up views, status updates, assignment, and record search/export.
- Email delivery, link correctness, flow failure visibility, and ownership of the flow connection.
- A representative producer's ability to complete the form without help and a reviewer's ability to take the next action.

Record issues and decisions. If the built-in form is the only material usability blocker, make a small Power Apps-customized form pilot using the SharePoint list as its data source and standard connectors only; verify the tenant's license and sharing rights before distributing it. Compare the two experiences and choose one for the release.

### 8. Accept, release, and hand over

- Obtain business-owner acceptance against the success criteria below.
- Promote or rebuild the approved configuration in the production location using the site's change process; confirm production permissions and recipients before announcing the link.
- Publish brief user instructions and administrator notes covering list columns, views, permissions, flow ownership, failure handling, and support contact.
- Monitor initial submissions and notifications, then review the PoC after an agreed period before considering additional features.

## PoC Acceptance Criteria

- Internal producers can submit the approved fields through the selected SharePoint form.
- Values are stored accurately in a controlled list and reviewers can filter, assign, update, and close records.
- Submitter and reviewer permissions match the approved access model.
- A new item reliably triggers an email to the approved distribution list with a working record link.
- The flow has a customer-owned owner and backup, and the customer accepts the form experience and operating handoff.
- No premium connector, external portal, or unapproved data source is needed for the demonstrated process.

## Microsoft Licensing References

- [Microsoft 365 Education licenses - A3 features](https://learn.microsoft.com/microsoft-365/education/guide/0-start-standard/standard-license): A3 feature matrix, including SharePoint Plan 2 and the A3/Office 365 A3 feature tables.
- [Microsoft 365 Education licenses - all plans](https://learn.microsoft.com/microsoft-365/education/guide/0-start/all-license): includes the Power Apps for Microsoft 365 and Power Automate for Microsoft 365 comparison.
- [Power Platform licensing FAQs](https://learn.microsoft.com/power-platform/admin/powerapps-flow-licensing-faq): Power Apps and Power Automate licensing considerations.
- [Types of Power Automate licenses](https://learn.microsoft.com/power-platform/admin/power-automate-licensing/types): connector entitlements and differences between standard and premium capabilities.

Licensing references reviewed September 29, 2026. Tenant administrators should confirm the actual assigned SKU and service plans before building or sharing the pilot.