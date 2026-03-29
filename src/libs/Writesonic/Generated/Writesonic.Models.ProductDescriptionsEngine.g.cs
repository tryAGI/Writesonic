
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProductDescriptionsEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Average,
        /// <summary>
        /// 
        /// </summary>
        Economy,
        /// <summary>
        /// 
        /// </summary>
        Good,
        /// <summary>
        /// 
        /// </summary>
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductDescriptionsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductDescriptionsEngine value)
        {
            return value switch
            {
                ProductDescriptionsEngine.Average => "average",
                ProductDescriptionsEngine.Economy => "economy",
                ProductDescriptionsEngine.Good => "good",
                ProductDescriptionsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductDescriptionsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ProductDescriptionsEngine.Average,
                "economy" => ProductDescriptionsEngine.Economy,
                "good" => ProductDescriptionsEngine.Good,
                "premium" => ProductDescriptionsEngine.Premium,
                _ => null,
            };
        }
    }
}