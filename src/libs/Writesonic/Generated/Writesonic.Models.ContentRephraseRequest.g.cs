
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentRephraseRequest
    {
        /// <summary>
        /// The text content to rephrase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_to_rephrase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentToRephrase { get; set; }

        /// <summary>
        /// Desired tone or style for the rephrased output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone_of_voice")]
        public string? ToneOfVoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentRephraseRequest" /> class.
        /// </summary>
        /// <param name="contentToRephrase">
        /// The text content to rephrase.
        /// </param>
        /// <param name="toneOfVoice">
        /// Desired tone or style for the rephrased output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentRephraseRequest(
            string contentToRephrase,
            string? toneOfVoice)
        {
            this.ContentToRephrase = contentToRephrase ?? throw new global::System.ArgumentNullException(nameof(contentToRephrase));
            this.ToneOfVoice = toneOfVoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentRephraseRequest" /> class.
        /// </summary>
        public ContentRephraseRequest()
        {
        }
    }
}