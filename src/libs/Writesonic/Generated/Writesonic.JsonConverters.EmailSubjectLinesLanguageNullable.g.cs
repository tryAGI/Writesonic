#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmailSubjectLinesLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.EmailSubjectLinesLanguage?>
    {
        /// <inheritdoc />
        public override global::Writesonic.EmailSubjectLinesLanguage? Read(
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
                        return global::Writesonic.EmailSubjectLinesLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.EmailSubjectLinesLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.EmailSubjectLinesLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.EmailSubjectLinesLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writesonic.EmailSubjectLinesLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
