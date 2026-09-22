# Azeeki Entity Rebrand — Project Tracking

**Last updated:** September 2, 2026
**Overall status:** In Progress
**Current phase:** Phases 0, 1, and 2 — approach confirmation, NC registry verification,
and name availability. All three run in parallel.
**Objective:** Retire the Javia LLC name from customer-facing operations and operate as
Azeeki, preserving the existing EIN, banking relationships, credit history, and entity age.

**Entity of record:** Javia LLC, registered in **North Carolina**. Single-state name
change via NC Articles of Amendment. No domestication or foreign qualification applies.

**Companion document:** `ToDo-List.md` holds the action plan. This file holds decisions,
findings, risks, and status.

> **Handling note.** This workspace is a Git repository. Do not record the EIN, account
> numbers, filing credentials, or policy numbers in this file. Keep them in a password
> manager and reference them here by description only.

---

## Status Legend

| Status | Meaning |
|---|---|
| Not Started | Work has not begun. |
| In Progress | Work is actively underway. |
| Blocked | Work cannot proceed until a dependency is resolved. |
| Ready for Review | Work is complete and awaiting review or approval. |
| Complete | Work and required approval are complete. |
| Deferred | Work is intentionally postponed. |

---

## Confirmed Direction

| Decision | Status | Notes |
|---|---|---|
| The business will operate publicly as Azeeki. | Confirmed | Owner direction. |
| The Azeeki trademark is already owned. | Confirmed | Registrant of record not yet verified. See F-03. |
| The existing entity will be renamed, not dissolved and reformed. | Confirmed | Preserves EIN, banking, credit history, entity age. |
| The existing EIN will be retained. | Confirmed | A name change alone generally does not require a new EIN. |
| Service focus is Power BI, Fabric, AI, Azure, and Azure DevOps reporting. | Confirmed | Drives brand and catalog positioning. |
| The LLC is registered in North Carolina. | Confirmed | Owner, September 2, 2026. Supersedes the earlier Virginia assumption. |
| Single-state change. No domestication or foreign qualification. | Confirmed | Follows from NC domicile. |
| Filing mechanism: NC Articles of Amendment. | Confirmed | Resolves D-02. |
| Legal entity name: `Azeeki LLC` or a variation. | **Open** | Dependent on NC name availability. See D-03. |

---

## Open Decisions

| ID | Decision | Owner | Status | Blocks | Notes |
|---|---|---|---|---|---|
| D-01 | State of domicile. | Eric | **Resolved** | — | North Carolina. Confirmed September 2, 2026. |
| D-02 | Filing mechanism. | Eric | **Resolved** | — | NC Articles of Amendment. Follows from D-01. |
| D-03 | Final legal entity name. | Eric | Not Started | Phases 4, 8 | Depends on NC availability and distinguishability. |
| D-04 | Whether to assign the trademark to the LLC, if held personally. | Eric | Not Started | Phase 3 | Operating entity should normally hold the brand. |
| D-05 | Whether a DBA bridge is needed for an in-flight engagement. | Eric | Not Started | Phase 11 | NC Assumed Business Name. Only if an engagement closes before the amendment completes. |
| D-06 | Rate tier for Microsoft 365 / Power Platform delivery work. | Eric | Not Started | Contracts | Catalog currently places it at Standard Advisory. Must match actual invoicing. |
| D-07 | LLC tax classification. | Eric | Not Started | Phase 5a | Determines the IRS notification method. |

---

## Findings

| ID | Finding | Impact | Status |
|---|---|---|---|
| F-01 | EIN was recorded in plaintext in `ToDo-List.md` inside a Git repository. | Business identity fraud exposure, elevated during a name-change window. | Redacted from the file. Repo history not yet assessed. |
| F-02 | Original plan sequenced North Carolina as Phase 5, after a Virginia amendment. | Would have driven filings in the wrong state entirely. | Superseded by F-12. |
| F-03 | Trademark registrant of record is unverified. | Chain of title could break at the rename. | Open. Phase 3. |
| F-04 | Original plan gated banking on IRS confirmation. | IRS step takes weeks to months and would have blocked the entire plan. | Corrected. Phases 5a and 5b now run in parallel. |
| F-05 | There is no online EIN name change, and the method varies by tax classification. | Tax classification must be confirmed before the IRS step. | Open. D-07. |
| F-06 | The original CP-575 is not reissued; Letter 147C is the replacement. | Commonly discovered late, costing weeks. | Documented in the plan. |
| F-07 | Operating Agreement amendment was absent from the original plan. | Proof-of-authority gap with banks, insurers, and clients. | Added as Phase 6. |
| F-08 | Insurance retroactive date and prior acts coverage were not addressed. | Potential loss of coverage for work already performed. | Added as Phase 7. |
| F-09 | Existing client notification was absent from the original plan. | Contracts remain valid, but notice and COI reissuance are owed. | Added as Phase 9. |
| F-10 | The NC annual report (~$200, due April 15) is the only recurring state filing. | No multi-state cost comparison applies. Recurring cost is unchanged by this project. | Closed. |
| F-11 | The rate and catalog documents reference the Azeeki brand but state no legal entity. | Client legal review will look for the contracting party. | Open. Phase 8. |
| F-12 | The entity was assumed to be Virginia-registered during the initial plan review. It is registered in North Carolina. | Plan reduced to a single-state amendment. Phase 0 is no longer a blocking decision, and Phases 0, 1, and 2 can run in parallel. | Corrected September 2, 2026. All Virginia actions removed. |

---

## Workstream 1: Legal Filing

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| LEG-01 | Confirm state of domicile. | Eric | **Complete** | North Carolina. Confirmed September 2, 2026. |
| LEG-02 | Confirm LLC tax classification. | Eric | Not Started | D-07. Determines Phase 5a method. |
| LEG-03 | Decide whether a DBA bridge is needed. | Eric | Not Started | D-05. NC Assumed Business Name if yes. |
| LEG-04 | Verify Javia LLC status, registered agent, and SOSID with the NC Secretary of State. | Eric | Not Started | Confirmed active and in good standing. |
| LEG-05 | Confirm the NC annual report is current. | Eric | Not Started | **Hard gate.** Delinquency causes filing rejection. |
| LEG-06 | Search NC name availability and distinguishability for Azeeki LLC. | Eric | Not Started | Input to D-03. |
| LEG-07 | File NC Articles of Amendment. | Eric | Not Started | File-stamped Articles of Amendment. |
| LEG-08 | Order certified copies and a Certificate of Existence in the new name. | Eric | Not Started | For bank, insurer, and client requests. |
| LEG-09 | Amend and execute the Operating Agreement. | Eric | Not Started | Signed amendment. |
| LEG-10 | Confirm the NC registry reflects the new name. | Eric | Not Started | Post-filing verification. |

---

## Workstream 2: Trademark

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| TM-01 | Identify the registrant of record for the Azeeki mark. | Eric | Not Started | Resolves F-03. |
| TM-02 | Decide on assignment to the LLC if held personally. | Eric | Not Started | D-04. |
| TM-03 | Record the name change with the USPTO. | Eric | Not Started | Requires LEG-07 approval. |
| TM-04 | Confirm unbroken chain of title before public launch. | Eric | Not Started | Gate on Phase 11. |

---

## Workstream 3: Tax and Financial

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| FIN-01 | Notify the IRS of the name change by the method matching tax classification. | Eric | Not Started | LEG-02, LEG-07. |
| FIN-02 | Request Letter 147C. | Eric | Not Started | Only if a bank or client requires IRS confirmation. |
| FIN-03 | Update business checking account name. | Eric | Not Started | LEG-07. Runs parallel to FIN-01. |
| FIN-04 | Confirm account number, routing number, and history are retained. | Eric | Not Started | Written confirmation from bank. |
| FIN-05 | Update business credit cards (Chase, Amex, Capital One, BoA, other). | Eric | Not Started | Credit line and history carry forward. |
| FIN-06 | Update accounting and payment systems. | Eric | Not Started | QuickBooks/FreshBooks, Stripe, PayPal, Square, merchant services. |
| FIN-07 | Verify invoices render the new legal name. | Eric | Not Started | Test invoice. |
| FIN-08 | Update state withholding and unemployment accounts. | Eric | Not Started | Only if payroll exists. |

---

## Workstream 4: Insurance and Risk

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| INS-01 | Update named insured on professional liability, E&O, and cyber policies. | Eric | Not Started | LEG-07. |
| INS-02 | Obtain **written** confirmation that retroactive date and prior acts coverage carry forward. | Eric | Not Started | Carrier letter. Gate before the change takes effect. |
| INS-03 | Reissue certificates of insurance for clients that require them. | Eric | Not Started | INS-01. |

---

## Workstream 5: Contracts and Client Communication

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| CON-01 | Issue a new W-9 in the new entity name. | Eric | Not Started | LEG-07. |
| CON-02 | Update MSA, SOW, NDA, and consulting agreement templates. | Eric | Not Started | D-03. |
| CON-03 | Add legal entity block to Engagement Terms in the customer-facing catalog. | Eric | Not Started | Resolves F-11. |
| CON-04 | Notify active clients in writing through established channels. | Eric | Not Started | Phone verification for larger clients. |
| CON-05 | State explicitly in the notice that banking details are unchanged. | Eric | Not Started | BEC fraud mitigation. See R-03. |
| CON-06 | Confirm local business or privilege licenses. | Eric | Not Started | Jurisdiction dependent. |

---

## Workstream 6: Technology and Public Presence

| ID | Task | Owner | Status | Dependency / Output |
|---|---|---|---|---|
| TEC-01 | Update Azure tenant billing and subscription billing profile. | Eric | Not Started | LEG-07. |
| TEC-02 | Update Entra tenant display name and Microsoft 365 tenant/domain. | Eric | Not Started | — |
| TEC-03 | Enroll in the Microsoft AI Cloud Partner Program under the new name. | Eric | Not Started | Do not enroll under Javia. |
| TEC-04 | Update GitHub organization, billing profile, and Copilot subscriptions. | Eric | Not Started | — |
| TEC-05 | Domain and email cutover (azeeki.com). | Eric | Not Started | — |
| TEC-06 | Update website copyright, privacy policy, and terms. | Eric | Not Started | D-03 final legal name. |
| TEC-07 | Update LinkedIn, GitHub, YouTube, and X. | Eric | Not Started | Launch last. |

---

## Risk Register

| ID | Risk | Likelihood | Impact | Mitigation |
|---|---|---|---|---|
| R-01 | NC Articles of Amendment rejected due to a delinquent annual report. | Medium | Schedule loss | LEG-05 as a hard gate before LEG-07. |
| R-02 | Trademark chain of title breaks at the rename. | Medium | High, and expensive to correct later | TM-01 through TM-04 before public launch. |
| R-03 | Client treats the name-change notice as a BEC attempt, or a third party exploits the transition to redirect payment. | Medium | High | Notify through established channels, phone AP contacts, state that banking is unchanged, never bundle a banking change into the same message. |
| R-04 | Insurance carrier resets the retroactive date. | Low | High — loss of coverage for prior work | INS-02 written confirmation before the change takes effect. |
| R-05 | IRS acknowledgment delays block banking. | High | Medium | Phases 5a and 5b decoupled; banks accept the state certificate. |
| R-06 | `Azeeki LLC` is not distinguishable from an existing NC entity, forcing a variation. | Medium | Medium | LEG-06 before D-03 is finalized and before any branding collateral is produced. |
| R-07 | EIN exposure through Git history. | Unknown | Medium to High | Redacted from working file; determine whether the repo is public and whether the value was previously pushed. |
| R-08 | NC annual report deadline (April 15) missed during the transition. | Low | High — administrative dissolution | Calendar the deadline now; confirm the filing reflects the correct name after LEG-07. |
| R-09 | Public brand launched before legal completion. | Medium | Contracts signed under an unresolved entity name | Phase 11 gated on all prior phases. |

---

## Immediate Next Actions

| Priority | Action | Task ID |
|---|---|---|
| 1 | Determine whether this repository is public and whether the EIN was previously committed and pushed. | R-07 |
| 2 | Verify Javia LLC standing, registered agent, and SOSID with the NC Secretary of State, and confirm the annual report is current. | LEG-04, LEG-05 |
| 3 | Search NC name availability and distinguishability for `Azeeki LLC`. | LEG-06 |
| 4 | Confirm LLC tax classification. | LEG-02, D-07 |
| 5 | Identify the trademark registrant of record. | TM-01 |

Items 2, 3, and 4 are independent and can be completed in a single sitting.

---

## Status Log

| Date | Entry |
|---|---|
| 2026-09-02 | Plan reviewed and restructured. Trademark, Operating Agreement, insurance retroactive date, and client notification workstreams added. IRS and banking decoupled. EIN redacted from the working file. Tracking document created. |
| 2026-09-02 | **Correction:** the LLC is registered in North Carolina, not Virginia. All Virginia actions removed from the plan. D-01 and D-02 resolved. The multi-state path analysis is void — this is a single-state NC Articles of Amendment. Phase 0 is no longer a blocking gate; Phases 0, 1, and 2 now run in parallel. Logged as F-12. |
