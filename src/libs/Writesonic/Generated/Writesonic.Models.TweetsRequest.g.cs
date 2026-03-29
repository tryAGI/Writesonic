
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TweetsRequest
    {
        /// <summary>
        /// Topic for the tweet.
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
        /// Initializes a new instance of the <see cref="TweetsRequest" /> class.
        /// </summary>
        /// <param name="topic">
        /// Topic for the tweet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TweetsRequest(
            string topic)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TweetsRequest" /> class.
        /// </summary>
        public TweetsRequest()
        {
        }
    }
}