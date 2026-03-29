
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsBlogPostLanguage
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
    public static class SeoMetaTagsBlogPostLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsBlogPostLanguage value)
        {
            return value switch
            {
                SeoMetaTagsBlogPostLanguage.Bg => "bg",
                SeoMetaTagsBlogPostLanguage.Cs => "cs",
                SeoMetaTagsBlogPostLanguage.Da => "da",
                SeoMetaTagsBlogPostLanguage.De => "de",
                SeoMetaTagsBlogPostLanguage.El => "el",
                SeoMetaTagsBlogPostLanguage.En => "en",
                SeoMetaTagsBlogPostLanguage.Es => "es",
                SeoMetaTagsBlogPostLanguage.Et => "et",
                SeoMetaTagsBlogPostLanguage.Fi => "fi",
                SeoMetaTagsBlogPostLanguage.Fr => "fr",
                SeoMetaTagsBlogPostLanguage.Hu => "hu",
                SeoMetaTagsBlogPostLanguage.It => "it",
                SeoMetaTagsBlogPostLanguage.Ja => "ja",
                SeoMetaTagsBlogPostLanguage.Lt => "lt",
                SeoMetaTagsBlogPostLanguage.Lv => "lv",
                SeoMetaTagsBlogPostLanguage.Nl => "nl",
                SeoMetaTagsBlogPostLanguage.Pl => "pl",
                SeoMetaTagsBlogPostLanguage.PtBr => "pt-br",
                SeoMetaTagsBlogPostLanguage.PtPt => "pt-pt",
                SeoMetaTagsBlogPostLanguage.Ro => "ro",
                SeoMetaTagsBlogPostLanguage.Ru => "ru",
                SeoMetaTagsBlogPostLanguage.Sk => "sk",
                SeoMetaTagsBlogPostLanguage.Sl => "sl",
                SeoMetaTagsBlogPostLanguage.Sv => "sv",
                SeoMetaTagsBlogPostLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsBlogPostLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => SeoMetaTagsBlogPostLanguage.Bg,
                "cs" => SeoMetaTagsBlogPostLanguage.Cs,
                "da" => SeoMetaTagsBlogPostLanguage.Da,
                "de" => SeoMetaTagsBlogPostLanguage.De,
                "el" => SeoMetaTagsBlogPostLanguage.El,
                "en" => SeoMetaTagsBlogPostLanguage.En,
                "es" => SeoMetaTagsBlogPostLanguage.Es,
                "et" => SeoMetaTagsBlogPostLanguage.Et,
                "fi" => SeoMetaTagsBlogPostLanguage.Fi,
                "fr" => SeoMetaTagsBlogPostLanguage.Fr,
                "hu" => SeoMetaTagsBlogPostLanguage.Hu,
                "it" => SeoMetaTagsBlogPostLanguage.It,
                "ja" => SeoMetaTagsBlogPostLanguage.Ja,
                "lt" => SeoMetaTagsBlogPostLanguage.Lt,
                "lv" => SeoMetaTagsBlogPostLanguage.Lv,
                "nl" => SeoMetaTagsBlogPostLanguage.Nl,
                "pl" => SeoMetaTagsBlogPostLanguage.Pl,
                "pt-br" => SeoMetaTagsBlogPostLanguage.PtBr,
                "pt-pt" => SeoMetaTagsBlogPostLanguage.PtPt,
                "ro" => SeoMetaTagsBlogPostLanguage.Ro,
                "ru" => SeoMetaTagsBlogPostLanguage.Ru,
                "sk" => SeoMetaTagsBlogPostLanguage.Sk,
                "sl" => SeoMetaTagsBlogPostLanguage.Sl,
                "sv" => SeoMetaTagsBlogPostLanguage.Sv,
                "zh" => SeoMetaTagsBlogPostLanguage.Zh,
                _ => null,
            };
        }
    }
}