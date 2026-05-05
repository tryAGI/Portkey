#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create a Integration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateIntegrationsResponse> CreateIntegrationsAsync(

            global::Portkey.CreateIntegrationRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Integration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateIntegrationsResponse>> CreateIntegrationsAsResponseAsync(

            global::Portkey.CreateIntegrationRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Integration
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier (auto-generated if not provided)<br/>
        /// Example: production-openai
        /// </param>
        /// <param name="aiProviderId">
        /// ID of the base AI provider<br/>
        /// Example: openai
        /// </param>
        /// <param name="key">
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </param>
        /// <param name="description">
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID (for workspace-scoped integrations)<br/>
        /// Example: ws-my-team-1234
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider when creating a workspace-scoped integration. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider. Only applicable for workspace-scoped integrations. If the slug already exists in the workspace, the request will fail with a validation error.
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique. When "key" is mapped, the key body field can be omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateIntegrationsResponse> CreateIntegrationsAsync(
            string name,
            string aiProviderId,
            string? slug = default,
            string? key = default,
            string? description = default,
            string? workspaceId = default,
            global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? configurations = default,
            bool? createDefaultProvider = default,
            string? defaultProviderSlug = default,
            global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? secretMappings = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}