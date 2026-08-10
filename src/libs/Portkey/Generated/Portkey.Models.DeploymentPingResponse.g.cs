
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentPingResponse
    {
        /// <summary>
        /// `partial` when exactly one of the two checks passes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentPingResponseStatusJsonConverter))]
        public global::Portkey.DeploymentPingResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_base_url")]
        public string? GatewayBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::Portkey.DeploymentPingResponseOutbound? Outbound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound")]
        public global::Portkey.DeploymentPingResponseInbound? Inbound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentPingResponseObjectJsonConverter))]
        public global::Portkey.DeploymentPingResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPingResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// `partial` when exactly one of the two checks passes
        /// </param>
        /// <param name="gatewayBaseUrl"></param>
        /// <param name="outbound"></param>
        /// <param name="inbound"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPingResponse(
            global::Portkey.DeploymentPingResponseStatus? status,
            string? gatewayBaseUrl,
            global::Portkey.DeploymentPingResponseOutbound? outbound,
            global::Portkey.DeploymentPingResponseInbound? inbound,
            global::Portkey.DeploymentPingResponseObject? @object)
        {
            this.Status = status;
            this.GatewayBaseUrl = gatewayBaseUrl;
            this.Outbound = outbound;
            this.Inbound = inbound;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPingResponse" /> class.
        /// </summary>
        public DeploymentPingResponse()
        {
        }

    }
}