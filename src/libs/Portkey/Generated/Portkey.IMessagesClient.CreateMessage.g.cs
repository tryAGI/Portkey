#nullable enable

namespace Portkey
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
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
        global::System.Threading.Tasks.Task<global::Portkey.CreateMessageResponse> CreateMessageAsync(

            global::Portkey.CreateAnthropicMessageRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
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
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateMessageResponse>> CreateMessageAsResponseAsync(

            global::Portkey.CreateAnthropicMessageRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="model">
        /// The model identifier. When using Portkey's provider/virtual-key routing, use the<br/>
        /// `@provider-slug/deployment-name` format (e.g., `@my-azure-foundry-provider/my-claude-deployment`).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </param>
        /// <param name="messages">
        /// List of input messages forming the conversation.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate in the response.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="system"></param>
        /// <param name="stream">
        /// Set to true to stream the response using server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 1.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability.
        /// </param>
        /// <param name="topK">
        /// Top-K sampling value.
        /// </param>
        /// <param name="stopSequences">
        /// Custom stop sequences.
        /// </param>
        /// <param name="tools">
        /// Tool definitions available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool the model uses.
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateMessageResponse> CreateMessageAsync(
            string model,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> messages,
            int maxTokens,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AnthropicSystemContent? system = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            int? topK = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? tools = default,
            global::Portkey.CreateAnthropicMessageRequestToolChoice? toolChoice = default,
            global::Portkey.AnthropicThinkingConfig? thinking = default,
            global::Portkey.CreateAnthropicMessageRequestMetadata? metadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}