
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeoMetaTagsProductPageLanguage
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
    public static class SeoMetaTagsProductPageLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeoMetaTagsProductPageLanguage value)
        {
            return value switch
            {
                SeoMetaTagsProductPageLanguage.Bg => "bg",
                SeoMetaTagsProductPageLanguage.Cs => "cs",
                SeoMetaTagsProductPageLanguage.Da => "da",
                SeoMetaTagsProductPageLanguage.De => "de",
                SeoMetaTagsProductPageLanguage.El => "el",
                SeoMetaTagsProductPageLanguage.En => "en",
                SeoMetaTagsProductPageLanguage.Es => "es",
                SeoMetaTagsProductPageLanguage.Et => "et",
                SeoMetaTagsProductPageLanguage.Fi => "fi",
                SeoMetaTagsProductPageLanguage.Fr => "fr",
                SeoMetaTagsProductPageLanguage.Hu => "hu",
                SeoMetaTagsProductPageLanguage.It => "it",
                SeoMetaTagsProductPageLanguage.Ja => "ja",
                SeoMetaTagsProductPageLanguage.Lt => "lt",
                SeoMetaTagsProductPageLanguage.Lv => "lv",
                SeoMetaTagsProductPageLanguage.Nl => "nl",
                SeoMetaTagsProductPageLanguage.Pl => "pl",
                SeoMetaTagsProductPageLanguage.PtBr => "pt-br",
                SeoMetaTagsProductPageLanguage.PtPt => "pt-pt",
                SeoMetaTagsProductPageLanguage.Ro => "ro",
                SeoMetaTagsProductPageLanguage.Ru => "ru",
                SeoMetaTagsProductPageLanguage.Sk => "sk",
                SeoMetaTagsProductPageLanguage.Sl => "sl",
                SeoMetaTagsProductPageLanguage.Sv => "sv",
                SeoMetaTagsProductPageLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeoMetaTagsProductPageLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => SeoMetaTagsProductPageLanguage.Bg,
                "cs" => SeoMetaTagsProductPageLanguage.Cs,
                "da" => SeoMetaTagsProductPageLanguage.Da,
                "de" => SeoMetaTagsProductPageLanguage.De,
                "el" => SeoMetaTagsProductPageLanguage.El,
                "en" => SeoMetaTagsProductPageLanguage.En,
                "es" => SeoMetaTagsProductPageLanguage.Es,
                "et" => SeoMetaTagsProductPageLanguage.Et,
                "fi" => SeoMetaTagsProductPageLanguage.Fi,
                "fr" => SeoMetaTagsProductPageLanguage.Fr,
                "hu" => SeoMetaTagsProductPageLanguage.Hu,
                "it" => SeoMetaTagsProductPageLanguage.It,
                "ja" => SeoMetaTagsProductPageLanguage.Ja,
                "lt" => SeoMetaTagsProductPageLanguage.Lt,
                "lv" => SeoMetaTagsProductPageLanguage.Lv,
                "nl" => SeoMetaTagsProductPageLanguage.Nl,
                "pl" => SeoMetaTagsProductPageLanguage.Pl,
                "pt-br" => SeoMetaTagsProductPageLanguage.PtBr,
                "pt-pt" => SeoMetaTagsProductPageLanguage.PtPt,
                "ro" => SeoMetaTagsProductPageLanguage.Ro,
                "ru" => SeoMetaTagsProductPageLanguage.Ru,
                "sk" => SeoMetaTagsProductPageLanguage.Sk,
                "sl" => SeoMetaTagsProductPageLanguage.Sl,
                "sv" => SeoMetaTagsProductPageLanguage.Sv,
                "zh" => SeoMetaTagsProductPageLanguage.Zh,
                _ => null,
            };
        }
    }
}