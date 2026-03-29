
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum AmazonProductDescriptionsLanguage
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
    public static class AmazonProductDescriptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmazonProductDescriptionsLanguage value)
        {
            return value switch
            {
                AmazonProductDescriptionsLanguage.Bg => "bg",
                AmazonProductDescriptionsLanguage.Cs => "cs",
                AmazonProductDescriptionsLanguage.Da => "da",
                AmazonProductDescriptionsLanguage.De => "de",
                AmazonProductDescriptionsLanguage.El => "el",
                AmazonProductDescriptionsLanguage.En => "en",
                AmazonProductDescriptionsLanguage.Es => "es",
                AmazonProductDescriptionsLanguage.Et => "et",
                AmazonProductDescriptionsLanguage.Fi => "fi",
                AmazonProductDescriptionsLanguage.Fr => "fr",
                AmazonProductDescriptionsLanguage.Hu => "hu",
                AmazonProductDescriptionsLanguage.It => "it",
                AmazonProductDescriptionsLanguage.Ja => "ja",
                AmazonProductDescriptionsLanguage.Lt => "lt",
                AmazonProductDescriptionsLanguage.Lv => "lv",
                AmazonProductDescriptionsLanguage.Nl => "nl",
                AmazonProductDescriptionsLanguage.Pl => "pl",
                AmazonProductDescriptionsLanguage.PtBr => "pt-br",
                AmazonProductDescriptionsLanguage.PtPt => "pt-pt",
                AmazonProductDescriptionsLanguage.Ro => "ro",
                AmazonProductDescriptionsLanguage.Ru => "ru",
                AmazonProductDescriptionsLanguage.Sk => "sk",
                AmazonProductDescriptionsLanguage.Sl => "sl",
                AmazonProductDescriptionsLanguage.Sv => "sv",
                AmazonProductDescriptionsLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmazonProductDescriptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => AmazonProductDescriptionsLanguage.Bg,
                "cs" => AmazonProductDescriptionsLanguage.Cs,
                "da" => AmazonProductDescriptionsLanguage.Da,
                "de" => AmazonProductDescriptionsLanguage.De,
                "el" => AmazonProductDescriptionsLanguage.El,
                "en" => AmazonProductDescriptionsLanguage.En,
                "es" => AmazonProductDescriptionsLanguage.Es,
                "et" => AmazonProductDescriptionsLanguage.Et,
                "fi" => AmazonProductDescriptionsLanguage.Fi,
                "fr" => AmazonProductDescriptionsLanguage.Fr,
                "hu" => AmazonProductDescriptionsLanguage.Hu,
                "it" => AmazonProductDescriptionsLanguage.It,
                "ja" => AmazonProductDescriptionsLanguage.Ja,
                "lt" => AmazonProductDescriptionsLanguage.Lt,
                "lv" => AmazonProductDescriptionsLanguage.Lv,
                "nl" => AmazonProductDescriptionsLanguage.Nl,
                "pl" => AmazonProductDescriptionsLanguage.Pl,
                "pt-br" => AmazonProductDescriptionsLanguage.PtBr,
                "pt-pt" => AmazonProductDescriptionsLanguage.PtPt,
                "ro" => AmazonProductDescriptionsLanguage.Ro,
                "ru" => AmazonProductDescriptionsLanguage.Ru,
                "sk" => AmazonProductDescriptionsLanguage.Sk,
                "sl" => AmazonProductDescriptionsLanguage.Sl,
                "sv" => AmazonProductDescriptionsLanguage.Sv,
                "zh" => AmazonProductDescriptionsLanguage.Zh,
                _ => null,
            };
        }
    }
}