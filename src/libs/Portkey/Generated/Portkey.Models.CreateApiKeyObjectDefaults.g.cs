
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyObjectDefaults
    {
        /// <summary>
        /// Example: {"environment":"development","team":"backend"}
        /// </summary>
        /// <example>{"environment":"development","team":"backend"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Example: config-abc
        /// </summary>
        /// <example>config-abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// When false, the pinned config_id cannot be overridden at request time.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_config_override")]
        public bool? AllowConfigOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectDefaults" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Example: {"environment":"development","team":"backend"}
        /// </param>
        /// <param name="configId">
        /// Example: config-abc
        /// </param>
        /// <param name="allowConfigOverride">
        /// When false, the pinned config_id cannot be overridden at request time.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyObjectDefaults(
            object? metadata,
            string? configId,
            bool? allowConfigOverride)
        {
            this.Metadata = metadata;
            this.ConfigId = configId;
            this.AllowConfigOverride = allowConfigOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectDefaults" /> class.
        /// </summary>
        public CreateApiKeyObjectDefaults()
        {
        }
    }
}