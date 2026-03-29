
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentShortenLanguage
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
    public static class ContentShortenLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentShortenLanguage value)
        {
            return value switch
            {
                ContentShortenLanguage.Bg => "bg",
                ContentShortenLanguage.Cs => "cs",
                ContentShortenLanguage.Da => "da",
                ContentShortenLanguage.De => "de",
                ContentShortenLanguage.El => "el",
                ContentShortenLanguage.En => "en",
                ContentShortenLanguage.Es => "es",
                ContentShortenLanguage.Et => "et",
                ContentShortenLanguage.Fi => "fi",
                ContentShortenLanguage.Fr => "fr",
                ContentShortenLanguage.Hu => "hu",
                ContentShortenLanguage.It => "it",
                ContentShortenLanguage.Ja => "ja",
                ContentShortenLanguage.Lt => "lt",
                ContentShortenLanguage.Lv => "lv",
                ContentShortenLanguage.Nl => "nl",
                ContentShortenLanguage.Pl => "pl",
                ContentShortenLanguage.PtBr => "pt-br",
                ContentShortenLanguage.PtPt => "pt-pt",
                ContentShortenLanguage.Ro => "ro",
                ContentShortenLanguage.Ru => "ru",
                ContentShortenLanguage.Sk => "sk",
                ContentShortenLanguage.Sl => "sl",
                ContentShortenLanguage.Sv => "sv",
                ContentShortenLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentShortenLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ContentShortenLanguage.Bg,
                "cs" => ContentShortenLanguage.Cs,
                "da" => ContentShortenLanguage.Da,
                "de" => ContentShortenLanguage.De,
                "el" => ContentShortenLanguage.El,
                "en" => ContentShortenLanguage.En,
                "es" => ContentShortenLanguage.Es,
                "et" => ContentShortenLanguage.Et,
                "fi" => ContentShortenLanguage.Fi,
                "fr" => ContentShortenLanguage.Fr,
                "hu" => ContentShortenLanguage.Hu,
                "it" => ContentShortenLanguage.It,
                "ja" => ContentShortenLanguage.Ja,
                "lt" => ContentShortenLanguage.Lt,
                "lv" => ContentShortenLanguage.Lv,
                "nl" => ContentShortenLanguage.Nl,
                "pl" => ContentShortenLanguage.Pl,
                "pt-br" => ContentShortenLanguage.PtBr,
                "pt-pt" => ContentShortenLanguage.PtPt,
                "ro" => ContentShortenLanguage.Ro,
                "ru" => ContentShortenLanguage.Ru,
                "sk" => ContentShortenLanguage.Sk,
                "sl" => ContentShortenLanguage.Sl,
                "sv" => ContentShortenLanguage.Sv,
                "zh" => ContentShortenLanguage.Zh,
                _ => null,
            };
        }
    }
}