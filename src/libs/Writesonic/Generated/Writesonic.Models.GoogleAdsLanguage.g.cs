
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleAdsLanguage
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
    public static class GoogleAdsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleAdsLanguage value)
        {
            return value switch
            {
                GoogleAdsLanguage.Bg => "bg",
                GoogleAdsLanguage.Cs => "cs",
                GoogleAdsLanguage.Da => "da",
                GoogleAdsLanguage.De => "de",
                GoogleAdsLanguage.El => "el",
                GoogleAdsLanguage.En => "en",
                GoogleAdsLanguage.Es => "es",
                GoogleAdsLanguage.Et => "et",
                GoogleAdsLanguage.Fi => "fi",
                GoogleAdsLanguage.Fr => "fr",
                GoogleAdsLanguage.Hu => "hu",
                GoogleAdsLanguage.It => "it",
                GoogleAdsLanguage.Ja => "ja",
                GoogleAdsLanguage.Lt => "lt",
                GoogleAdsLanguage.Lv => "lv",
                GoogleAdsLanguage.Nl => "nl",
                GoogleAdsLanguage.Pl => "pl",
                GoogleAdsLanguage.PtBr => "pt-br",
                GoogleAdsLanguage.PtPt => "pt-pt",
                GoogleAdsLanguage.Ro => "ro",
                GoogleAdsLanguage.Ru => "ru",
                GoogleAdsLanguage.Sk => "sk",
                GoogleAdsLanguage.Sl => "sl",
                GoogleAdsLanguage.Sv => "sv",
                GoogleAdsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleAdsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => GoogleAdsLanguage.Bg,
                "cs" => GoogleAdsLanguage.Cs,
                "da" => GoogleAdsLanguage.Da,
                "de" => GoogleAdsLanguage.De,
                "el" => GoogleAdsLanguage.El,
                "en" => GoogleAdsLanguage.En,
                "es" => GoogleAdsLanguage.Es,
                "et" => GoogleAdsLanguage.Et,
                "fi" => GoogleAdsLanguage.Fi,
                "fr" => GoogleAdsLanguage.Fr,
                "hu" => GoogleAdsLanguage.Hu,
                "it" => GoogleAdsLanguage.It,
                "ja" => GoogleAdsLanguage.Ja,
                "lt" => GoogleAdsLanguage.Lt,
                "lv" => GoogleAdsLanguage.Lv,
                "nl" => GoogleAdsLanguage.Nl,
                "pl" => GoogleAdsLanguage.Pl,
                "pt-br" => GoogleAdsLanguage.PtBr,
                "pt-pt" => GoogleAdsLanguage.PtPt,
                "ro" => GoogleAdsLanguage.Ro,
                "ru" => GoogleAdsLanguage.Ru,
                "sk" => GoogleAdsLanguage.Sk,
                "sl" => GoogleAdsLanguage.Sl,
                "sv" => GoogleAdsLanguage.Sv,
                "zh" => GoogleAdsLanguage.Zh,
                _ => null,
            };
        }
    }
}