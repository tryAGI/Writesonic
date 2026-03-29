
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToneChangerRequest
    {
        /// <summary>
        /// The text content whose tone should be changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The desired tone (e.g. professional, casual, friendly, witty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToneChangerRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The text content whose tone should be changed.
        /// </param>
        /// <param name="tone">
        /// The desired tone (e.g. professional, casual, friendly, witty).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToneChangerRequest(
            string content,
            string tone)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Tone = tone ?? throw new global::System.ArgumentNullException(nameof(tone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToneChangerRequest" /> class.
        /// </summary>
        public ToneChangerRequest()
        {
        }
    }
}