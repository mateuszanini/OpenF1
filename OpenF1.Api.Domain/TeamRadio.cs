namespace OpenF1.Api.Domain
{
    public class TeamRadio
    {
        public virtual DateTime Date { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual string RecordingUrl { get; set; }
        public virtual int SessionKey { get; set; }
    }
}
