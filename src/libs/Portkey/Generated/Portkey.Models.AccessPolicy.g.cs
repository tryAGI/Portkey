
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessPolicy
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyEffectJsonConverter))]
        public global::Portkey.AccessPolicyEffect? Effect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjects")]
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubjectDetails>? Subjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget>? Targets { get; set; }

        /// <summary>
        /// Incremented on every update; send it back on Update Access Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyStatusJsonConverter))]
        public global::Portkey.AccessPolicyStatus? Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyObjectJsonConverter))]
        public global::Portkey.AccessPolicyObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicy" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="effect"></param>
        /// <param name="subjects"></param>
        /// <param name="targets"></param>
        /// <param name="version">
        /// Incremented on every update; send it back on Update Access Policy
        /// </param>
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
        public AccessPolicy(
            global::System.Guid? id,
            string? name,
            string? description,
            bool? enabled,
            global::Portkey.AccessPolicyEffect? effect,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubjectDetails>? subjects,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget>? targets,
            int? version,
            global::Portkey.AccessPolicyStatus? status,
            global::System.Guid? workspaceId,
            global::System.Guid? organisationId,
            string? createdBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::Portkey.AccessPolicyObject? @object)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Effect = effect;
            this.Subjects = subjects;
            this.Targets = targets;
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
        /// Initializes a new instance of the <see cref="AccessPolicy" /> class.
        /// </summary>
        public AccessPolicy()
        {
        }

    }
}