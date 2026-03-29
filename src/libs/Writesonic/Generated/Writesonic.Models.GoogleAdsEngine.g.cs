
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleAdsEngine
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
    public static class GoogleAdsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleAdsEngine value)
        {
            return value switch
            {
                GoogleAdsEngine.Average => "average",
                GoogleAdsEngine.Economy => "economy",
                GoogleAdsEngine.Good => "good",
                GoogleAdsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleAdsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => GoogleAdsEngine.Average,
                "economy" => GoogleAdsEngine.Economy,
                "good" => GoogleAdsEngine.Good,
                "premium" => GoogleAdsEngine.Premium,
                _ => null,
            };
        }
    }
}