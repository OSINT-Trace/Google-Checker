#!/usr/bin/env bash

# Verify by email or username
curl --request POST \
  --url https://api.osinttrace.com/v1/check/google \
  --header 'x-osint-key: YOUR_OSINT_KEY' \
  --header 'Content-Type: application/json' \
  --data '{"input":"test@gmail.com"}'

# Or verify by phone number (E.164 format)
# curl --request POST \
#   --url https://api.osinttrace.com/v1/check/google \
#   --header 'x-osint-key: YOUR_OSINT_KEY' \
#   --header 'Content-Type: application/json' \
#   --data '{"input":"+14155552671"}'

# Alternative (API.Market):
# curl --request POST \
#   --url https://prod.api.market/api/v1/osint-trace-1/google-checker/check/google \
#   --header 'X-Api-Key: YOUR_API_KEY' \
#   --header 'Content-Type: application/json' \
#   --data '{"input":"test@gmail.com"}'

# Alternative (RapidAPI):
# curl --request POST \
#   --url https://google-checker2.p.rapidapi.com/check \
#   --header 'x-rapidapi-host: google-checker2.p.rapidapi.com' \
#   --header 'x-rapidapi-key: YOUR_RAPIDAPI_KEY' \
#   --header 'Content-Type: application/json' \
#   --data '{"input":"test@gmail.com"}'