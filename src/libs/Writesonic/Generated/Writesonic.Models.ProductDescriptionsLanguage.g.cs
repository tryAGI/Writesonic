
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProductDescriptionsLanguage
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
    public static class ProductDescriptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductDescriptionsLanguage value)
        {
            return value switch
            {
                ProductDescriptionsLanguage.Bg => "bg",
                ProductDescriptionsLanguage.Cs => "cs",
                ProductDescriptionsLanguage.Da => "da",
                ProductDescriptionsLanguage.De => "de",
                ProductDescriptionsLanguage.El => "el",
                ProductDescriptionsLanguage.En => "en",
                ProductDescriptionsLanguage.Es => "es",
                ProductDescriptionsLanguage.Et => "et",
                ProductDescriptionsLanguage.Fi => "fi",
                ProductDescriptionsLanguage.Fr => "fr",
                ProductDescriptionsLanguage.Hu => "hu",
                ProductDescriptionsLanguage.It => "it",
                ProductDescriptionsLanguage.Ja => "ja",
                ProductDescriptionsLanguage.Lt => "lt",
                ProductDescriptionsLanguage.Lv => "lv",
                ProductDescriptionsLanguage.Nl => "nl",
                ProductDescriptionsLanguage.Pl => "pl",
                ProductDescriptionsLanguage.PtBr => "pt-br",
                ProductDescriptionsLanguage.PtPt => "pt-pt",
                ProductDescriptionsLanguage.Ro => "ro",
                ProductDescriptionsLanguage.Ru => "ru",
                ProductDescriptionsLanguage.Sk => "sk",
                ProductDescriptionsLanguage.Sl => "sl",
                ProductDescriptionsLanguage.Sv => "sv",
                ProductDescriptionsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductDescriptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ProductDescriptionsLanguage.Bg,
                "cs" => ProductDescriptionsLanguage.Cs,
                "da" => ProductDescriptionsLanguage.Da,
                "de" => ProductDescriptionsLanguage.De,
                "el" => ProductDescriptionsLanguage.El,
                "en" => ProductDescriptionsLanguage.En,
                "es" => ProductDescriptionsLanguage.Es,
                "et" => ProductDescriptionsLanguage.Et,
                "fi" => ProductDescriptionsLanguage.Fi,
                "fr" => ProductDescriptionsLanguage.Fr,
                "hu" => ProductDescriptionsLanguage.Hu,
                "it" => ProductDescriptionsLanguage.It,
                "ja" => ProductDescriptionsLanguage.Ja,
                "lt" => ProductDescriptionsLanguage.Lt,
                "lv" => ProductDescriptionsLanguage.Lv,
                "nl" => ProductDescriptionsLanguage.Nl,
                "pl" => ProductDescriptionsLanguage.Pl,
                "pt-br" => ProductDescriptionsLanguage.PtBr,
                "pt-pt" => ProductDescriptionsLanguage.PtPt,
                "ro" => ProductDescriptionsLanguage.Ro,
                "ru" => ProductDescriptionsLanguage.Ru,
                "sk" => ProductDescriptionsLanguage.Sk,
                "sl" => ProductDescriptionsLanguage.Sl,
                "sv" => ProductDescriptionsLanguage.Sv,
                "zh" => ProductDescriptionsLanguage.Zh,
                _ => null,
            };
        }
    }
}