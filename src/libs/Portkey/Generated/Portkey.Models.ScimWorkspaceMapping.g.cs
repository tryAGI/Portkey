
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"id":"a1b2c3d4-e5f6-7890-abcd-ef1234567890","workspace_id":"ws-12345","scim_group":"Engineering Team","role":"member","scim_group_id":"d290f1ee-6c54-4b01-90e6-d701748f0851"}
    /// </summary>
    public sealed partial class ScimWorkspaceMapping
    {
        /// <summary>
        /// Unique ID of the mapping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ID of the mapped workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Display name of the SCIM group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group")]
        public string? ScimGroup { get; set; }

        /// <summary>
        /// Role assigned to group members
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter))]
        public global::Portkey.ScimWorkspaceMappingRole? Role { get; set; }

        /// <summary>
        /// ID of the SCIM group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_id")]
        public string? ScimGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimWorkspaceMapping" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the mapping
        /// </param>
        /// <param name="workspaceId">
        /// ID of the mapped workspace
        /// </param>
        /// <param name="scimGroup">
        /// Display name of the SCIM group
        /// </param>
        /// <param name="role">
        /// Role assigned to group members
        /// </param>
        /// <param name="scimGroupId">
        /// ID of the SCIM group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimWorkspaceMapping(
            string? id,
            string? workspaceId,
            string? scimGroup,
            global::Portkey.ScimWorkspaceMappingRole? role,
            string? scimGroupId)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.ScimGroup = scimGroup;
            this.Role = role;
            this.ScimGroupId = scimGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimWorkspaceMapping" /> class.
        /// </summary>
        public ScimWorkspaceMapping()
        {
        }

    }
}