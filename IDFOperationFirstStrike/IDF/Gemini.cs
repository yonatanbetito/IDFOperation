using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace IDFOperationFirstStrike.IDF
{
    class GeminiSimple
    {
        public static async Task Run()
        {
        string apiKey = "AIzaSyC0pC2TSmyheO-5mlArd0_98LZ5QfjGRVY";

        string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={apiKey}";

        HttpClient client = new HttpClient();

        string jsonBody = @"
                {
                  ""contents"": [{
                    ""parts"": [
                      { ""text"": ""Create new terorist"" }
                    ]
                  }]
                }";

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.SendAsync(request);
        string responseContent = await response.Content.ReadAsStringAsync();

        JsonDocument doc = JsonDocument.Parse(responseContent);
        string resultText = doc.RootElement
            .GetProperty("candidates")[0]
            .GetProperty("content")
            .GetProperty("parts")[0]
            .GetProperty("text")
            .GetString();

        Console.WriteLine("Raw Text:\n" + resultText);
    }

}
}