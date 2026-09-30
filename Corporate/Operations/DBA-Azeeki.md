# Azeeki Entity Rebrand — Action Plan

**Objective:** retire the Javia LLC name from customer-facing operations and operate as
Azeeki, while preserving the existing EIN, banking relationships, credit history, and
entity age.

**Companion document:** `Entity-Rebrand-Tracking.md` holds decisions, findings, risks,
and status. This file is the *what to do*. That file is the *what happened*.

> **Handling note.** This workspace is a Git repository. Do not record the EIN, account
> numbers, or credentials in this file. Keep them in a password manager and reference
> them here as "EIN on file."

---

## Phase 0 — Confirm Approach

The LLC is registered in **North Carolina**. There is no multi-state question, no
domestication, and no foreign qualification. This is a single-state name change:
North Carolina Articles of Amendment against the existing entity.

Two items still need confirmation before filing.

### Full amendment vs. assumed name bridge

| Approach | Outcome |
|---|---|
| **Articles of Amendment** (recommended) | Legal name becomes Azeeki. Contracts, W-9, banking, and invoices all read the new name. This is the destination. |
| **Assumed Business Name (DBA)** | Fast bridge only. Contracts read "Javia LLC d/b/a Azeeki." Banking, W-9, and payments stay under Javia. |

Use the DBA only if a client engagement will close before the amendment completes. It is
a stopgap, not a substitute. Filing one does not block or complicate the amendment.

### Ongoing cost

Unchanged by this project. The NC annual report remains due each year regardless of the
entity's name — commonly around $200, due April 15. Verify the current figure with the
Secretary of State.

### Actions

- [ ] Confirm the LLC's tax classification — disregarded, S-corp, or partnership. This
      determines the IRS step in Phase 5a.
- [ ] Decide whether a DBA bridge is needed for any in-flight engagement
- [ ] Record both decisions in the tracking document

---

## Phase 1 — Verify Current Status

- [ ] Look up Javia LLC in the North Carolina Secretary of State business registry
- [ ] Confirm **active** status and good standing
- [ ] Confirm the registered agent and registered office on record
- [ ] Confirm the annual report is current — **hard gate.** An amendment filed against a
      delinquent entity will be rejected and the timeline is lost.
- [ ] Record the SOSID in the tracking document
- [ ] Confirm formation date and entity age

Source: North Carolina Secretary of State, Business Registration Division.

---

## Phase 2 — Verify Name Availability

- [ ] Search the North Carolina registry for `Azeeki LLC`
- [ ] Determine whether a variation is required, such as `Azeeki Consulting LLC`
- [ ] Confirm the name meets NC distinguishability requirements against existing entities
- [ ] Optionally reserve the name if the amendment will not be filed immediately

Source: North Carolina Secretary of State business registration search.

---

## Phase 3 — Trademark Chain of Title

The Azeeki mark is already owned. Confirm ownership stays traceable through the rename.
A break in chain of title stays invisible until it matters, and is expensive at that
point.

- [ ] Confirm the registrant of record — Javia LLC, or an individual
- [ ] If registered to Javia LLC, record the name change with the USPTO after the state
      filing is approved
- [ ] If registered personally, decide whether to assign the mark to the LLC. Usually
      yes; the operating entity should hold the brand.
- [ ] Confirm no gap in chain of title before public launch

---

## Phase 4 — File the Name Change

File Articles of Amendment with the North Carolina Secretary of State changing the LLC's
name. Confirm the current form and fee on the Secretary of State site before filing —
the LLC amendment form is commonly designated L-17 and the fee is modest.

- [ ] File NC Articles of Amendment
- [ ] Obtain the file-stamped Articles of Amendment
- [ ] Confirm the registry reflects the new name
- [ ] Order certified copies for the bank and insurer
- [ ] Obtain a Certificate of Existence in the new name if a client or bank requests one
- [ ] Store approved documents and note their location in the tracking document

The registered agent does not change. The SOSID does not change. The entity does not
change — only its name.

These documents are the foundation for every later update. Nothing in Phases 5 through
11 can proceed without them.

---

## Phase 5a — IRS Notification

**Runs in parallel with Phase 5b. Do not let this gate banking.**

There is no online EIN name change, and the method depends on tax classification.

| Tax classification | Notification method |
|---|---|
| Single-member, disregarded | Signed letter to the IRS campus where returns are filed |
| S-corp election | Name-change box on Form 1120-S |
| Partnership | Name-change box on Form 1065 |

- [ ] Confirm classification, carried forward from Phase 0
- [ ] Send notification by the correct method
- [ ] Request **Letter 147C** if a bank or client requires IRS confirmation of the new name

The EIN itself does not change. A name change alone generally does not require a new EIN.
The original CP-575 will not be reissued — Letter 147C is the replacement, and people
routinely lose weeks discovering that.

Expect this step to take weeks to months.

---

## Phase 5b — Banking and Credit

**Runs in parallel with Phase 5a.** Banks generally accept the state Certificate of
Amendment. Do not wait on the IRS.

### Business checking

- [ ] Provide Certificate of Amendment, updated LLC paperwork, EIN confirmation if
      requested, and driver's license
- [ ] Request account name change and new checks
- [ ] Confirm the account number is retained
- [ ] Confirm the routing number is retained
- [ ] Confirm account history is retained

### Business credit cards

- [ ] Chase
- [ ] Amex
- [ ] Capital One
- [ ] Bank of America
- [ ] Other

For each: confirm the credit line and history carry forward, and request replacement
cards showing the new name.

---

## Phase 6 — Operating Agreement

- [ ] Amend the Operating Agreement to the new entity name
- [ ] Execute and date the amendment
- [ ] Store it with the state filing documents

A stale operating agreement naming a company that no longer exists becomes a problem the
first time a bank, insurer, or client asks for proof of authority.

---

## Phase 7 — Insurance

- [ ] Update the named insured on professional liability, errors and omissions, and
      cyber policies
- [ ] **Obtain written confirmation that the retroactive date and prior acts coverage
      carry forward**
- [ ] Confirm the carrier is not treating this as a new policy

If the retroactive date resets, coverage for work already performed is lost. Get the
confirmation in writing before the change takes effect.

---

## Phase 8 — Business Identity and Contracts

- [ ] Issue a new W-9 in the new entity name, referencing the existing EIN
- [ ] Update MSA template
- [ ] Update SOW templates
- [ ] Update NDA template
- [ ] Update consulting agreement template
- [ ] Add a legal entity block — legal name, state of formation, EIN reference — to the
      Engagement Terms section of `Azeeki Consulting Playbook v2.md`

Convention: the contracting party is the **legal entity name**. The brand and marketing
voice is **Azeeki**.

- [ ] Confirm any local business or privilege licenses
- [ ] Update state withholding and unemployment accounts if payroll exists

---

## Phase 9 — Notify Existing Clients

A name change on the same entity with the same EIN does not require novation. Existing
contracts remain valid. Written notice is still owed.

> **Fraud caution.** "Our company changed names, please update your records and remit to
> the new name" is indistinguishable from a business email compromise attempt. It is one
> of the most common invoice-fraud patterns. Handle deliberately.

- [ ] Send notice through established channels
- [ ] Phone accounts-payable contacts directly at larger clients
- [ ] State explicitly that **bank account and routing numbers are unchanged**
- [ ] Do not bundle any banking change into the same communication
- [ ] Reissue certificates of insurance for clients that require them
- [ ] Expect verbal verification requests and treat them as a good sign

---

## Phase 10 — Systems

### Financial

- [ ] QuickBooks / FreshBooks
- [ ] Stripe
- [ ] PayPal Business
- [ ] Square
- [ ] Merchant services
- [ ] Verify invoices render the new legal name

### Microsoft and cloud

- [ ] Azure tenant billing
- [ ] Subscription billing profile and payment methods
- [ ] Entra tenant display name
- [ ] Microsoft 365 tenant and domain
- [ ] Enroll in the Microsoft AI Cloud Partner Program under the new name

### Development

- [ ] GitHub organization name
- [ ] GitHub billing profile
- [ ] Copilot subscriptions

---

## Phase 11 — Public Launch

- [ ] Domain: azeeki.com
- [ ] Email: info@azeeki.com, eric@azeeki.com
- [ ] Website copyright notice
- [ ] Privacy policy
- [ ] Terms of service
- [ ] LinkedIn
- [ ] GitHub
- [ ] YouTube
- [ ] X

Launch last. Public branding should follow legal completion, not lead it.

---

## Sequencing Summary

| Phase | Depends on |
|---|---|
| 0 — Confirm approach and tax classification | Nothing |
| 1 — Verify Javia standing in NC | Nothing |
| 2 — Name availability in NC | Nothing |
| 3 — Trademark chain of title | Nothing to confirm; record after Phase 4 |
| 4 — File NC Articles of Amendment | Phases 0, 1, 2 |
| 5a — IRS notification | Phase 4 |
| 5b — Banking and credit | Phase 4 only, **not** 5a |
| 6 — Operating Agreement | Phase 4 |
| 7 — Insurance | Phase 4 |
| 8 — Identity and contracts | Phase 4 |
| 9 — Client notification | Phases 4, 7, 8 |
| 10 — Systems | Phase 4 |
| 11 — Public launch | All |

Phases 0, 1, and 2 are independent and can all run on day one.

---

## Requires Professional Advice

| Item | Who |
|---|---|
| Trademark chain of title | Trademark attorney, if the mark is held by Javia LLC or personally |
| Tax classification confirmation, if uncertain | CPA |

Everything else is administrative and can be self-executed. Because this is a
single-state name change on an existing entity, no attorney is required for the filing
itself.

---

## Why This Preserves Value

The entity is retained rather than dissolved and reformed, which keeps the EIN, banking
relationships, credit history, and entity age intact. If Javia LLC has roughly two
decades of operating history, that age is a real asset in credit and procurement
contexts — worth confirming in Phase 1, and worth protecting through every step here.

The outcome is the Javia name eliminated from customer-facing operations with no loss of
business history.
