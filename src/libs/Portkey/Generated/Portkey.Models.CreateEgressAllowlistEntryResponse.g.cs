
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEgressAllowlistEntryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Normalized (trimmed, lowercased) domain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateEgressAllowlistEntryResponseObjectJsonConverter))]
        public global::Portkey.CreateEgressAllowlistEntryResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEgressAllowlistEntryResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="domain">
        /// Normalized (trimmed, lowercased) domain
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEgressAllowlistEntryResponse(
            global::System.Guid? id,
            string? domain,
            global::Portkey.CreateEgressAllowlistEntryResponseObject? @object)
        {
            this.Id = id;
            this.Domain = domain;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEgressAllowlistEntryResponse" /> class.
        /// </summary>
        public CreateEgressAllowlistEntryResponse()
        {
        }

    }
}