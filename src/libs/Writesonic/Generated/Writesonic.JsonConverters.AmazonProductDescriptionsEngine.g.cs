#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class AmazonProductDescriptionsEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.AmazonProductDescriptionsEngine>
    {
        /// <inheritdoc />
        public override global::Writesonic.AmazonProductDescriptionsEngine Read(
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
                        return global::Writesonic.AmazonProductDescriptionsEngineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.AmazonProductDescriptionsEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.AmazonProductDescriptionsEngine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.AmazonProductDescriptionsEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Writesonic.AmazonProductDescriptionsEngineExtensions.ToValueString(value));
        }
    }
}
