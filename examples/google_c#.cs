using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();

        // Primary (Recommended): OSINT Trace Direct API
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.osinttrace.com/v1/check/google"),
            // Alternative (API.Market): new Uri("https://prod.api.market/api/v1/osint-trace-1/google-checker/check/google"),
            // Alternative (RapidAPI): new Uri("https://google-checker2.p.rapidapi.com/check"),
            Headers =
            {
                { "x-osint-key", "YOUR_OSINT_KEY" }
                // Alternative API.Market: { "X-Api-Key", "YOUR_API_KEY" }
                // Alternative RapidAPI: { "x-rapidapi-key", "YOUR_RAPIDAPI_KEY" }, { "x-rapidapi-host", "google-checker2.p.rapidapi.com" }
            },
            Content = new StringContent("{\"input\":\"test@gmail.com\"}")
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
            }
        };

        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        Console.WriteLine(body);
    }
}