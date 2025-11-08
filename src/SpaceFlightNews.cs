using System.Net.Http;

namespace SpaceFlightNewsApi
{
    public class SpaceFlightNews
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.spaceflightnewsapi.net/v4";
        public SpaceFlightNews()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetArticles()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/articles");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetBlogs()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/blogs");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetInfo()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/info");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetReports()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/reports");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
