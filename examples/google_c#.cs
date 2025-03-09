using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Post,
	RequestUri = new Uri("https://google-checker2.p.rapidapi.com/check_bulk"),
	Headers =
	{
		{ "x-rapidapi-key", "Sign Up for Key" },
		{ "x-rapidapi-host", "google-checker2.p.rapidapi.com" },
	},
	Content = new StringContent("{\"input\":[\"test@gmail.com\",\"john@doe.com\"]}")
	{
		Headers =
		{
			ContentType = new MediaTypeHeaderValue("application/json")
		}
	}
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}