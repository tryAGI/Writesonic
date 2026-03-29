
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlogIdeasRequest
    {
        /// <summary>
        /// Topic to generate blog article ideas for.
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
        /// Initializes a new instance of the <see cref="BlogIdeasRequest" /> class.
        /// </summary>
        /// <param name="topic">
        /// Topic to generate blog article ideas for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlogIdeasRequest(
            string topic)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogIdeasRequest" /> class.
        /// </summary>
        public BlogIdeasRequest()
        {
        }
    }
}