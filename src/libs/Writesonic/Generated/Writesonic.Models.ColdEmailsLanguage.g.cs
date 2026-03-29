
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColdEmailsLanguage
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
    public static class ColdEmailsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColdEmailsLanguage value)
        {
            return value switch
            {
                ColdEmailsLanguage.Bg => "bg",
                ColdEmailsLanguage.Cs => "cs",
                ColdEmailsLanguage.Da => "da",
                ColdEmailsLanguage.De => "de",
                ColdEmailsLanguage.El => "el",
                ColdEmailsLanguage.En => "en",
                ColdEmailsLanguage.Es => "es",
                ColdEmailsLanguage.Et => "et",
                ColdEmailsLanguage.Fi => "fi",
                ColdEmailsLanguage.Fr => "fr",
                ColdEmailsLanguage.Hu => "hu",
                ColdEmailsLanguage.It => "it",
                ColdEmailsLanguage.Ja => "ja",
                ColdEmailsLanguage.Lt => "lt",
                ColdEmailsLanguage.Lv => "lv",
                ColdEmailsLanguage.Nl => "nl",
                ColdEmailsLanguage.Pl => "pl",
                ColdEmailsLanguage.PtBr => "pt-br",
                ColdEmailsLanguage.PtPt => "pt-pt",
                ColdEmailsLanguage.Ro => "ro",
                ColdEmailsLanguage.Ru => "ru",
                ColdEmailsLanguage.Sk => "sk",
                ColdEmailsLanguage.Sl => "sl",
                ColdEmailsLanguage.Sv => "sv",
                ColdEmailsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColdEmailsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ColdEmailsLanguage.Bg,
                "cs" => ColdEmailsLanguage.Cs,
                "da" => ColdEmailsLanguage.Da,
                "de" => ColdEmailsLanguage.De,
                "el" => ColdEmailsLanguage.El,
                "en" => ColdEmailsLanguage.En,
                "es" => ColdEmailsLanguage.Es,
                "et" => ColdEmailsLanguage.Et,
                "fi" => ColdEmailsLanguage.Fi,
                "fr" => ColdEmailsLanguage.Fr,
                "hu" => ColdEmailsLanguage.Hu,
                "it" => ColdEmailsLanguage.It,
                "ja" => ColdEmailsLanguage.Ja,
                "lt" => ColdEmailsLanguage.Lt,
                "lv" => ColdEmailsLanguage.Lv,
                "nl" => ColdEmailsLanguage.Nl,
                "pl" => ColdEmailsLanguage.Pl,
                "pt-br" => ColdEmailsLanguage.PtBr,
                "pt-pt" => ColdEmailsLanguage.PtPt,
                "ro" => ColdEmailsLanguage.Ro,
                "ru" => ColdEmailsLanguage.Ru,
                "sk" => ColdEmailsLanguage.Sk,
                "sl" => ColdEmailsLanguage.Sl,
                "sv" => ColdEmailsLanguage.Sv,
                "zh" => ColdEmailsLanguage.Zh,
                _ => null,
            };
        }
    }
}