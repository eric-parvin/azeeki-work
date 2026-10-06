# Azeeki Entity Rebrand — Action Plan (v2.1)

**Objective:** retire the Javia name from all customer-facing and legal use and operate as **Azeeki LLC**, with a clean cutover effective **January 1, 2027**.

**Revised 9/29/2026** with the NC Secretary of State's answers on the amendment process, fees, timing, and delayed effective date.

**Companion document:** `Entity-Rebrand-Tracking.md` holds decisions, findings, risks, and status. This file is the what to do. That file is the what happened.

**Handling note.** This workspace is a Git repository. Do not record the EIN (old or new), account numbers, or credentials in this file. Keep them in a password manager and reference them here as "old EIN on file" and "new EIN on file." Do not commit scans of IRS letters. Store them outside the repo.

---

## What changed from v1

The v1 plan assumed one continuous entity with a single EIN. The source documents show otherwise:

| Fact | Source |
|---|---|
| The EIN was issued in March 2006 to **Javia LLC**, a Virginia LLC, sole member. | IRS CP 575 letter; VA SCC certificate (effective 3/22/2006) |
| The Virginia entity **no longer exists** (not listed in the VA database). | VA SCC lookup |
| **Javia Company LLC** was formed in NC on 7/31/2009 by plain Articles of Organization (Form L-01). No conversion, merger, or succession language. It is a **separate legal entity**. | NC SOS certified Articles |
| Javia Company LLC is active, with two members (Eric and Cynthia). | NC 2026 annual report |
| The NC entity has been using the **original 2006 EIN**, including on the UNC vendor record and the insurance policy. | Confirmed by Eric |
| The name Javia LLC is unavailable in NC (held by an unrelated, administratively dissolved entity). | NC SOS registry |
| Azeeki LLC is available in NC. The Azeeki mark is owned by Eric (confirm whether personally or by an entity). | Confirmed by Eric |

**Consequences for the plan:**

- A name-change notice to the IRS is **not** the right fix. The EIN belongs to an entity that no longer exists, so the NC entity needs **its own new EIN**.
- The DBA route is **dropped**. It attaches to the wrong legal entity for the end goal and adds a filing for a name being replaced.
- The rename and the EIN change should happen **together** (one round with the bank, UNC, and the insurer).

---

## Decisions (record in the tracking document)

| Decision | Status |
|---|---|
| Legal name: rename Javia Company LLC to **Azeeki LLC** via NC Articles of Amendment (Form L-17) | Decided |
| EIN: obtain a **new EIN** for the NC entity under the Azeeki LLC name | Decided, pending CPA confirmation |
| DBA (assumed business name) | **Not filing** |
| Cutover date | **January 1, 2027** (Eric's preference; CPA to confirm feasible, see Phase 0) |
| NC filing mechanics | **Confirmed by SOS** (next section) |
| Tax classification (two members: partnership by default, or S-corp election) | **Open, CPA** |
| Trademark: assign to the LLC or license to it | **Open, trademark attorney** |
| NCDOR account for the UNC work | **Open, CPA** (likely not needed for consulting; see Phase 0) |

---

## NC Secretary of State Confirmation (email from Corpinfo, 9/29/2026)

| Item | Answer |
|---|---|
| Form | **L-17**, Amendment of Articles of Organization |
| Filing fee | **$50** |
| Standard turnaround | **8 business days** |
| Expedite | **$100** for 24 hours; **$200** same day if filed before 12 noon |
| Delayed effective date | Allowed, **up to 90 days out** |
| Name reservation | **Not required** before filing |
| SOSID | **Unchanged** after the name change |
| Annual report | Future filings carry the new name |
| Certified copy | Order online, **$10** |
| Registry history | Former-name information stays visible under "view filings" |

**Filing window for a 1/1/2027 effective date**

- The 90-day limit puts the earliest filing date at about **October 3, 2026** (a Saturday), so **Monday, October 5** at the soonest. Stay a few days inside the limit unless the SOS says whether the 90 days run from submission or from approval.
- On standard turnaround, the **latest sensible filing date is about December 1**, allowing for holidays and a possible rejection.
- **Target: file the week of November 9, 2026.** Approval should land around November 20, leaving weeks of cushion to fix any rejection. Expedite is not needed.

**Still to ask the SOS**

- [ ] Do the 90 days run from the date of submission or the date of approval?
- [ ] Can a filed future-dated amendment be **withdrawn or changed** before it takes effect?
- [ ] Can the certified copy be ordered once the amendment is **approved**, or only once it is **effective**?
- [ ] Is there any additional online processing fee beyond the $50?
- [ ] Does a filed future-dated amendment **hold the Azeeki LLC name** in the meantime?
- [ ] What is the fee for a Certificate of Existence?

---

## Phase 0 — Confirm With Professionals (now, by mid-October 2026)

Nothing is filed in this phase. The goal is answers, so the November filing is routine. **Do not file the amendment until the CPA confirms the January 1 cutover.**

**CPA meeting.** Bring: the 2006 IRS EIN letter, the VA SCC certificate, the 2009 NC Articles, the 2026 NC annual report, and tax returns since 2009.

- [ ] Confirm the NC entity's tax classification and how the change from one member to two was handled
- [ ] Confirm what has been filed under the old EIN since 2009, and under which name
- [ ] Confirm the clean cutover plan: new EIN effective for 2027, 2026 stays under the old number. Get a written answer on **how the 2026 return will be filed** and under which EIN
- [ ] **Get the CPA's go-ahead on the 1/1/2027 cutover before the amendment is filed**
- [ ] Confirm whether the IRS may issue mismatch notices or backup withholding on the UNC payments if the name and EIN diverge before the switch
- [ ] Confirm how to handle **payments made in January 2027 for December 2026 invoices**. Payments are generally reported by year paid, so decide with UNC which EIN applies from which payment date
- [ ] Ask about requesting a Letter 147C for the old EIN, to see the name the IRS holds on file
- [ ] Ask about closing the old EIN account, and when
- [ ] Ask whether an S-corp election (Form 2553) is worth considering for the new entity
- [ ] Ask whether any **NCDOR account** is needed for the UNC work. Consulting is generally not subject to NC sales tax and custom software is exempt, but confirm against the actual deliverables (prewritten software, and support or maintenance components, are treated differently)

**Attorney (business/contracts).** Bring: the UNC contract, the insurance policy, and this plan.

- [ ] Confirm the **named party** on the UNC contract and whether it needs an amendment, assignment, or notice
- [ ] Confirm the **named insured** and the FEIN on the insurance policy
- [ ] Draft an accurate one-paragraph history statement for counterparties. Do **not** describe Javia Company LLC as a "rename" or "successor" of Javia LLC, because it is neither
- [ ] Review the operating agreement update (two members, signing authority, new name)

**Trademark attorney.**

- [ ] Confirm the registrant/owner of record for Azeeki
- [ ] Decide: assign the mark to Azeeki LLC (in writing, with goodwill, and record with the USPTO if registered) or keep it personal and grant a written license to the LLC
- [ ] Confirm no gap in chain of title before public launch

---

## Phase 1 — Prepare (October to early November 2026)

Prepare without changing anything legal.

- [ ] Search the NC registry again to confirm Azeeki LLC is still available. Availability is not held for you
- [ ] Name reservation: **not required** (SOS confirmed). Filing in early November keeps the window short for anyone else to register the name
- [ ] Confirm the Javia Company LLC annual report and registered agent are current
- [ ] Check whether any **NCDOR account** (sales and use, withholding) already exists under the old EIN, since it would need to move at cutover
- [ ] **UNC procurement:** open a conversation about their process for a legal-name and TIN change. Ask what documents they need and what lead time they expect. Use the attorney's history statement. Do not send an updated W-9 yet
- [ ] **Insurance broker:** tell them the legal name and FEIN will change effective 1/1/2027. Ask what the carrier needs to keep coverage continuous. Get written confirmation the retroactive date and prior-acts coverage carry forward. Ask how to handle the current named insured in the meantime
- [ ] **Bank:** ask how an EIN change is handled (re-papering vs. new accounts), what documents are needed, and the lead time. Confirm account number, history, and any cards
- [ ] Send the open questions above to the SOS
- [ ] Draft the amended operating agreement for both members' signature (Phase 2)
- [ ] Draft (do not issue) updated contract templates: MSA, SOW, NDA, consulting agreement, legal-entity block in the playbook
- [ ] Build the launch assets for azeeki.com but do not publish them

---

## Phase 2 — File and Execute (week of November 9, 2026 onward)

- [ ] **Gate:** CPA has confirmed the 1/1/2027 cutover (Phase 0)
- [ ] **File Form L-17** online with the NC Secretary of State: new name **Azeeki LLC**, **effective date 1/1/2027**, signed by a member (the LLC is member-managed). Fee $50. Standard turnaround 8 business days. Keep the confirmation
- [ ] If the filing is rejected, correct and refile immediately. The December 1 cutoff for standard turnaround is the last safe date. After that, use the $100 24-hour expedite
- [ ] Confirm the approved filing on the registry (it should show the pending name change and keep the SOSID)
- [ ] Sign the amended **operating agreement**, effective 1/1/2027, by Eric and Cynthia
- [ ] Prepare the counterparty package: certified amendment (once available), new W-9 (blank until the EIN exists), updated certificate of insurance request, history statement
- [ ] Confirm with the bank, UNC, and the broker that each is ready for the first week of January

---

## Phase 3 — Cutover (January 1 to 15, 2027)

January 1 is a Friday and a holiday. The legal name change takes effect that day, and the IRS online EIN application runs on weekdays, so the new EIN is issued Monday, January 4 at the earliest. Plan for a few days of overlap.

Do these in order.

1. [ ] **Confirm the amendment is effective** and the registry shows Azeeki LLC with the same SOSID. Order certified copies ($10 each, online) and a Certificate of Existence if the bank or UNC requests one
2. [ ] **Apply for the new EIN** for Azeeki LLC on **January 4**, with the tax classification from Phase 0. Store the confirmation outside the repo
3. [ ] **Bank and credit:** provide the certified amendment, new EIN confirmation, and operating agreement. Move or re-paper accounts per the bank's process. Replace cards and checks
4. [ ] **Insurance:** endorse or reissue with the named insured **Azeeki LLC** and the new FEIN. Get written confirmation of continuous coverage and the retroactive date. Reissue certificates for clients that require them
5. [ ] **UNC:** send the corrected package: new W-9, certified amendment, updated certificate of insurance, and any amendment the attorney identified. Agree the payment cutover date for the new EIN
6. [ ] **Tax and licensing accounts:** update any **NCDOR accounts** found in Phase 1 to the new name and EIN. Do not register for new NCDOR accounts until the new EIN exists, and only if the CPA says one is needed. Also NC Division of Employment Security (if payroll), local business or privilege licenses, and any state or university supplier registrations
7. [ ] **Clients:** send written notice through established channels. Phone accounts-payable contacts directly at larger clients. Do **not** bundle a banking change into the same message. Expect verification requests and treat them as a good sign

**Fraud caution.** "We changed names and banking, please update your records" is indistinguishable from a business email compromise attempt. Verify by phone, and state clearly what is and is not changing.

---

## Phase 4 — Systems and Templates (January 2027)

**Contracts**

- [ ] Issue the updated MSA, SOW, NDA, and consulting agreement templates
- [ ] Add the legal-entity block (legal name, state of formation, "EIN on file") to the Engagement Terms section of the Azeeki Consulting Playbook

**Financial**

- [ ] QuickBooks / FreshBooks
- [ ] Stripe / PayPal Business / Square / merchant services
- [ ] Verify invoices render the new legal name and the new EIN

**Microsoft and cloud**

- [ ] Azure tenant billing profile and payment methods
- [ ] Entra tenant display name
- [ ] Microsoft 365 tenant and domain
- [ ] Microsoft AI Cloud Partner Program: verify what legal name and tax ID it requires before changing

**Development**

- [ ] GitHub organization name and billing profile
- [ ] Copilot subscriptions

---

## Phase 5 — Public Launch

Launch after legal and tax steps in Phase 3 are complete. Public branding follows legal completion.

- [ ] Domain: azeeki.com
- [ ] Email: info@azeeki.com, eric@azeeki.com
- [ ] Website copyright notice, privacy policy, terms of service
- [ ] LinkedIn, GitHub, YouTube, X
- [ ] Consider a transition line such as "Azeeki LLC (formerly Javia Company LLC)". The registry keeps the former name visible, so banks and vendors can trace the change

---

## Phase 6 — Wind-Down and Records (Q1 2027)

- [ ] File the **2026 returns** as directed by the CPA (Phase 0)
- [ ] Close the **old EIN** account with the IRS once the CPA confirms the final filings are complete
- [ ] File the NC **annual report** due April 15, 2027. It will carry the Azeeki LLC name. The 2026 report was filed on 4/16/2026, one day after the due date, so file on time
- [ ] Store the approved documents outside the repo and record their **locations** in the tracking document: NC Articles of Amendment, operating agreement, new EIN letter, insurance endorsement, UNC confirmation
- [ ] Retain the Virginia SCC certificate, the 2006 IRS letter, and the 2009 NC Articles in the permanent records

---

## Sequencing Summary

| Phase | Depends on | Target |
|---|---|---|
| 0 — CPA, attorney, trademark answers | Nothing | By mid-Oct 2026 |
| 1 — Prepare, counterparty heads-up, SOS follow-up questions | Phase 0 | Oct to early Nov 2026 |
| 2 — File L-17 (effective 1/1/2027), sign operating agreement | Phase 0 CPA go-ahead | File week of Nov 9; approval about Nov 20 |
| 3 — Cutover: new EIN, bank, insurance, UNC | Amendment effective 1/1/2027 | Jan 1 to 15, 2027 (EIN on Jan 4) |
| 4 — Systems and templates | Phase 3 | January 2027 |
| 5 — Public launch | Phases 3 and 4 | After Phase 3 completes |
| 6 — Wind-down and records | Phase 3 | Q1 2027 |

---

## Costs (known so far)

| Item | Amount |
|---|---|
| L-17 Amendment of Articles of Organization | $50 |
| Expedite, only if needed | $100 (24 hours) or $200 (same day before noon) |
| Certified copy, online | $10 each |
| New EIN | Free from the IRS |
| NC annual report | Due April 15 each year; confirm the current fee with the SOS |
| Professional fees (CPA, attorney, trademark attorney) | Get quotes |

---

## Requires Professional Advice

| Item | Who |
|---|---|
| Tax classification, EIN change, 2026 return, backup-withholding risk, old-EIN close-out, any NCDOR account | CPA |
| UNC contract party, insurance named insured, operating agreement, history statement | Business attorney |
| Trademark ownership and chain of title | Trademark attorney |
| Everything else is administrative and can be self-executed | Eric |

---

## Open Risks

| Risk | Mitigation |
|---|---|
| The IRS record for the old EIN says "Javia LLC", which no longer exists. The current name control (JAVI) probably passes matching for "Javia Company LLC" but will not for "Azeeki LLC". | Do not present "Azeeki LLC" with the old EIN. The cutover keeps the name and EIN change simultaneous. |
| The UNC contract may name a party that does not exist. | Attorney review in Phase 0. |
| The insurance policy may name the wrong entity or FEIN. | Broker conversation in Phase 1. |
| The name Azeeki LLC could be registered by someone else before the filing. | File in early November. Ask the SOS whether a filed future-dated amendment holds the name. |
| A future-dated amendment may be hard to change once filed. | Do not file until the CPA confirms the cutover. Ask the SOS about withdrawal. |
| A rejected filing near the end of the window could push the effective date past 1/1/2027. | File in early November. Use the $100 expedite if needed. Latest safe standard filing date is about December 1. |
| The 2026 return may not be able to stay under the old EIN. | CPA answer in Phase 0. |
