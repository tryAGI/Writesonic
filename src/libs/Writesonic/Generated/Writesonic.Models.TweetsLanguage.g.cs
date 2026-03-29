
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TweetsLanguage
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
    public static class TweetsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TweetsLanguage value)
        {
            return value switch
            {
                TweetsLanguage.Bg => "bg",
                TweetsLanguage.Cs => "cs",
                TweetsLanguage.Da => "da",
                TweetsLanguage.De => "de",
                TweetsLanguage.El => "el",
                TweetsLanguage.En => "en",
                TweetsLanguage.Es => "es",
                TweetsLanguage.Et => "et",
                TweetsLanguage.Fi => "fi",
                TweetsLanguage.Fr => "fr",
                TweetsLanguage.Hu => "hu",
                TweetsLanguage.It => "it",
                TweetsLanguage.Ja => "ja",
                TweetsLanguage.Lt => "lt",
                TweetsLanguage.Lv => "lv",
                TweetsLanguage.Nl => "nl",
                TweetsLanguage.Pl => "pl",
                TweetsLanguage.PtBr => "pt-br",
                TweetsLanguage.PtPt => "pt-pt",
                TweetsLanguage.Ro => "ro",
                TweetsLanguage.Ru => "ru",
                TweetsLanguage.Sk => "sk",
                TweetsLanguage.Sl => "sl",
                TweetsLanguage.Sv => "sv",
                TweetsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TweetsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => TweetsLanguage.Bg,
                "cs" => TweetsLanguage.Cs,
                "da" => TweetsLanguage.Da,
                "de" => TweetsLanguage.De,
                "el" => TweetsLanguage.El,
                "en" => TweetsLanguage.En,
                "es" => TweetsLanguage.Es,
                "et" => TweetsLanguage.Et,
                "fi" => TweetsLanguage.Fi,
                "fr" => TweetsLanguage.Fr,
                "hu" => TweetsLanguage.Hu,
                "it" => TweetsLanguage.It,
                "ja" => TweetsLanguage.Ja,
                "lt" => TweetsLanguage.Lt,
                "lv" => TweetsLanguage.Lv,
                "nl" => TweetsLanguage.Nl,
                "pl" => TweetsLanguage.Pl,
                "pt-br" => TweetsLanguage.PtBr,
                "pt-pt" => TweetsLanguage.PtPt,
                "ro" => TweetsLanguage.Ro,
                "ru" => TweetsLanguage.Ru,
                "sk" => TweetsLanguage.Sk,
                "sl" => TweetsLanguage.Sl,
                "sv" => TweetsLanguage.Sv,
                "zh" => TweetsLanguage.Zh,
                _ => null,
            };
        }
    }
}