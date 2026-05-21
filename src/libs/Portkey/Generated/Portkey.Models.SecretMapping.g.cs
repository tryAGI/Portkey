
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretMapping
    {
        /// <summary>
        /// The field on the entity to populate from the secret reference. Must be unique within the array.<br/>
        /// - **Integrations**: `key` or `configurations.&lt;field&gt;` (e.g. `configurations.aws_secret_access_key`)<br/>
        /// - **Virtual Keys**: `key` or `model_config.&lt;field&gt;` (e.g. `model_config.awsSecretAccessKey`)<br/>
        /// - **MCP Integrations**: `configurations.&lt;field&gt;` (e.g. `configurations.oauth_metadata`)<br/>
        /// Example: key
        /// </summary>
        /// <example>key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetField { get; set; }

        /// <summary>
        /// UUID or slug of the secret reference. Must belong to the same organisation and be accessible by the workspace.<br/>
        /// Example: my-aws-secret
        /// </summary>
        /// <example>my-aws-secret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_reference_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretReferenceId { get; set; }

        /// <summary>
        /// Override the secret_key defined on the secret reference. Use to pick a specific key from a multi-value secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Format of the secret value.<br/>
        /// - `string`: The secret value is treated as a plain string.<br/>
        /// - `json`: The secret value is parsed as JSON before being applied to the target field. Use this when the target field expects a structured object (e.g. `configurations.oauth_metadata`).<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.SecretMappingValueFormatJsonConverter))]
        public global::Portkey.SecretMappingValueFormat? ValueFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretMapping" /> class.
        /// </summary>
        /// <param name="targetField">
        /// The field on the entity to populate from the secret reference. Must be unique within the array.<br/>
        /// - **Integrations**: `key` or `configurations.&lt;field&gt;` (e.g. `configurations.aws_secret_access_key`)<br/>
        /// - **Virtual Keys**: `key` or `model_config.&lt;field&gt;` (e.g. `model_config.awsSecretAccessKey`)<br/>
        /// - **MCP Integrations**: `configurations.&lt;field&gt;` (e.g. `configurations.oauth_metadata`)<br/>
        /// Example: key
        /// </param>
        /// <param name="secretReferenceId">
        /// UUID or slug of the secret reference. Must belong to the same organisation and be accessible by the workspace.<br/>
        /// Example: my-aws-secret
        /// </param>
        /// <param name="secretKey">
        /// Override the secret_key defined on the secret reference. Use to pick a specific key from a multi-value secret.
        /// </param>
        /// <param name="valueFormat">
        /// Format of the secret value.<br/>
        /// - `string`: The secret value is treated as a plain string.<br/>
        /// - `json`: The secret value is parsed as JSON before being applied to the target field. Use this when the target field expects a structured object (e.g. `configurations.oauth_metadata`).<br/>
        /// Example: json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretMapping(
            string targetField,
            string secretReferenceId,
            string? secretKey,
            global::Portkey.SecretMappingValueFormat? valueFormat)
        {
            this.TargetField = targetField ?? throw new global::System.ArgumentNullException(nameof(targetField));
            this.SecretReferenceId = secretReferenceId ?? throw new global::System.ArgumentNullException(nameof(secretReferenceId));
            this.SecretKey = secretKey;
            this.ValueFormat = valueFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretMapping" /> class.
        /// </summary>
        public SecretMapping()
        {
        }

    }
}