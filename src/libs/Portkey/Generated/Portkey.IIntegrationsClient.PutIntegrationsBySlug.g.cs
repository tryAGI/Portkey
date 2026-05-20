#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugAsync(
            string slug,

            global::Portkey.UpdateIntegrationRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> PutIntegrationsBySlugAsResponseAsync(
            string slug,

            global::Portkey.UpdateIntegrationRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name">
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </param>
        /// <param name="key">
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </param>
        /// <param name="description">
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique.
        /// </param>
        /// <param name="pricingAdjustments">
        /// Per-Integration pricing adjustments applied on top of Portkey's base model pricing<br/>
        /// for cost tracking, analytics, and budget limits. Use to reflect negotiated discounts,<br/>
        /// committed-use rates, or internal markups for cost showback.<br/>
        /// Example: {"multiplier":{"default":0.8,"cache_read_input_token":0.9,"cache_write_input_token":0.9}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugAsync(
            string slug,
            string? name = default,
            string? key = default,
            string? description = default,
            global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? configurations = default,
            global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? secretMappings = default,
            global::Portkey.PricingAdjustments? pricingAdjustments = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}