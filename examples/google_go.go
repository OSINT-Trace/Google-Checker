package main

import (
	"fmt"
	"strings"
	"net/http"
	"io"
)

func main() {

	url := "https://google-checker2.p.rapidapi.com/check_bulk"

	payload := strings.NewReader("{"input":["test@gmail.com","john@doe.com"]}")

	req, _ := http.NewRequest("POST", url, payload)

	req.Header.Add("x-rapidapi-key", "Sign Up for Key")
	req.Header.Add("x-rapidapi-host", "google-checker2.p.rapidapi.com")
	req.Header.Add("Content-Type", "application/json")

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := io.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))

}