
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// Response from ChatSonic.
    /// </summary>
    public sealed partial class ChatSonicResponse
    {
        /// <summary>
        /// The AI-generated response message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// URLs of generated images, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSonicResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The AI-generated response message.
        /// </param>
        /// <param name="imageUrls">
        /// URLs of generated images, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSonicResponse(
            string? message,
            global::System.Collections.Generic.IList<string>? imageUrls)
        {
            this.Message = message;
            this.ImageUrls = imageUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSonicResponse" /> class.
        /// </summary>
        public ChatSonicResponse()
        {
        }
    }
}