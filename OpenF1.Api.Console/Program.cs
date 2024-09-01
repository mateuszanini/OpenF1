using OpenF1.Api.Client;
using OpenF1.Api.Data.Filters;

var meetingFilter = new MeetingFilter()
{
    Year = new(2023),
    //CountryCode = "USA"
};
var queryString = meetingFilter.ToString();

var client = new HttpClient()
{
    BaseAddress = new("https://api.openf1.org/v1/")
};

var openF1Client = new OpenF1Client(client);

var meetings = await openF1Client.GetMeetingsAsync();

Console.ReadKey();