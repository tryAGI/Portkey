
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentAuthSettings
    {
        /// <summary>
        /// Base URL of the self-hosted Gateway. Validated against the allowed-host rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_base_url")]
        public string? GatewayBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_gateway_base_url")]
        public string? McpGatewayBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_link_endpoint")]
        public string? PrivateLinkEndpoint { get; set; }

        /// <summary>
        /// When enabled, `gateway_base_url` and `private_link_endpoint` are both required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_private_link_proxy")]
        public int? UsePrivateLinkProxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dataservice_hosted")]
        public int? IsDataserviceHosted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playground_proxy_allowed")]
        public int? IsPlaygroundProxyAllowed { get; set; }

        /// <summary>
        /// Defaults to the organisation-level setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_portkey_gateway")]
        public int? DisablePortkeyGateway { get; set; }

        /// <summary>
        /// Workspace slugs this deployment may serve. Empty means all workspaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces_allowed")]
        public global::System.Collections.Generic.IList<string>? WorkspacesAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_subs_allowed")]
        public global::System.Collections.Generic.IList<string>? JwtSubsAllowed { get; set; }

        /// <summary>
        /// Maps a JWT `sub` to a workspace slug. Subs and workspaces here are merged into the allowed lists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_sub_workspace_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? JwtSubWorkspaceMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentAuthSettings" /> class.
        /// </summary>
        /// <param name="gatewayBaseUrl">
        /// Base URL of the self-hosted Gateway. Validated against the allowed-host rules.
        /// </param>
        /// <param name="mcpGatewayBaseUrl"></param>
        /// <param name="privateLinkEndpoint"></param>
        /// <param name="usePrivateLinkProxy">
        /// When enabled, `gateway_base_url` and `private_link_endpoint` are both required.
        /// </param>
        /// <param name="isDataserviceHosted"></param>
        /// <param name="isPlaygroundProxyAllowed"></param>
        /// <param name="disablePortkeyGateway">
        /// Defaults to the organisation-level setting.
        /// </param>
        /// <param name="workspacesAllowed">
        /// Workspace slugs this deployment may serve. Empty means all workspaces.
        /// </param>
        /// <param name="jwtSubsAllowed"></param>
        /// <param name="jwtSubWorkspaceMapping">
        /// Maps a JWT `sub` to a workspace slug. Subs and workspaces here are merged into the allowed lists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentAuthSettings(
            string? gatewayBaseUrl,
            string? mcpGatewayBaseUrl,
            string? privateLinkEndpoint,
            int? usePrivateLinkProxy,
            int? isDataserviceHosted,
            int? isPlaygroundProxyAllowed,
            int? disablePortkeyGateway,
            global::System.Collections.Generic.IList<string>? workspacesAllowed,
            global::System.Collections.Generic.IList<string>? jwtSubsAllowed,
            global::System.Collections.Generic.Dictionary<string, string>? jwtSubWorkspaceMapping)
        {
            this.GatewayBaseUrl = gatewayBaseUrl;
            this.McpGatewayBaseUrl = mcpGatewayBaseUrl;
            this.PrivateLinkEndpoint = privateLinkEndpoint;
            this.UsePrivateLinkProxy = usePrivateLinkProxy;
            this.IsDataserviceHosted = isDataserviceHosted;
            this.IsPlaygroundProxyAllowed = isPlaygroundProxyAllowed;
            this.DisablePortkeyGateway = disablePortkeyGateway;
            this.WorkspacesAllowed = workspacesAllowed;
            this.JwtSubsAllowed = jwtSubsAllowed;
            this.JwtSubWorkspaceMapping = jwtSubWorkspaceMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentAuthSettings" /> class.
        /// </summary>
        public DeploymentAuthSettings()
        {
        }

    }
}