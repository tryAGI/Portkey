
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentDetailResponseVariant2
    {
        /// <summary>
        /// When `use_private_link_proxy` is enabled, the private link endpoint is returned as `gateway_base_url` and `private_link_endpoint` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>))]
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>? AuthSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_config")]
        public object? DeploymentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>? Workspaces { get; set; }

        /// <summary>
        /// Always masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Portkey.DeploymentCredentials? Credentials { get; set; }

        /// <summary>
        /// Always masked. Returned unmasked only on create and on `rotate_auth`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_auth")]
        public string? ClientAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponseVariant2" /> class.
        /// </summary>
        /// <param name="authSettings">
        /// When `use_private_link_proxy` is enabled, the private link endpoint is returned as `gateway_base_url` and `private_link_endpoint` is omitted.
        /// </param>
        /// <param name="deploymentConfig"></param>
        /// <param name="workspaces"></param>
        /// <param name="credentials">
        /// Always masked
        /// </param>
        /// <param name="clientAuth">
        /// Always masked. Returned unmasked only on create and on `rotate_auth`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentDetailResponseVariant2(
            global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>? authSettings,
            object? deploymentConfig,
            global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>? workspaces,
            global::Portkey.DeploymentCredentials? credentials,
            string? clientAuth)
        {
            this.AuthSettings = authSettings;
            this.DeploymentConfig = deploymentConfig;
            this.Workspaces = workspaces;
            this.Credentials = credentials;
            this.ClientAuth = clientAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponseVariant2" /> class.
        /// </summary>
        public DeploymentDetailResponseVariant2()
        {
        }

    }
}