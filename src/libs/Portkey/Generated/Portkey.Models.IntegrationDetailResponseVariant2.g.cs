
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationDetailResponseVariant2
    {
        /// <summary>
        /// Masked API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masked_key")]
        public string? MaskedKey { get; set; }

        /// <summary>
        /// Provider-specific configuration object<br/>
        /// **⚠️ Security Note - Response Masking:**<br/>
        /// When retrieving integration details, sensitive fields are automatically masked:<br/>
        /// - Sensitive fields get a `masked_` prefix (e.g., `client_secret` → `masked_client_secret`)<br/>
        /// - Non-sensitive fields (IDs, URLs, regions, etc.) remain unchanged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>))]
        public global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access_settings")]
        public global::Portkey.GlobalWorkspaceAccess? GlobalWorkspaceAccessSettings { get; set; }

        /// <summary>
        /// Whether new models will be enabled by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_models")]
        public bool? AllowAllModels { get; set; }

        /// <summary>
        /// Number of workspaces with access to this integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_count")]
        public int? WorkspaceCount { get; set; }

        /// <summary>
        /// Secret reference mappings for this integration. Valid target_field values are "key" or "configurations.&lt;field&gt;".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_mappings")]
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Per-Integration pricing adjustments applied on top of Portkey's base model pricing<br/>
        /// for cost tracking, analytics, and budget limits. Use to reflect negotiated discounts,<br/>
        /// committed-use rates, or internal markups for cost showback.<br/>
        /// Example: {"multiplier":{"default":0.8,"cache_read_input_token":0.9,"cache_write_input_token":0.9}}
        /// </summary>
        /// <example>{"multiplier":{"default":0.8,"cache_read_input_token":0.9,"cache_write_input_token":0.9}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_adjustments")]
        public global::Portkey.PricingAdjustments? PricingAdjustments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDetailResponseVariant2" /> class.
        /// </summary>
        /// <param name="maskedKey">
        /// Masked API key
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object<br/>
        /// **⚠️ Security Note - Response Masking:**<br/>
        /// When retrieving integration details, sensitive fields are automatically masked:<br/>
        /// - Sensitive fields get a `masked_` prefix (e.g., `client_secret` → `masked_client_secret`)<br/>
        /// - Non-sensitive fields (IDs, URLs, regions, etc.) remain unchanged
        /// </param>
        /// <param name="globalWorkspaceAccessSettings"></param>
        /// <param name="allowAllModels">
        /// Whether new models will be enabled by default
        /// </param>
        /// <param name="workspaceCount">
        /// Number of workspaces with access to this integration
        /// </param>
        /// <param name="secretMappings">
        /// Secret reference mappings for this integration. Valid target_field values are "key" or "configurations.&lt;field&gt;".
        /// </param>
        /// <param name="pricingAdjustments">
        /// Per-Integration pricing adjustments applied on top of Portkey's base model pricing<br/>
        /// for cost tracking, analytics, and budget limits. Use to reflect negotiated discounts,<br/>
        /// committed-use rates, or internal markups for cost showback.<br/>
        /// Example: {"multiplier":{"default":0.8,"cache_read_input_token":0.9,"cache_write_input_token":0.9}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationDetailResponseVariant2(
            string? maskedKey,
            global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? configurations,
            global::Portkey.GlobalWorkspaceAccess? globalWorkspaceAccessSettings,
            bool? allowAllModels,
            int? workspaceCount,
            global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? secretMappings,
            global::Portkey.PricingAdjustments? pricingAdjustments)
        {
            this.MaskedKey = maskedKey;
            this.Configurations = configurations;
            this.GlobalWorkspaceAccessSettings = globalWorkspaceAccessSettings;
            this.AllowAllModels = allowAllModels;
            this.WorkspaceCount = workspaceCount;
            this.SecretMappings = secretMappings;
            this.PricingAdjustments = pricingAdjustments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDetailResponseVariant2" /> class.
        /// </summary>
        public IntegrationDetailResponseVariant2()
        {
        }

    }
}