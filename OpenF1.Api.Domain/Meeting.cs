﻿namespace OpenF1.Api.Domain
{
    public class Meeting
    {
        public virtual int CircuitKey { get; set; }
        public virtual string CircuitShortName { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual int CountryKey { get; set; }
        public virtual string CountryName { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual TimeSpan GmtOffset { get; set; }
        public virtual string Location { get; set; }
        public virtual int MeetingKey { get; set; }
        public virtual string MeetingName { get; set; }
        public virtual string MeetingOfficialName { get; set; }
        public virtual int Year { get; set; }
    }
}
