
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsBlogPostEngine
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
    public static class SeoMetaTagsBlogPostEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsBlogPostEngine value)
        {
            return value switch
            {
                SeoMetaTagsBlogPostEngine.Average => "average",
                SeoMetaTagsBlogPostEngine.Economy => "economy",
                SeoMetaTagsBlogPostEngine.Good => "good",
                SeoMetaTagsBlogPostEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsBlogPostEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => SeoMetaTagsBlogPostEngine.Average,
                "economy" => SeoMetaTagsBlogPostEngine.Economy,
                "good" => SeoMetaTagsBlogPostEngine.Good,
                "premium" => SeoMetaTagsBlogPostEngine.Premium,
                _ => null,
            };
        }
    }
}