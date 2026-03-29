
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToneChangerEngine
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
    public static class ToneChangerEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToneChangerEngine value)
        {
            return value switch
            {
                ToneChangerEngine.Average => "average",
                ToneChangerEngine.Economy => "economy",
                ToneChangerEngine.Good => "good",
                ToneChangerEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToneChangerEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ToneChangerEngine.Average,
                "economy" => ToneChangerEngine.Economy,
                "good" => ToneChangerEngine.Good,
                "premium" => ToneChangerEngine.Premium,
                _ => null,
            };
        }
    }
}