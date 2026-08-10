
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentAuthSettingsInput
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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dataservice_hosted")]
        public int? IsDataserviceHosted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_playground_proxy_allowed")]
        public int? IsPlaygroundProxyAllowed { get; set; }

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
        /// Initializes a new instance of the <see cref="DeploymentAuthSettingsInput" /> class.
        /// </summary>
        /// <param name="gatewayBaseUrl">
        /// Base URL of the self-hosted Gateway. Validated against the allowed-host rules.
        /// </param>
        /// <param name="mcpGatewayBaseUrl"></param>
        /// <param name="isDataserviceHosted"></param>
        /// <param name="isPlaygroundProxyAllowed"></param>
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
        public DeploymentAuthSettingsInput(
            string? gatewayBaseUrl,
            string? mcpGatewayBaseUrl,
            int? isDataserviceHosted,
            int? isPlaygroundProxyAllowed,
            global::System.Collections.Generic.IList<string>? workspacesAllowed,
            global::System.Collections.Generic.IList<string>? jwtSubsAllowed,
            global::System.Collections.Generic.Dictionary<string, string>? jwtSubWorkspaceMapping)
        {
            this.GatewayBaseUrl = gatewayBaseUrl;
            this.McpGatewayBaseUrl = mcpGatewayBaseUrl;
            this.IsDataserviceHosted = isDataserviceHosted;
            this.IsPlaygroundProxyAllowed = isPlaygroundProxyAllowed;
            this.WorkspacesAllowed = workspacesAllowed;
            this.JwtSubsAllowed = jwtSubsAllowed;
            this.JwtSubWorkspaceMapping = jwtSubWorkspaceMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentAuthSettingsInput" /> class.
        /// </summary>
        public DeploymentAuthSettingsInput()
        {
        }

    }
}