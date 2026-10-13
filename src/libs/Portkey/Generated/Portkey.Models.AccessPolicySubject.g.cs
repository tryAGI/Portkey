
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"type":"user","id":"8f1c2a4e-1b2c-4d3e-9f00-1a2b3c4d5e6f"}
    /// </summary>
    public sealed partial class AccessPolicySubject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicySubjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AccessPolicySubjectType Type { get; set; }

        /// <summary>
        /// ID of the user, group, or agent. Use `ANY` to match every user (`type: user`) or every agent (`type: agent`).<br/>
        /// The user side and the agent side are matched independently; if a side has no entries, the policy matches requests without a principal on that side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicySubject" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// ID of the user, group, or agent. Use `ANY` to match every user (`type: user`) or every agent (`type: agent`).<br/>
        /// The user side and the agent side are matched independently; if a side has no entries, the policy matches requests without a principal on that side.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPolicySubject(
            global::Portkey.AccessPolicySubjectType type,
            string id)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicySubject" /> class.
        /// </summary>
        public AccessPolicySubject()
        {
        }

    }
}