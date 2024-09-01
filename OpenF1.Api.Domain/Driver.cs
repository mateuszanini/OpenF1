namespace OpenF1.Api.Domain
{
    public class Driver
    {
        public virtual string BroadcastName { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual int DriverNumber { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string FullName { get; set; }
        public virtual string HeadshotUrl { get; set; }
        public virtual string LastName { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual string NameAcronym { get; set; }
        public virtual int SessionKey { get; set; }
        public virtual string TeamColour { get; set; }
        public virtual string TeamName { get; set; }
    }
}
