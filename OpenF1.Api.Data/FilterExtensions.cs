using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace OpenF1.Api.Data
{
    public static class FilterExtensions
    {
        public static string BuildQueryString<T>(this T objeto)
        {
            var expressions = new List<string>();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                if (property.GetValue(objeto) is IFilterProperty value)
                {
                    var propertyName = property.ToSnakeCaseLower();
                    var textExpression = value.GetTextExpression();
                    expressions.Add(string.Concat(propertyName, textExpression));
                }
            }

            return string.Join('&', expressions);
        }

        public static string GetTextOperator(this ComparisonOperator teste) =>
            teste switch
            {
                ComparisonOperator.GreaterThan => ">",
                ComparisonOperator.GreaterThanOrEqual => ">=",
                ComparisonOperator.LessThan => "<",
                ComparisonOperator.LessThanOrEqual => "<=",
                _ or ComparisonOperator.Equal => "=",
            };

        public static string ToSnakeCaseLower(this PropertyInfo propertyInfo) =>
            propertyInfo.Name.ToSnakeCaseLower();

        public static string ToSnakeCaseLower(this string text) =>
            new DefaultContractResolver() { NamingStrategy = new SnakeCaseNamingStrategy() }.GetResolvedPropertyName(text).ToLowerInvariant();
    }
}
