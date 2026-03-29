
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSonicEngine
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
    public static class ChatSonicEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSonicEngine value)
        {
            return value switch
            {
                ChatSonicEngine.Average => "average",
                ChatSonicEngine.Economy => "economy",
                ChatSonicEngine.Good => "good",
                ChatSonicEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSonicEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ChatSonicEngine.Average,
                "economy" => ChatSonicEngine.Economy,
                "good" => ChatSonicEngine.Good,
                "premium" => ChatSonicEngine.Premium,
                _ => null,
            };
        }
    }
}