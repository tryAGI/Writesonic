
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentRephraseLanguage
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
    public static class ContentRephraseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentRephraseLanguage value)
        {
            return value switch
            {
                ContentRephraseLanguage.Bg => "bg",
                ContentRephraseLanguage.Cs => "cs",
                ContentRephraseLanguage.Da => "da",
                ContentRephraseLanguage.De => "de",
                ContentRephraseLanguage.El => "el",
                ContentRephraseLanguage.En => "en",
                ContentRephraseLanguage.Es => "es",
                ContentRephraseLanguage.Et => "et",
                ContentRephraseLanguage.Fi => "fi",
                ContentRephraseLanguage.Fr => "fr",
                ContentRephraseLanguage.Hu => "hu",
                ContentRephraseLanguage.It => "it",
                ContentRephraseLanguage.Ja => "ja",
                ContentRephraseLanguage.Lt => "lt",
                ContentRephraseLanguage.Lv => "lv",
                ContentRephraseLanguage.Nl => "nl",
                ContentRephraseLanguage.Pl => "pl",
                ContentRephraseLanguage.PtBr => "pt-br",
                ContentRephraseLanguage.PtPt => "pt-pt",
                ContentRephraseLanguage.Ro => "ro",
                ContentRephraseLanguage.Ru => "ru",
                ContentRephraseLanguage.Sk => "sk",
                ContentRephraseLanguage.Sl => "sl",
                ContentRephraseLanguage.Sv => "sv",
                ContentRephraseLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentRephraseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ContentRephraseLanguage.Bg,
                "cs" => ContentRephraseLanguage.Cs,
                "da" => ContentRephraseLanguage.Da,
                "de" => ContentRephraseLanguage.De,
                "el" => ContentRephraseLanguage.El,
                "en" => ContentRephraseLanguage.En,
                "es" => ContentRephraseLanguage.Es,
                "et" => ContentRephraseLanguage.Et,
                "fi" => ContentRephraseLanguage.Fi,
                "fr" => ContentRephraseLanguage.Fr,
                "hu" => ContentRephraseLanguage.Hu,
                "it" => ContentRephraseLanguage.It,
                "ja" => ContentRephraseLanguage.Ja,
                "lt" => ContentRephraseLanguage.Lt,
                "lv" => ContentRephraseLanguage.Lv,
                "nl" => ContentRephraseLanguage.Nl,
                "pl" => ContentRephraseLanguage.Pl,
                "pt-br" => ContentRephraseLanguage.PtBr,
                "pt-pt" => ContentRephraseLanguage.PtPt,
                "ro" => ContentRephraseLanguage.Ro,
                "ru" => ContentRephraseLanguage.Ru,
                "sk" => ContentRephraseLanguage.Sk,
                "sl" => ContentRephraseLanguage.Sl,
                "sv" => ContentRephraseLanguage.Sv,
                "zh" => ContentRephraseLanguage.Zh,
                _ => null,
            };
        }
    }
}