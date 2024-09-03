using OpenF1.Api.Domain;

namespace OpenF1.Api.Data.Filters
{
    public class MeetingFilter : Meeting
    {
        public new FilterProperty<int>? CircuitKey { get; set; }
        public new FilterProperty<string>? CircuitShortName { get; set; }
        public new FilterProperty<string>? CountryCode { get; set; }
        public new FilterProperty<int>? CountryKey { get; set; }
        public new FilterProperty<string>? CountryName { get; set; }
        public new FilterProperty<DateTime>? DateStart { get; set; }
        public new FilterProperty<TimeSpan>? GmtOffset { get; set; }
        public new FilterProperty<string>? Location { get; set; }
        public new FilterProperty<int>? MeetingKey { get; set; }
        public new FilterProperty<string>? MeetingName { get; set; }
        public new FilterProperty<string>? MeetingOfficialName { get; set; }
        public new FilterProperty<int>? Year { get; set; }
    }
}
