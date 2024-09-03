namespace OpenF1.Api.Data
{
    public interface IFilterProperty
    {
        ComparisonOperator PropertyOperator { get; set; }

        string GetTextExpression();
    }

    public interface IFilterProperty<T> : IFilterProperty
    {
        T? Value { get; set; }
    }
}
