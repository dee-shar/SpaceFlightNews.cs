# SpaceFlightNews.cs
Web-API for [spaceflightnewsapi.net](https://www.spaceflightnewsapi.net/) the Most Complete Spaceflight Related News API

## Example
```cs
using SpaceFlightNewsApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new SpaceFlightNews();
            string articles = await api.GetArticles();
            Console.WriteLine(articles);
        }
    }
}
```
