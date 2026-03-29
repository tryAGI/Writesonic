
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsHomepageEngine
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
    public static class SeoMetaTagsHomepageEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsHomepageEngine value)
        {
            return value switch
            {
                SeoMetaTagsHomepageEngine.Average => "average",
                SeoMetaTagsHomepageEngine.Economy => "economy",
                SeoMetaTagsHomepageEngine.Good => "good",
                SeoMetaTagsHomepageEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsHomepageEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => SeoMetaTagsHomepageEngine.Average,
                "economy" => SeoMetaTagsHomepageEngine.Economy,
                "good" => SeoMetaTagsHomepageEngine.Good,
                "premium" => SeoMetaTagsHomepageEngine.Premium,
                _ => null,
            };
        }
    }
}