
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogIdeasLanguage
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
    public static class BlogIdeasLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogIdeasLanguage value)
        {
            return value switch
            {
                BlogIdeasLanguage.Bg => "bg",
                BlogIdeasLanguage.Cs => "cs",
                BlogIdeasLanguage.Da => "da",
                BlogIdeasLanguage.De => "de",
                BlogIdeasLanguage.El => "el",
                BlogIdeasLanguage.En => "en",
                BlogIdeasLanguage.Es => "es",
                BlogIdeasLanguage.Et => "et",
                BlogIdeasLanguage.Fi => "fi",
                BlogIdeasLanguage.Fr => "fr",
                BlogIdeasLanguage.Hu => "hu",
                BlogIdeasLanguage.It => "it",
                BlogIdeasLanguage.Ja => "ja",
                BlogIdeasLanguage.Lt => "lt",
                BlogIdeasLanguage.Lv => "lv",
                BlogIdeasLanguage.Nl => "nl",
                BlogIdeasLanguage.Pl => "pl",
                BlogIdeasLanguage.PtBr => "pt-br",
                BlogIdeasLanguage.PtPt => "pt-pt",
                BlogIdeasLanguage.Ro => "ro",
                BlogIdeasLanguage.Ru => "ru",
                BlogIdeasLanguage.Sk => "sk",
                BlogIdeasLanguage.Sl => "sl",
                BlogIdeasLanguage.Sv => "sv",
                BlogIdeasLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogIdeasLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => BlogIdeasLanguage.Bg,
                "cs" => BlogIdeasLanguage.Cs,
                "da" => BlogIdeasLanguage.Da,
                "de" => BlogIdeasLanguage.De,
                "el" => BlogIdeasLanguage.El,
                "en" => BlogIdeasLanguage.En,
                "es" => BlogIdeasLanguage.Es,
                "et" => BlogIdeasLanguage.Et,
                "fi" => BlogIdeasLanguage.Fi,
                "fr" => BlogIdeasLanguage.Fr,
                "hu" => BlogIdeasLanguage.Hu,
                "it" => BlogIdeasLanguage.It,
                "ja" => BlogIdeasLanguage.Ja,
                "lt" => BlogIdeasLanguage.Lt,
                "lv" => BlogIdeasLanguage.Lv,
                "nl" => BlogIdeasLanguage.Nl,
                "pl" => BlogIdeasLanguage.Pl,
                "pt-br" => BlogIdeasLanguage.PtBr,
                "pt-pt" => BlogIdeasLanguage.PtPt,
                "ro" => BlogIdeasLanguage.Ro,
                "ru" => BlogIdeasLanguage.Ru,
                "sk" => BlogIdeasLanguage.Sk,
                "sl" => BlogIdeasLanguage.Sl,
                "sv" => BlogIdeasLanguage.Sv,
                "zh" => BlogIdeasLanguage.Zh,
                _ => null,
            };
        }
    }
}