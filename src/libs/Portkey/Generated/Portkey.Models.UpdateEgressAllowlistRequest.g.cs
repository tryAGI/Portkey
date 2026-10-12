
#nullable enable

namespace Portkey
{
    /// <summary>
    /// At least one field must be provided.
    /// </summary>
    public sealed partial class UpdateEgressAllowlistRequest
    {
        /// <summary>
        /// An exact hostname, an IP literal (IPv4 or IPv6, optionally bracketed), or a `*.` wildcard.<br/>
        /// No scheme, path, credentials, or port. Stored trimmed and lowercased.<br/>
        /// Cloud-metadata addresses and hostnames are rejected.<br/>
        /// Example: *.internal.example.com
        /// </summary>
        /// <example>*.internal.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEgressAllowlistRequest" /> class.
        /// </summary>
        /// <param name="domain">
        /// An exact hostname, an IP literal (IPv4 or IPv6, optionally bracketed), or a `*.` wildcard.<br/>
        /// No scheme, path, credentials, or port. Stored trimmed and lowercased.<br/>
        /// Cloud-metadata addresses and hostnames are rejected.<br/>
        /// Example: *.internal.example.com
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEgressAllowlistRequest(
            string? domain,
            string? description)
        {
            this.Domain = domain;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEgressAllowlistRequest" /> class.
        /// </summary>
        public UpdateEgressAllowlistRequest()
        {
        }

    }
}