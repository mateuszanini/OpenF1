using OpenF1.Api.Domain;
using System.Net.Http.Json;
using System.Text.Json;

namespace OpenF1.Api.Client
{
    public partial class OpenF1Client
    {
        public OpenF1Client(HttpClient client)
        {
            Client = client;
            JsonSerializerOptions = new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                WriteIndented = true
            };
        }

        public HttpClient Client { get; init; }

        public JsonSerializerOptions JsonSerializerOptions { get; init; }
    }
}
