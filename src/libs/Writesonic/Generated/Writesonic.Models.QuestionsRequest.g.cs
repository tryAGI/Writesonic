
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionsRequest
    {
        /// <summary>
        /// Topic for generating questions or polls.
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
        /// Initializes a new instance of the <see cref="QuestionsRequest" /> class.
        /// </summary>
        /// <param name="topic">
        /// Topic for generating questions or polls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionsRequest(
            string topic)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionsRequest" /> class.
        /// </summary>
        public QuestionsRequest()
        {
        }
    }
}