
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum LinkedInAdsEngine
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
    public static class LinkedInAdsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LinkedInAdsEngine value)
        {
            return value switch
            {
                LinkedInAdsEngine.Average => "average",
                LinkedInAdsEngine.Economy => "economy",
                LinkedInAdsEngine.Good => "good",
                LinkedInAdsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LinkedInAdsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => LinkedInAdsEngine.Average,
                "economy" => LinkedInAdsEngine.Economy,
                "good" => LinkedInAdsEngine.Good,
                "premium" => LinkedInAdsEngine.Premium,
                _ => null,
            };
        }
    }
}