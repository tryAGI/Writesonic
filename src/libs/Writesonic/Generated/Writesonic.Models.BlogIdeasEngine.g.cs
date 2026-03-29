
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogIdeasEngine
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
    public static class BlogIdeasEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogIdeasEngine value)
        {
            return value switch
            {
                BlogIdeasEngine.Average => "average",
                BlogIdeasEngine.Economy => "economy",
                BlogIdeasEngine.Good => "good",
                BlogIdeasEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogIdeasEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => BlogIdeasEngine.Average,
                "economy" => BlogIdeasEngine.Economy,
                "good" => BlogIdeasEngine.Good,
                "premium" => BlogIdeasEngine.Premium,
                _ => null,
            };
        }
    }
}