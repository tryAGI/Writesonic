
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum TweetsEngine
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
    public static class TweetsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TweetsEngine value)
        {
            return value switch
            {
                TweetsEngine.Average => "average",
                TweetsEngine.Economy => "economy",
                TweetsEngine.Good => "good",
                TweetsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TweetsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => TweetsEngine.Average,
                "economy" => TweetsEngine.Economy,
                "good" => TweetsEngine.Good,
                "premium" => TweetsEngine.Premium,
                _ => null,
            };
        }
    }
}