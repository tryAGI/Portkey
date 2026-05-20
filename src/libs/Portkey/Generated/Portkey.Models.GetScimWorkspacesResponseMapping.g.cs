
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScimWorkspacesResponseMapping
    {
        /// <summary>
        /// Unique ID of the SCIM workspace mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ID of the mapped workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Display name of the SCIM group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group")]
        public string? ScimGroup { get; set; }

        /// <summary>
        /// ID of the SCIM group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_id")]
        public string? ScimGroupId { get; set; }

        /// <summary>
        /// Role assigned to group members in the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter))]
        public global::Portkey.GetScimWorkspacesResponseMappingRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimWorkspacesResponseMapping" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the SCIM workspace mapping.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the mapped workspace.
        /// </param>
        /// <param name="scimGroup">
        /// Display name of the SCIM group.
        /// </param>
        /// <param name="scimGroupId">
        /// ID of the SCIM group.
        /// </param>
        /// <param name="role">
        /// Role assigned to group members in the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScimWorkspacesResponseMapping(
            string? id,
            string? workspaceId,
            string? scimGroup,
            string? scimGroupId,
            global::Portkey.GetScimWorkspacesResponseMappingRole? role)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.ScimGroup = scimGroup;
            this.ScimGroupId = scimGroupId;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimWorkspacesResponseMapping" /> class.
        /// </summary>
        public GetScimWorkspacesResponseMapping()
        {
        }

    }
}