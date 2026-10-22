#nullable enable

namespace Portkey
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Count Message Tokens<br/>
        /// Count the number of tokens that will be used by a Messages API request before actually sending it to Claude. Useful for cost estimation and staying within context window limits.<br/>
        /// Supported on the same providers as the `/messages` endpoint: Anthropic, AWS Bedrock, Google Vertex AI, and Azure AI Foundry (Anthropic models).
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CountMessageTokensResponse> CountMessageTokensAsync(

            global::Portkey.CountMessageTokensRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count Message Tokens<br/>
        /// Count the number of tokens that will be used by a Messages API request before actually sending it to Claude. Useful for cost estimation and staying within context window limits.<br/>
        /// Supported on the same providers as the `/messages` endpoint: Anthropic, AWS Bedrock, Google Vertex AI, and Azure AI Foundry (Anthropic models).
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CountMessageTokensResponse>> CountMessageTokensAsResponseAsync(

            global::Portkey.CountMessageTokensRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count Message Tokens<br/>
        /// Count the number of tokens that will be used by a Messages API request before actually sending it to Claude. Useful for cost estimation and staying within context window limits.<br/>
        /// Supported on the same providers as the `/messages` endpoint: Anthropic, AWS Bedrock, Google Vertex AI, and Azure AI Foundry (Anthropic models).
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="model">
        /// The model identifier (same format as CreateAnthropicMessageRequest).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CountMessageTokensResponse> CountMessageTokensAsync(
            string model,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> messages,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AnthropicSystemContent? system = default,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? tools = default,
            global::Portkey.CountMessageTokensRequestToolChoice? toolChoice = default,
            global::Portkey.AnthropicThinkingConfig? thinking = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}