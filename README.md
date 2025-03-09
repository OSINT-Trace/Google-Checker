# Google Account Checker API

[![RapidAPI Badge](https://img.shields.io/badge/Available%20on-RapidAPI-black?style=for-the-badge&logo=rapidapi)](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2)

A lightweight API to verify Google account existence by username or email.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
  - [Single Account Check](#single-account-check)
  - [Bulk Account Check](#bulk-account-check)
- [Response Format](#response-format)
- [Requirements](#requirements)
- [Pricing](#pricing)
- [Support](#support)
- [Legal Compliance](#legal-compliance)

## Features

✅ Single account verification  
✅ Bulk check up to 10 accounts at once  
✅ Supports emails and usernames  
✅ Fast JSON responses  
✅ Enterprise-grade reliability  

## Getting Started
1. **Get API Key**
   - Subscribe via [RapidAPI Hub](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2)
   - Get your `X-RapidAPI-Key` from your dashboard

2. **Base URL**
```text
https://google-checker2.p.rapidapi.com
```
## API Endpoints
### Single Account Check

**Endpoint**
> POST /check

***Request***  
   ```json
{
    "input": "test@example.com"
}
```

**cURL Example**
```bash
curl --request POST \
     --url https://google-checker2.p.rapidapi.com/check \
     --header 'X-RapidAPI-Host: google-checker2.p.rapidapi.com' \
     --header 'X-RapidAPI-Key: YOUR_API_KEY' \
     --header 'Content-Type: application/json' \
     --data '{"input": "test@example.com"}'
```
### Bulk Account Check
**Endpoint**  
> POST /check_bulk

**Request**
```json
{
    "input": [
        "test@example.com",
        "googleuser123"
    ]
}
```
**Python Example**
```python
import requests

url = "https://google-checker2.p.rapidapi.com/check_bulk"
payload = {"input": ["test@example.com", "googleuser123"]}
headers = {
    "X-RapidAPI-Key": "YOUR_API_KEY",
    "X-RapidAPI-Host": "google-checker2.p.rapidapi.com",
    "Content-Type": "application/json"
}

response = requests.post(url, json=payload, headers=headers)
print(response.json())
```

## Response Format
**Successful Response**
```json
{
  "live": true,
  "note": ""
}
```
**Bulk Response**
```json
[
  {
    "live": true,
    "identifier": "john@doe.com",
    "note": ""
  },
  {
    "live": true,
    "identifier": "jane@doe.com",
    "note": ""
  }
]
```
_note=suspended if the account were suspended_  

## Requirements
- Minimum input length: 3 characters

- Bulk requests limited to 10 items per call

- Valid input types:
  - Email addresses
  - Usernames
 
## Pricing
Flexible plans available through [RapidAPI](https://rapidapi.com/osint-org-osint-org-default/api/google-checker2/pricing).   
Free tier available for testing and low-volume usage.

## Support

For technical issues or enterprise inquiries:  
📧 <info@osinttrace.com>
## Legal Compliance

This API is intended for legitimate use cases only. Users are responsible for:

- Complying with Google's Terms of Service
- Adhering to all applicable data privacy laws
- Obtaining proper consent for data processing

*This service is not affiliated with or endorsed by Alphabet Inc.*
