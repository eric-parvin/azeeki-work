# RE Tracking Prospect Sales Brief

## Project Tracking

**Last updated:** August 18, 2026  
**Overall status:** Initiation  
**Current phase:** Customer plan review and tenant discovery  
**Target site:** Lee & Mason Sales and Marketing SharePoint site

## Status Legend

| Status | Meaning |
|---|---|
| Not Started | Work has not begun. |
| In Progress | Work is actively underway. |
| Blocked | Work cannot proceed until a dependency is resolved. |
| Ready for Review | Work is complete and awaiting review or approval. |
| Complete | Work and required approval are complete. |
| Deferred | Work is outside the current release or intentionally postponed. |

## Confirmed Direction

| Decision | Status | Source / Notes |
|---|---|---|
| The solution is for internal producers. | Confirmed | Customer meeting, August 17, 2026. |
| The solution should remain in the Microsoft 365 environment. | Confirmed | Customer meeting. |
| The current PDF should be replaced by a centrally controlled online experience. | Confirmed | Version control is a primary business concern. |
| Submissions should persist for review and follow-up. | Confirmed | SharePoint List is the proposed system of record. |
| The team should be notified after a submission. | Confirmed | Final distribution list is still required. |
| CRM integration is not required for the initial release. | Confirmed | Customer does not use a common CRM for this process. |
| Complex skip logic and extensive visual customization are optional. | Confirmed | Customer stated these are not requirements. |
| Standard SharePoint form will be evaluated before Power Apps customization. | Proposed | Requires customer approval of the implementation plan. |
| Standard Microsoft 365 connectors will be used for the initial workflow. | Proposed | License and tenant policy validation remain open. |

## Workstream 1: Project Management and Decisions

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| PM-01 | Send the high-level implementation plan for customer review. | Eric | Ready for Review | Customer approval or comments. |
| PM-02 | Confirm customer business owner, site owner, technical owner, and support owner. | Customer | Not Started | Named owners. |
| PM-03 | Schedule the design review and pilot review sessions. | Eric / Customer | Not Started | Reviewer availability. |
| PM-04 | Confirm scope, success criteria, and initial release boundaries. | Customer / Eric | Not Started | Approved scope. |
| PM-05 | Maintain decisions, risks, issues, and weekly status. | Eric | In Progress | Updated tracker. |

## Workstream 2: Tenant, Site, and Access Discovery

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| ACC-01 | Validate access to the Sales and Marketing SharePoint site. | Eric | In Progress | Confirmed site URL and access level. |
| ACC-02 | Confirm the approved location for the page, list, and supporting assets. | Customer Site Owner | Not Started | Site placement decision. |
| ACC-03 | Review existing site navigation, lists, pages, naming standards, and permissions. | Eric | Not Started | Tenant discovery notes. |
| ACC-04 | Confirm whether a pilot can be built in the target site or requires a separate test location. | Customer Site Owner | Not Started | Build location. |
| ACC-05 | Validate that Microsoft Lists, Power Automate, and required standard connectors are enabled. | Customer Admin / Eric | Not Started | Capability and licensing confirmation. |
| ACC-06 | Identify the customer-owned account for production workflow connections. | Customer Admin | Not Started | Flow owner and connection strategy. |

## Workstream 3: Requirements and Solution Design

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| DES-01 | Reconcile every PDF field to a proposed SharePoint column. | Eric / Business Owner | Not Started | Approved field mapping. |
| DES-02 | Confirm field types, choices, formats, and validation rules. | Eric / Business Owner | Not Started | List schema. |
| DES-03 | Classify fields as required, conditionally relevant, or optional. | Business Owner | Not Started | Submission rules. |
| DES-04 | Decide whether the data fits one prospect list or requires related detail records. | Eric | Not Started | Approved data model. |
| DES-05 | Define statuses, assignment, ownership, and record closure rules. | Business Owner | Not Started | Process lifecycle. |
| DES-06 | Confirm whether submitters can view all records, only their records, or no records after submission. | Business Owner / Site Owner | Not Started | Access model. |
| DES-07 | Confirm whether records may be edited after submission and by whom. | Business Owner | Not Started | Edit and audit rules. |
| DES-08 | Confirm attachment requirements and allowed file types. | Business Owner | Not Started | Attachment decision. |
| DES-09 | Define initial list views, filters, and exports. | Business Owner / Reviewers | Not Started | View specifications. |
| DES-10 | Define notification recipients, subject, body, key fields, and record link. | Business Owner | Not Started | Notification specification. |
| DES-11 | Confirm retention, sensitivity, version history, and audit expectations. | Customer Admin / Business Owner | Not Started | Governance requirements. |
| DES-12 | Approve the solution design before pilot configuration. | Customer | Not Started | Design approval. |

## Workstream 4: SharePoint Form and List Build

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| BLD-01 | Create the pilot Microsoft List with approved columns. | Eric | Not Started | DES-01 through DES-04. |
| BLD-02 | Configure list settings, versioning, attachments, and validation. | Eric | Not Started | DES-07, DES-08, DES-11. |
| BLD-03 | Configure form sections and field order to reflect the sales brief using [SharePoint list form configuration](https://learn.microsoft.com/sharepoint/dev/declarative-customization/list-form-configuration). | Eric | Not Started | Approved field mapping. |
| BLD-04 | Configure basic conditional visibility where it adds material value. | Eric | Not Started | DES-03; keep optional. |
| BLD-05 | Create reviewer and process views. | Eric | Not Started | DES-05 and DES-09. |
| BLD-06 | Add the intake experience to the approved SharePoint page or navigation. | Eric / Site Owner | Not Started | ACC-02 and pilot approval. |
| BLD-07 | Demonstrate the standard SharePoint form to pilot users. | Eric | Not Started | BLD-01 through BLD-06. |
| BLD-08 | Decide whether Power Apps customization is justified by pilot feedback. | Customer / Eric | Not Started | User-experience decision gate. |
| BLD-09 | If approved, [customize the SharePoint list form with Power Apps](https://learn.microsoft.com/sharepoint/dev/business-apps/power-apps/get-started/create-your-first-custom-form) using standard connectors. | Eric | Deferred | BLD-08 approval and license validation. |

## Workstream 5: Notification and Workflow

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| FLW-01 | Provide and validate the notification distribution list. | Customer | Not Started | Working recipient address. |
| FLW-02 | Build the new-item Power Automate flow using Microsoft's [send an email when a new SharePoint list item is created](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/get-started/create-your-first-flow) tutorial. | Eric | Not Started | DES-10 and BLD-01. |
| FLW-03 | Include agreed key values and a secure record link in the email using SharePoint dynamic content and the documented [SharePoint connector actions and triggers](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/sharepoint-connector-actions-triggers). | Eric | Not Started | Notification specification. |
| FLW-04 | Configure the flow with customer-owned connections. | Customer Admin / Eric | Not Started | ACC-06. |
| FLW-05 | Configure failure notification and identify the flow support owner. | Eric / Customer Admin | Not Started | Support model. |
| FLW-06 | [Test the flow](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/get-started/create-your-first-flow#test-your-flow), including delivery, permissions, duplicate handling, and failure behavior. | Eric / Pilot Users | Not Started | Completed pilot flow. |
| FLW-07 | Decide whether the initial release also needs a [Teams message](https://learn.microsoft.com/power-automate/teams/send-a-message-in-teams) or a [date-based reminder flow](https://learn.microsoft.com/power-automate/create-sharepoint-reminder-flows). | Business Owner / Eric | Not Started | Optional notification decision. |

## Microsoft Learn Implementation References

Use these references during design, configuration, testing, and handoff. Email is the baseline notification for the initial release; Teams messages and date-based reminders are optional patterns that should be added only when the business owner confirms the need.

| Area | Microsoft Learn Guidance | Application to This Project |
|---|---|---|
| Native SharePoint form | [Configure the list form](https://learn.microsoft.com/sharepoint/dev/declarative-customization/list-form-configuration) | Use **Edit form > Configure layout** and body JSON to organize approved list columns into sections. Form formatting changes presentation, not the stored list data. |
| Optional Power Apps form | [Customize a form for a SharePoint list](https://learn.microsoft.com/sharepoint/dev/business-apps/power-apps/get-started/create-your-first-custom-form) | Use only if pilot feedback requires conditional visibility, read-only fields, or a richer experience. Publish the approved version back to SharePoint. |
| SharePoint flow trigger | [SharePoint connector actions and triggers](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/sharepoint-connector-actions-triggers) | Use the SharePoint **When an item is created** trigger against the approved site and list. Review supported actions and trigger behavior before adding workflow complexity. |
| New-submission email | [Send an email when a new item is created in a SharePoint list](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/get-started/create-your-first-flow) | Baseline implementation for notifying the distribution list. Configure recipients, subject, dynamic list values, and a link to the submitted record. |
| Flow testing | [Test your flow](https://learn.microsoft.com/sharepoint/dev/business-apps/power-automate/get-started/create-your-first-flow#test-your-flow) | Submit a representative list item, review run history, inspect action inputs and outputs, and verify the received email and record link. |
| Teams notification | [Send a message in Teams using Power Automate](https://learn.microsoft.com/power-automate/teams/send-a-message-in-teams) | Optional alternative or supplement to email. A flow can post as the Flow bot or signed-in user to a chat or channel. Confirm the team, channel, audience, and connection owner first. |
| Follow-up reminder | [Create a SharePoint reminder flow](https://learn.microsoft.com/power-automate/create-sharepoint-reminder-flows) | Optional date-based notification for requested proposal dates or follow-up dates. Requires the relevant date column to be present in the list view. |

## Workstream 6: Security and Governance

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| SEC-01 | Identify submitter, reviewer, administrator, and support groups. | Customer | Not Started | Named users or Entra/Microsoft 365 groups. |
| SEC-02 | Configure least-privilege SharePoint permissions. | Site Owner / Eric | Not Started | DES-06 and SEC-01. |
| SEC-03 | Test create, read, edit, delete, and administrative access by role. | Eric / Pilot Users | Not Started | Security test results. |
| SEC-04 | Validate tenant DLP policies and connector restrictions. | Customer Admin | Not Started | Governance approval. |
| SEC-05 | Confirm retention, version history, audit, and records-management settings. | Customer Admin | Not Started | DES-11. |
| SEC-06 | Document the process for access changes and form updates. | Site Owner / Support Owner | Not Started | Operating procedure. |

## Workstream 7: Testing and Acceptance

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| TST-01 | Define representative submission and process test scenarios. | Eric / Business Owner | Not Started | Approved requirements. |
| TST-02 | Test field behavior, validation, optional responses, and data accuracy. | Eric | Not Started | Functional test results. |
| TST-03 | Test desktop and supported browser usability. | Eric / Pilot Users | Not Started | Usability results. |
| TST-04 | Test list views, filters, assignment, status, and export. | Reviewers | Not Started | Process test results. |
| TST-05 | Test notification content, delivery, links, and permissions. | Eric / Reviewers | Not Started | Workflow test results. |
| TST-06 | Conduct user acceptance testing with producers and reviewers. | Customer Pilot Group | Not Started | UAT feedback. |
| TST-07 | Resolve agreed defects and retest. | Eric | Not Started | Closed defects. |
| TST-08 | Obtain production approval. | Business Owner / Site Owner | Not Started | Written acceptance. |

## Workstream 8: Launch and Handover

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| REL-01 | Finalize production permissions, page placement, views, and workflow connections. | Eric / Site Owner | Not Started | TST-08. |
| REL-02 | Publish concise producer and reviewer guidance. | Eric | Not Started | Final solution behavior. |
| REL-03 | Confirm administrator and support ownership. | Customer | Not Started | Named operational owners. |
| REL-04 | Launch the solution to the approved audience. | Customer / Eric | Not Started | Production release. |
| REL-05 | Monitor initial submissions and workflow runs. | Eric / Support Owner | Not Started | Stabilization results. |
| REL-06 | Conduct a post-launch review and prioritize enhancements. | Customer / Eric | Not Started | Enhancement backlog. |

## Milestones

| Milestone | Target Date | Status | Acceptance Evidence |
|---|---|---|---|
| Customer approves high-level plan | TBD | Not Started | Approval or consolidated comments. |
| Tenant discovery complete | TBD | Not Started | Access, site, capability, and ownership confirmed. |
| Solution design approved | TBD | Not Started | Field map and design decisions approved. |
| Pilot ready for review | TBD | Not Started | Working list, form, views, and flow. |
| User experience decision complete | TBD | Not Started | Standard form accepted or Power Apps approved. |
| UAT complete | TBD | Not Started | UAT sign-off and defects resolved. |
| Production launch | TBD | Not Started | Business owner launch approval. |
| Handover complete | TBD | Not Started | Support owner accepts documentation and ownership. |

## Open Decisions and Gaps

| ID | Decision / Gap | Owner | Needed By | Status |
|---|---|---|---|---|
| D-01 | Who is the business owner and final approver? | Customer | Before design approval | Open |
| D-02 | Which site, page, and list location are approved? | Site Owner | Before pilot build | Open |
| D-03 | Which fields are required versus optional? | Business Owner | Before list build | Open |
| D-04 | What statuses, assignment fields, and follow-up process are required? | Business Owner | Before view design | Open |
| D-05 | Can submitters see or edit other submissions? | Business Owner | Before permission configuration | Open |
| D-06 | Who receives notifications, and what should the email contain? | Business Owner | Before flow build | Open |
| D-07 | Are attachments required? | Business Owner | Before list configuration | Open |
| D-08 | What retention, sensitivity, and audit rules apply? | Customer Admin | Before production | Open |
| D-09 | Who owns the production flow and its connections? | Customer Admin | Before workflow testing | Open |
| D-10 | Is native SharePoint form usability acceptable? | Pilot Group | At pilot review | Open |
| D-11 | What initial reporting or export is required? | Business Owner | Before UAT | Open |
| D-12 | What are the expected submission volume and target launch date? | Business Owner | During planning | Open |

## Risks and Mitigations

| ID | Risk | Probability | Impact | Mitigation / Next Action | Owner |
|---|---|---|---|---|---|
| R-01 | Current SharePoint access does not include sufficient build permissions. | Medium | High | Validate permissions immediately and engage the site owner if elevated access is needed. | Eric / Site Owner |
| R-02 | Tenant licensing or DLP policy blocks a planned connector or customization. | Low | High | Validate service plans, connectors, and DLP before build; retain a SharePoint-only baseline. | Customer Admin |
| R-03 | A wide form feels too long or difficult to complete. | Medium | Medium | Group fields into sections, limit required fields, and test with producers before adding custom technology. | Eric / Pilot Group |
| R-04 | Personal workflow connections create a support problem after handoff. | Medium | High | Use a customer-owned account and assign a support owner before production. | Customer Admin |
| R-05 | List permissions expose prospect information too broadly. | Medium | High | Agree on the visibility model, use groups, and test every role before launch. | Site Owner / Eric |
| R-06 | Unresolved process stages cause inconsistent follow-up. | Medium | Medium | Define a minimal status and ownership lifecycle during design. | Business Owner |
| R-07 | Excessive customization increases cost and maintenance. | Medium | Medium | Require a pilot-based decision before Power Apps or premium capabilities are introduced. | Customer / Eric |

## Immediate Action List

| Priority | Action | Owner | Status |
|---|---|---|---|
| 1 | Send Customer_Implementation_Plan.md for review. | Eric | Ready for Review |
| 2 | Confirm the SharePoint site URL and validate build permissions. | Eric / Site Owner | In Progress |
| 3 | Name the business owner, technical owner, and pilot users. | Customer | Not Started |
| 4 | Schedule the requirements and field-mapping review. | Eric / Customer | Not Started |
| 5 | Confirm notification recipients and desired launch timing. | Customer | Not Started |
| 6 | Review site standards and determine the pilot build location. | Eric | Not Started |
| 7 | Build the approved field map and initial list schema. | Eric | Not Started |

## Future Enhancement Backlog

| Enhancement | Trigger / Business Value | Status |
|---|---|---|
| Power Apps customized form | Native SharePoint form does not meet agreed usability needs. | Deferred |
| Advanced approval or escalation | Customer defines a formal approval path or service-level requirement. | Deferred |
| Proposal document generation | Repeated manual proposal preparation justifies automation. | Deferred |
| Power BI dashboard | Submission volume and management reporting needs justify a dashboard. | Deferred |
| CRM integration | Customer adopts a common CRM and requests lead synchronization. | Deferred |
| External intake portal | External producers or customers must submit directly. | Deferred; requires architecture and licensing review. |

## Weekly Status Notes

Use this section for brief dated updates.

### August 18, 2026

- Reconciled the meeting notes, requirements, and recommendation.
- Confirmed the SharePoint-first implementation strategy.
- Created the customer-facing high-level implementation plan.
- SharePoint access is now available; site and permission discovery are next.