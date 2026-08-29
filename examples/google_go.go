package main

import (
	"fmt"
	"io"
	"net/http"
	"strings"
)

func main() {
	// Primary (Recommended): OSINT Trace Direct API
	url := "https://api.osinttrace.com/v1/check/google"

	// Alternative (API.Market):
	// url := "https://prod.api.market/api/v1/osint-trace-1/google-checker/check/google"

	// Alternative (RapidAPI):
	// url := "https://google-checker2.p.rapidapi.com/check"

	payload := strings.NewReader(`{"input":"test@gmail.com"}`)

	req, err := http.NewRequest("POST", url, payload)
	if err != nil {
		fmt.Println("Error creating request:", err)
		return
	}

	// Primary Auth Header
	req.Header.Add("x-osint-key", "YOUR_OSINT_KEY")
	req.Header.Add("Content-Type", "application/json")

	// Alternative Headers:
	// req.Header.Add("X-Api-Key", "YOUR_API_KEY") // API.Market
	// req.Header.Add("x-rapidapi-key", "YOUR_RAPIDAPI_KEY") // RapidAPI
	// req.Header.Add("x-rapidapi-host", "google-checker2.p.rapidapi.com") // RapidAPI

	res, err := http.DefaultClient.Do(req)
	if err != nil {
		fmt.Println("Error sending request:", err)
		return
	}
	defer res.Body.Close()

	body, _ := io.ReadAll(res.Body)
	fmt.Println(string(body))
}