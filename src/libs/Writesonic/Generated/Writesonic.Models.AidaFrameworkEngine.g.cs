
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum AidaFrameworkEngine
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
    public static class AidaFrameworkEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AidaFrameworkEngine value)
        {
            return value switch
            {
                AidaFrameworkEngine.Average => "average",
                AidaFrameworkEngine.Economy => "economy",
                AidaFrameworkEngine.Good => "good",
                AidaFrameworkEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AidaFrameworkEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => AidaFrameworkEngine.Average,
                "economy" => AidaFrameworkEngine.Economy,
                "good" => AidaFrameworkEngine.Good,
                "premium" => AidaFrameworkEngine.Premium,
                _ => null,
            };
        }
    }
}