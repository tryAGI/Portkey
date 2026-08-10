
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Gateway authentication token. Returned unmasked only on create and on `rotate_auth`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_auth")]
        public string? ClientAuth { get; set; }

        /// <summary>
        /// Present only when the organisation has registry credentials configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Portkey.DeploymentCredentials? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentCreateResponseObjectJsonConverter))]
        public global::Portkey.DeploymentCreateResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentCreateResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organisationId"></param>
        /// <param name="clientAuth">
        /// Gateway authentication token. Returned unmasked only on create and on `rotate_auth`.
        /// </param>
        /// <param name="credentials">
        /// Present only when the organisation has registry credentials configured.
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentCreateResponse(
            global::System.Guid? id,
            global::System.Guid? organisationId,
            string? clientAuth,
            global::Portkey.DeploymentCredentials? credentials,
            global::Portkey.DeploymentCreateResponseObject? @object)
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.ClientAuth = clientAuth;
            this.Credentials = credentials;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentCreateResponse" /> class.
        /// </summary>
        public DeploymentCreateResponse()
        {
        }

    }
}