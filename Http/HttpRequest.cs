using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Http
{
    public static class HttpRequest
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private static async Task<HttpResponseMessage> Send(HttpMethod method, string url)
        {

            var request = new HttpRequestMessage() { Method = method, RequestUri = new Uri(url) };
            return await httpClient.SendAsync(request);
        }

        private static async Task<T?> Get<T>(string url)
        {
            var response = await Send(HttpMethod.Get, url);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }
    }
}
