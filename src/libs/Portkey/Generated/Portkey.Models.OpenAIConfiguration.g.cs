
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Configuration for OpenAI integrations. Supports three authentication modes<br/>
    /// selected via `provider_auth_type`:<br/>
    /// - **apiKey** (default) – standard API-key auth; no extra fields required.<br/>
    /// - **oauthClientCredentials** – Portkey obtains an access token from your IdP using<br/>
    ///   the OAuth 2.0 client-credentials grant and forwards it to OpenAI.<br/>
    /// - **wif** (Workload Identity Federation) – Portkey mints a subject JWT via your<br/>
    ///   configured IdP and exchanges it at OpenAI's WIF token endpoint.
    /// </summary>
    public sealed partial class OpenAIConfiguration
    {
        /// <summary>
        /// Authentication mode for the OpenAI integration<br/>
        /// Default Value: apiKey
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OpenAIConfigurationProviderAuthTypeJsonConverter))]
        public global::Portkey.OpenAIConfigurationProviderAuthType? ProviderAuthType { get; set; }

        /// <summary>
        /// OpenAI organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_organization")]
        public string? OpenaiOrganization { get; set; }

        /// <summary>
        /// OpenAI project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_project")]
        public string? OpenaiProject { get; set; }

        /// <summary>
        /// Token endpoint URL of your identity provider (required for oauthClientCredentials and wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_token_endpoint")]
        public string? OauthTokenEndpoint { get; set; }

        /// <summary>
        /// OAuth client ID issued by your IdP (required for oauthClientCredentials and wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_id")]
        public string? OauthClientId { get; set; }

        /// <summary>
        /// OAuth client secret (required for oauthClientCredentials and wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_secret")]
        public string? OauthClientSecret { get; set; }

        /// <summary>
        /// OAuth scope to request (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_scope")]
        public string? OauthScope { get; set; }

        /// <summary>
        /// Source of the subject JWT for WIF exchange (only configuredIdp is supported today)<br/>
        /// Default Value: configuredIdp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wif_identity_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OpenAIConfigurationWifIdentitySourceJsonConverter))]
        public global::Portkey.OpenAIConfigurationWifIdentitySource? WifIdentitySource { get; set; }

        /// <summary>
        /// Audience claim for the subject JWT (optional, wif only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_audience")]
        public string? OauthAudience { get; set; }

        /// <summary>
        /// OpenAI identity provider ID (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_identity_provider_id")]
        public string? OpenaiIdentityProviderId { get; set; }

        /// <summary>
        /// OpenAI service account ID (required for wif auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai_service_account_id")]
        public string? OpenaiServiceAccountId { get; set; }

        /// <summary>
        /// Whether an API key is still required. Set to false for oauthClientCredentials and wif auth.<br/>
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
        /// Initializes a new instance of the <see cref="OpenAIConfiguration" /> class.
        /// </summary>
        /// <param name="providerAuthType">
        /// Authentication mode for the OpenAI integration<br/>
        /// Default Value: apiKey
        /// </param>
        /// <param name="openaiOrganization">
        /// OpenAI organization ID
        /// </param>
        /// <param name="openaiProject">
        /// OpenAI project ID
        /// </param>
        /// <param name="oauthTokenEndpoint">
        /// Token endpoint URL of your identity provider (required for oauthClientCredentials and wif auth)
        /// </param>
        /// <param name="oauthClientId">
        /// OAuth client ID issued by your IdP (required for oauthClientCredentials and wif auth)
        /// </param>
        /// <param name="oauthClientSecret">
        /// OAuth client secret (required for oauthClientCredentials and wif auth)
        /// </param>
        /// <param name="oauthScope">
        /// OAuth scope to request (optional)
        /// </param>
        /// <param name="wifIdentitySource">
        /// Source of the subject JWT for WIF exchange (only configuredIdp is supported today)<br/>
        /// Default Value: configuredIdp
        /// </param>
        /// <param name="oauthAudience">
        /// Audience claim for the subject JWT (optional, wif only)
        /// </param>
        /// <param name="openaiIdentityProviderId">
        /// OpenAI identity provider ID (required for wif auth)
        /// </param>
        /// <param name="openaiServiceAccountId">
        /// OpenAI service account ID (required for wif auth)
        /// </param>
        /// <param name="isKeyRequired">
        /// Whether an API key is still required. Set to false for oauthClientCredentials and wif auth.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIConfiguration(
            global::Portkey.OpenAIConfigurationProviderAuthType? providerAuthType,
            string? openaiOrganization,
            string? openaiProject,
            string? oauthTokenEndpoint,
            string? oauthClientId,
            string? oauthClientSecret,
            string? oauthScope,
            global::Portkey.OpenAIConfigurationWifIdentitySource? wifIdentitySource,
            string? oauthAudience,
            string? openaiIdentityProviderId,
            string? openaiServiceAccountId,
            bool? isKeyRequired)
        {
            this.ProviderAuthType = providerAuthType;
            this.OpenaiOrganization = openaiOrganization;
            this.OpenaiProject = openaiProject;
            this.OauthTokenEndpoint = oauthTokenEndpoint;
            this.OauthClientId = oauthClientId;
            this.OauthClientSecret = oauthClientSecret;
            this.OauthScope = oauthScope;
            this.WifIdentitySource = wifIdentitySource;
            this.OauthAudience = oauthAudience;
            this.OpenaiIdentityProviderId = openaiIdentityProviderId;
            this.OpenaiServiceAccountId = openaiServiceAccountId;
            this.IsKeyRequired = isKeyRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIConfiguration" /> class.
        /// </summary>
        public OpenAIConfiguration()
        {
        }

    }
}