
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToneChangerLanguage
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
    public static class ToneChangerLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToneChangerLanguage value)
        {
            return value switch
            {
                ToneChangerLanguage.Bg => "bg",
                ToneChangerLanguage.Cs => "cs",
                ToneChangerLanguage.Da => "da",
                ToneChangerLanguage.De => "de",
                ToneChangerLanguage.El => "el",
                ToneChangerLanguage.En => "en",
                ToneChangerLanguage.Es => "es",
                ToneChangerLanguage.Et => "et",
                ToneChangerLanguage.Fi => "fi",
                ToneChangerLanguage.Fr => "fr",
                ToneChangerLanguage.Hu => "hu",
                ToneChangerLanguage.It => "it",
                ToneChangerLanguage.Ja => "ja",
                ToneChangerLanguage.Lt => "lt",
                ToneChangerLanguage.Lv => "lv",
                ToneChangerLanguage.Nl => "nl",
                ToneChangerLanguage.Pl => "pl",
                ToneChangerLanguage.PtBr => "pt-br",
                ToneChangerLanguage.PtPt => "pt-pt",
                ToneChangerLanguage.Ro => "ro",
                ToneChangerLanguage.Ru => "ru",
                ToneChangerLanguage.Sk => "sk",
                ToneChangerLanguage.Sl => "sl",
                ToneChangerLanguage.Sv => "sv",
                ToneChangerLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToneChangerLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ToneChangerLanguage.Bg,
                "cs" => ToneChangerLanguage.Cs,
                "da" => ToneChangerLanguage.Da,
                "de" => ToneChangerLanguage.De,
                "el" => ToneChangerLanguage.El,
                "en" => ToneChangerLanguage.En,
                "es" => ToneChangerLanguage.Es,
                "et" => ToneChangerLanguage.Et,
                "fi" => ToneChangerLanguage.Fi,
                "fr" => ToneChangerLanguage.Fr,
                "hu" => ToneChangerLanguage.Hu,
                "it" => ToneChangerLanguage.It,
                "ja" => ToneChangerLanguage.Ja,
                "lt" => ToneChangerLanguage.Lt,
                "lv" => ToneChangerLanguage.Lv,
                "nl" => ToneChangerLanguage.Nl,
                "pl" => ToneChangerLanguage.Pl,
                "pt-br" => ToneChangerLanguage.PtBr,
                "pt-pt" => ToneChangerLanguage.PtPt,
                "ro" => ToneChangerLanguage.Ro,
                "ru" => ToneChangerLanguage.Ru,
                "sk" => ToneChangerLanguage.Sk,
                "sl" => ToneChangerLanguage.Sl,
                "sv" => ToneChangerLanguage.Sv,
                "zh" => ToneChangerLanguage.Zh,
                _ => null,
            };
        }
    }
}