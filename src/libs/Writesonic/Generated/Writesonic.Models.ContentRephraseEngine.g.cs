
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentRephraseEngine
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
    public static class ContentRephraseEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentRephraseEngine value)
        {
            return value switch
            {
                ContentRephraseEngine.Average => "average",
                ContentRephraseEngine.Economy => "economy",
                ContentRephraseEngine.Good => "good",
                ContentRephraseEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentRephraseEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ContentRephraseEngine.Average,
                "economy" => ContentRephraseEngine.Economy,
                "good" => ContentRephraseEngine.Good,
                "premium" => ContentRephraseEngine.Premium,
                _ => null,
            };
        }
    }
}