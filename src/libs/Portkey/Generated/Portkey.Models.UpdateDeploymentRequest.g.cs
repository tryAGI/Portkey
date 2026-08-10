
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDeploymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateDeploymentRequestTypeJsonConverter))]
        public global::Portkey.UpdateDeploymentRequestType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateDeploymentRequestStatusJsonConverter))]
        public global::Portkey.UpdateDeploymentRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_config")]
        public object? DeploymentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Issues a new `client_auth` token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate_auth")]
        public bool? RotateAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_existing")]
        public bool? OverrideExisting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>))]
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>? AuthSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="deploymentConfig"></param>
        /// <param name="isDefault"></param>
        /// <param name="rotateAuth">
        /// Issues a new `client_auth` token
        /// </param>
        /// <param name="overrideExisting"></param>
        /// <param name="authSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentRequest(
            string? name,
            global::Portkey.UpdateDeploymentRequestType? type,
            global::Portkey.UpdateDeploymentRequestStatus? status,
            object? deploymentConfig,
            bool? isDefault,
            bool? rotateAuth,
            bool? overrideExisting,
            global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>? authSettings)
        {
            this.Name = name;
            this.Type = type;
            this.Status = status;
            this.DeploymentConfig = deploymentConfig;
            this.IsDefault = isDefault;
            this.RotateAuth = rotateAuth;
            this.OverrideExisting = overrideExisting;
            this.AuthSettings = authSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequest" /> class.
        /// </summary>
        public UpdateDeploymentRequest()
        {
        }

    }
}