
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEgressAllowlistRequest
    {
        /// <summary>
        /// An exact hostname, an IP literal (IPv4 or IPv6, optionally bracketed), or a `*.` wildcard.<br/>
        /// No scheme, path, credentials, or port. Stored trimmed and lowercased.<br/>
        /// Cloud-metadata addresses and hostnames are rejected.<br/>
        /// Example: *.internal.example.com
        /// </summary>
        /// <example>*.internal.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateEgressAllowlistRequest" /> class.
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
        public CreateEgressAllowlistRequest(
            string domain,
            string? description)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEgressAllowlistRequest" /> class.
        /// </summary>
        public CreateEgressAllowlistRequest()
        {
        }

    }
}