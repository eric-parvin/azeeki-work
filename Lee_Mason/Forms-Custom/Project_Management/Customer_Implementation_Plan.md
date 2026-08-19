# RE Tracking Prospect Sales Brief

## High-Level Implementation Plan

**Prepared for:** Lee & Mason  
**Date:** August 18, 2026  
**Status:** Draft for Customer Review

## Project Objective

Replace the current PDF-based Prospect Sales Brief with a SharePoint intake process for internal producers. The solution will standardize the information collected, maintain one current version of the questionnaire, retain submissions for follow-up, and notify the appropriate team when a new prospect is submitted.

## Recommended Approach

Use the existing Sales and Marketing SharePoint site as the entry point for the solution.

The initial solution will include:

- A Microsoft SharePoint List as the system of record for prospect submissions.
- A SharePoint-based form organized into clear sections that reflect the current sales brief.
- Basic validation and appropriate field types for dates, numbers, percentages, currency, choices, and notes.
- SharePoint views to support review and follow-up.
- A Power Automate workflow, using standard Microsoft 365 connectors, to email the designated distribution list when a submission is created.
- SharePoint permissions for approved submitters, reviewers, and solution owners.

The team will first validate the standard SharePoint form experience. A Power Apps customized form will be considered only if the standard experience does not provide an acceptable guided intake process. This decision will be made after a working pilot is reviewed.

## Initial Scope

### Included

- Internal employee access through Microsoft 365.
- Capture of the values in the current Prospect Sales Brief in SharePoint.
- Structured storage, search, filtering, and export of submissions.
- New-submission email notification with key details and a link to the record.
- Basic ownership and status tracking, subject to confirmation during design.
- User acceptance testing, launch support, and administrator handoff.

### Not Included in the Initial Release

- External or anonymous customer access.
- CRM integration.
- Dataverse, Power Pages, premium connectors, or other premium Power Platform features.
- Advanced approval routing, document generation, or Power BI dashboards.
- Complex conditional navigation unless pilot feedback demonstrates that it is necessary.

These capabilities can be evaluated as future enhancements after the initial process is in use.

## Implementation Workstreams

| Workstream | Key Activities | Primary Deliverables |
|---|---|---|
| 1. Discovery and Design | Compare the generated Excel field schema with the source PDF; confirm field names, data types, completeness, required versus optional responses, process stages, owners, notification recipients, security, and reporting needs. | Customer-approved Excel field map, process outline, and solution design. |
| 2. SharePoint and Security Setup | Confirm the target site, validate access, define user groups, and configure the list and supporting page. | Configured SharePoint location, permissions, and Microsoft List. |
| 3. Form and Workflow Configuration | Organize the form, configure validation and views, and build the new-submission email workflow. | Working pilot form, list views, and notification flow. |
| 4. Testing and Acceptance | Test form submission, data accuracy, permissions, notifications, and record follow-up with representative users. | Test results, resolved issues, and customer acceptance. |
| 5. Launch and Handover | Publish the solution, provide brief user guidance, confirm support ownership, and monitor initial use. | Production release, operating guidance, and support handoff. |

## Delivery Sequence

| Phase | Outcome | Customer Review Point |
|---|---|---|
| 1. Confirm | Scope, fields, ownership, access, and success criteria are agreed. | Compare `Tracking_Prospect_SharePoint_List_Import.xlsx` with `Tracking Prospect_Sales Brief.pdf` and approve the field names, data types, completeness, and design decisions. |
| 2. Pilot | A working SharePoint form, list, views, and notification flow are available. | Review usability and decide whether Power Apps customization is needed. |
| 3. Validate | Functional, security, and user acceptance testing are complete. | Approve the solution for production use. |
| 4. Launch | The solution is published and ownership is transferred. | Confirm launch and post-launch support. |

A detailed schedule will be established after the design decisions and customer reviewer availability are confirmed.

## Customer Inputs and Decisions Needed

The following items are needed to complete the design:

1. Confirm the business owner, SharePoint owner, and long-term support owner.
2. Confirm the internal users who may submit, view, edit, assign, and close records.
3. Review `Tracking_Prospect_SharePoint_List_Import.xlsx` against `Tracking Prospect_Sales Brief.pdf`; confirm that all required fields are represented, the field names and proposed data types are appropriate, and identify which fields must be required.
4. Confirm whether users should be able to view all submissions or only their own.
5. Confirm the process stages, ownership fields, and expected follow-up actions.
6. Provide the notification distribution list and approve the email content.
7. Confirm whether attachments are needed.
8. Confirm data retention, sensitivity, and audit requirements.
9. Confirm expected submission volume and any reporting needed for the initial release.
10. Identify a small group of producers and reviewers for pilot testing.

## Immediate Next Steps

Now that SharePoint access is available, the project team will:

1. Validate access to the target Sales and Marketing site and confirm the permitted build location.
2. Review the site's existing structure, permissions, naming standards, and related lists or pages.
3. Provide `Tracking_Prospect_SharePoint_List_Import.xlsx` and `Tracking Prospect_Sales Brief.pdf` to the business owner for a side-by-side field review.
4. Record requested additions, removals, naming changes, data-type changes, and required-field decisions in the Excel field map.
5. Obtain customer approval of the revised Excel field map before creating the SharePoint list.
6. Build the pilot list, form, views, and notification workflow in the customer tenant.
7. Demonstrate the pilot and collect focused feedback from representative users.

## Success Criteria

The initial release will be considered successful when:

- Internal producers can submit the Prospect Sales Brief through the approved SharePoint experience.
- The form captures the agreed information accurately without requiring distribution of a PDF.
- New submissions are stored in a controlled Microsoft List and can be reviewed and filtered.
- The designated team receives a reliable email notification containing a link to the submission.
- Permissions prevent unauthorized access while allowing the agreed review and follow-up process.
- The customer accepts the user experience and identifies an owner for ongoing administration.

## Key Considerations

- Microsoft 365 E3 and standard connectors are the working licensing assumption and will be validated in the customer tenant.
- The standard SharePoint form is the baseline because the customer prioritized simplicity, internal use, and version control over extensive visual customization.
- Required fields should be limited to information that is essential at initial submission. Optional information can still improve proposal quality without blocking intake.
- Workflow connections should be owned by an appropriate customer account rather than depending on a temporary project account.
- Any future requirement for external users, premium connectors, CRM integration, or complex process automation will require a separate architecture and licensing review.

## Approval

Customer review of this plan will confirm the recommended direction and authorize the discovery activities. SharePoint list construction will begin after the customer compares `Tracking_Prospect_SharePoint_List_Import.xlsx` with `Tracking Prospect_Sales Brief.pdf` and approves the field names, data types, completeness, and required-field decisions.