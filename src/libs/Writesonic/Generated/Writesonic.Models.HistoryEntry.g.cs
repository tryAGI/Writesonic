
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// A conversation history entry for ChatSonic memory.
    /// </summary>
    public sealed partial class HistoryEntry
    {
        /// <summary>
        /// True if the message was sent by the user, false if by ChatSonic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSent { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryEntry" /> class.
        /// </summary>
        /// <param name="isSent">
        /// True if the message was sent by the user, false if by ChatSonic.
        /// </param>
        /// <param name="message">
        /// The message text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryEntry(
            bool isSent,
            string message)
        {
            this.IsSent = isSent;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryEntry" /> class.
        /// </summary>
        public HistoryEntry()
        {
        }
    }
}