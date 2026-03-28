
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateIntegrationRequest
    {
        /// <summary>
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </summary>
        /// <example>Production OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </summary>
        /// <example>sk-...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </summary>
        /// <example>Production OpenAI integration for customer-facing applications</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Provider-specific configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>))]
        public global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? Configurations { get; set; }

        /// <summary>
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_mappings")]
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIntegrationRequest(
            string? name,
            string? key,
            string? description,
            global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? configurations,
            global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? secretMappings)
        {
            this.Name = name;
            this.Key = key;
            this.Description = description;
            this.Configurations = configurations;
            this.SecretMappings = secretMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationRequest" /> class.
        /// </summary>
        public UpdateIntegrationRequest()
        {
        }
    }
}