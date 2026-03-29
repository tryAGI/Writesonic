
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColdEmailsEngine
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
    public static class ColdEmailsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColdEmailsEngine value)
        {
            return value switch
            {
                ColdEmailsEngine.Average => "average",
                ColdEmailsEngine.Economy => "economy",
                ColdEmailsEngine.Good => "good",
                ColdEmailsEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColdEmailsEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ColdEmailsEngine.Average,
                "economy" => ColdEmailsEngine.Economy,
                "good" => ColdEmailsEngine.Good,
                "premium" => ColdEmailsEngine.Premium,
                _ => null,
            };
        }
    }
}