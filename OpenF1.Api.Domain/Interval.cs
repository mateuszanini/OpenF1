namespace OpenF1.Api.Domain
{
    public class Interval
    {
        public virtual DateTime Date { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual decimal GapToLeader { get; set; }
        //public virtual decimal Interval { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual int SessionKey { get; set; }
    }
}
