using OpenF1.Api.Domain;
using System.Text.Json;

namespace OpenF1.Api.Client
{
    public partial class OpenF1Client
    {
        public async Task<IEnumerable<Meeting>?> GetMeetingsAsync(int year = 2024, CancellationToken cancellationToken = default)
        {
            var response = await Client.GetAsync($"meetings?year={year}", cancellationToken);
            response.EnsureSuccessStatusCode();
            var contentStream = await response.Content.ReadAsStreamAsync(cancellationToken);
            var meetings = await JsonSerializer.DeserializeAsync<IEnumerable<Meeting>>(contentStream, JsonSerializerOptions, cancellationToken);

            return meetings;
        }
    }
}
