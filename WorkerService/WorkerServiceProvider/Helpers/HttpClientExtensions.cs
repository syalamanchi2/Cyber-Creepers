namespace WorkerServiceProvider
{
    using Newtonsoft.Json;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonConvert.SerializeObject(data);
            var content = new StringContent(dataAsString);
            httpClient.BaseAddress = new Uri(url);
            httpClient.DefaultRequestHeaders.Add("x-ms-version", "2017-01-01");
            httpClient.Timeout = TimeSpan.FromMinutes(5);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            return await httpClient.PostAsync(url, content, token);
        }
    }
}