
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsHomepageLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeoMetaTagsHomepageLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsHomepageLanguage value)
        {
            return value switch
            {
                SeoMetaTagsHomepageLanguage.Bg => "bg",
                SeoMetaTagsHomepageLanguage.Cs => "cs",
                SeoMetaTagsHomepageLanguage.Da => "da",
                SeoMetaTagsHomepageLanguage.De => "de",
                SeoMetaTagsHomepageLanguage.El => "el",
                SeoMetaTagsHomepageLanguage.En => "en",
                SeoMetaTagsHomepageLanguage.Es => "es",
                SeoMetaTagsHomepageLanguage.Et => "et",
                SeoMetaTagsHomepageLanguage.Fi => "fi",
                SeoMetaTagsHomepageLanguage.Fr => "fr",
                SeoMetaTagsHomepageLanguage.Hu => "hu",
                SeoMetaTagsHomepageLanguage.It => "it",
                SeoMetaTagsHomepageLanguage.Ja => "ja",
                SeoMetaTagsHomepageLanguage.Lt => "lt",
                SeoMetaTagsHomepageLanguage.Lv => "lv",
                SeoMetaTagsHomepageLanguage.Nl => "nl",
                SeoMetaTagsHomepageLanguage.Pl => "pl",
                SeoMetaTagsHomepageLanguage.PtBr => "pt-br",
                SeoMetaTagsHomepageLanguage.PtPt => "pt-pt",
                SeoMetaTagsHomepageLanguage.Ro => "ro",
                SeoMetaTagsHomepageLanguage.Ru => "ru",
                SeoMetaTagsHomepageLanguage.Sk => "sk",
                SeoMetaTagsHomepageLanguage.Sl => "sl",
                SeoMetaTagsHomepageLanguage.Sv => "sv",
                SeoMetaTagsHomepageLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsHomepageLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => SeoMetaTagsHomepageLanguage.Bg,
                "cs" => SeoMetaTagsHomepageLanguage.Cs,
                "da" => SeoMetaTagsHomepageLanguage.Da,
                "de" => SeoMetaTagsHomepageLanguage.De,
                "el" => SeoMetaTagsHomepageLanguage.El,
                "en" => SeoMetaTagsHomepageLanguage.En,
                "es" => SeoMetaTagsHomepageLanguage.Es,
                "et" => SeoMetaTagsHomepageLanguage.Et,
                "fi" => SeoMetaTagsHomepageLanguage.Fi,
                "fr" => SeoMetaTagsHomepageLanguage.Fr,
                "hu" => SeoMetaTagsHomepageLanguage.Hu,
                "it" => SeoMetaTagsHomepageLanguage.It,
                "ja" => SeoMetaTagsHomepageLanguage.Ja,
                "lt" => SeoMetaTagsHomepageLanguage.Lt,
                "lv" => SeoMetaTagsHomepageLanguage.Lv,
                "nl" => SeoMetaTagsHomepageLanguage.Nl,
                "pl" => SeoMetaTagsHomepageLanguage.Pl,
                "pt-br" => SeoMetaTagsHomepageLanguage.PtBr,
                "pt-pt" => SeoMetaTagsHomepageLanguage.PtPt,
                "ro" => SeoMetaTagsHomepageLanguage.Ro,
                "ru" => SeoMetaTagsHomepageLanguage.Ru,
                "sk" => SeoMetaTagsHomepageLanguage.Sk,
                "sl" => SeoMetaTagsHomepageLanguage.Sl,
                "sv" => SeoMetaTagsHomepageLanguage.Sv,
                "zh" => SeoMetaTagsHomepageLanguage.Zh,
                _ => null,
            };
        }
    }
}