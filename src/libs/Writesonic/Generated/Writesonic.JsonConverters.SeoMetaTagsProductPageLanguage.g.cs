#nullable enable

namespace Writesonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class SeoMetaTagsProductPageLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writesonic.SeoMetaTagsProductPageLanguage>
    {
        /// <inheritdoc />
        public override global::Writesonic.SeoMetaTagsProductPageLanguage Read(
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
                        return global::Writesonic.SeoMetaTagsProductPageLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writesonic.SeoMetaTagsProductPageLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writesonic.SeoMetaTagsProductPageLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writesonic.SeoMetaTagsProductPageLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Writesonic.SeoMetaTagsProductPageLanguageExtensions.ToValueString(value));
        }
    }
}
