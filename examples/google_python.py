import requests

# API.Market URL: https://prod.api.market/api/v1/osint-trace-1/google-checker/check/google
url = "https://google-checker2.p.rapidapi.com/check"

payload = { "input": "test@example.com" }
# API.Market Header: X-Api-Key: YOUR_API_KEY
headers = {
	"x-rapidapi-key": "Sign Up for Key",
	"x-rapidapi-host": "google-checker2.p.rapidapi.com",
	"Content-Type": "application/json"
}

response = requests.post(url, json=payload, headers=headers)

print(response.json())