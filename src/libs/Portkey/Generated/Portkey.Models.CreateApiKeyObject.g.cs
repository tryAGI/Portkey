
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyObject
    {
        /// <summary>
        /// Example: Development API Key
        /// </summary>
        /// <example>Development API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: API key for development environment
        /// </summary>
        /// <example>API key for development environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Organisation ID. Optional when calling via an org-level API key (picked from auth context).<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Example: ws-myworkspace
        /// </summary>
        /// <example>ws-myworkspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </summary>
        /// <example>c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? RateLimits { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::Portkey.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: [completions.write]
        /// </summary>
        /// <example>[completions.write]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::Portkey.CreateApiKeyObjectDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_emails")]
        public global::System.Collections.Generic.IList<string>? AlertEmails { get; set; }

        /// <summary>
        /// ISO 8601 datetime at which this key expires. Must not exceed the org/workspace maximum TTL if configured.<br/>
        /// Example: 2026-12-31T23:59:59Z
        /// </summary>
        /// <example>2026-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Automatic key rotation configuration. Requires either rotation_period or next_rotation_at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation_policy")]
        public global::Portkey.CreateApiKeyObjectRotationPolicy? RotationPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObject" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="organisationId">
        /// Organisation ID. Optional when calling via an org-level API key (picked from auth context).<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt">
        /// ISO 8601 datetime at which this key expires. Must not exceed the org/workspace maximum TTL if configured.<br/>
        /// Example: 2026-12-31T23:59:59Z
        /// </param>
        /// <param name="rotationPolicy">
        /// Automatic key rotation configuration. Requires either rotation_period or next_rotation_at.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyObject(
            string name,
            global::System.Collections.Generic.IList<string> scopes,
            string? description,
            global::System.Guid? organisationId,
            string? workspaceId,
            global::System.Guid? userId,
            global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? rateLimits,
            global::Portkey.UsageLimits? usageLimits,
            global::Portkey.CreateApiKeyObjectDefaults? defaults,
            global::System.Collections.Generic.IList<string>? alertEmails,
            global::System.DateTime? expiresAt,
            global::Portkey.CreateApiKeyObjectRotationPolicy? rotationPolicy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.UserId = userId;
            this.RateLimits = rateLimits;
            this.UsageLimits = usageLimits;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Defaults = defaults;
            this.AlertEmails = alertEmails;
            this.ExpiresAt = expiresAt;
            this.RotationPolicy = rotationPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObject" /> class.
        /// </summary>
        public CreateApiKeyObject()
        {
        }
    }
}