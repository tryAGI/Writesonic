#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Email Subject Lines<br/>
        /// Generate attention-grabbing email subject lines.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> EmailSubjectLinesAsync(
            global::Writesonic.EmailSubjectLinesEngine engine,
            global::Writesonic.EmailSubjectLinesLanguage language,
            int numCopies,

            global::Writesonic.SubjectLinesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Email Subject Lines<br/>
        /// Generate attention-grabbing email subject lines.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="productName">
        /// Name of the product or service.
        /// </param>
        /// <param name="productDescription">
        /// Description of the product or service.
        /// </param>
        /// <param name="emailType">
        /// Type of email (e.g. promotional, newsletter, welcome).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> EmailSubjectLinesAsync(
            global::Writesonic.EmailSubjectLinesEngine engine,
            global::Writesonic.EmailSubjectLinesLanguage language,
            int numCopies,
            string productName,
            string productDescription,
            string? emailType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}