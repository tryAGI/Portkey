
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessPolicyProviderTarget
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyProviderTargetTypeJsonConverter))]
        public global::Portkey.AccessPolicyProviderTargetType Type { get; set; }

        /// <summary>
        /// Provider ID or slug in the workspace. Responses always return the ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// `ALL` for every model on the provider, or a non-empty list of model slugs. Defaults to `ALL` when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.IList<string>>))]
        public global::Portkey.OneOf<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.IList<string>>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyProviderTarget" /> class.
        /// </summary>
        /// <param name="providerId">
        /// Provider ID or slug in the workspace. Responses always return the ID.
        /// </param>
        /// <param name="type"></param>
        /// <param name="models">
        /// `ALL` for every model on the provider, or a non-empty list of model slugs. Defaults to `ALL` when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPolicyProviderTarget(
            string providerId,
            global::Portkey.AccessPolicyProviderTargetType type,
            global::Portkey.OneOf<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.IList<string>>? models)
        {
            this.Type = type;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyProviderTarget" /> class.
        /// </summary>
        public AccessPolicyProviderTarget()
        {
        }

    }
}