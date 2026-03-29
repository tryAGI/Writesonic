
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// Request body for ChatSonic conversation.
    /// </summary>
    public sealed partial class ChatSonicRequest
    {
        /// <summary>
        /// When enabled, ChatSonic uses Google search results to answer.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_google_results")]
        public bool? EnableGoogleResults { get; set; }

        /// <summary>
        /// When enabled, ChatSonic remembers previous conversation context.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_memory")]
        public bool? EnableMemory { get; set; }

        /// <summary>
        /// The question or prompt to send to ChatSonic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputText { get; set; }

        /// <summary>
        /// Previous conversation turns for context when memory is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_data")]
        public global::System.Collections.Generic.IList<global::Writesonic.HistoryEntry>? HistoryData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSonicRequest" /> class.
        /// </summary>
        /// <param name="inputText">
        /// The question or prompt to send to ChatSonic.
        /// </param>
        /// <param name="enableGoogleResults">
        /// When enabled, ChatSonic uses Google search results to answer.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableMemory">
        /// When enabled, ChatSonic remembers previous conversation context.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="historyData">
        /// Previous conversation turns for context when memory is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSonicRequest(
            string inputText,
            bool? enableGoogleResults,
            bool? enableMemory,
            global::System.Collections.Generic.IList<global::Writesonic.HistoryEntry>? historyData)
        {
            this.EnableGoogleResults = enableGoogleResults;
            this.EnableMemory = enableMemory;
            this.InputText = inputText ?? throw new global::System.ArgumentNullException(nameof(inputText));
            this.HistoryData = historyData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSonicRequest" /> class.
        /// </summary>
        public ChatSonicRequest()
        {
        }
    }
}