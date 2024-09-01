namespace OpenF1.Api.Data.Filters
{
    public class BaseFilter//<T> where T : class
    {
        public BaseFilter()
        {
            InitializeDefaultPropertyOperators();
        }

        public Dictionary<string, Operator> PropertyOperators { get; set; } = [];

        private string BuildQueryString()
        {
            var expressions = new List<string>();
            var properties = GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(this, null) is IFilterProperty value)
                {
                    var defaulValue = Activator.CreateInstance(property.PropertyType);

                    if (value != defaulValue)
                    {
                        if(PropertyOperators.TryGetValue(property.Name, out var propertyOperator))
                            expressions.Add(string.Join(propertyOperator.GetTextOperator(), property.Name, value.ToString()));
                    }
                }
            }

            return string.Join('&', expressions);
        }

        private void InitializeDefaultPropertyOperators()
        {
            var properties = GetType().GetProperties();

            foreach (var property in properties)
                _ = PropertyOperators.TryAdd(property.Name, Operator.Equal);
        }

        public override string ToString() =>
            BuildQueryString();
    }
}
