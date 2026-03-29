
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum FacebookAdsLanguage
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
    public static class FacebookAdsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FacebookAdsLanguage value)
        {
            return value switch
            {
                FacebookAdsLanguage.Bg => "bg",
                FacebookAdsLanguage.Cs => "cs",
                FacebookAdsLanguage.Da => "da",
                FacebookAdsLanguage.De => "de",
                FacebookAdsLanguage.El => "el",
                FacebookAdsLanguage.En => "en",
                FacebookAdsLanguage.Es => "es",
                FacebookAdsLanguage.Et => "et",
                FacebookAdsLanguage.Fi => "fi",
                FacebookAdsLanguage.Fr => "fr",
                FacebookAdsLanguage.Hu => "hu",
                FacebookAdsLanguage.It => "it",
                FacebookAdsLanguage.Ja => "ja",
                FacebookAdsLanguage.Lt => "lt",
                FacebookAdsLanguage.Lv => "lv",
                FacebookAdsLanguage.Nl => "nl",
                FacebookAdsLanguage.Pl => "pl",
                FacebookAdsLanguage.PtBr => "pt-br",
                FacebookAdsLanguage.PtPt => "pt-pt",
                FacebookAdsLanguage.Ro => "ro",
                FacebookAdsLanguage.Ru => "ru",
                FacebookAdsLanguage.Sk => "sk",
                FacebookAdsLanguage.Sl => "sl",
                FacebookAdsLanguage.Sv => "sv",
                FacebookAdsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FacebookAdsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => FacebookAdsLanguage.Bg,
                "cs" => FacebookAdsLanguage.Cs,
                "da" => FacebookAdsLanguage.Da,
                "de" => FacebookAdsLanguage.De,
                "el" => FacebookAdsLanguage.El,
                "en" => FacebookAdsLanguage.En,
                "es" => FacebookAdsLanguage.Es,
                "et" => FacebookAdsLanguage.Et,
                "fi" => FacebookAdsLanguage.Fi,
                "fr" => FacebookAdsLanguage.Fr,
                "hu" => FacebookAdsLanguage.Hu,
                "it" => FacebookAdsLanguage.It,
                "ja" => FacebookAdsLanguage.Ja,
                "lt" => FacebookAdsLanguage.Lt,
                "lv" => FacebookAdsLanguage.Lv,
                "nl" => FacebookAdsLanguage.Nl,
                "pl" => FacebookAdsLanguage.Pl,
                "pt-br" => FacebookAdsLanguage.PtBr,
                "pt-pt" => FacebookAdsLanguage.PtPt,
                "ro" => FacebookAdsLanguage.Ro,
                "ru" => FacebookAdsLanguage.Ru,
                "sk" => FacebookAdsLanguage.Sk,
                "sl" => FacebookAdsLanguage.Sl,
                "sv" => FacebookAdsLanguage.Sv,
                "zh" => FacebookAdsLanguage.Zh,
                _ => null,
            };
        }
    }
}