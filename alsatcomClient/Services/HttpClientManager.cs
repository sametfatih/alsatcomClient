using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Models;
using System.Text.Json;

namespace alsatcomClient.Services
{
    public class HttpClientManager : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientManager(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("Alsatcom");
        }

        public async Task<T> GetRequest<T>(string requestUri)
        {
            string response = await _httpClient.GetStringAsync(requestUri);

            T? result = JsonSerializer.Deserialize<T>(response);

            return result!;
        }
    }
}
