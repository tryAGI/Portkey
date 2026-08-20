
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsProviderResponseDataItem
    {
        /// <summary>
        /// The virtual key (provider) for which the data is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Total requests made for this provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsProviderResponseDataItem" /> class.
        /// </summary>
        /// <param name="provider">
        /// The virtual key (provider) for which the data is calculated
        /// </param>
        /// <param name="requests">
        /// Total requests made for this provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsProviderResponseDataItem(
            string? provider,
            int? requests)
        {
            this.Provider = provider;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsProviderResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsProviderResponseDataItem()
        {
        }

    }
}