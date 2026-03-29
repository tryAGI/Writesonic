
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstagramCaptionsEngine
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
    public static class InstagramCaptionsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstagramCaptionsEngine value)
        {
            return value switch
            {
                InstagramCaptionsEngine.Average => "average",
                InstagramCaptionsEngine.Economy => "economy",
                InstagramCaptionsEngine.Good => "good",
                InstagramCaptionsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstagramCaptionsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => InstagramCaptionsEngine.Average,
                "economy" => InstagramCaptionsEngine.Economy,
                "good" => InstagramCaptionsEngine.Good,
                "premium" => InstagramCaptionsEngine.Premium,
                _ => null,
            };
        }
    }
}