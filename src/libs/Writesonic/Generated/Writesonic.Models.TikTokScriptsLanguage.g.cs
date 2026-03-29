
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TikTokScriptsLanguage
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
    public static class TikTokScriptsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TikTokScriptsLanguage value)
        {
            return value switch
            {
                TikTokScriptsLanguage.Bg => "bg",
                TikTokScriptsLanguage.Cs => "cs",
                TikTokScriptsLanguage.Da => "da",
                TikTokScriptsLanguage.De => "de",
                TikTokScriptsLanguage.El => "el",
                TikTokScriptsLanguage.En => "en",
                TikTokScriptsLanguage.Es => "es",
                TikTokScriptsLanguage.Et => "et",
                TikTokScriptsLanguage.Fi => "fi",
                TikTokScriptsLanguage.Fr => "fr",
                TikTokScriptsLanguage.Hu => "hu",
                TikTokScriptsLanguage.It => "it",
                TikTokScriptsLanguage.Ja => "ja",
                TikTokScriptsLanguage.Lt => "lt",
                TikTokScriptsLanguage.Lv => "lv",
                TikTokScriptsLanguage.Nl => "nl",
                TikTokScriptsLanguage.Pl => "pl",
                TikTokScriptsLanguage.PtBr => "pt-br",
                TikTokScriptsLanguage.PtPt => "pt-pt",
                TikTokScriptsLanguage.Ro => "ro",
                TikTokScriptsLanguage.Ru => "ru",
                TikTokScriptsLanguage.Sk => "sk",
                TikTokScriptsLanguage.Sl => "sl",
                TikTokScriptsLanguage.Sv => "sv",
                TikTokScriptsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TikTokScriptsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => TikTokScriptsLanguage.Bg,
                "cs" => TikTokScriptsLanguage.Cs,
                "da" => TikTokScriptsLanguage.Da,
                "de" => TikTokScriptsLanguage.De,
                "el" => TikTokScriptsLanguage.El,
                "en" => TikTokScriptsLanguage.En,
                "es" => TikTokScriptsLanguage.Es,
                "et" => TikTokScriptsLanguage.Et,
                "fi" => TikTokScriptsLanguage.Fi,
                "fr" => TikTokScriptsLanguage.Fr,
                "hu" => TikTokScriptsLanguage.Hu,
                "it" => TikTokScriptsLanguage.It,
                "ja" => TikTokScriptsLanguage.Ja,
                "lt" => TikTokScriptsLanguage.Lt,
                "lv" => TikTokScriptsLanguage.Lv,
                "nl" => TikTokScriptsLanguage.Nl,
                "pl" => TikTokScriptsLanguage.Pl,
                "pt-br" => TikTokScriptsLanguage.PtBr,
                "pt-pt" => TikTokScriptsLanguage.PtPt,
                "ro" => TikTokScriptsLanguage.Ro,
                "ru" => TikTokScriptsLanguage.Ru,
                "sk" => TikTokScriptsLanguage.Sk,
                "sl" => TikTokScriptsLanguage.Sl,
                "sv" => TikTokScriptsLanguage.Sv,
                "zh" => TikTokScriptsLanguage.Zh,
                _ => null,
            };
        }
    }
}