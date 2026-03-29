
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentShortenEngine
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
    public static class ContentShortenEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentShortenEngine value)
        {
            return value switch
            {
                ContentShortenEngine.Average => "average",
                ContentShortenEngine.Economy => "economy",
                ContentShortenEngine.Good => "good",
                ContentShortenEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentShortenEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ContentShortenEngine.Average,
                "economy" => ContentShortenEngine.Economy,
                "good" => ContentShortenEngine.Good,
                "premium" => ContentShortenEngine.Premium,
                _ => null,
            };
        }
    }
}