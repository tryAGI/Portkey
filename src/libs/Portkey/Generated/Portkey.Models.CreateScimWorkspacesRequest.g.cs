
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateScimWorkspacesRequest
    {
        /// <summary>
        /// ID or slug (ws_ prefix) of the workspace to map the SCIM group to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Role assigned to group members in the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.CreateScimWorkspacesRequestRole Role { get; set; }

        /// <summary>
        /// ID of an existing SCIM group. Required if scim_group_name is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_id")]
        public string? ScimGroupId { get; set; }

        /// <summary>
        /// Display name for the SCIM group. If the group doesn't exist, it will be created. Required if scim_group_id is not provided. Must not match the pattern-based auto-provisioning format (e.g. ws-name-role-admin).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_name")]
        public string? ScimGroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScimWorkspacesRequest" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// ID or slug (ws_ prefix) of the workspace to map the SCIM group to.
        /// </param>
        /// <param name="role">
        /// Role assigned to group members in the workspace.
        /// </param>
        /// <param name="scimGroupId">
        /// ID of an existing SCIM group. Required if scim_group_name is not provided.
        /// </param>
        /// <param name="scimGroupName">
        /// Display name for the SCIM group. If the group doesn't exist, it will be created. Required if scim_group_id is not provided. Must not match the pattern-based auto-provisioning format (e.g. ws-name-role-admin).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScimWorkspacesRequest(
            string workspaceId,
            global::Portkey.CreateScimWorkspacesRequestRole role,
            string? scimGroupId,
            string? scimGroupName)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Role = role;
            this.ScimGroupId = scimGroupId;
            this.ScimGroupName = scimGroupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScimWorkspacesRequest" /> class.
        /// </summary>
        public CreateScimWorkspacesRequest()
        {
        }

    }
}