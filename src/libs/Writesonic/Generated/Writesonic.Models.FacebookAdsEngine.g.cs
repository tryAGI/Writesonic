
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum FacebookAdsEngine
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
    public static class FacebookAdsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FacebookAdsEngine value)
        {
            return value switch
            {
                FacebookAdsEngine.Average => "average",
                FacebookAdsEngine.Economy => "economy",
                FacebookAdsEngine.Good => "good",
                FacebookAdsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FacebookAdsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => FacebookAdsEngine.Average,
                "economy" => FacebookAdsEngine.Economy,
                "good" => FacebookAdsEngine.Good,
                "premium" => FacebookAdsEngine.Premium,
                _ => null,
            };
        }
    }
}