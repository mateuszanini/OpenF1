```csharp
var client = new HttpClient()
{
    BaseAddress = new("https://api.openf1.org/v1/")
};

var openF1Client = new OpenF1Client(client);

var meetingFilter = new MeetingFilter()
{
    CountryCode = new("USA"),
    Year = new(2023, ComparisonOperator.GreaterThanOrEqual)
};

var meetings = await openF1Client.GetMeetingsAsync(meetingFilter);
```