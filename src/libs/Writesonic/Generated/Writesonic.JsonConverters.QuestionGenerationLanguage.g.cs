#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class QuestionGenerationLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.QuestionGenerationLanguage>
    {
        /// <inheritdoc />
        public override global::Writesonic.QuestionGenerationLanguage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Writesonic.QuestionGenerationLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.QuestionGenerationLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.QuestionGenerationLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.QuestionGenerationLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Writesonic.QuestionGenerationLanguageExtensions.ToValueString(value));
        }
    }
}
