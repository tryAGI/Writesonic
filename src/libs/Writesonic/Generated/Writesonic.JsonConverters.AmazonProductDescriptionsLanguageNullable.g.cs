#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class AmazonProductDescriptionsLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.AmazonProductDescriptionsLanguage?>
    {
        /// <inheritdoc />
        public override global::Writesonic.AmazonProductDescriptionsLanguage? Read(
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
                        return global::Writesonic.AmazonProductDescriptionsLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.AmazonProductDescriptionsLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.AmazonProductDescriptionsLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.AmazonProductDescriptionsLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writesonic.AmazonProductDescriptionsLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
