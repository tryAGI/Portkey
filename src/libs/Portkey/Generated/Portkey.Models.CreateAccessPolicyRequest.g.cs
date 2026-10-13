
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAccessPolicyRequest
    {
        /// <summary>
        /// Workspace ID or slug. Required when using an organisation-level API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Unique within the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Inferred when omitted (see endpoint description)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateAccessPolicyRequestEffectJsonConverter))]
        public global::Portkey.CreateAccessPolicyRequestEffect? Effect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject> Subjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget> Targets { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessPolicyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique within the workspace
        /// </param>
        /// <param name="subjects"></param>
        /// <param name="targets"></param>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required when using an organisation-level API key.
        /// </param>
        /// <param name="description"></param>
        /// <param name="effect">
        /// Inferred when omitted (see endpoint description)
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessPolicyRequest(
            string name,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject> subjects,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget> targets,
            string? workspaceId,
            string? description,
            global::Portkey.CreateAccessPolicyRequestEffect? effect,
            bool? enabled)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Effect = effect;
            this.Subjects = subjects ?? throw new global::System.ArgumentNullException(nameof(subjects));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessPolicyRequest" /> class.
        /// </summary>
        public CreateAccessPolicyRequest()
        {
        }

    }
}