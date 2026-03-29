
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassiveToActiveVoiceEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Average,
        /// <summary>
        /// 
        /// </summary>
        Economy,
        /// <summary>
        /// 
        /// </summary>
        Good,
        /// <summary>
        /// 
        /// </summary>
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassiveToActiveVoiceEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassiveToActiveVoiceEngine value)
        {
            return value switch
            {
                PassiveToActiveVoiceEngine.Average => "average",
                PassiveToActiveVoiceEngine.Economy => "economy",
                PassiveToActiveVoiceEngine.Good => "good",
                PassiveToActiveVoiceEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassiveToActiveVoiceEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => PassiveToActiveVoiceEngine.Average,
                "economy" => PassiveToActiveVoiceEngine.Economy,
                "good" => PassiveToActiveVoiceEngine.Good,
                "premium" => PassiveToActiveVoiceEngine.Premium,
                _ => null,
            };
        }
    }
}