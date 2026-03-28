
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsAssumedRoleAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter))]
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRoleArn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumedRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="awsAuthType"></param>
        /// <param name="awsRoleArn"></param>
        /// <param name="awsExternalId"></param>
        /// <param name="awsRegion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsAssumedRoleAuthConfig(
            string awsRoleArn,
            string awsRegion,
            global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType awsAuthType,
            string? awsExternalId)
        {
            this.AwsRoleArn = awsRoleArn ?? throw new global::System.ArgumentNullException(nameof(awsRoleArn));
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
            this.AwsAuthType = awsAuthType;
            this.AwsExternalId = awsExternalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumedRoleAuthConfig" /> class.
        /// </summary>
        public AwsAssumedRoleAuthConfig()
        {
        }
    }
}