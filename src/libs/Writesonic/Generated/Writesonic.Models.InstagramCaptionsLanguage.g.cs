
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstagramCaptionsLanguage
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
    public static class InstagramCaptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstagramCaptionsLanguage value)
        {
            return value switch
            {
                InstagramCaptionsLanguage.Bg => "bg",
                InstagramCaptionsLanguage.Cs => "cs",
                InstagramCaptionsLanguage.Da => "da",
                InstagramCaptionsLanguage.De => "de",
                InstagramCaptionsLanguage.El => "el",
                InstagramCaptionsLanguage.En => "en",
                InstagramCaptionsLanguage.Es => "es",
                InstagramCaptionsLanguage.Et => "et",
                InstagramCaptionsLanguage.Fi => "fi",
                InstagramCaptionsLanguage.Fr => "fr",
                InstagramCaptionsLanguage.Hu => "hu",
                InstagramCaptionsLanguage.It => "it",
                InstagramCaptionsLanguage.Ja => "ja",
                InstagramCaptionsLanguage.Lt => "lt",
                InstagramCaptionsLanguage.Lv => "lv",
                InstagramCaptionsLanguage.Nl => "nl",
                InstagramCaptionsLanguage.Pl => "pl",
                InstagramCaptionsLanguage.PtBr => "pt-br",
                InstagramCaptionsLanguage.PtPt => "pt-pt",
                InstagramCaptionsLanguage.Ro => "ro",
                InstagramCaptionsLanguage.Ru => "ru",
                InstagramCaptionsLanguage.Sk => "sk",
                InstagramCaptionsLanguage.Sl => "sl",
                InstagramCaptionsLanguage.Sv => "sv",
                InstagramCaptionsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstagramCaptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => InstagramCaptionsLanguage.Bg,
                "cs" => InstagramCaptionsLanguage.Cs,
                "da" => InstagramCaptionsLanguage.Da,
                "de" => InstagramCaptionsLanguage.De,
                "el" => InstagramCaptionsLanguage.El,
                "en" => InstagramCaptionsLanguage.En,
                "es" => InstagramCaptionsLanguage.Es,
                "et" => InstagramCaptionsLanguage.Et,
                "fi" => InstagramCaptionsLanguage.Fi,
                "fr" => InstagramCaptionsLanguage.Fr,
                "hu" => InstagramCaptionsLanguage.Hu,
                "it" => InstagramCaptionsLanguage.It,
                "ja" => InstagramCaptionsLanguage.Ja,
                "lt" => InstagramCaptionsLanguage.Lt,
                "lv" => InstagramCaptionsLanguage.Lv,
                "nl" => InstagramCaptionsLanguage.Nl,
                "pl" => InstagramCaptionsLanguage.Pl,
                "pt-br" => InstagramCaptionsLanguage.PtBr,
                "pt-pt" => InstagramCaptionsLanguage.PtPt,
                "ro" => InstagramCaptionsLanguage.Ro,
                "ru" => InstagramCaptionsLanguage.Ru,
                "sk" => InstagramCaptionsLanguage.Sk,
                "sl" => InstagramCaptionsLanguage.Sl,
                "sv" => InstagramCaptionsLanguage.Sv,
                "zh" => InstagramCaptionsLanguage.Zh,
                _ => null,
            };
        }
    }
}