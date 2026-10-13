
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessPolicyListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyListItemEffectJsonConverter))]
        public global::Portkey.AccessPolicyListItemEffect? Effect { get; set; }

        /// <summary>
        /// Whether the policy applies to every user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_users")]
        public bool? AllowAllUsers { get; set; }

        /// <summary>
        /// Whether the policy applies to every agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_agents")]
        public bool? AllowAllAgents { get; set; }

        /// <summary>
        /// Number of MCP server targets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_server_count")]
        public int? TargetServerCount { get; set; }

        /// <summary>
        /// Number of provider targets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_provider_count")]
        public int? TargetProviderCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyListItemStatusJsonConverter))]
        public global::Portkey.AccessPolicyListItemStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyListItemObjectJsonConverter))]
        public global::Portkey.AccessPolicyListItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="effect"></param>
        /// <param name="allowAllUsers">
        /// Whether the policy applies to every user
        /// </param>
        /// <param name="allowAllAgents">
        /// Whether the policy applies to every agent
        /// </param>
        /// <param name="targetServerCount">
        /// Number of MCP server targets
        /// </param>
        /// <param name="targetProviderCount">
        /// Number of provider targets
        /// </param>
        /// <param name="version"></param>
        /// <param name="status"></param>
        /// <param name="workspaceId"></param>
        /// <param name="organisationId"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPolicyListItem(
            global::System.Guid? id,
            string? name,
            string? description,
            bool? enabled,
            global::Portkey.AccessPolicyListItemEffect? effect,
            bool? allowAllUsers,
            bool? allowAllAgents,
            int? targetServerCount,
            int? targetProviderCount,
            int? version,
            global::Portkey.AccessPolicyListItemStatus? status,
            global::System.Guid? workspaceId,
            global::System.Guid? organisationId,
            string? createdBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::Portkey.AccessPolicyListItemObject? @object)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Effect = effect;
            this.AllowAllUsers = allowAllUsers;
            this.AllowAllAgents = allowAllAgents;
            this.TargetServerCount = targetServerCount;
            this.TargetProviderCount = targetProviderCount;
            this.Version = version;
            this.Status = status;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyListItem" /> class.
        /// </summary>
        public AccessPolicyListItem()
        {
        }

    }
}