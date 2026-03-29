#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class InstagramCaptionsEngineNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.InstagramCaptionsEngine?>
    {
        /// <inheritdoc />
        public override global::Writesonic.InstagramCaptionsEngine? Read(
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
                        return global::Writesonic.InstagramCaptionsEngineExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.InstagramCaptionsEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.InstagramCaptionsEngine?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.InstagramCaptionsEngine? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writesonic.InstagramCaptionsEngineExtensions.ToValueString(value.Value));
            }
        }
    }
}
