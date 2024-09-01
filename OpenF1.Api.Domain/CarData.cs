namespace OpenF1.Api.Domain
{
    public class CarData
    {
        public virtual int Brake { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual int Drs { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual int NGear { get; set; }
        public virtual int Rmp { get; set; }
        public virtual int SessionKey { get; set; }
        public virtual int Speed { get; set; }
        public virtual int Throttle { get; set; }
    }
}
