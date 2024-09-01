namespace OpenF1.Api.Data.Filters
{
    public interface IFilterProperty
    {
        Operator PropertyOperator { get; set; }
        object Value { get; set; }

        string GetTextExpression();
    }
}
