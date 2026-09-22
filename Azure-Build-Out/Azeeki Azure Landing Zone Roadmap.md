# Azeeki Azure Landing Zone & Modernization Roadmap

## Purpose

This document provides a strategic roadmap for transitioning Azeeki from a traditional hosting model into a Microsoft-first consulting company built on Azure, Microsoft 365, Fabric, GitHub, and Entra ID.

The goal is to establish a scalable, secure, and modern platform that supports:

- Consulting services
- Customer demonstrations
- Internal operations
- AI initiatives
- Fabric solutions
- Future SaaS offerings

---

# Vision

Azeeki becomes a Microsoft-centric consulting company operating on:

- Microsoft 365
- Entra ID
- Azure
- Microsoft Fabric
- GitHub
- Azure AI Services

The website is only one component of the broader technology platform.

---

# What Most New Consulting Companies Miss

Many new consulting organizations focus on:

- Websites
- Email
- Azure subscriptions

While overlooking:

- Identity management
- Security architecture
- Governance
- Backup strategy
- Cost management
- Customer data isolation
- CRM and lead tracking
- Proposal management
- GitHub governance
- Tenant architecture

Treat Azeeki like a customer landing zone from the beginning.

---

# Target Architecture

```text
Azeeki
│
├── Entra ID
│
├── Microsoft 365 Business Premium
│
├── Azure
│   ├── App Services
│   ├── Azure SQL
│   ├── Storage Accounts
│   ├── Key Vault
│   ├── AI Services
│   └── Monitoring
│
├── Microsoft Fabric
│   ├── Internal Operations
│   ├── Demo Environment
│   ├── Customer Demos
│   └── Training Environments
│
├── GitHub
│   ├── Public Repositories
│   ├── Private Repositories
│   └── GitHub Copilot
│
└── Website & Blog
```

---

# Phase 1 – Identity First

## Objective

Establish company identity and security.

## Recommended Actions

Purchase:

- Microsoft 365 Business Premium

Capabilities gained:

- Entra ID
- Intune
- Defender
- Office Apps
- SharePoint
- Teams

## Why First?

Everything later will connect through Entra ID:

- Azure
- Fabric
- GitHub
- Customer portals
- Internal systems

Identity is the foundation.

---

# Phase 2 – Azure Landing Zone

## Management Group

```text
Azeeki
```

## Initial Azure Subscription Strategy

```text
Production
Development
Sandbox
```

Purpose:

- Separate production from experimentation
- Improve governance
- Simplify cost tracking

---

# Resource Group Design

## Shared Services

```text
rg-shared-prod
```

Contains:

- Key Vault
- Shared Storage
- Monitoring
- Diagnostic Services

---

## Website

```text
rg-web-prod
```

Contains:

- App Service
- Database
- Certificates
- Logging

---

## Fabric Demo

```text
rg-fabric-demo
```

Contains:

- Demo databases
- Demo datasets
- Storage accounts

---

# Phase 3 – Website Strategy

## Current State

Website and WordPress blog hosted in GoDaddy.

## Recommendation

Do NOT migrate immediately.

Focus first on:

- Identity
- Azure
- Fabric
- GitHub
- Security

The website is not currently the business bottleneck.

---

## Future Option 1

WordPress on Azure App Service

Benefits:

- Managed hosting
- Backups
- SSL management
- Azure integration
- Improved scalability

---

## Future Option 2

Replace WordPress with:

- Next.js
- React
- Hugo
- Static Site Generator

Host with:

Azure Static Web Apps

Benefits:

- Lower cost
- GitHub integration
- Faster deployment
- Simpler operations

---

# Phase 4 – GitHub Strategy

## Public Repositories

```text
azeeki-blog-examples
fabric-samples
powerbi-patterns
```

## Private Repositories

```text
azeeki-internal
customer-assets
proposals
```

## Benefits

- Intellectual property management
- Customer solution examples
- Marketing content
- Reusable assets

---

# Phase 5 – Fabric Landing Zone

## Internal Operations Workspace

Track:

- Revenue
- Leads
- Projects
- Pipeline

---

## Demo Workspace

Support:

- Customer demonstrations
- Workshops
- Presentations

---

## Training Workspace

Support:

- Fabric training
- Learning exercises
- Customer enablement

---

## Customer Template Workspace

Store:

- Reference architectures
- Reusable solutions
- Industry accelerators

---

# Phase 6 – Azure SQL Foundation

Deploy:

Azure SQL Database

Potential Uses:

- CRM system
- Customer tracking
- Proposal tracking
- Assessment tracking
- Blog analytics

Benefit:

Supports both learning and demonstration scenarios.

---

# Phase 7 – AI Ready Foundation

Create dedicated AI resource group.

Potential Services:

- Azure AI Foundry
- Azure OpenAI
- Search
- RAG solutions
- Agents

Even if unused initially, prepare the foundation.

---

# Startup Benefits Strategy

## Microsoft for Startups

Potential advantages identified in Microsoft startup resources include:

- Startup credits
- Azure resources
- Technical guidance
- Additional startup benefits
- Potential access to significant Azure credits over time for qualifying startups

References:
- Microsoft for Startups guidance
- Startup credit programs

---

## Microsoft AI Cloud Partner Program

Potential benefits include:

- Azure credits
- Visual Studio benefits
- Partner enablement resources
- Additional development benefits

References:
- Microsoft AI Cloud Partner Program documentation

---

# Visual Studio Strategy

Investigate the following paths:

1. Microsoft for Startups
2. Microsoft AI Cloud Partner Program
3. Direct Visual Studio subscription purchase

Potential outcomes may include:

- Visual Studio access
- Azure DevOps access
- Development tooling benefits

---

# Business Foundations Often Missed

## Corporate

- LLC / DBA alignment
- Business banking
- Accounting platform
- Business insurance
- Legal documents

---

## Microsoft Foundation

- Microsoft 365 Business Premium
- Entra ID
- Azure
- Fabric
- GitHub

---

## Sales Foundation

- CRM
- Proposal templates
- SOW templates
- MSA templates

---

## Security Foundation

- MFA
- Conditional Access
- Password vault
- Backup procedures

---

## Marketing Foundation

- Blogging strategy
- Domain strategy
- Case studies
- Lead generation

---

## Delivery Foundation

- Demo environments
- Assessment toolkit
- Reusable architectures
- Industry accelerators

---

# 90-Day Implementation Plan

## Month 1

- Create Microsoft 365 tenant
- Configure Entra ID
- Create Azure subscriptions
- Create GitHub organization
- Apply for startup and partner programs

## Month 2

- Build Azure landing zone
- Create Fabric workspaces
- Deploy Azure SQL
- Deploy Key Vault
- Enable monitoring

## Month 3

- Build demo environments
- Create AI sandbox
- Evaluate website migration
- Develop customer demo assets

---

# Critical Strategic Question

## What Am I Missing As A New Company In The Azure Mix?

The answer is usually not technology.

The biggest gaps for new consulting organizations are:

1. Governance
2. Identity
3. Security
4. Cost Management
5. Sales Processes
6. Reusable Intellectual Property
7. Customer Acquisition Strategy
8. Delivery Frameworks
9. Proposal and Contract Templates
10. Operational Reporting

Technology alone rarely creates a successful consulting business.

The combination of:

- Azure
- Fabric
- Entra ID
- GitHub
- Security
- Governance
- Sales operations

creates the foundation for a scalable consulting company.

---

# Long-Term Vision

Azeeki should evolve into a Microsoft-first consulting organization built on:

- Azure
- Fabric
- GitHub
- Entra ID
- AI Services
- Modern SaaS Architecture

The website is simply the entry point. The real asset is the platform, intellectual property, expertise, and repeatable delivery capability behind it.
