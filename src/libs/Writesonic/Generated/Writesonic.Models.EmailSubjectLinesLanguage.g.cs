
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmailSubjectLinesLanguage
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
    public static class EmailSubjectLinesLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailSubjectLinesLanguage value)
        {
            return value switch
            {
                EmailSubjectLinesLanguage.Bg => "bg",
                EmailSubjectLinesLanguage.Cs => "cs",
                EmailSubjectLinesLanguage.Da => "da",
                EmailSubjectLinesLanguage.De => "de",
                EmailSubjectLinesLanguage.El => "el",
                EmailSubjectLinesLanguage.En => "en",
                EmailSubjectLinesLanguage.Es => "es",
                EmailSubjectLinesLanguage.Et => "et",
                EmailSubjectLinesLanguage.Fi => "fi",
                EmailSubjectLinesLanguage.Fr => "fr",
                EmailSubjectLinesLanguage.Hu => "hu",
                EmailSubjectLinesLanguage.It => "it",
                EmailSubjectLinesLanguage.Ja => "ja",
                EmailSubjectLinesLanguage.Lt => "lt",
                EmailSubjectLinesLanguage.Lv => "lv",
                EmailSubjectLinesLanguage.Nl => "nl",
                EmailSubjectLinesLanguage.Pl => "pl",
                EmailSubjectLinesLanguage.PtBr => "pt-br",
                EmailSubjectLinesLanguage.PtPt => "pt-pt",
                EmailSubjectLinesLanguage.Ro => "ro",
                EmailSubjectLinesLanguage.Ru => "ru",
                EmailSubjectLinesLanguage.Sk => "sk",
                EmailSubjectLinesLanguage.Sl => "sl",
                EmailSubjectLinesLanguage.Sv => "sv",
                EmailSubjectLinesLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailSubjectLinesLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => EmailSubjectLinesLanguage.Bg,
                "cs" => EmailSubjectLinesLanguage.Cs,
                "da" => EmailSubjectLinesLanguage.Da,
                "de" => EmailSubjectLinesLanguage.De,
                "el" => EmailSubjectLinesLanguage.El,
                "en" => EmailSubjectLinesLanguage.En,
                "es" => EmailSubjectLinesLanguage.Es,
                "et" => EmailSubjectLinesLanguage.Et,
                "fi" => EmailSubjectLinesLanguage.Fi,
                "fr" => EmailSubjectLinesLanguage.Fr,
                "hu" => EmailSubjectLinesLanguage.Hu,
                "it" => EmailSubjectLinesLanguage.It,
                "ja" => EmailSubjectLinesLanguage.Ja,
                "lt" => EmailSubjectLinesLanguage.Lt,
                "lv" => EmailSubjectLinesLanguage.Lv,
                "nl" => EmailSubjectLinesLanguage.Nl,
                "pl" => EmailSubjectLinesLanguage.Pl,
                "pt-br" => EmailSubjectLinesLanguage.PtBr,
                "pt-pt" => EmailSubjectLinesLanguage.PtPt,
                "ro" => EmailSubjectLinesLanguage.Ro,
                "ru" => EmailSubjectLinesLanguage.Ru,
                "sk" => EmailSubjectLinesLanguage.Sk,
                "sl" => EmailSubjectLinesLanguage.Sl,
                "sv" => EmailSubjectLinesLanguage.Sv,
                "zh" => EmailSubjectLinesLanguage.Zh,
                _ => null,
            };
        }
    }
}