
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogIntrosLanguage
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
    public static class BlogIntrosLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogIntrosLanguage value)
        {
            return value switch
            {
                BlogIntrosLanguage.Bg => "bg",
                BlogIntrosLanguage.Cs => "cs",
                BlogIntrosLanguage.Da => "da",
                BlogIntrosLanguage.De => "de",
                BlogIntrosLanguage.El => "el",
                BlogIntrosLanguage.En => "en",
                BlogIntrosLanguage.Es => "es",
                BlogIntrosLanguage.Et => "et",
                BlogIntrosLanguage.Fi => "fi",
                BlogIntrosLanguage.Fr => "fr",
                BlogIntrosLanguage.Hu => "hu",
                BlogIntrosLanguage.It => "it",
                BlogIntrosLanguage.Ja => "ja",
                BlogIntrosLanguage.Lt => "lt",
                BlogIntrosLanguage.Lv => "lv",
                BlogIntrosLanguage.Nl => "nl",
                BlogIntrosLanguage.Pl => "pl",
                BlogIntrosLanguage.PtBr => "pt-br",
                BlogIntrosLanguage.PtPt => "pt-pt",
                BlogIntrosLanguage.Ro => "ro",
                BlogIntrosLanguage.Ru => "ru",
                BlogIntrosLanguage.Sk => "sk",
                BlogIntrosLanguage.Sl => "sl",
                BlogIntrosLanguage.Sv => "sv",
                BlogIntrosLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogIntrosLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => BlogIntrosLanguage.Bg,
                "cs" => BlogIntrosLanguage.Cs,
                "da" => BlogIntrosLanguage.Da,
                "de" => BlogIntrosLanguage.De,
                "el" => BlogIntrosLanguage.El,
                "en" => BlogIntrosLanguage.En,
                "es" => BlogIntrosLanguage.Es,
                "et" => BlogIntrosLanguage.Et,
                "fi" => BlogIntrosLanguage.Fi,
                "fr" => BlogIntrosLanguage.Fr,
                "hu" => BlogIntrosLanguage.Hu,
                "it" => BlogIntrosLanguage.It,
                "ja" => BlogIntrosLanguage.Ja,
                "lt" => BlogIntrosLanguage.Lt,
                "lv" => BlogIntrosLanguage.Lv,
                "nl" => BlogIntrosLanguage.Nl,
                "pl" => BlogIntrosLanguage.Pl,
                "pt-br" => BlogIntrosLanguage.PtBr,
                "pt-pt" => BlogIntrosLanguage.PtPt,
                "ro" => BlogIntrosLanguage.Ro,
                "ru" => BlogIntrosLanguage.Ru,
                "sk" => BlogIntrosLanguage.Sk,
                "sl" => BlogIntrosLanguage.Sl,
                "sv" => BlogIntrosLanguage.Sv,
                "zh" => BlogIntrosLanguage.Zh,
                _ => null,
            };
        }
    }
}