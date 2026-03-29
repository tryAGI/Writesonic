
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProductNamesEngine
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
    public static class ProductNamesEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductNamesEngine value)
        {
            return value switch
            {
                ProductNamesEngine.Average => "average",
                ProductNamesEngine.Economy => "economy",
                ProductNamesEngine.Good => "good",
                ProductNamesEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductNamesEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ProductNamesEngine.Average,
                "economy" => ProductNamesEngine.Economy,
                "good" => ProductNamesEngine.Good,
                "premium" => ProductNamesEngine.Premium,
                _ => null,
            };
        }
    }
}