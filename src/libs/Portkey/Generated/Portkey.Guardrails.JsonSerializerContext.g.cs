
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateGuardrailRequestTarget), TypeInfoPropertyName = "CreateGuardrailRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailActions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailActionsOnSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailActionsOnSuccessFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailActionsOnFail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailActionsOnFailFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailCheckId), TypeInfoPropertyName = "GuardrailCheckId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JWTParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelWhitelistParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RegexMatchParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SentenceCountParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WordCountParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CharacterCountParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JSONSchemaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JSONKeysParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValidUrlsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsCodeParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EndsWithParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UppercaseParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RequiredMetadataKeysParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllowedRequestTypesParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SydeGuardParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AporiaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PillarScanParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PatronusParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PatronusCustomParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyModerationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyLanguageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyPIIParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MistralModerationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockGuardParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptfooParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureContentSafetyParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzurePIIParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PANWPrismaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BasicParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListGuardrailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryTarget), TypeInfoPropertyName = "GuardrailSummaryTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryStatus), TypeInfoPropertyName = "GuardrailSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetails), TypeInfoPropertyName = "GuardrailDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetailsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerMappingRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerMappingRunOnItem), TypeInfoPropertyName = "McpServerMappingRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkSyncMcpServerMappingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem), TypeInfoPropertyName = "BulkSyncMcpServerMappingsRequestMcpServersRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkSyncMcpServerMappingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpsertMcpServerMappingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem), TypeInfoPropertyName = "UpsertMcpServerMappingRequestRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpsertMcpServerMappingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JSONKeysParametersOperator), TypeInfoPropertyName = "JSONKeysParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsParametersOperator), TypeInfoPropertyName = "ContainsParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsCodeParametersFormat), TypeInfoPropertyName = "ContainsCodeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RequiredMetadataKeysParametersOperator), TypeInfoPropertyName = "RequiredMetadataKeysParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllowedRequestTypesParametersAllowedType), TypeInfoPropertyName = "AllowedRequestTypesParametersAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllowedRequestTypesParametersBlockedType), TypeInfoPropertyName = "AllowedRequestTypesParametersBlockedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PillarScanParametersScanner), TypeInfoPropertyName = "PillarScanParametersScanner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyModerationParametersCategorie), TypeInfoPropertyName = "PortkeyModerationParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyLanguageParametersLanguage), TypeInfoPropertyName = "PortkeyLanguageParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyPIIParametersCategorie), TypeInfoPropertyName = "PortkeyPIIParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MistralModerationParametersCategorie), TypeInfoPropertyName = "MistralModerationParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersLanguageValues), TypeInfoPropertyName = "AcuvityScanParametersLanguageValues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersPiiCategorie), TypeInfoPropertyName = "AcuvityScanParametersPiiCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersSecretsCategorie), TypeInfoPropertyName = "AcuvityScanParametersSecretsCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureContentSafetyParametersCategorie), TypeInfoPropertyName = "AzureContentSafetyParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzurePIIParametersDomain), TypeInfoPropertyName = "AzurePIIParametersDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateGuardrailRequestTarget?), TypeInfoPropertyName = "NullableCreateGuardrailRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailCheckId?), TypeInfoPropertyName = "NullableGuardrailCheckId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryTarget?), TypeInfoPropertyName = "NullableGuardrailSummaryTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryStatus?), TypeInfoPropertyName = "NullableGuardrailSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetails?), TypeInfoPropertyName = "NullableGuardrailDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerMappingRunOnItem?), TypeInfoPropertyName = "NullableMcpServerMappingRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem?), TypeInfoPropertyName = "NullableBulkSyncMcpServerMappingsRequestMcpServersRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem?), TypeInfoPropertyName = "NullableUpsertMcpServerMappingRequestRunOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JSONKeysParametersOperator?), TypeInfoPropertyName = "NullableJSONKeysParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsParametersOperator?), TypeInfoPropertyName = "NullableContainsParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ContainsCodeParametersFormat?), TypeInfoPropertyName = "NullableContainsCodeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RequiredMetadataKeysParametersOperator?), TypeInfoPropertyName = "NullableRequiredMetadataKeysParametersOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllowedRequestTypesParametersAllowedType?), TypeInfoPropertyName = "NullableAllowedRequestTypesParametersAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllowedRequestTypesParametersBlockedType?), TypeInfoPropertyName = "NullableAllowedRequestTypesParametersBlockedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PillarScanParametersScanner?), TypeInfoPropertyName = "NullablePillarScanParametersScanner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyModerationParametersCategorie?), TypeInfoPropertyName = "NullablePortkeyModerationParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyLanguageParametersLanguage?), TypeInfoPropertyName = "NullablePortkeyLanguageParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyPIIParametersCategorie?), TypeInfoPropertyName = "NullablePortkeyPIIParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MistralModerationParametersCategorie?), TypeInfoPropertyName = "NullableMistralModerationParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersLanguageValues?), TypeInfoPropertyName = "NullableAcuvityScanParametersLanguageValues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersPiiCategorie?), TypeInfoPropertyName = "NullableAcuvityScanParametersPiiCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AcuvityScanParametersSecretsCategorie?), TypeInfoPropertyName = "NullableAcuvityScanParametersSecretsCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureContentSafetyParametersCategorie?), TypeInfoPropertyName = "NullableAzureContentSafetyParametersCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzurePIIParametersDomain?), TypeInfoPropertyName = "NullableAzurePIIParametersDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GuardrailCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GuardrailSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerMappingRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersAllowedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersBlockedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PillarScanParametersScanner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PortkeyModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PortkeyPIIParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MistralModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersPiiCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersSecretsCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AzureContentSafetyParametersCategorie>))]
    internal sealed partial class GuardrailsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GuardrailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GuardrailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailDetailsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Portkey.CreateGuardrailRequestTarget)

                    || typeToConvert == typeof(global::Portkey.CreateGuardrailRequestTarget?)

                    || typeToConvert == typeof(global::Portkey.GuardrailCheckId)

                    || typeToConvert == typeof(global::Portkey.GuardrailCheckId?)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryTarget)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryTarget?)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus?)

                    || typeToConvert == typeof(global::Portkey.McpServerMappingRunOnItem)

                    || typeToConvert == typeof(global::Portkey.McpServerMappingRunOnItem?)

                    || typeToConvert == typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem)

                    || typeToConvert == typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem?)

                    || typeToConvert == typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem)

                    || typeToConvert == typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem?)

                    || typeToConvert == typeof(global::Portkey.JSONKeysParametersOperator)

                    || typeToConvert == typeof(global::Portkey.JSONKeysParametersOperator?)

                    || typeToConvert == typeof(global::Portkey.ContainsParametersOperator)

                    || typeToConvert == typeof(global::Portkey.ContainsParametersOperator?)

                    || typeToConvert == typeof(global::Portkey.ContainsCodeParametersFormat)

                    || typeToConvert == typeof(global::Portkey.ContainsCodeParametersFormat?)

                    || typeToConvert == typeof(global::Portkey.RequiredMetadataKeysParametersOperator)

                    || typeToConvert == typeof(global::Portkey.RequiredMetadataKeysParametersOperator?)

                    || typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersAllowedType)

                    || typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersAllowedType?)

                    || typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersBlockedType)

                    || typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersBlockedType?)

                    || typeToConvert == typeof(global::Portkey.PillarScanParametersScanner)

                    || typeToConvert == typeof(global::Portkey.PillarScanParametersScanner?)

                    || typeToConvert == typeof(global::Portkey.PortkeyModerationParametersCategorie)

                    || typeToConvert == typeof(global::Portkey.PortkeyModerationParametersCategorie?)

                    || typeToConvert == typeof(global::Portkey.PortkeyLanguageParametersLanguage)

                    || typeToConvert == typeof(global::Portkey.PortkeyLanguageParametersLanguage?)

                    || typeToConvert == typeof(global::Portkey.PortkeyPIIParametersCategorie)

                    || typeToConvert == typeof(global::Portkey.PortkeyPIIParametersCategorie?)

                    || typeToConvert == typeof(global::Portkey.MistralModerationParametersCategorie)

                    || typeToConvert == typeof(global::Portkey.MistralModerationParametersCategorie?)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersLanguageValues)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersLanguageValues?)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersPiiCategorie)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersPiiCategorie?)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersSecretsCategorie)

                    || typeToConvert == typeof(global::Portkey.AcuvityScanParametersSecretsCategorie?)

                    || typeToConvert == typeof(global::Portkey.AzureContentSafetyParametersCategorie)

                    || typeToConvert == typeof(global::Portkey.AzureContentSafetyParametersCategorie?)

                    || typeToConvert == typeof(global::Portkey.AzurePIIParametersDomain)

                    || typeToConvert == typeof(global::Portkey.AzurePIIParametersDomain?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateGuardrailRequestTarget))
                {
                    return new global::Portkey.JsonConverters.CreateGuardrailRequestTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateGuardrailRequestTarget?))
                {
                    return new global::Portkey.JsonConverters.CreateGuardrailRequestTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailCheckId))
                {
                    return new global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailCheckId?))
                {
                    return new global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryTarget))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryTarget?))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus?))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerMappingRunOnItem))
                {
                    return new global::Portkey.JsonConverters.McpServerMappingRunOnItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerMappingRunOnItem?))
                {
                    return new global::Portkey.JsonConverters.McpServerMappingRunOnItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem))
                {
                    return new global::Portkey.JsonConverters.BulkSyncMcpServerMappingsRequestMcpServersRunOnItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem?))
                {
                    return new global::Portkey.JsonConverters.BulkSyncMcpServerMappingsRequestMcpServersRunOnItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem))
                {
                    return new global::Portkey.JsonConverters.UpsertMcpServerMappingRequestRunOnItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpsertMcpServerMappingRequestRunOnItem?))
                {
                    return new global::Portkey.JsonConverters.UpsertMcpServerMappingRequestRunOnItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.JSONKeysParametersOperator))
                {
                    return new global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.JSONKeysParametersOperator?))
                {
                    return new global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ContainsParametersOperator))
                {
                    return new global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ContainsParametersOperator?))
                {
                    return new global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ContainsCodeParametersFormat))
                {
                    return new global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ContainsCodeParametersFormat?))
                {
                    return new global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RequiredMetadataKeysParametersOperator))
                {
                    return new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RequiredMetadataKeysParametersOperator?))
                {
                    return new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersAllowedType))
                {
                    return new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersAllowedType?))
                {
                    return new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersBlockedType))
                {
                    return new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AllowedRequestTypesParametersBlockedType?))
                {
                    return new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PillarScanParametersScanner))
                {
                    return new global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PillarScanParametersScanner?))
                {
                    return new global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyModerationParametersCategorie))
                {
                    return new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyModerationParametersCategorie?))
                {
                    return new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyLanguageParametersLanguage))
                {
                    return new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyLanguageParametersLanguage?))
                {
                    return new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyPIIParametersCategorie))
                {
                    return new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PortkeyPIIParametersCategorie?))
                {
                    return new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MistralModerationParametersCategorie))
                {
                    return new global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MistralModerationParametersCategorie?))
                {
                    return new global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersLanguageValues))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersLanguageValues?))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersPiiCategorie))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersPiiCategorie?))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersSecretsCategorie))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AcuvityScanParametersSecretsCategorie?))
                {
                    return new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureContentSafetyParametersCategorie))
                {
                    return new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureContentSafetyParametersCategorie?))
                {
                    return new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzurePIIParametersDomain))
                {
                    return new global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzurePIIParametersDomain?))
                {
                    return new global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new GuardrailsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}