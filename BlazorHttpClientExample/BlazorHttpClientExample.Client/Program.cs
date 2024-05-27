using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorHttpClientExample.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") });

            builder.Services.AddHttpClient("JsonPlaceHolderClient", client =>
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            });

            builder.Services.AddHttpClient<JsonPlaceHolderClient>(client =>
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            });

            await builder.Build().RunAsync();
        }
    }
}
