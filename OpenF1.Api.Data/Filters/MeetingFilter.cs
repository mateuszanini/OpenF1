using OpenF1.Api.Domain;

namespace OpenF1.Api.Data.Filters
{
    public class MeetingFilter : BaseFilter//Meeting, IFilter
    {
        public MeetingFilter() : base()
        {
            //PropertyOperators = this.InitializeDefaultPropertyOperators(typeof(Meeting), this);
            //var queryString = this.BuildQueryString(typeof(Meeting), this);
        }

        //public Dictionary<string, Operator> PropertyOperators { get; set; }

        public virtual FilterProperty<int>? Year { get; set; }
    }
}
