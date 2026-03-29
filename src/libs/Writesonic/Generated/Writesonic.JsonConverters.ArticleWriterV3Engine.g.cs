#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ArticleWriterV3EngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.ArticleWriterV3Engine>
    {
        /// <inheritdoc />
        public override global::Writesonic.ArticleWriterV3Engine Read(
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
                        return global::Writesonic.ArticleWriterV3EngineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.ArticleWriterV3Engine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.ArticleWriterV3Engine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.ArticleWriterV3Engine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Writesonic.ArticleWriterV3EngineExtensions.ToValueString(value));
        }
    }
}
