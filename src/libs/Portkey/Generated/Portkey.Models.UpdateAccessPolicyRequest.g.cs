
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAccessPolicyRequest
    {
        /// <summary>
        /// Current version of the policy, as returned by Get Access Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

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
        /// Keeps the stored effect when omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateAccessPolicyRequestEffectJsonConverter))]
        public global::Portkey.UpdateAccessPolicyRequestEffect? Effect { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessPolicyRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Current version of the policy, as returned by Get Access Policy
        /// </param>
        /// <param name="subjects"></param>
        /// <param name="targets"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="effect">
        /// Keeps the stored effect when omitted
        /// </param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAccessPolicyRequest(
            int version,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject> subjects,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget> targets,
            string? name,
            string? description,
            global::Portkey.UpdateAccessPolicyRequestEffect? effect,
            bool? enabled)
        {
            this.Version = version;
            this.Name = name;
            this.Description = description;
            this.Effect = effect;
            this.Subjects = subjects ?? throw new global::System.ArgumentNullException(nameof(subjects));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessPolicyRequest" /> class.
        /// </summary>
        public UpdateAccessPolicyRequest()
        {
        }

    }
}