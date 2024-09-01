namespace OpenF1.Api.Data.Filters
{
    public interface IFilter
    {
        public Dictionary<string, Operator> PropertyOperators { get; set; }
    }
}
