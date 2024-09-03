using OpenF1.Api.Data;
using OpenF1.Api.Data.Filters;
using OpenF1.Api.Domain;
using System.Net.Http.Json;
using System.Text.Json;

namespace OpenF1.Api.Client
{
    public class OpenF1Client
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

        private async Task<IEnumerable<EntityType>?> GetAsync<EntityType, FilterType>(FilterType filter, string endpoint, CancellationToken cancellationToken = default)
            where EntityType : class
            where FilterType : class, EntityType
        {
            var queryString = filter.BuildQueryString();
            var requestUri = string.Join('?', endpoint, queryString);
            var responseObject = await Client.GetFromJsonAsync<IEnumerable<EntityType>>(requestUri, JsonSerializerOptions, cancellationToken);

            return responseObject;
        }

        public async Task<IEnumerable<Meeting>?> GetMeetingsAsync(MeetingFilter filter, CancellationToken cancellationToken = default) =>
            await GetAsync<Meeting, MeetingFilter>(filter, "meetings", cancellationToken);
    }
}
