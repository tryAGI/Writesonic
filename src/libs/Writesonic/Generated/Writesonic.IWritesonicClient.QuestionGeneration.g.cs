#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Questions<br/>
        /// Generate engaging questions and polls that increase audience participation.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> QuestionGenerationAsync(
            global::Writesonic.QuestionGenerationEngine engine,
            global::Writesonic.QuestionGenerationLanguage language,
            int numCopies,

            global::Writesonic.QuestionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Questions<br/>
        /// Generate engaging questions and polls that increase audience participation.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="topic">
        /// Topic for generating questions or polls.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> QuestionGenerationAsync(
            global::Writesonic.QuestionGenerationEngine engine,
            global::Writesonic.QuestionGenerationLanguage language,
            int numCopies,
            string topic,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}