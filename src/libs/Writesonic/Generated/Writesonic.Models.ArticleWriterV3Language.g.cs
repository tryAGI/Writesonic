
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArticleWriterV3Language
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
    public static class ArticleWriterV3LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArticleWriterV3Language value)
        {
            return value switch
            {
                ArticleWriterV3Language.Bg => "bg",
                ArticleWriterV3Language.Cs => "cs",
                ArticleWriterV3Language.Da => "da",
                ArticleWriterV3Language.De => "de",
                ArticleWriterV3Language.El => "el",
                ArticleWriterV3Language.En => "en",
                ArticleWriterV3Language.Es => "es",
                ArticleWriterV3Language.Et => "et",
                ArticleWriterV3Language.Fi => "fi",
                ArticleWriterV3Language.Fr => "fr",
                ArticleWriterV3Language.Hu => "hu",
                ArticleWriterV3Language.It => "it",
                ArticleWriterV3Language.Ja => "ja",
                ArticleWriterV3Language.Lt => "lt",
                ArticleWriterV3Language.Lv => "lv",
                ArticleWriterV3Language.Nl => "nl",
                ArticleWriterV3Language.Pl => "pl",
                ArticleWriterV3Language.PtBr => "pt-br",
                ArticleWriterV3Language.PtPt => "pt-pt",
                ArticleWriterV3Language.Ro => "ro",
                ArticleWriterV3Language.Ru => "ru",
                ArticleWriterV3Language.Sk => "sk",
                ArticleWriterV3Language.Sl => "sl",
                ArticleWriterV3Language.Sv => "sv",
                ArticleWriterV3Language.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArticleWriterV3Language? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ArticleWriterV3Language.Bg,
                "cs" => ArticleWriterV3Language.Cs,
                "da" => ArticleWriterV3Language.Da,
                "de" => ArticleWriterV3Language.De,
                "el" => ArticleWriterV3Language.El,
                "en" => ArticleWriterV3Language.En,
                "es" => ArticleWriterV3Language.Es,
                "et" => ArticleWriterV3Language.Et,
                "fi" => ArticleWriterV3Language.Fi,
                "fr" => ArticleWriterV3Language.Fr,
                "hu" => ArticleWriterV3Language.Hu,
                "it" => ArticleWriterV3Language.It,
                "ja" => ArticleWriterV3Language.Ja,
                "lt" => ArticleWriterV3Language.Lt,
                "lv" => ArticleWriterV3Language.Lv,
                "nl" => ArticleWriterV3Language.Nl,
                "pl" => ArticleWriterV3Language.Pl,
                "pt-br" => ArticleWriterV3Language.PtBr,
                "pt-pt" => ArticleWriterV3Language.PtPt,
                "ro" => ArticleWriterV3Language.Ro,
                "ru" => ArticleWriterV3Language.Ru,
                "sk" => ArticleWriterV3Language.Sk,
                "sl" => ArticleWriterV3Language.Sl,
                "sv" => ArticleWriterV3Language.Sv,
                "zh" => ArticleWriterV3Language.Zh,
                _ => null,
            };
        }
    }
}