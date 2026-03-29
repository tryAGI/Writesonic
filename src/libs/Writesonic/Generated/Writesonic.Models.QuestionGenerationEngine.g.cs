
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public enum QuestionGenerationEngine
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
    public static class QuestionGenerationEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuestionGenerationEngine value)
        {
            return value switch
            {
                QuestionGenerationEngine.Average => "average",
                QuestionGenerationEngine.Economy => "economy",
                QuestionGenerationEngine.Good => "good",
                QuestionGenerationEngine.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuestionGenerationEngine? ToEnum(string value)
        {
            return value switch
            {
                "average" => QuestionGenerationEngine.Average,
                "economy" => QuestionGenerationEngine.Economy,
                "good" => QuestionGenerationEngine.Good,
                "premium" => QuestionGenerationEngine.Premium,
                _ => null,
            };
        }
    }
}