
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentShortenRequest
    {
        /// <summary>
        /// The text content to shorten.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_to_shorten")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentToShorten { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentShortenRequest" /> class.
        /// </summary>
        /// <param name="contentToShorten">
        /// The text content to shorten.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentShortenRequest(
            string contentToShorten)
        {
            this.ContentToShorten = contentToShorten ?? throw new global::System.ArgumentNullException(nameof(contentToShorten));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentShortenRequest" /> class.
        /// </summary>
        public ContentShortenRequest()
        {
        }
    }
}