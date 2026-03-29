
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArticleWriterV3Engine
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
    public static class ArticleWriterV3EngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArticleWriterV3Engine value)
        {
            return value switch
            {
                ArticleWriterV3Engine.Average => "average",
                ArticleWriterV3Engine.Economy => "economy",
                ArticleWriterV3Engine.Good => "good",
                ArticleWriterV3Engine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArticleWriterV3Engine? ToEnum(string value)
        {
            return value switch
            {
                "average" => ArticleWriterV3Engine.Average,
                "economy" => ArticleWriterV3Engine.Economy,
                "good" => ArticleWriterV3Engine.Good,
                "premium" => ArticleWriterV3Engine.Premium,
                _ => null,
            };
        }
    }
}