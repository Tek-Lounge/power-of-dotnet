using System.Text.Json;

namespace News.Core;

public class NewsClient
{
    private HttpClient _client;
    private string API_KEY = "ENTER API KEY HERE";

    public NewsClient()
    {
        _client = new HttpClient { BaseAddress = new Uri("http://api.mediastack.com") };
    }

    public async Task<NewsList> GetNews(string categories = "", string countries = "", string languages = "en")
    {
        var response = await _client.GetStringAsync($"/v1/news?access_key={API_KEY}&languages={languages}&countries={countries}&categories={categories}");
        return JsonSerializer.Deserialize<NewsList>(response);
    }
}