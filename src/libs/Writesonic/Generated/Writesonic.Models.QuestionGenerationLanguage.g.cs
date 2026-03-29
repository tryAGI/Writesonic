
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum QuestionGenerationLanguage
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
    public static class QuestionGenerationLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuestionGenerationLanguage value)
        {
            return value switch
            {
                QuestionGenerationLanguage.Bg => "bg",
                QuestionGenerationLanguage.Cs => "cs",
                QuestionGenerationLanguage.Da => "da",
                QuestionGenerationLanguage.De => "de",
                QuestionGenerationLanguage.El => "el",
                QuestionGenerationLanguage.En => "en",
                QuestionGenerationLanguage.Es => "es",
                QuestionGenerationLanguage.Et => "et",
                QuestionGenerationLanguage.Fi => "fi",
                QuestionGenerationLanguage.Fr => "fr",
                QuestionGenerationLanguage.Hu => "hu",
                QuestionGenerationLanguage.It => "it",
                QuestionGenerationLanguage.Ja => "ja",
                QuestionGenerationLanguage.Lt => "lt",
                QuestionGenerationLanguage.Lv => "lv",
                QuestionGenerationLanguage.Nl => "nl",
                QuestionGenerationLanguage.Pl => "pl",
                QuestionGenerationLanguage.PtBr => "pt-br",
                QuestionGenerationLanguage.PtPt => "pt-pt",
                QuestionGenerationLanguage.Ro => "ro",
                QuestionGenerationLanguage.Ru => "ru",
                QuestionGenerationLanguage.Sk => "sk",
                QuestionGenerationLanguage.Sl => "sl",
                QuestionGenerationLanguage.Sv => "sv",
                QuestionGenerationLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuestionGenerationLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => QuestionGenerationLanguage.Bg,
                "cs" => QuestionGenerationLanguage.Cs,
                "da" => QuestionGenerationLanguage.Da,
                "de" => QuestionGenerationLanguage.De,
                "el" => QuestionGenerationLanguage.El,
                "en" => QuestionGenerationLanguage.En,
                "es" => QuestionGenerationLanguage.Es,
                "et" => QuestionGenerationLanguage.Et,
                "fi" => QuestionGenerationLanguage.Fi,
                "fr" => QuestionGenerationLanguage.Fr,
                "hu" => QuestionGenerationLanguage.Hu,
                "it" => QuestionGenerationLanguage.It,
                "ja" => QuestionGenerationLanguage.Ja,
                "lt" => QuestionGenerationLanguage.Lt,
                "lv" => QuestionGenerationLanguage.Lv,
                "nl" => QuestionGenerationLanguage.Nl,
                "pl" => QuestionGenerationLanguage.Pl,
                "pt-br" => QuestionGenerationLanguage.PtBr,
                "pt-pt" => QuestionGenerationLanguage.PtPt,
                "ro" => QuestionGenerationLanguage.Ro,
                "ru" => QuestionGenerationLanguage.Ru,
                "sk" => QuestionGenerationLanguage.Sk,
                "sl" => QuestionGenerationLanguage.Sl,
                "sv" => QuestionGenerationLanguage.Sv,
                "zh" => QuestionGenerationLanguage.Zh,
                _ => null,
            };
        }
    }
}