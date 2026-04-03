
#nullable enable

namespace Writesonic
{
    public partial class WritesonicClient
    {
        partial void PrepareChatSonicArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Writesonic.ChatSonicEngine engine,
            ref global::Writesonic.ChatSonicLanguage language,
            ref int numCopies,
            global::Writesonic.ChatSonicRequest request);
        partial void PrepareChatSonicRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Writesonic.ChatSonicEngine engine,
            global::Writesonic.ChatSonicLanguage language,
            int numCopies,
            global::Writesonic.ChatSonicRequest request);
        partial void ProcessChatSonicResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatSonicResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ChatSonic (Like ChatGPT)<br/>
        /// Conversational AI chatbot with real-time Google search integration,<br/>
        /// memory functionality, and support for 24 languages.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Writesonic.ChatSonicResponse> ChatSonicAsync(
            global::Writesonic.ChatSonicEngine engine,
            global::Writesonic.ChatSonicLanguage language,
            int numCopies,

            global::Writesonic.ChatSonicRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChatSonicArguments(
                httpClient: HttpClient,
                engine: ref engine,
                language: ref language,
                numCopies: ref numCopies,
                request: request);

            var __pathBuilder = new global::Writesonic.PathBuilder(
                path: "/v2/business/content/chatsonic",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("engine", engine.ToValueString())
                .AddRequiredParameter("language", language.ToValueString())
                .AddRequiredParameter("num_copies", numCopies.ToString()!) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatSonicRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                engine: engine,
                language: language,
                numCopies: numCopies,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatSonicResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation error.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Writesonic.ValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Writesonic.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Writesonic.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Writesonic.ApiException<global::Writesonic.ValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessChatSonicResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Writesonic.ChatSonicResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Writesonic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Writesonic.ChatSonicResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Writesonic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// ChatSonic (Like ChatGPT)<br/>
        /// Conversational AI chatbot with real-time Google search integration,<br/>
        /// memory functionality, and support for 24 languages.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="enableGoogleResults">
        /// When enabled, ChatSonic uses Google search results to answer.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableMemory">
        /// When enabled, ChatSonic remembers previous conversation context.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="inputText">
        /// The question or prompt to send to ChatSonic.
        /// </param>
        /// <param name="historyData">
        /// Previous conversation turns for context when memory is enabled.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Writesonic.ChatSonicResponse> ChatSonicAsync(
            global::Writesonic.ChatSonicEngine engine,
            global::Writesonic.ChatSonicLanguage language,
            int numCopies,
            string inputText,
            bool? enableGoogleResults = default,
            bool? enableMemory = default,
            global::System.Collections.Generic.IList<global::Writesonic.HistoryEntry>? historyData = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Writesonic.ChatSonicRequest
            {
                EnableGoogleResults = enableGoogleResults,
                EnableMemory = enableMemory,
                InputText = inputText,
                HistoryData = historyData,
            };

            return await ChatSonicAsync(
                engine: engine,
                language: language,
                numCopies: numCopies,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}