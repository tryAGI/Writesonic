
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TikTokScriptsRequest
    {
        /// <summary>
        /// Topic for the TikTok video script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TikTokScriptsRequest" /> class.
        /// </summary>
        /// <param name="topic">
        /// Topic for the TikTok video script.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TikTokScriptsRequest(
            string topic)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TikTokScriptsRequest" /> class.
        /// </summary>
        public TikTokScriptsRequest()
        {
        }
    }
}