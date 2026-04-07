
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RotateApiKeyResponse
    {
        /// <summary>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Newly rotated API key value.<br/>
        /// Example: pk_live_new_rotated_key_value
        /// </summary>
        /// <example>pk_live_new_rotated_key_value</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Timestamp when the previous key version stops being accepted.<br/>
        /// Example: 2026-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2026-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_transition_expires_at")]
        public global::System.DateTime? KeyTransitionExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="key">
        /// Newly rotated API key value.<br/>
        /// Example: pk_live_new_rotated_key_value
        /// </param>
        /// <param name="keyTransitionExpiresAt">
        /// Timestamp when the previous key version stops being accepted.<br/>
        /// Example: 2026-01-15T10:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyResponse(
            global::System.Guid? id,
            string? key,
            global::System.DateTime? keyTransitionExpiresAt)
        {
            this.Id = id;
            this.Key = key;
            this.KeyTransitionExpiresAt = keyTransitionExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse" /> class.
        /// </summary>
        public RotateApiKeyResponse()
        {
        }
    }
}