#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Cold Emails<br/>
        /// Generate personalized cold email copy with sender and recipient context.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ColdEmailsAsync(
            global::Writesonic.ColdEmailsEngine engine,
            global::Writesonic.ColdEmailsLanguage language,
            int numCopies,

            global::Writesonic.ColdEmailsRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cold Emails<br/>
        /// Generate personalized cold email copy with sender and recipient context.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ColdEmailsAsync(
            global::Writesonic.ColdEmailsEngine engine,
            global::Writesonic.ColdEmailsLanguage language,
            int numCopies,
            string fromName,
            string toName,
            string goal,
            string? scenario = default,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}