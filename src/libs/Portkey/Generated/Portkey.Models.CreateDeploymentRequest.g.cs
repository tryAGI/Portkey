
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentRequest
    {
        /// <summary>
        /// Required if not using API key auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Auto-generated from name as `dp-&lt;slug&gt;` if omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Default Value: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateDeploymentRequestTypeJsonConverter))]
        public global::Portkey.CreateDeploymentRequestType? Type { get; set; }

        /// <summary>
        /// Freeform deployment configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_config")]
        public object? DeploymentConfig { get; set; }

        /// <summary>
        /// The first active deployment in an organisation is always made default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_settings")]
        public global::Portkey.DeploymentAuthSettingsInput? AuthSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="organisationId">
        /// Required if not using API key auth
        /// </param>
        /// <param name="slug">
        /// Auto-generated from name as `dp-&lt;slug&gt;` if omitted
        /// </param>
        /// <param name="type">
        /// Default Value: production
        /// </param>
        /// <param name="deploymentConfig">
        /// Freeform deployment configuration
        /// </param>
        /// <param name="isDefault">
        /// The first active deployment in an organisation is always made default.
        /// </param>
        /// <param name="authSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequest(
            string name,
            global::System.Guid? organisationId,
            string? slug,
            global::Portkey.CreateDeploymentRequestType? type,
            object? deploymentConfig,
            bool? isDefault,
            global::Portkey.DeploymentAuthSettingsInput? authSettings)
        {
            this.OrganisationId = organisationId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Type = type;
            this.DeploymentConfig = deploymentConfig;
            this.IsDefault = isDefault;
            this.AuthSettings = authSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        public CreateDeploymentRequest()
        {
        }

    }
}