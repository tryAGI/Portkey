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

            global::Portkey.CreateMessageRequest request,
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

            global::Portkey.CreateMessageRequest request,
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
        /// <param name="role">
        /// The role of the entity that is creating the message. Allowed values include:<br/>
        /// - `user`: Indicates the message is sent by an actual user and should be used in most cases to represent user-generated messages.<br/>
        /// - `assistant`: Indicates the message is generated by the assistant. Use this value to insert messages from the assistant into the conversation.
        /// </param>
        /// <param name="content"></param>
        /// <param name="attachments">
        /// A list of files attached to the message, and the tools they should be added to.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateMessageResponse> CreateMessageAsync(
            global::Portkey.CreateMessageRequestRole role,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>> content,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? attachments = default,
            object? metadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}