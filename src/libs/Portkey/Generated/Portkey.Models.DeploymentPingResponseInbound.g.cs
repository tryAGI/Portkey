
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentPingResponseInbound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentPingResponseInboundStatusJsonConverter))]
        public global::Portkey.DeploymentPingResponseInboundStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="DeploymentPingResponseInbound" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPingResponseInbound(
            global::Portkey.DeploymentPingResponseInboundStatus? status,
            string? error)
        {
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPingResponseInbound" /> class.
        /// </summary>
        public DeploymentPingResponseInbound()
        {
        }

    }
}