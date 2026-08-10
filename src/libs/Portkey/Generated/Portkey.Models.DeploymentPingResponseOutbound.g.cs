
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentPingResponseOutbound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentPingResponseOutboundStatusJsonConverter))]
        public global::Portkey.DeploymentPingResponseOutboundStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gateway version reported by `/v1/health`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPingResponseOutbound" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statusCode"></param>
        /// <param name="version">
        /// Gateway version reported by `/v1/health`
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPingResponseOutbound(
            global::Portkey.DeploymentPingResponseOutboundStatus? status,
            int? statusCode,
            string? version,
            string? error)
        {
            this.Status = status;
            this.StatusCode = statusCode;
            this.Version = version;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPingResponseOutbound" /> class.
        /// </summary>
        public DeploymentPingResponseOutbound()
        {
        }

    }
}