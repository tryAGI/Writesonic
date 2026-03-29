
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsProductPageEngine
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
    public static class SeoMetaTagsProductPageEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsProductPageEngine value)
        {
            return value switch
            {
                SeoMetaTagsProductPageEngine.Average => "average",
                SeoMetaTagsProductPageEngine.Economy => "economy",
                SeoMetaTagsProductPageEngine.Good => "good",
                SeoMetaTagsProductPageEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsProductPageEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => SeoMetaTagsProductPageEngine.Average,
                "economy" => SeoMetaTagsProductPageEngine.Economy,
                "good" => SeoMetaTagsProductPageEngine.Good,
                "premium" => SeoMetaTagsProductPageEngine.Premium,
                _ => null,
            };
        }
    }
}