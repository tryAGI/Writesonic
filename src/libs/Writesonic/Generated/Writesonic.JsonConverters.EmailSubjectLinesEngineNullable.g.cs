#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmailSubjectLinesEngineNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.EmailSubjectLinesEngine?>
    {
        /// <inheritdoc />
        public override global::Writesonic.EmailSubjectLinesEngine? Read(
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
                        return global::Writesonic.EmailSubjectLinesEngineExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.EmailSubjectLinesEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.EmailSubjectLinesEngine?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.EmailSubjectLinesEngine? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writesonic.EmailSubjectLinesEngineExtensions.ToValueString(value.Value));
            }
        }
    }
}
