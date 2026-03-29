
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSonicLanguage
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
    public static class ChatSonicLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSonicLanguage value)
        {
            return value switch
            {
                ChatSonicLanguage.Bg => "bg",
                ChatSonicLanguage.Cs => "cs",
                ChatSonicLanguage.Da => "da",
                ChatSonicLanguage.De => "de",
                ChatSonicLanguage.El => "el",
                ChatSonicLanguage.En => "en",
                ChatSonicLanguage.Es => "es",
                ChatSonicLanguage.Et => "et",
                ChatSonicLanguage.Fi => "fi",
                ChatSonicLanguage.Fr => "fr",
                ChatSonicLanguage.Hu => "hu",
                ChatSonicLanguage.It => "it",
                ChatSonicLanguage.Ja => "ja",
                ChatSonicLanguage.Lt => "lt",
                ChatSonicLanguage.Lv => "lv",
                ChatSonicLanguage.Nl => "nl",
                ChatSonicLanguage.Pl => "pl",
                ChatSonicLanguage.PtBr => "pt-br",
                ChatSonicLanguage.PtPt => "pt-pt",
                ChatSonicLanguage.Ro => "ro",
                ChatSonicLanguage.Ru => "ru",
                ChatSonicLanguage.Sk => "sk",
                ChatSonicLanguage.Sl => "sl",
                ChatSonicLanguage.Sv => "sv",
                ChatSonicLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSonicLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => ChatSonicLanguage.Bg,
                "cs" => ChatSonicLanguage.Cs,
                "da" => ChatSonicLanguage.Da,
                "de" => ChatSonicLanguage.De,
                "el" => ChatSonicLanguage.El,
                "en" => ChatSonicLanguage.En,
                "es" => ChatSonicLanguage.Es,
                "et" => ChatSonicLanguage.Et,
                "fi" => ChatSonicLanguage.Fi,
                "fr" => ChatSonicLanguage.Fr,
                "hu" => ChatSonicLanguage.Hu,
                "it" => ChatSonicLanguage.It,
                "ja" => ChatSonicLanguage.Ja,
                "lt" => ChatSonicLanguage.Lt,
                "lv" => ChatSonicLanguage.Lv,
                "nl" => ChatSonicLanguage.Nl,
                "pl" => ChatSonicLanguage.Pl,
                "pt-br" => ChatSonicLanguage.PtBr,
                "pt-pt" => ChatSonicLanguage.PtPt,
                "ro" => ChatSonicLanguage.Ro,
                "ru" => ChatSonicLanguage.Ru,
                "sk" => ChatSonicLanguage.Sk,
                "sl" => ChatSonicLanguage.Sl,
                "sv" => ChatSonicLanguage.Sv,
                "zh" => ChatSonicLanguage.Zh,
                _ => null,
            };
        }
    }
}