namespace OpenF1.Api.Domain
{
    public class Session
    {
        public virtual int CircuitKey { get; set; }
        public virtual string CircuitShortName { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual int CountryKey { get; set; }
        public virtual string CountryName { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual TimeSpan GmtOffset { get; set; }
        public virtual string Location { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual int SessionKey { get; set; }
        public virtual string SessionName { get; set; }
        public virtual string SessionType { get; set; }
        public virtual int Year { get; set; }
    }
}
