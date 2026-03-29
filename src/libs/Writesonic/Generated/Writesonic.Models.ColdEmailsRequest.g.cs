
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ColdEmailsRequest
    {
        /// <summary>
        /// Sender name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromName { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToName { get; set; }

        /// <summary>
        /// Goal of the cold email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Goal { get; set; }

        /// <summary>
        /// Context or scenario for the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        public string? Scenario { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdEmailsRequest" /> class.
        /// </summary>
        /// <param name="fromName">
        /// Sender name.
        /// </param>
        /// <param name="toName">
        /// Recipient name.
        /// </param>
        /// <param name="goal">
        /// Goal of the cold email.
        /// </param>
        /// <param name="scenario">
        /// Context or scenario for the email.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdEmailsRequest(
            string fromName,
            string toName,
            string goal,
            string? scenario)
        {
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.ToName = toName ?? throw new global::System.ArgumentNullException(nameof(toName));
            this.Goal = goal ?? throw new global::System.ArgumentNullException(nameof(goal));
            this.Scenario = scenario;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdEmailsRequest" /> class.
        /// </summary>
        public ColdEmailsRequest()
        {
        }
    }
}