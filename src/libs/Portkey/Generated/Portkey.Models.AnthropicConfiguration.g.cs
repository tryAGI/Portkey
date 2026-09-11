
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Configuration for Anthropic integrations. Supports two authentication modes<br/>
    /// selected via `provider_auth_type`:<br/>
    /// - **apiKey** (default) – standard API-key auth; no extra fields required.<br/>
    /// - **wif** (Workload Identity Federation) – Portkey mints a subject JWT via your<br/>
    ///   configured IdP and exchanges it at Anthropic's WIF token endpoint.
    /// </summary>
    public sealed partial class AnthropicConfiguration
    {
        /// <summary>
        /// Authentication mode for the Anthropic integration<br/>
        /// Default Value: apiKey
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicConfigurationProviderAuthTypeJsonConverter))]
        public global::Portkey.AnthropicConfigurationProviderAuthType? ProviderAuthType { get; set; }

        /// <summary>
        /// Enable inspection of streaming responses for overloaded errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic_inspect_stream_for_overloaded_error")]
        public bool? AnthropicInspectStreamForOverloadedError { get; set; }

        /// <summary>
        /// Token endpoint URL of your identity provider (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_token_endpoint")]
        public string? OauthTokenEndpoint { get; set; }

        /// <summary>
        /// OAuth client ID issued by your IdP (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_id")]
        public string? OauthClientId { get; set; }

        /// <summary>
        /// OAuth client secret (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_secret")]
        public string? OauthClientSecret { get; set; }

        /// <summary>
        /// OAuth scope to request (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_scope")]
        public string? OauthScope { get; set; }

        /// <summary>
        /// Source of the subject JWT for WIF exchange<br/>
        /// Default Value: configuredIdp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wif_identity_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicConfigurationWifIdentitySourceJsonConverter))]
        public global::Portkey.AnthropicConfigurationWifIdentitySource? WifIdentitySource { get; set; }

        /// <summary>
        /// Audience claim for the subject JWT (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_audience")]
        public string? OauthAudience { get; set; }

        /// <summary>
        /// Anthropic federation rule ID (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic_federation_rule_id")]
        public string? AnthropicFederationRuleId { get; set; }

        /// <summary>
        /// Anthropic organization ID (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic_organization_id")]
        public string? AnthropicOrganizationId { get; set; }

        /// <summary>
        /// Anthropic service account ID (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic_service_account_id")]
        public string? AnthropicServiceAccountId { get; set; }

        /// <summary>
        /// Anthropic workspace ID (optional, for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic_workspace_id")]
        public string? AnthropicWorkspaceId { get; set; }

        /// <summary>
        /// Whether an API key is still required. Set to false for wif auth.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_key_required")]
        public bool? IsKeyRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicConfiguration" /> class.
        /// </summary>
        /// <param name="providerAuthType">
        /// Authentication mode for the Anthropic integration<br/>
        /// Default Value: apiKey
        /// </param>
        /// <param name="anthropicInspectStreamForOverloadedError">
        /// Enable inspection of streaming responses for overloaded errors
        /// </param>
        /// <param name="oauthTokenEndpoint">
        /// Token endpoint URL of your identity provider (required for wif auth)
        /// </param>
        /// <param name="oauthClientId">
        /// OAuth client ID issued by your IdP (required for wif auth)
        /// </param>
        /// <param name="oauthClientSecret">
        /// OAuth client secret (required for wif auth)
        /// </param>
        /// <param name="oauthScope">
        /// OAuth scope to request (optional)
        /// </param>
        /// <param name="wifIdentitySource">
        /// Source of the subject JWT for WIF exchange<br/>
        /// Default Value: configuredIdp
        /// </param>
        /// <param name="oauthAudience">
        /// Audience claim for the subject JWT (optional)
        /// </param>
        /// <param name="anthropicFederationRuleId">
        /// Anthropic federation rule ID (required for wif auth)
        /// </param>
        /// <param name="anthropicOrganizationId">
        /// Anthropic organization ID (required for wif auth)
        /// </param>
        /// <param name="anthropicServiceAccountId">
        /// Anthropic service account ID (required for wif auth)
        /// </param>
        /// <param name="anthropicWorkspaceId">
        /// Anthropic workspace ID (optional, for wif auth)
        /// </param>
        /// <param name="isKeyRequired">
        /// Whether an API key is still required. Set to false for wif auth.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicConfiguration(
            global::Portkey.AnthropicConfigurationProviderAuthType? providerAuthType,
            bool? anthropicInspectStreamForOverloadedError,
            string? oauthTokenEndpoint,
            string? oauthClientId,
            string? oauthClientSecret,
            string? oauthScope,
            global::Portkey.AnthropicConfigurationWifIdentitySource? wifIdentitySource,
            string? oauthAudience,
            string? anthropicFederationRuleId,
            string? anthropicOrganizationId,
            string? anthropicServiceAccountId,
            string? anthropicWorkspaceId,
            bool? isKeyRequired)
        {
            this.ProviderAuthType = providerAuthType;
            this.AnthropicInspectStreamForOverloadedError = anthropicInspectStreamForOverloadedError;
            this.OauthTokenEndpoint = oauthTokenEndpoint;
            this.OauthClientId = oauthClientId;
            this.OauthClientSecret = oauthClientSecret;
            this.OauthScope = oauthScope;
            this.WifIdentitySource = wifIdentitySource;
            this.OauthAudience = oauthAudience;
            this.AnthropicFederationRuleId = anthropicFederationRuleId;
            this.AnthropicOrganizationId = anthropicOrganizationId;
            this.AnthropicServiceAccountId = anthropicServiceAccountId;
            this.AnthropicWorkspaceId = anthropicWorkspaceId;
            this.IsKeyRequired = isKeyRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicConfiguration" /> class.
        /// </summary>
        public AnthropicConfiguration()
        {
        }

    }
}