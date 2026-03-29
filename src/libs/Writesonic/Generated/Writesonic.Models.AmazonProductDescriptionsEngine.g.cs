
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum AmazonProductDescriptionsEngine
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
    public static class AmazonProductDescriptionsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmazonProductDescriptionsEngine value)
        {
            return value switch
            {
                AmazonProductDescriptionsEngine.Average => "average",
                AmazonProductDescriptionsEngine.Economy => "economy",
                AmazonProductDescriptionsEngine.Good => "good",
                AmazonProductDescriptionsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmazonProductDescriptionsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => AmazonProductDescriptionsEngine.Average,
                "economy" => AmazonProductDescriptionsEngine.Economy,
                "good" => AmazonProductDescriptionsEngine.Good,
                "premium" => AmazonProductDescriptionsEngine.Premium,
                _ => null,
            };
        }
    }
}