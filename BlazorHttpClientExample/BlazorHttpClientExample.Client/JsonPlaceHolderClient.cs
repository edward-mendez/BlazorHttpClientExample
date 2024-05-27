using BlazorHttpClientExample.Client.Models;
using System.Net.Http.Json;

namespace BlazorHttpClientExample.Client
{
    public class JsonPlaceHolderClient
    {
        private HttpClient _httpClient;
        public JsonPlaceHolderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Todos[]> GetTodos()
        {
            return await _httpClient.GetFromJsonAsync<Todos[]>("todos");
        }
    }
}
