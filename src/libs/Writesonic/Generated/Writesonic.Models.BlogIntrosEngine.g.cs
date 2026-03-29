
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogIntrosEngine
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
    public static class BlogIntrosEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogIntrosEngine value)
        {
            return value switch
            {
                BlogIntrosEngine.Average => "average",
                BlogIntrosEngine.Economy => "economy",
                BlogIntrosEngine.Good => "good",
                BlogIntrosEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogIntrosEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => BlogIntrosEngine.Average,
                "economy" => BlogIntrosEngine.Economy,
                "good" => BlogIntrosEngine.Good,
                "premium" => BlogIntrosEngine.Premium,
                _ => null,
            };
        }
    }
}