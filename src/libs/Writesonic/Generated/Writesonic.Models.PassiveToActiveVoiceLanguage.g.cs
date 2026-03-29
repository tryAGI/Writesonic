
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassiveToActiveVoiceLanguage
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
    public static class PassiveToActiveVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassiveToActiveVoiceLanguage value)
        {
            return value switch
            {
                PassiveToActiveVoiceLanguage.Bg => "bg",
                PassiveToActiveVoiceLanguage.Cs => "cs",
                PassiveToActiveVoiceLanguage.Da => "da",
                PassiveToActiveVoiceLanguage.De => "de",
                PassiveToActiveVoiceLanguage.El => "el",
                PassiveToActiveVoiceLanguage.En => "en",
                PassiveToActiveVoiceLanguage.Es => "es",
                PassiveToActiveVoiceLanguage.Et => "et",
                PassiveToActiveVoiceLanguage.Fi => "fi",
                PassiveToActiveVoiceLanguage.Fr => "fr",
                PassiveToActiveVoiceLanguage.Hu => "hu",
                PassiveToActiveVoiceLanguage.It => "it",
                PassiveToActiveVoiceLanguage.Ja => "ja",
                PassiveToActiveVoiceLanguage.Lt => "lt",
                PassiveToActiveVoiceLanguage.Lv => "lv",
                PassiveToActiveVoiceLanguage.Nl => "nl",
                PassiveToActiveVoiceLanguage.Pl => "pl",
                PassiveToActiveVoiceLanguage.PtBr => "pt-br",
                PassiveToActiveVoiceLanguage.PtPt => "pt-pt",
                PassiveToActiveVoiceLanguage.Ro => "ro",
                PassiveToActiveVoiceLanguage.Ru => "ru",
                PassiveToActiveVoiceLanguage.Sk => "sk",
                PassiveToActiveVoiceLanguage.Sl => "sl",
                PassiveToActiveVoiceLanguage.Sv => "sv",
                PassiveToActiveVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassiveToActiveVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => PassiveToActiveVoiceLanguage.Bg,
                "cs" => PassiveToActiveVoiceLanguage.Cs,
                "da" => PassiveToActiveVoiceLanguage.Da,
                "de" => PassiveToActiveVoiceLanguage.De,
                "el" => PassiveToActiveVoiceLanguage.El,
                "en" => PassiveToActiveVoiceLanguage.En,
                "es" => PassiveToActiveVoiceLanguage.Es,
                "et" => PassiveToActiveVoiceLanguage.Et,
                "fi" => PassiveToActiveVoiceLanguage.Fi,
                "fr" => PassiveToActiveVoiceLanguage.Fr,
                "hu" => PassiveToActiveVoiceLanguage.Hu,
                "it" => PassiveToActiveVoiceLanguage.It,
                "ja" => PassiveToActiveVoiceLanguage.Ja,
                "lt" => PassiveToActiveVoiceLanguage.Lt,
                "lv" => PassiveToActiveVoiceLanguage.Lv,
                "nl" => PassiveToActiveVoiceLanguage.Nl,
                "pl" => PassiveToActiveVoiceLanguage.Pl,
                "pt-br" => PassiveToActiveVoiceLanguage.PtBr,
                "pt-pt" => PassiveToActiveVoiceLanguage.PtPt,
                "ro" => PassiveToActiveVoiceLanguage.Ro,
                "ru" => PassiveToActiveVoiceLanguage.Ru,
                "sk" => PassiveToActiveVoiceLanguage.Sk,
                "sl" => PassiveToActiveVoiceLanguage.Sl,
                "sv" => PassiveToActiveVoiceLanguage.Sv,
                "zh" => PassiveToActiveVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}