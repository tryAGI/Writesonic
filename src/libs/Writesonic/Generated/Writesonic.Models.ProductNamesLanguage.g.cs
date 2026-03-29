
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProductNamesLanguage
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
    public static class ProductNamesLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductNamesLanguage value)
        {
            return value switch
            {
                ProductNamesLanguage.Bg => "bg",
                ProductNamesLanguage.Cs => "cs",
                ProductNamesLanguage.Da => "da",
                ProductNamesLanguage.De => "de",
                ProductNamesLanguage.El => "el",
                ProductNamesLanguage.En => "en",
                ProductNamesLanguage.Es => "es",
                ProductNamesLanguage.Et => "et",
                ProductNamesLanguage.Fi => "fi",
                ProductNamesLanguage.Fr => "fr",
                ProductNamesLanguage.Hu => "hu",
                ProductNamesLanguage.It => "it",
                ProductNamesLanguage.Ja => "ja",
                ProductNamesLanguage.Lt => "lt",
                ProductNamesLanguage.Lv => "lv",
                ProductNamesLanguage.Nl => "nl",
                ProductNamesLanguage.Pl => "pl",
                ProductNamesLanguage.PtBr => "pt-br",
                ProductNamesLanguage.PtPt => "pt-pt",
                ProductNamesLanguage.Ro => "ro",
                ProductNamesLanguage.Ru => "ru",
                ProductNamesLanguage.Sk => "sk",
                ProductNamesLanguage.Sl => "sl",
                ProductNamesLanguage.Sv => "sv",
                ProductNamesLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductNamesLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ProductNamesLanguage.Bg,
                "cs" => ProductNamesLanguage.Cs,
                "da" => ProductNamesLanguage.Da,
                "de" => ProductNamesLanguage.De,
                "el" => ProductNamesLanguage.El,
                "en" => ProductNamesLanguage.En,
                "es" => ProductNamesLanguage.Es,
                "et" => ProductNamesLanguage.Et,
                "fi" => ProductNamesLanguage.Fi,
                "fr" => ProductNamesLanguage.Fr,
                "hu" => ProductNamesLanguage.Hu,
                "it" => ProductNamesLanguage.It,
                "ja" => ProductNamesLanguage.Ja,
                "lt" => ProductNamesLanguage.Lt,
                "lv" => ProductNamesLanguage.Lv,
                "nl" => ProductNamesLanguage.Nl,
                "pl" => ProductNamesLanguage.Pl,
                "pt-br" => ProductNamesLanguage.PtBr,
                "pt-pt" => ProductNamesLanguage.PtPt,
                "ro" => ProductNamesLanguage.Ro,
                "ru" => ProductNamesLanguage.Ru,
                "sk" => ProductNamesLanguage.Sk,
                "sl" => ProductNamesLanguage.Sl,
                "sv" => ProductNamesLanguage.Sv,
                "zh" => ProductNamesLanguage.Zh,
                _ => null,
            };
        }
    }
}