namespace OpenF1.Api.Domain
{
    public class Pit
    {
        public virtual DateTime Date { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual int LapNumber { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual decimal PitDuration { get; set; }
        public virtual int SessionKey { get; set; }
    }
}
