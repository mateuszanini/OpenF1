namespace OpenF1.Api.Data
{
    public class FilterProperty<T> : IFilterProperty<T>
    {
        public FilterProperty(T value, ComparisonOperator propertyOperator = ComparisonOperator.Equal)
        {
            PropertyOperator = propertyOperator;
            Value = value;
        }

        public ComparisonOperator PropertyOperator { get; set; }
        public T? Value { get; set; }

        public string GetTextExpression()
        {
            if (Value is null)
                throw new ArgumentNullException(nameof(Value));

            var textValue = Value?.ToString();

            if (Value is DateTime date)
                textValue = date.ToString("yyyy-MM-ddTHH:mm:ss.fff");


            return string.Concat(PropertyOperator.GetTextOperator(), textValue);
        }
    }
}
