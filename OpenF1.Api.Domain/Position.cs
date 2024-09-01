namespace OpenF1.Api.Domain
{
    public class Position
    {
        public virtual DateTime Date { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual int MeetingKey { get; set; }
        //public virtual int Position { get; set; }
        public virtual int SessionKey { get; set; }
    }
}
