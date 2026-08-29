# Google Account Checker & Intelligence API

[![OSINT Trace - Direct API (Recommended)](https://img.shields.io/badge/OSINT%20Trace-Direct%20API%20(Recommended)-00DF9A?style=for-the-badge&logo=shield)](https://osinttrace.com) [![API.Market](https://img.shields.io/badge/API.Market-8B5CF6?style=for-the-badge)](https://api.market/store/osint-trace-1/google-checker) [![RapidAPI](https://img.shields.io/badge/RapidAPI-black?style=for-the-badge&logo=rapidapi)](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2)

A lightweight, enterprise-grade OSINT API to verify Google account existence, deliverability status, and diagnostic state (active vs. suspended, consumer Gmail vs. Google Workspace custom domain mailboxes) by email address or username.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
  - [1. Get API Key](#1-get-api-key)
  - [2. Base URL & Authentication](#2-base-url--authentication)
- [API Endpoints](#api-endpoints)
  - [Single Account Check](#single-account-check)
  - [Code Examples](#code-examples)
- [Response Format](#response-format)
- [HTTP Status Codes](#http-status-codes)
- [Requirements](#requirements)
- [Pricing](#pricing)
- [Support](#support)
- [Legal Compliance](#legal-compliance)

---

## Features

✅ **Instant Verification**: Real-time presence verification for Google Accounts and Gmail mailboxes.  
✅ **Domain & Workspace Support**: Works seamlessly across `@gmail.com` and custom Google Workspace domains.  
✅ **Diagnostic Status & Deliverability**: Flags suspended, disabled, or security-restricted accounts in the `note` field.  
✅ **High Performance**: Asynchronous architecture with high-speed proxy cycling.  
✅ **Developer-Friendly**: Available via direct REST API on [OSINT Trace](https://osinttrace.com) (Recommended) and major developer marketplaces.

---

## Getting Started

### 1. Get API Key

- **OSINT Trace Direct (Recommended)**: Create an account on [OSINT Trace](https://osinttrace.com) and generate your API Key from the [Workspace Dashboard](https://app.osinttrace.com).
- **API.Market**: Subscribe via [API.Market Google Checker](https://api.market/store/osint-trace-1/google-checker).
- **RapidAPI**: Subscribe via [RapidAPI Google Checker](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2).

### 2. Base URL & Authentication

Authentication headers and endpoints vary by provider:

| Provider | Base URL | Auth Header | Endpoint |
|:---|:---|:---|:---|
| **OSINT Trace (Direct - Recommended)** | `https://api.osinttrace.com/v1` | `x-osint-key: YOUR_OSINT_KEY` | `POST /check/google` |
| **API.Market** | `https://prod.api.market/api/v1/osint-trace-1/google-checker` | `X-Api-Key: YOUR_API_KEY` | `POST /check/google` |
| **RapidAPI** | `https://google-checker2.p.rapidapi.com` | `X-RapidAPI-Key: YOUR_API_KEY`<br>`X-RapidAPI-Host: google-checker2.p.rapidapi.com` | `POST /check` |

---

## API Endpoints

### Single Account Check

**Endpoint (OSINT Trace Direct - Recommended):**
> `POST https://api.osinttrace.com/v1/check/google`

**Request Body:**
```json
{
  "input": "target@gmail.com"
}
```

### Code Examples

<details open>
<summary><b>OSINT Trace Direct API (cURL) — Recommended</b></summary>

```bash
curl --request POST \
     --url https://api.osinttrace.com/v1/check/google \
     --header 'x-osint-key: YOUR_OSINT_KEY' \
     --header 'Content-Type: application/json' \
     --data '{"input": "target@gmail.com"}'
```
</details>

<details>
<summary><b>API.Market (cURL)</b></summary>

```bash
curl --request POST \
     --url https://prod.api.market/api/v1/osint-trace-1/google-checker/check/google \
     --header 'X-Api-Key: YOUR_API_KEY' \
     --header 'Content-Type: application/json' \
     --data '{"input": "target@gmail.com"}'
```
</details>

<details>
<summary><b>RapidAPI (cURL)</b></summary>

```bash
curl --request POST \
     --url https://google-checker2.p.rapidapi.com/check \
     --header 'X-RapidAPI-Host: google-checker2.p.rapidapi.com' \
     --header 'X-RapidAPI-Key: YOUR_API_KEY' \
     --header 'Content-Type: application/json' \
     --data '{"input": "target@gmail.com"}'
```
</details>

> Additional code snippets for Python, Node.js, Go, PHP, C#, Java, and Shell are available in the [`examples/`](./examples) directory.

---

## Response Format

### Active Account Found
```json
{
  "live": true,
  "note": null
}
```

### Suspended Account Found
```json
{
  "live": true,
  "note": "suspended"
}
```

### Account Not Found
```json
{
  "live": false,
  "note": null
}
```

---

## HTTP Status Codes

| Status Code | Description | Rationale |
|:---|:---|:---|
| **`200 OK`** | Success | Query processed and presence/diagnostic state returned. |
| **`400 Bad Request`** | Validation Error | Malformed request body or input under minimum length. |
| **`401 Unauthorized`** | Authentication Required | Missing, invalid, or expired API key header. |
| **`403 Forbidden`** | Quota / Subscription Error | Quota balance exhausted or subscription inactive. |
| **`408 Request Timeout`** | Timeout | Upstream verification exceeded maximum execution window. |
| **`429 Too Many Requests`** | Rate Limit Exceeded | Exceeded 1 request/second limit. |

---

## Requirements

- **Minimum input length**: 3 characters
- **Supported input formats**:
  - Email addresses (`user@gmail.com`, `user@custom-workspace-domain.com`)
  - Usernames (`john_doe`)
- **Rate Limit**: 1 request per second per active API key.

---

## Pricing

- **Direct Plans (Recommended)**: Flexible subscription tiers and bulk volume pricing available on [OSINT Trace Pricing](https://osinttrace.com/pricing).
- **Marketplace Plans**: Subscriptions also available through [API.Market](https://api.market/store/osint-trace-1/google-checker) and [RapidAPI](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2/pricing).
- **Free Tier**: Free tier available for evaluation and testing.

---

## Support

For technical inquiries, enterprise SLA plans, or integration assistance:  
📧 Email: [support@osinttrace.com](mailto:support@osinttrace.com)  
🌐 Website: [osinttrace.com](https://osinttrace.com)

---

## Legal Compliance

This API is designed for legitimate cybersecurity investigation, fraud prevention, email deliverability hygiene, and threat intelligence. Users must:
- Comply with applicable local and international data protection regulations (e.g., GDPR, CCPA).
- Adhere to Google's Terms of Service and acceptable use policies.
- Ensure lawful basis for investigative data processing.

*This service is independently operated by OSINT Trace and is not affiliated with or endorsed by Alphabet Inc. or Google LLC.*
