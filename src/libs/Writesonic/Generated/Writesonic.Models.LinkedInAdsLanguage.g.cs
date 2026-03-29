
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum LinkedInAdsLanguage
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
    public static class LinkedInAdsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LinkedInAdsLanguage value)
        {
            return value switch
            {
                LinkedInAdsLanguage.Bg => "bg",
                LinkedInAdsLanguage.Cs => "cs",
                LinkedInAdsLanguage.Da => "da",
                LinkedInAdsLanguage.De => "de",
                LinkedInAdsLanguage.El => "el",
                LinkedInAdsLanguage.En => "en",
                LinkedInAdsLanguage.Es => "es",
                LinkedInAdsLanguage.Et => "et",
                LinkedInAdsLanguage.Fi => "fi",
                LinkedInAdsLanguage.Fr => "fr",
                LinkedInAdsLanguage.Hu => "hu",
                LinkedInAdsLanguage.It => "it",
                LinkedInAdsLanguage.Ja => "ja",
                LinkedInAdsLanguage.Lt => "lt",
                LinkedInAdsLanguage.Lv => "lv",
                LinkedInAdsLanguage.Nl => "nl",
                LinkedInAdsLanguage.Pl => "pl",
                LinkedInAdsLanguage.PtBr => "pt-br",
                LinkedInAdsLanguage.PtPt => "pt-pt",
                LinkedInAdsLanguage.Ro => "ro",
                LinkedInAdsLanguage.Ru => "ru",
                LinkedInAdsLanguage.Sk => "sk",
                LinkedInAdsLanguage.Sl => "sl",
                LinkedInAdsLanguage.Sv => "sv",
                LinkedInAdsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LinkedInAdsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => LinkedInAdsLanguage.Bg,
                "cs" => LinkedInAdsLanguage.Cs,
                "da" => LinkedInAdsLanguage.Da,
                "de" => LinkedInAdsLanguage.De,
                "el" => LinkedInAdsLanguage.El,
                "en" => LinkedInAdsLanguage.En,
                "es" => LinkedInAdsLanguage.Es,
                "et" => LinkedInAdsLanguage.Et,
                "fi" => LinkedInAdsLanguage.Fi,
                "fr" => LinkedInAdsLanguage.Fr,
                "hu" => LinkedInAdsLanguage.Hu,
                "it" => LinkedInAdsLanguage.It,
                "ja" => LinkedInAdsLanguage.Ja,
                "lt" => LinkedInAdsLanguage.Lt,
                "lv" => LinkedInAdsLanguage.Lv,
                "nl" => LinkedInAdsLanguage.Nl,
                "pl" => LinkedInAdsLanguage.Pl,
                "pt-br" => LinkedInAdsLanguage.PtBr,
                "pt-pt" => LinkedInAdsLanguage.PtPt,
                "ro" => LinkedInAdsLanguage.Ro,
                "ru" => LinkedInAdsLanguage.Ru,
                "sk" => LinkedInAdsLanguage.Sk,
                "sl" => LinkedInAdsLanguage.Sl,
                "sv" => LinkedInAdsLanguage.Sv,
                "zh" => LinkedInAdsLanguage.Zh,
                _ => null,
            };
        }
    }
}