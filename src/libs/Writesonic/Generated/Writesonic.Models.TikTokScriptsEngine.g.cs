
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TikTokScriptsEngine
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
    public static class TikTokScriptsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TikTokScriptsEngine value)
        {
            return value switch
            {
                TikTokScriptsEngine.Average => "average",
                TikTokScriptsEngine.Economy => "economy",
                TikTokScriptsEngine.Good => "good",
                TikTokScriptsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TikTokScriptsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => TikTokScriptsEngine.Average,
                "economy" => TikTokScriptsEngine.Economy,
                "good" => TikTokScriptsEngine.Good,
                "premium" => TikTokScriptsEngine.Premium,
                _ => null,
            };
        }
    }
}