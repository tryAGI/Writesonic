
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlogOutlinesEngine
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
    public static class BlogOutlinesEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlogOutlinesEngine value)
        {
            return value switch
            {
                BlogOutlinesEngine.Average => "average",
                BlogOutlinesEngine.Economy => "economy",
                BlogOutlinesEngine.Good => "good",
                BlogOutlinesEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlogOutlinesEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => BlogOutlinesEngine.Average,
                "economy" => BlogOutlinesEngine.Economy,
                "good" => BlogOutlinesEngine.Good,
                "premium" => BlogOutlinesEngine.Premium,
                _ => null,
            };
        }
    }
}