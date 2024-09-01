namespace OpenF1.Api.Data.Filters
{
    public class FilterProperty<T> : IFilterProperty
    {
        public FilterProperty(object value, Operator propertyOperator = Operator.Equal)
        {
            PropertyOperator = propertyOperator;
            Value = value;
        }

        public Operator PropertyOperator { get; set; }
        public object Value { get; set; }

        public string GetTextExpression() =>
            string.Concat(PropertyOperator.GetTextOperator(), Value.ToString());
    }
}
