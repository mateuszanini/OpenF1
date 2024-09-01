namespace OpenF1.Api.Data.Filters
{
    public static class FilterExtensions
    {
        public static string BuildQueryString(this IFilter filter, Type objetcType, object objectValue)
        {
            var expressions = new List<string>();

            foreach (var property in objetcType.GetProperties())
            {
                if (property.GetValue(objectValue) is var value)
                {
                    var defaulValue = Activator.CreateInstance(property.PropertyType);

                    if (value != defaulValue)
                    {
                    }                        
                }
            }

            return string.Join('&', expressions);
        }

        public static Dictionary<string, Operator> InitializeDefaultPropertyOperators(this IFilter filter, Type objetcType, object objectValue)
        {
            var propertyOperators = new Dictionary<string, Operator>();
            var properties = objetcType.GetProperties();

            foreach (var property in properties)
                _ = propertyOperators.TryAdd(property.Name, Operator.Equal);

            return propertyOperators;
        }

        public static string GetTextOperator(this Operator teste) =>
            teste switch
            {
                Operator.GreaterThan => ">",
                Operator.GreaterThanOrEqual => ">=",
                Operator.LessThan => "<",
                Operator.LessThanOrEqual => "<=",
                _ or Operator.Equal => "=",
            };
    }
}
