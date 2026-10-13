
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessPolicySubjectDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicySubjectDetailsTypeJsonConverter))]
        public global::Portkey.AccessPolicySubjectDetailsType? Type { get; set; }

        /// <summary>
        /// Subject ID, or `ANY` when the policy matches every user or every agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name. Absent on `ANY` entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Present on `user` entries only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicySubjectDetails" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Subject ID, or `ANY` when the policy matches every user or every agent
        /// </param>
        /// <param name="name">
        /// Display name. Absent on `ANY` entries.
        /// </param>
        /// <param name="email">
        /// Present on `user` entries only
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPolicySubjectDetails(
            global::Portkey.AccessPolicySubjectDetailsType? type,
            string? id,
            string? name,
            string? email)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicySubjectDetails" /> class.
        /// </summary>
        public AccessPolicySubjectDetails()
        {
        }

    }
}