import requests

url = "https://google-checker2.p.rapidapi.com/check_bulk"

payload = { "input": ["test@gmail.com", "john@doe.com"] }
headers = {
	"x-rapidapi-key": "Sign Up for Key",
	"x-rapidapi-host": "google-checker2.p.rapidapi.com",
	"Content-Type": "application/json"
}

response = requests.post(url, json=payload, headers=headers)

print(response.json())