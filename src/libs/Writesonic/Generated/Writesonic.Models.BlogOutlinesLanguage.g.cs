
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogOutlinesLanguage
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
    public static class BlogOutlinesLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogOutlinesLanguage value)
        {
            return value switch
            {
                BlogOutlinesLanguage.Bg => "bg",
                BlogOutlinesLanguage.Cs => "cs",
                BlogOutlinesLanguage.Da => "da",
                BlogOutlinesLanguage.De => "de",
                BlogOutlinesLanguage.El => "el",
                BlogOutlinesLanguage.En => "en",
                BlogOutlinesLanguage.Es => "es",
                BlogOutlinesLanguage.Et => "et",
                BlogOutlinesLanguage.Fi => "fi",
                BlogOutlinesLanguage.Fr => "fr",
                BlogOutlinesLanguage.Hu => "hu",
                BlogOutlinesLanguage.It => "it",
                BlogOutlinesLanguage.Ja => "ja",
                BlogOutlinesLanguage.Lt => "lt",
                BlogOutlinesLanguage.Lv => "lv",
                BlogOutlinesLanguage.Nl => "nl",
                BlogOutlinesLanguage.Pl => "pl",
                BlogOutlinesLanguage.PtBr => "pt-br",
                BlogOutlinesLanguage.PtPt => "pt-pt",
                BlogOutlinesLanguage.Ro => "ro",
                BlogOutlinesLanguage.Ru => "ru",
                BlogOutlinesLanguage.Sk => "sk",
                BlogOutlinesLanguage.Sl => "sl",
                BlogOutlinesLanguage.Sv => "sv",
                BlogOutlinesLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogOutlinesLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => BlogOutlinesLanguage.Bg,
                "cs" => BlogOutlinesLanguage.Cs,
                "da" => BlogOutlinesLanguage.Da,
                "de" => BlogOutlinesLanguage.De,
                "el" => BlogOutlinesLanguage.El,
                "en" => BlogOutlinesLanguage.En,
                "es" => BlogOutlinesLanguage.Es,
                "et" => BlogOutlinesLanguage.Et,
                "fi" => BlogOutlinesLanguage.Fi,
                "fr" => BlogOutlinesLanguage.Fr,
                "hu" => BlogOutlinesLanguage.Hu,
                "it" => BlogOutlinesLanguage.It,
                "ja" => BlogOutlinesLanguage.Ja,
                "lt" => BlogOutlinesLanguage.Lt,
                "lv" => BlogOutlinesLanguage.Lv,
                "nl" => BlogOutlinesLanguage.Nl,
                "pl" => BlogOutlinesLanguage.Pl,
                "pt-br" => BlogOutlinesLanguage.PtBr,
                "pt-pt" => BlogOutlinesLanguage.PtPt,
                "ro" => BlogOutlinesLanguage.Ro,
                "ru" => BlogOutlinesLanguage.Ru,
                "sk" => BlogOutlinesLanguage.Sk,
                "sl" => BlogOutlinesLanguage.Sl,
                "sv" => BlogOutlinesLanguage.Sv,
                "zh" => BlogOutlinesLanguage.Zh,
                _ => null,
            };
        }
    }
}