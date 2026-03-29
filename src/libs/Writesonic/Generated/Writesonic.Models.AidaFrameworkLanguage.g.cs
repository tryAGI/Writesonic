
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum AidaFrameworkLanguage
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
    public static class AidaFrameworkLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AidaFrameworkLanguage value)
        {
            return value switch
            {
                AidaFrameworkLanguage.Bg => "bg",
                AidaFrameworkLanguage.Cs => "cs",
                AidaFrameworkLanguage.Da => "da",
                AidaFrameworkLanguage.De => "de",
                AidaFrameworkLanguage.El => "el",
                AidaFrameworkLanguage.En => "en",
                AidaFrameworkLanguage.Es => "es",
                AidaFrameworkLanguage.Et => "et",
                AidaFrameworkLanguage.Fi => "fi",
                AidaFrameworkLanguage.Fr => "fr",
                AidaFrameworkLanguage.Hu => "hu",
                AidaFrameworkLanguage.It => "it",
                AidaFrameworkLanguage.Ja => "ja",
                AidaFrameworkLanguage.Lt => "lt",
                AidaFrameworkLanguage.Lv => "lv",
                AidaFrameworkLanguage.Nl => "nl",
                AidaFrameworkLanguage.Pl => "pl",
                AidaFrameworkLanguage.PtBr => "pt-br",
                AidaFrameworkLanguage.PtPt => "pt-pt",
                AidaFrameworkLanguage.Ro => "ro",
                AidaFrameworkLanguage.Ru => "ru",
                AidaFrameworkLanguage.Sk => "sk",
                AidaFrameworkLanguage.Sl => "sl",
                AidaFrameworkLanguage.Sv => "sv",
                AidaFrameworkLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AidaFrameworkLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => AidaFrameworkLanguage.Bg,
                "cs" => AidaFrameworkLanguage.Cs,
                "da" => AidaFrameworkLanguage.Da,
                "de" => AidaFrameworkLanguage.De,
                "el" => AidaFrameworkLanguage.El,
                "en" => AidaFrameworkLanguage.En,
                "es" => AidaFrameworkLanguage.Es,
                "et" => AidaFrameworkLanguage.Et,
                "fi" => AidaFrameworkLanguage.Fi,
                "fr" => AidaFrameworkLanguage.Fr,
                "hu" => AidaFrameworkLanguage.Hu,
                "it" => AidaFrameworkLanguage.It,
                "ja" => AidaFrameworkLanguage.Ja,
                "lt" => AidaFrameworkLanguage.Lt,
                "lv" => AidaFrameworkLanguage.Lv,
                "nl" => AidaFrameworkLanguage.Nl,
                "pl" => AidaFrameworkLanguage.Pl,
                "pt-br" => AidaFrameworkLanguage.PtBr,
                "pt-pt" => AidaFrameworkLanguage.PtPt,
                "ro" => AidaFrameworkLanguage.Ro,
                "ru" => AidaFrameworkLanguage.Ru,
                "sk" => AidaFrameworkLanguage.Sk,
                "sl" => AidaFrameworkLanguage.Sl,
                "sv" => AidaFrameworkLanguage.Sv,
                "zh" => AidaFrameworkLanguage.Zh,
                _ => null,
            };
        }
    }
}