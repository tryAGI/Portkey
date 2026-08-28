
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelPricingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelPayAsYouGo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelCalculateConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelPricingConfigCurrency), TypeInfoPropertyName = "ModelPricingConfigCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelFinetuneConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelTokenPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelCalculateOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelCalculateOperationOperation), TypeInfoPropertyName = "ModelCalculateOperationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>), TypeInfoPropertyName = "OneOfModelCalculateOperationModelValueReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelValueReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole), TypeInfoPropertyName = "InviteRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateInviteWorkspaceApiKeyDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteRole), TypeInfoPropertyName = "WorkspaceInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteType), TypeInfoPropertyName = "WorkspaceInviteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SuccessInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsResponseObject), TypeInfoPropertyName = "ListModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Model11>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Model11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequestModel), TypeInfoPropertyName = "CreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>), TypeInfoPropertyName = "OneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>), TypeInfoPropertyName = "DictionaryStringDouble_System_Collections_Generic_Dictionary_string_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseObject), TypeInfoPropertyName = "CreateCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType), TypeInfoPropertyName = "ChatCompletionMessageContentPartThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType), TypeInfoPropertyName = "ChatCompletionMessageContentPartRedactedThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessage), TypeInfoPropertyName = "ChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessageRole), TypeInfoPropertyName = "ChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole), TypeInfoPropertyName = "ChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessageRole), TypeInfoPropertyName = "ChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolType), TypeInfoPropertyName = "FileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>), TypeInfoPropertyName = "OneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptionsRanker), TypeInfoPropertyName = "FileSearchToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallType), TypeInfoPropertyName = "FileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallStatus), TypeInfoPropertyName = "FileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole), TypeInfoPropertyName = "FineTuneChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessageRole), TypeInfoPropertyName = "ChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole), TypeInfoPropertyName = "ChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestFunctionMessage), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionFunctionCallOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOption), TypeInfoPropertyName = "ChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum), TypeInfoPropertyName = "ChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputAudioType), TypeInfoPropertyName = "OutputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputContent), TypeInfoPropertyName = "OutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Refusal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItem), TypeInfoPropertyName = "OutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminatorType), TypeInfoPropertyName = "OutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputTextType), TypeInfoPropertyName = "OutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Annotation), TypeInfoPropertyName = "Annotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallChunkType), TypeInfoPropertyName = "ChatCompletionMessageToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallChunkFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRole), TypeInfoPropertyName = "ChatCompletionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentBlock), TypeInfoPropertyName = "ChatCompletionMessageContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageRole), TypeInfoPropertyName = "ChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole), TypeInfoPropertyName = "ChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestModel), TypeInfoPropertyName = "CreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>), TypeInfoPropertyName = "OneOfResponseFormatTextResponseFormatJsonSchemaResponseFormatJsonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinkingType), TypeInfoPropertyName = "CreateChatCompletionRequestThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestFunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestFunctionCall), TypeInfoPropertyName = "CreateChatCompletionRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseObject), TypeInfoPropertyName = "CreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionFunctionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponseObject), TypeInfoPropertyName = "CreateChatCompletionFunctionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject), TypeInfoPropertyName = "ListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionStreamResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseObject), TypeInfoPropertyName = "CreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestModel), TypeInfoPropertyName = "CreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestQuality), TypeInfoPropertyName = "CreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestResponseFormat), TypeInfoPropertyName = "CreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestSize), TypeInfoPropertyName = "CreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestStyle), TypeInfoPropertyName = "CreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Includable), TypeInfoPropertyName = "Includable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallType), TypeInfoPropertyName = "FunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallStatus), TypeInfoPropertyName = "FunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputType), TypeInfoPropertyName = "FunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputStatus), TypeInfoPropertyName = "FunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResource), TypeInfoPropertyName = "FunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResource), TypeInfoPropertyName = "FunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputAudioType), TypeInfoPropertyName = "InputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputAudioFormat), TypeInfoPropertyName = "InputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputContent), TypeInfoPropertyName = "InputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFileType), TypeInfoPropertyName = "InputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageType), TypeInfoPropertyName = "InputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageDetail), TypeInfoPropertyName = "InputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItem), TypeInfoPropertyName = "InputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Item), TypeInfoPropertyName = "Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminatorType), TypeInfoPropertyName = "InputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageType), TypeInfoPropertyName = "InputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageRole), TypeInfoPropertyName = "InputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageStatus), TypeInfoPropertyName = "InputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResource), TypeInfoPropertyName = "InputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputTextType), TypeInfoPropertyName = "InputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestModel), TypeInfoPropertyName = "CreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestSize), TypeInfoPropertyName = "CreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestResponseFormat), TypeInfoPropertyName = "CreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestModel), TypeInfoPropertyName = "CreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestResponseFormat), TypeInfoPropertyName = "CreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestSize), TypeInfoPropertyName = "CreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModelResponseProperties), TypeInfoPropertyName = "CreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationRequestModel), TypeInfoPropertyName = "CreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationResponseResultCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationResponseResultCategoryScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponse), TypeInfoPropertyName = "CreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>), TypeInfoPropertyName = "OneOfStringIListInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Includable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesResponseObject), TypeInfoPropertyName = "ListFilesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateFileRequestPurpose), TypeInfoPropertyName = "CreateFileRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteFileResponseObject), TypeInfoPropertyName = "DeleteFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockFinetuneJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodType), TypeInfoPropertyName = "OpenAIFinetuneJobMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodSupervised))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodDpo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyFinetuneJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexFinetuneJob), TypeInfoPropertyName = "VertexFinetuneJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponseObject), TypeInfoPropertyName = "ListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject), TypeInfoPropertyName = "ListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestModel), TypeInfoPropertyName = "CreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat), TypeInfoPropertyName = "CreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseObject), TypeInfoPropertyName = "CreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankDocument), TypeInfoPropertyName = "RerankDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankDocumentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RerankDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRerankResponseObject), TypeInfoPropertyName = "CreateRerankResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RerankResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrRequestDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrRequestDocumentType), TypeInfoPropertyName = "CreateOcrRequestDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OcrPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OcrPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrResponseUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OcrPageImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OcrPageImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestModel), TypeInfoPropertyName = "CreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestResponseFormat), TypeInfoPropertyName = "CreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "CreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequestModel), TypeInfoPropertyName = "CreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestVoice), TypeInfoPropertyName = "CreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelObject), TypeInfoPropertyName = "ModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Move))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MoveType), TypeInfoPropertyName = "MoveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFileObject), TypeInfoPropertyName = "OpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFilePurpose), TypeInfoPropertyName = "OpenAIFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFileStatus), TypeInfoPropertyName = "OpenAIFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClick))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClickType), TypeInfoPropertyName = "DoubleClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Drag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DragType), TypeInfoPropertyName = "DragType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Coordinate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Coordinate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageRole), TypeInfoPropertyName = "EasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>), TypeInfoPropertyName = "OneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageType), TypeInfoPropertyName = "EasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EmbeddingObject), TypeInfoPropertyName = "EmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparametersNEpochs), TypeInfoPropertyName = "FineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobObject), TypeInfoPropertyName = "FineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobStatus), TypeInfoPropertyName = "FineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationType), TypeInfoPropertyName = "FineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventLevel), TypeInfoPropertyName = "FineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventObject), TypeInfoPropertyName = "FineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointObject), TypeInfoPropertyName = "FineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FinetuneChatRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FinetuneCompletionRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Click))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickType), TypeInfoPropertyName = "ClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickButton), TypeInfoPropertyName = "ClickButton2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputType), TypeInfoPropertyName = "CodeInterpreterFileOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutputType), TypeInfoPropertyName = "CodeInterpreterTextOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolType), TypeInfoPropertyName = "CodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallType), TypeInfoPropertyName = "CodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallStatus), TypeInfoPropertyName = "CodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolOutput), TypeInfoPropertyName = "CodeInterpreterToolOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilterType), TypeInfoPropertyName = "ComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, double?, bool?>), TypeInfoPropertyName = "OneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompleteUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>), TypeInfoPropertyName = "OneOfComparisonFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerAction), TypeInfoPropertyName = "ComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Screenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Scroll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Wait))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImageType), TypeInfoPropertyName = "ComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolType), TypeInfoPropertyName = "ComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolEnvironment), TypeInfoPropertyName = "ComputerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallType), TypeInfoPropertyName = "ComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallSafetyCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallStatus), TypeInfoPropertyName = "ComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputType), TypeInfoPropertyName = "ComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputStatus), TypeInfoPropertyName = "ComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResource), TypeInfoPropertyName = "ComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Content3), TypeInfoPropertyName = "Content32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CostsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CostsResultObject), TypeInfoPropertyName = "CostsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CostsResultAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Reasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningEffort), TypeInfoPropertyName = "ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningGenerateSummary), TypeInfoPropertyName = "ReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemType), TypeInfoPropertyName = "ReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItemType), TypeInfoPropertyName = "ReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemStatus), TypeInfoPropertyName = "ReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RefusalType), TypeInfoPropertyName = "RefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Response), TypeInfoPropertyName = "Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Object), TypeInfoPropertyName = "ResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Status), TypeInfoPropertyName = "ResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason), TypeInfoPropertyName = "ResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEventType), TypeInfoPropertyName = "ResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEventType), TypeInfoPropertyName = "ResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEventType), TypeInfoPropertyName = "ResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEventType), TypeInfoPropertyName = "ResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEventType), TypeInfoPropertyName = "ResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEventType), TypeInfoPropertyName = "ResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorCode), TypeInfoPropertyName = "ResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEventType), TypeInfoPropertyName = "ResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEventType), TypeInfoPropertyName = "ResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEventType), TypeInfoPropertyName = "ResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEventType), TypeInfoPropertyName = "ResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemListObject), TypeInfoPropertyName = "ResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResource), TypeInfoPropertyName = "ItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseModalitie), TypeInfoPropertyName = "ResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseModalitiesTextOnlyItem), TypeInfoPropertyName = "ResponseModalitiesTextOnlyItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEventType), TypeInfoPropertyName = "ResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEventType), TypeInfoPropertyName = "ResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatConfiguration), TypeInfoPropertyName = "TextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>), TypeInfoPropertyName = "OneOfToolChoiceOptionsToolChoiceTypesToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceOptions), TypeInfoPropertyName = "ToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesTruncation), TypeInfoPropertyName = "ResponsePropertiesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEventType), TypeInfoPropertyName = "ResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEventType), TypeInfoPropertyName = "ResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEvent), TypeInfoPropertyName = "ResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "ResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEventType), TypeInfoPropertyName = "ResponseTextAnnotationDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEventType), TypeInfoPropertyName = "ResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEventType), TypeInfoPropertyName = "ResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOption), TypeInfoPropertyName = "AssistantsApiResponseFormatOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum), TypeInfoPropertyName = "AssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatType), TypeInfoPropertyName = "AssistantsApiResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectObject), TypeInfoPropertyName = "AssistantObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>), TypeInfoPropertyName = "OneOfAssistantToolsCodeAssistantToolsFileSearchAssistantToolsFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestModel), TypeInfoPropertyName = "CreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponses), TypeInfoPropertyName = "ModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponsesEnum), TypeInfoPropertyName = "ModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponseObject), TypeInfoPropertyName = "DeleteAssistantResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminatorType), TypeInfoPropertyName = "ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReferenceType), TypeInfoPropertyName = "ItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminatorType), TypeInfoPropertyName = "ItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPressType), TypeInfoPropertyName = "KeyPressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListAssistantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsCodeType), TypeInfoPropertyName = "AssistantToolsCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchType), TypeInfoPropertyName = "AssistantToolsFileSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchTypeOnly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType), TypeInfoPropertyName = "AssistantToolsFileSearchTypeOnlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFunctionType), TypeInfoPropertyName = "AssistantToolsFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TruncationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TruncationObjectType), TypeInfoPropertyName = "TruncationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiToolChoiceOption), TypeInfoPropertyName = "AssistantsApiToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum), TypeInfoPropertyName = "AssistantsApiToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsNamedToolChoiceType), TypeInfoPropertyName = "AssistantsNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectObject), TypeInfoPropertyName = "RunObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectStatus), TypeInfoPropertyName = "RunObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectRequiredAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectRequiredActionType), TypeInfoPropertyName = "RunObjectRequiredActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectRequiredActionSubmitToolOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectLastErrorCode), TypeInfoPropertyName = "RunObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectIncompleteDetailsReason), TypeInfoPropertyName = "RunObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRunRequestModel), TypeInfoPropertyName = "CreateRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SubmitToolOutputsRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SubmitToolOutputsRunRequestToolOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchemaType), TypeInfoPropertyName = "TextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectType), TypeInfoPropertyName = "RunToolCallObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScreenshotType), TypeInfoPropertyName = "ScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScrollType), TypeInfoPropertyName = "ScrollType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequestModel), TypeInfoPropertyName = "CreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObjectObject), TypeInfoPropertyName = "ThreadObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObjectToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyThreadRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteThreadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteThreadResponseObject), TypeInfoPropertyName = "DeleteThreadResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListThreadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ThreadObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectObject), TypeInfoPropertyName = "MessageObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectStatus), TypeInfoPropertyName = "MessageObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectIncompleteDetailsReason), TypeInfoPropertyName = "MessageObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectRole), TypeInfoPropertyName = "MessageObjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>), TypeInfoPropertyName = "OneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>), TypeInfoPropertyName = "OneOfAssistantToolsCodeAssistantToolsFileSearchTypeOnly2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObjectObject), TypeInfoPropertyName = "MessageDeltaObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObjectDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObjectDeltaRole), TypeInfoPropertyName = "MessageDeltaObjectDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>), TypeInfoPropertyName = "OneOfMessageDeltaContentImageFileObjectMessageDeltaContentTextObjectMessageDeltaContentImageUrlObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMessageRequestRole), TypeInfoPropertyName = "CreateMessageRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>), TypeInfoPropertyName = "OneOfStringIListOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>), TypeInfoPropertyName = "OneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageRequestContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMessageRequestAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteMessageResponseObject), TypeInfoPropertyName = "DeleteMessageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectType), TypeInfoPropertyName = "MessageContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail), TypeInfoPropertyName = "MessageContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObjectType), TypeInfoPropertyName = "MessageDeltaContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail), TypeInfoPropertyName = "MessageDeltaContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectType), TypeInfoPropertyName = "MessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail), TypeInfoPropertyName = "MessageContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObjectType), TypeInfoPropertyName = "MessageDeltaContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail), TypeInfoPropertyName = "MessageDeltaContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextObjectType), TypeInfoPropertyName = "MessageContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextObjectText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>), TypeInfoPropertyName = "OneOfMessageContentTextAnnotationsFileCitationObjectMessageContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFilePathObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageRequestContentTextObjectType), TypeInfoPropertyName = "MessageRequestContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType), TypeInfoPropertyName = "MessageContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType), TypeInfoPropertyName = "MessageContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextObjectType), TypeInfoPropertyName = "MessageDeltaContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextObjectText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>), TypeInfoPropertyName = "OneOfMessageDeltaContentTextAnnotationsFileCitationObjectMessageDeltaContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType), TypeInfoPropertyName = "MessageDeltaContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType), TypeInfoPropertyName = "MessageDeltaContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectObject), TypeInfoPropertyName = "RunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectType), TypeInfoPropertyName = "RunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectStatus), TypeInfoPropertyName = "RunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>), TypeInfoPropertyName = "OneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastErrorCode), TypeInfoPropertyName = "RunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaObjectObject), TypeInfoPropertyName = "RunStepDeltaObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaObjectDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>), TypeInfoPropertyName = "OneOfRunStepDeltaStepDetailsMessageCreationObjectRunStepDeltaStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectType), TypeInfoPropertyName = "RunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeObjectRunStepDetailsToolCallsFileSearchObjectRunStepDetailsToolCallsFunctionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>), TypeInfoPropertyName = "OneOfRunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectRunStepDeltaStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfterAnchor), TypeInfoPropertyName = "VectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectObject), TypeInfoPropertyName = "VectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectStatus), TypeInfoPropertyName = "VectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchRequestRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker), TypeInfoPropertyName = "VectorStoreSearchRequestRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultContentObjectType), TypeInfoPropertyName = "VectorStoreSearchResultContentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultsPageObject), TypeInfoPropertyName = "VectorStoreSearchResultsPageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VoiceIdsShared), TypeInfoPropertyName = "VoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VoiceIdsSharedEnum), TypeInfoPropertyName = "VoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WaitType), TypeInfoPropertyName = "WaitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchContextSize), TypeInfoPropertyName = "WebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolType), TypeInfoPropertyName = "WebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>), TypeInfoPropertyName = "AllOfWebSearchLocationWebSearchToolUserLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocationType), TypeInfoPropertyName = "WebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallType), TypeInfoPropertyName = "WebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallStatus), TypeInfoPropertyName = "WebSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>), TypeInfoPropertyName = "OneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TypeType1), TypeInfoPropertyName = "TypeType12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitationType), TypeInfoPropertyName = "UrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponseObject), TypeInfoPropertyName = "DeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectObject), TypeInfoPropertyName = "VectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectStatus), TypeInfoPropertyName = "VectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastErrorCode), TypeInfoPropertyName = "VectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>), TypeInfoPropertyName = "OneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParamType), TypeInfoPropertyName = "OtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParamType), TypeInfoPropertyName = "StaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParamType), TypeInfoPropertyName = "AutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParamType), TypeInfoPropertyName = "StaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChunkingStrategyRequestParam), TypeInfoPropertyName = "ChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponseObject), TypeInfoPropertyName = "DeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectObject), TypeInfoPropertyName = "VectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectStatus), TypeInfoPropertyName = "VectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreFileBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantStreamEvent), TypeInfoPropertyName = "AssistantStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadStreamEvent), TypeInfoPropertyName = "ThreadStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEvent), TypeInfoPropertyName = "RunStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEvent), TypeInfoPropertyName = "RunStepStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEvent), TypeInfoPropertyName = "MessageStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadStreamEventVariant1Event), TypeInfoPropertyName = "ThreadStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunctionType), TypeInfoPropertyName = "ToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypesType), TypeInfoPropertyName = "ToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant1Event), TypeInfoPropertyName = "RunStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant2Event), TypeInfoPropertyName = "RunStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant3Event), TypeInfoPropertyName = "RunStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant4Event), TypeInfoPropertyName = "RunStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant5Event), TypeInfoPropertyName = "RunStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant6Event), TypeInfoPropertyName = "RunStreamEventVariant6Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant7Event), TypeInfoPropertyName = "RunStreamEventVariant7Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant8Event), TypeInfoPropertyName = "RunStreamEventVariant8Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant9Event), TypeInfoPropertyName = "RunStreamEventVariant9Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant10Event), TypeInfoPropertyName = "RunStreamEventVariant10Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant1Event), TypeInfoPropertyName = "RunStepStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant2Event), TypeInfoPropertyName = "RunStepStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant3Event), TypeInfoPropertyName = "RunStepStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant4Event), TypeInfoPropertyName = "RunStepStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant5Event), TypeInfoPropertyName = "RunStepStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant6Event), TypeInfoPropertyName = "RunStepStreamEventVariant6Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant7Event), TypeInfoPropertyName = "RunStepStreamEventVariant7Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant1Event), TypeInfoPropertyName = "MessageStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant2Event), TypeInfoPropertyName = "MessageStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant3Event), TypeInfoPropertyName = "MessageStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant4Event), TypeInfoPropertyName = "MessageStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant5Event), TypeInfoPropertyName = "MessageStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ErrorEventEvent), TypeInfoPropertyName = "ErrorEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitationType), TypeInfoPropertyName = "FileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePathType), TypeInfoPropertyName = "FilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoneEventEvent), TypeInfoPropertyName = "DoneEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoneEventData), TypeInfoPropertyName = "DoneEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchObject), TypeInfoPropertyName = "BatchObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchErrorsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestInputMethod), TypeInfoPropertyName = "BatchRequestInputMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestOutputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponseObject), TypeInfoPropertyName = "ListBatchesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FeedbackUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType), TypeInfoPropertyName = "RateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit), TypeInfoPropertyName = "RateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType), TypeInfoPropertyName = "UsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset), TypeInfoPropertyName = "UsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkersAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfiguration), TypeInfoPropertyName = "SageMakerConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HuggingFaceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CortexConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomHostConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingAdjustments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponse), TypeInfoPropertyName = "IntegrationDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GlobalWorkspaceAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingMultiplierImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>), TypeInfoPropertyName = "DictionaryStringDouble_System_Collections_Generic_Dictionary_string_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode), TypeInfoPropertyName = "AzureOpenAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDeploymentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfigurationAwsAuthType), TypeInfoPropertyName = "BedrockConfigurationAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfigurationVertexAuthType), TypeInfoPropertyName = "VertexAIConfigurationVertexAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfigurationAzureAuthMode), TypeInfoPropertyName = "AzureAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat), TypeInfoPropertyName = "SecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequest))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestManagerType), TypeInfoPropertyName = "CreateSecretReferenceRequestManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuthConfig), TypeInfoPropertyName = "AuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType), TypeInfoPropertyName = "CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateSecretReferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemManagerType), TypeInfoPropertyName = "SecretReferenceListItemManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemStatus), TypeInfoPropertyName = "SecretReferenceListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemObject), TypeInfoPropertyName = "SecretReferenceListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseManagerType), TypeInfoPropertyName = "SecretReferenceDetailResponseManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseStatus), TypeInfoPropertyName = "SecretReferenceDetailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseObject), TypeInfoPropertyName = "SecretReferenceDetailResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsAccessKeyAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsAssumedRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsServiceRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureEntraAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureManagedAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureDefaultAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpTokenAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpAppRoleAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpKubernetesAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListStatus), TypeInfoPropertyName = "IntegrationListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListObject), TypeInfoPropertyName = "IntegrationListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingConfigType), TypeInfoPropertyName = "PricingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PayAsYouGoPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TokenPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelConfigurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelConfigurationsCustomHeaders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateModelsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Providers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ProvidersStatus), TypeInfoPropertyName = "ProvidersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ProvidersObject), TypeInfoPropertyName = "ProvidersObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysStatus), TypeInfoPropertyName = "VirtualKeysStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysObject), TypeInfoPropertyName = "VirtualKeysObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Invite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole2), TypeInfoPropertyName = "InviteRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteStatus), TypeInfoPropertyName = "InviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteListObject), TypeInfoPropertyName = "InviteListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserObject), TypeInfoPropertyName = "UserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserRole), TypeInfoPropertyName = "UserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserListObject), TypeInfoPropertyName = "UserListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject), TypeInfoPropertyName = "WorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole), TypeInfoPropertyName = "WorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole), TypeInfoPropertyName = "WorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus), TypeInfoPropertyName = "WorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberListObject), TypeInfoPropertyName = "WorkspaceMemberListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaultsObject), TypeInfoPropertyName = "WorkspaceDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceListObject), TypeInfoPropertyName = "WorkspaceListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaultsObject), TypeInfoPropertyName = "WorkspaceWithUsersDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMappingRole), TypeInfoPropertyName = "ScimWorkspaceMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Collection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionStatus), TypeInfoPropertyName = "CollectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithDetails), TypeInfoPropertyName = "CollectionWithDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithDetailsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChildCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithChildCollections), TypeInfoPropertyName = "CollectionWithChildCollections2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithChildCollectionsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChildCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateLabelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListLabelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummaryObject), TypeInfoPropertyName = "PromptSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Prompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPromptVersionStatus), TypeInfoPropertyName = "PromptPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryStatus), TypeInfoPropertyName = "PromptVersionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryObject), TypeInfoPropertyName = "PromptVersionSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialSummaryStatus), TypeInfoPropertyName = "PromptPartialSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialSummaryObject), TypeInfoPropertyName = "PromptPartialSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartial))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialStatus), TypeInfoPropertyName = "PromptPartialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialVersionPromptVersionStatus), TypeInfoPropertyName = "PromptPartialVersionPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialVersionObject), TypeInfoPropertyName = "PromptPartialVersionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomLogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomLogMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponseObject), TypeInfoPropertyName = "ExportListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ExportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GenerationsFilterSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemStatus), TypeInfoPropertyName = "ExportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemObject), TypeInfoPropertyName = "ExportItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponseObject), TypeInfoPropertyName = "UpdateExportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponseObject), TypeInfoPropertyName = "ExportTaskResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DownloadLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnalyticsMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RequestResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogRequestMethod), TypeInfoPropertyName = "LogRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogExportsRequestedDataItem), TypeInfoPropertyName = "LogExportsRequestedDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListRecordMethod), TypeInfoPropertyName = "AuditLogObjectListRecordMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListRecordUserType), TypeInfoPropertyName = "AuditLogObjectListRecordUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListObject), TypeInfoPropertyName = "AuditLogObjectListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectType), TypeInfoPropertyName = "ApiKeyObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectStatus), TypeInfoPropertyName = "ApiKeyObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectCreationMode), TypeInfoPropertyName = "ApiKeyObjectCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectObject), TypeInfoPropertyName = "ApiKeyObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectListObject), TypeInfoPropertyName = "ApiKeyObjectListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRateLimitType), TypeInfoPropertyName = "CreateApiKeyObjectRateLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit), TypeInfoPropertyName = "CreateApiKeyObjectRateLimitUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRotationPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod), TypeInfoPropertyName = "CreateApiKeyObjectRotationPolicyRotationPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRateLimitType), TypeInfoPropertyName = "UpdateApiKeyObjectRateLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit), TypeInfoPropertyName = "UpdateApiKeyObjectRateLimitUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRotationPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod), TypeInfoPropertyName = "UpdateApiKeyObjectRotationPolicyRotationPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RotateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RotateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestCreateCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateGuardrailRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryStatus), TypeInfoPropertyName = "GuardrailSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetails), TypeInfoPropertyName = "GuardrailDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetailsVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockBatchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CommonBatchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobCompletionWindow), TypeInfoPropertyName = "OpenAIBatchJobCompletionWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobEndpoint), TypeInfoPropertyName = "OpenAIBatchJobEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>), TypeInfoPropertyName = "AnyOfPortkeyBatchJobProviderOptionsBedrockOptionsPortkeyBatchJobProviderOptionsVertexOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexBatchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestType), TypeInfoPropertyName = "CreateUsageLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset), TypeInfoPropertyName = "CreateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset), TypeInfoPropertyName = "UpdateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestType), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit), TypeInfoPropertyName = "UpdateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyType), TypeInfoPropertyName = "UsageLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyPeriodicReset), TypeInfoPropertyName = "UsageLimitsPolicyPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyStatus), TypeInfoPropertyName = "UsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsageStatus), TypeInfoPropertyName = "ValueKeyUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyType), TypeInfoPropertyName = "RateLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyUnit), TypeInfoPropertyName = "RateLimitsPolicyUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyStatus), TypeInfoPropertyName = "RateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyTarget), TypeInfoPropertyName = "RateLimitsPolicyTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePolicyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponse), TypeInfoPropertyName = "UsageLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyEntityListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponse), TypeInfoPropertyName = "RateLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationConfigurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationAuthType), TypeInfoPropertyName = "CreateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationTransport), TypeInfoPropertyName = "CreateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationAuthType), TypeInfoPropertyName = "McpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationTransport), TypeInfoPropertyName = "McpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationType), TypeInfoPropertyName = "McpIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemType), TypeInfoPropertyName = "McpIntegrationListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemAuthType), TypeInfoPropertyName = "McpIntegrationListItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemTransport), TypeInfoPropertyName = "McpIntegrationListItemTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationConfigurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationAuthType), TypeInfoPropertyName = "UpdateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationTransport), TypeInfoPropertyName = "UpdateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationWorkspaceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationWorkspacesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationWorkspacesLegacyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationWorkspaces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilityItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilityItemType), TypeInfoPropertyName = "McpIntegrationCapabilityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesCountsTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesCountsPrompts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesCountsResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType), TypeInfoPropertyName = "BulkUpdateMcpIntegrationCapabilitiesCapabilitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerMcpIntegrationDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilityItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilityItemType), TypeInfoPropertyName = "McpServerCapabilityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesCountsTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesCountsPrompts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesCountsResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesCountsResourceTemplates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType), TypeInfoPropertyName = "BulkUpdateMcpServerCapabilitiesCapabilitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesBulkUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessItemConnectionStatus), TypeInfoPropertyName = "McpServerUserAccessItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess), TypeInfoPropertyName = "McpServerUserAccessListResponseDefaultUserAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerUserAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerUserAccessUserAcces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess), TypeInfoPropertyName = "BulkUpdateMcpServerUserAccessDefaultUserAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessBulkUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerConnectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerConnectionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpServerConnectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerConnectionDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentAuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentAuthSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequestType), TypeInfoPropertyName = "CreateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestType), TypeInfoPropertyName = "UpdateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestStatus), TypeInfoPropertyName = "UpdateDeploymentRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>), TypeInfoPropertyName = "AllOfDeploymentAuthSettingsInputUpdateDeploymentRequestAuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestAuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponseObject), TypeInfoPropertyName = "DeploymentCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemType), TypeInfoPropertyName = "DeploymentListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemStatus), TypeInfoPropertyName = "DeploymentListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemConnectionStatus), TypeInfoPropertyName = "DeploymentListItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemObject), TypeInfoPropertyName = "DeploymentListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponse), TypeInfoPropertyName = "DeploymentDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>), TypeInfoPropertyName = "AllOfDeploymentAuthSettingsDeploymentDetailResponseVariant2AuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2AuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseStatus), TypeInfoPropertyName = "DeploymentPingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutbound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutboundStatus), TypeInfoPropertyName = "DeploymentPingResponseOutboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInbound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInboundStatus), TypeInfoPropertyName = "DeploymentPingResponseInboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseObject), TypeInfoPropertyName = "DeploymentPingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptPartialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptPartialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptPartialDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptCompletionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRenderRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>), TypeInfoPropertyName = "AnyOfOpenAIFinetuneJobBedrockFinetuneJobPortkeyFinetuneJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>), TypeInfoPropertyName = "AnyOfOpenAIBatchJobBedrockBatchJobVertexBatchJobPortkeyBatchJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateConfigRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateProvidersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutProvidersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestProvider), TypeInfoPropertyName = "CreateVirtualKeysRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysRequestDeploymentConfigItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminUsersRequestRole), TypeInfoPropertyName = "PutAdminUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole), TypeInfoPropertyName = "CreateAdminWorkspacesUsersRequestUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole), TypeInfoPropertyName = "PutAdminWorkspacesUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesRequestDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesRequestDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequestRole), TypeInfoPropertyName = "CreateScimWorkspacesRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>), TypeInfoPropertyName = "OneOfCustomLogIListCustomLog2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CustomLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutLogsExportsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateLogsExportsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsSort), TypeInfoPropertyName = "ListModelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsOrder), TypeInfoPropertyName = "ListModelsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListAssistantsOrder), TypeInfoPropertyName = "ListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListInputItemsOrder), TypeInfoPropertyName = "ListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListMessagesOrder), TypeInfoPropertyName = "ListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunsOrder), TypeInfoPropertyName = "ListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsOrder), TypeInfoPropertyName = "ListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresOrder), TypeInfoPropertyName = "ListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesOrder), TypeInfoPropertyName = "ListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesFilter), TypeInfoPropertyName = "ListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchOrder), TypeInfoPropertyName = "ListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchFilter), TypeInfoPropertyName = "ListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsType), TypeInfoPropertyName = "GetIntegrationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesRole), TypeInfoPropertyName = "GetAdminUsersInvitesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesStatus), TypeInfoPropertyName = "GetAdminUsersInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersRole), TypeInfoPropertyName = "GetAdminUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesUsersRole), TypeInfoPropertyName = "GetAdminWorkspacesUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesStatus), TypeInfoPropertyName = "GetAdminWorkspacesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesRole), TypeInfoPropertyName = "GetScimWorkspacesRole2")]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationsListType), TypeInfoPropertyName = "McpIntegrationsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesListType), TypeInfoPropertyName = "McpIntegrationCapabilitiesListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesListType), TypeInfoPropertyName = "McpServerCapabilitiesListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetLogsPathFormat), TypeInfoPropertyName = "GetLogsPathFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetLogsType), TypeInfoPropertyName = "GetLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAuditLogsMethod), TypeInfoPropertyName = "GetAuditLogsMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAuditLogsUserType), TypeInfoPropertyName = "GetAuditLogsUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysType), TypeInfoPropertyName = "CreateKeysType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysSubType), TypeInfoPropertyName = "CreateKeysSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesStatus), TypeInfoPropertyName = "ListUsageLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesType), TypeInfoPropertyName = "ListUsageLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetUsageLimitsPolicyStatus), TypeInfoPropertyName = "GetUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus), TypeInfoPropertyName = "ListUsageLimitsPolicyEntitiesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesStatus), TypeInfoPropertyName = "ListRateLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesType), TypeInfoPropertyName = "ListRateLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesUnit), TypeInfoPropertyName = "ListRateLimitsPoliciesUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesTarget), TypeInfoPropertyName = "ListRateLimitsPoliciesTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetRateLimitsPolicyStatus), TypeInfoPropertyName = "GetRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal), TypeInfoPropertyName = "GetAnalyticsGroupsProviderIncludeTotal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesManagerType), TypeInfoPropertyName = "ListSecretReferencesManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsStatus), TypeInfoPropertyName = "ListDeploymentsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsType), TypeInfoPropertyName = "ListDeploymentsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponseObject), TypeInfoPropertyName = "CreatePromptResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPromptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptPartialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptPartialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>), TypeInfoPropertyName = "OneOfCreateChatCompletionResponseCreateCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListConfigsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateConfigResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseDataConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseDataConfigRetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseDataConfigCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseDataConfigStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetConfigResponseDataConfigTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateConfigResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListConfigVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListConfigVersionsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponseObject), TypeInfoPropertyName = "GetIntegrationsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.IntegrationList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetProvidersResponseObject), TypeInfoPropertyName = "GetProvidersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Providers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseObject), TypeInfoPropertyName = "GetVirtualKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponseData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminUsersInvitesResendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMappingRole), TypeInfoPropertyName = "GetScimWorkspacesResponseMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteScimWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>), TypeInfoPropertyName = "OneOfMcpIntegrationWorkspacesListResponseMcpIntegrationWorkspacesLegacyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysResponseObject), TypeInfoPropertyName = "CreateKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCostResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsTokensResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsUsersRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsStacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsStatusCodesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsRequestsRescuedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCacheHitRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCacheLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksScoresResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksWeightedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsSummaryCacheResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsSummaryCacheResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject), TypeInfoPropertyName = "GetAnalyticsSummaryCacheResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsUsersResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsAiModelsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsProviderResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsMetadataResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsMetadataResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetModelPricingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponseObject), TypeInfoPropertyName = "ListSecretReferencesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponseObject), TypeInfoPropertyName = "CreateSecretReferenceResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponseObject), TypeInfoPropertyName = "ListDeploymentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.DeploymentListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelPricingConfigCurrency?), TypeInfoPropertyName = "NullableModelPricingConfigCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelCalculateOperationOperation?), TypeInfoPropertyName = "NullableModelCalculateOperationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>?), TypeInfoPropertyName = "NullableOneOfModelCalculateOperationModelValueReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole?), TypeInfoPropertyName = "NullableInviteRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteRole?), TypeInfoPropertyName = "NullableWorkspaceInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteType?), TypeInfoPropertyName = "NullableWorkspaceInviteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsResponseObject?), TypeInfoPropertyName = "NullableListModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequestModel?), TypeInfoPropertyName = "NullableCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>?), TypeInfoPropertyName = "NullableOneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?), TypeInfoPropertyName = "NullableChatCompletionMessageContentPartThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?), TypeInfoPropertyName = "NullableChatCompletionMessageContentPartRedactedThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessage?), TypeInfoPropertyName = "NullableChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolType?), TypeInfoPropertyName = "NullableFileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>?), TypeInfoPropertyName = "NullableOneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptionsRanker?), TypeInfoPropertyName = "NullableFileSearchToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallType?), TypeInfoPropertyName = "NullableFileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallStatus?), TypeInfoPropertyName = "NullableFileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole?), TypeInfoPropertyName = "NullableFineTuneChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuneChatCompletionRequestFunctionMessage?), TypeInfoPropertyName = "NullableFineTuneChatCompletionRequestFunctionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolType?), TypeInfoPropertyName = "NullableChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOption?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceType?), TypeInfoPropertyName = "NullableChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputAudioType?), TypeInfoPropertyName = "NullableOutputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputContent?), TypeInfoPropertyName = "NullableOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItem?), TypeInfoPropertyName = "NullableOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminatorType?), TypeInfoPropertyName = "NullableOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageType?), TypeInfoPropertyName = "NullableOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageRole?), TypeInfoPropertyName = "NullableOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageStatus?), TypeInfoPropertyName = "NullableOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputTextType?), TypeInfoPropertyName = "NullableOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Annotation?), TypeInfoPropertyName = "NullableAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallChunkType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRole?), TypeInfoPropertyName = "NullableChatCompletionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentBlock?), TypeInfoPropertyName = "NullableChatCompletionMessageContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageRole?), TypeInfoPropertyName = "NullableChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole?), TypeInfoPropertyName = "NullableChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestModel?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>?), TypeInfoPropertyName = "NullableOneOfResponseFormatTextResponseFormatJsonSchemaResponseFormatJsonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinkingType?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestFunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionFunctionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionFunctionResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionFunctionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?), TypeInfoPropertyName = "NullableListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionStreamResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionStreamResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestModel?), TypeInfoPropertyName = "NullableCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestQuality?), TypeInfoPropertyName = "NullableCreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestSize?), TypeInfoPropertyName = "NullableCreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestStyle?), TypeInfoPropertyName = "NullableCreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Includable?), TypeInfoPropertyName = "NullableIncludable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolType?), TypeInfoPropertyName = "NullableFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallType?), TypeInfoPropertyName = "NullableFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallStatus?), TypeInfoPropertyName = "NullableFunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputType?), TypeInfoPropertyName = "NullableFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputStatus?), TypeInfoPropertyName = "NullableFunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResource?), TypeInfoPropertyName = "NullableFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResource?), TypeInfoPropertyName = "NullableFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputAudioType?), TypeInfoPropertyName = "NullableInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputAudioFormat?), TypeInfoPropertyName = "NullableInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputContent?), TypeInfoPropertyName = "NullableInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFileType?), TypeInfoPropertyName = "NullableInputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageType?), TypeInfoPropertyName = "NullableInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageDetail?), TypeInfoPropertyName = "NullableInputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItem?), TypeInfoPropertyName = "NullableInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Item?), TypeInfoPropertyName = "NullableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminatorType?), TypeInfoPropertyName = "NullableInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageType?), TypeInfoPropertyName = "NullableInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageRole?), TypeInfoPropertyName = "NullableInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageStatus?), TypeInfoPropertyName = "NullableInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResource?), TypeInfoPropertyName = "NullableInputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputTextType?), TypeInfoPropertyName = "NullableInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestModel?), TypeInfoPropertyName = "NullableCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestSize?), TypeInfoPropertyName = "NullableCreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestModel?), TypeInfoPropertyName = "NullableCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestSize?), TypeInfoPropertyName = "NullableCreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModelResponseProperties?), TypeInfoPropertyName = "NullableCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModerationRequestModel?), TypeInfoPropertyName = "NullableCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponse?), TypeInfoPropertyName = "NullableCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>?), TypeInfoPropertyName = "NullableOneOfStringIListInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesResponseObject?), TypeInfoPropertyName = "NullableListFilesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateFileRequestPurpose?), TypeInfoPropertyName = "NullableCreateFileRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteFileResponseObject?), TypeInfoPropertyName = "NullableDeleteFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFinetuneJobMethodType?), TypeInfoPropertyName = "NullableOpenAIFinetuneJobMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexFinetuneJob?), TypeInfoPropertyName = "NullableVertexFinetuneJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestModel?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseObject?), TypeInfoPropertyName = "NullableCreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RerankDocument?), TypeInfoPropertyName = "NullableRerankDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRerankResponseObject?), TypeInfoPropertyName = "NullableCreateRerankResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateOcrRequestDocumentType?), TypeInfoPropertyName = "NullableCreateOcrRequestDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestModel?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequestModel?), TypeInfoPropertyName = "NullableCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestModel?), TypeInfoPropertyName = "NullableCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestVoice?), TypeInfoPropertyName = "NullableCreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelObject?), TypeInfoPropertyName = "NullableModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MoveType?), TypeInfoPropertyName = "NullableMoveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFileObject?), TypeInfoPropertyName = "NullableOpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFilePurpose?), TypeInfoPropertyName = "NullableOpenAIFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIFileStatus?), TypeInfoPropertyName = "NullableOpenAIFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClickType?), TypeInfoPropertyName = "NullableDoubleClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DragType?), TypeInfoPropertyName = "NullableDragType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageRole?), TypeInfoPropertyName = "NullableEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageType?), TypeInfoPropertyName = "NullableEasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EmbeddingObject?), TypeInfoPropertyName = "NullableEmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobObject?), TypeInfoPropertyName = "NullableFineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobStatus?), TypeInfoPropertyName = "NullableFineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationType?), TypeInfoPropertyName = "NullableFineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventLevel?), TypeInfoPropertyName = "NullableFineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventObject?), TypeInfoPropertyName = "NullableFineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointObject?), TypeInfoPropertyName = "NullableFineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickType?), TypeInfoPropertyName = "NullableClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickButton?), TypeInfoPropertyName = "NullableClickButton2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputType?), TypeInfoPropertyName = "NullableCodeInterpreterFileOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutputType?), TypeInfoPropertyName = "NullableCodeInterpreterTextOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallStatus?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolOutput?), TypeInfoPropertyName = "NullableCodeInterpreterToolOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilterType?), TypeInfoPropertyName = "NullableComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilterType?), TypeInfoPropertyName = "NullableCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>?), TypeInfoPropertyName = "NullableOneOfComparisonFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerAction?), TypeInfoPropertyName = "NullableComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImageType?), TypeInfoPropertyName = "NullableComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolType?), TypeInfoPropertyName = "NullableComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolEnvironment?), TypeInfoPropertyName = "NullableComputerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallType?), TypeInfoPropertyName = "NullableComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallStatus?), TypeInfoPropertyName = "NullableComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputType?), TypeInfoPropertyName = "NullableComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputStatus?), TypeInfoPropertyName = "NullableComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResource?), TypeInfoPropertyName = "NullableComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Content3?), TypeInfoPropertyName = "NullableContent32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CostsResultObject?), TypeInfoPropertyName = "NullableCostsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningEffort?), TypeInfoPropertyName = "NullableReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningGenerateSummary?), TypeInfoPropertyName = "NullableReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemType?), TypeInfoPropertyName = "NullableReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItemType?), TypeInfoPropertyName = "NullableReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemStatus?), TypeInfoPropertyName = "NullableReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RefusalType?), TypeInfoPropertyName = "NullableRefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Response?), TypeInfoPropertyName = "NullableResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Object?), TypeInfoPropertyName = "NullableResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Status?), TypeInfoPropertyName = "NullableResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?), TypeInfoPropertyName = "NullableResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEventType?), TypeInfoPropertyName = "NullableResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEventType?), TypeInfoPropertyName = "NullableResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEventType?), TypeInfoPropertyName = "NullableResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEventType?), TypeInfoPropertyName = "NullableResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorCode?), TypeInfoPropertyName = "NullableResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEventType?), TypeInfoPropertyName = "NullableResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEventType?), TypeInfoPropertyName = "NullableResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEventType?), TypeInfoPropertyName = "NullableResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEventType?), TypeInfoPropertyName = "NullableResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemListObject?), TypeInfoPropertyName = "NullableResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResource?), TypeInfoPropertyName = "NullableItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseModalitie?), TypeInfoPropertyName = "NullableResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseModalitiesTextOnlyItem?), TypeInfoPropertyName = "NullableResponseModalitiesTextOnlyItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEventType?), TypeInfoPropertyName = "NullableResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEventType?), TypeInfoPropertyName = "NullableResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatConfiguration?), TypeInfoPropertyName = "NullableTextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>?), TypeInfoPropertyName = "NullableOneOfToolChoiceOptionsToolChoiceTypesToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceOptions?), TypeInfoPropertyName = "NullableToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesTruncation?), TypeInfoPropertyName = "NullableResponsePropertiesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEventType?), TypeInfoPropertyName = "NullableResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEventType?), TypeInfoPropertyName = "NullableResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEvent?), TypeInfoPropertyName = "NullableResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?), TypeInfoPropertyName = "NullableResponseTextAnnotationDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEventType?), TypeInfoPropertyName = "NullableResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOption?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatType?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectObject?), TypeInfoPropertyName = "NullableAssistantObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>?), TypeInfoPropertyName = "NullableOneOfAssistantToolsCodeAssistantToolsFileSearchAssistantToolsFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestModel?), TypeInfoPropertyName = "NullableCreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponses?), TypeInfoPropertyName = "NullableModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponsesEnum?), TypeInfoPropertyName = "NullableModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponseObject?), TypeInfoPropertyName = "NullableDeleteAssistantResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminatorType?), TypeInfoPropertyName = "NullableItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReferenceType?), TypeInfoPropertyName = "NullableItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPressType?), TypeInfoPropertyName = "NullableKeyPressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsCodeType?), TypeInfoPropertyName = "NullableAssistantToolsCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchType?), TypeInfoPropertyName = "NullableAssistantToolsFileSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType?), TypeInfoPropertyName = "NullableAssistantToolsFileSearchTypeOnlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantToolsFunctionType?), TypeInfoPropertyName = "NullableAssistantToolsFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TruncationObjectType?), TypeInfoPropertyName = "NullableTruncationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiToolChoiceOption?), TypeInfoPropertyName = "NullableAssistantsApiToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableAssistantsApiToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsNamedToolChoiceType?), TypeInfoPropertyName = "NullableAssistantsNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectObject?), TypeInfoPropertyName = "NullableRunObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectStatus?), TypeInfoPropertyName = "NullableRunObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectRequiredActionType?), TypeInfoPropertyName = "NullableRunObjectRequiredActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectLastErrorCode?), TypeInfoPropertyName = "NullableRunObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunObjectIncompleteDetailsReason?), TypeInfoPropertyName = "NullableRunObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRunRequestModel?), TypeInfoPropertyName = "NullableCreateRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectType?), TypeInfoPropertyName = "NullableRunToolCallObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScreenshotType?), TypeInfoPropertyName = "NullableScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScrollType?), TypeInfoPropertyName = "NullableScrollType2")]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadAndRunRequestModel?), TypeInfoPropertyName = "NullableCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadObjectObject?), TypeInfoPropertyName = "NullableThreadObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteThreadResponseObject?), TypeInfoPropertyName = "NullableDeleteThreadResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectObject?), TypeInfoPropertyName = "NullableMessageObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectStatus?), TypeInfoPropertyName = "NullableMessageObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectIncompleteDetailsReason?), TypeInfoPropertyName = "NullableMessageObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageObjectRole?), TypeInfoPropertyName = "NullableMessageObjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>?), TypeInfoPropertyName = "NullableOneOfAssistantToolsCodeAssistantToolsFileSearchTypeOnly2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObjectObject?), TypeInfoPropertyName = "NullableMessageDeltaObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaObjectDeltaRole?), TypeInfoPropertyName = "NullableMessageDeltaObjectDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>?), TypeInfoPropertyName = "NullableOneOfMessageDeltaContentImageFileObjectMessageDeltaContentTextObjectMessageDeltaContentImageUrlObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMessageRequestRole?), TypeInfoPropertyName = "NullableCreateMessageRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>?), TypeInfoPropertyName = "NullableOneOfStringIListOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteMessageResponseObject?), TypeInfoPropertyName = "NullableDeleteMessageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectType?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObjectType?), TypeInfoPropertyName = "NullableMessageDeltaContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail?), TypeInfoPropertyName = "NullableMessageDeltaContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectType?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObjectType?), TypeInfoPropertyName = "NullableMessageDeltaContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail?), TypeInfoPropertyName = "NullableMessageDeltaContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextObjectType?), TypeInfoPropertyName = "NullableMessageContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentTextAnnotationsFileCitationObjectMessageContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageRequestContentTextObjectType?), TypeInfoPropertyName = "NullableMessageRequestContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextObjectType?), TypeInfoPropertyName = "NullableMessageDeltaContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>?), TypeInfoPropertyName = "NullableOneOfMessageDeltaContentTextAnnotationsFileCitationObjectMessageDeltaContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType?), TypeInfoPropertyName = "NullableMessageDeltaContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType?), TypeInfoPropertyName = "NullableMessageDeltaContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectObject?), TypeInfoPropertyName = "NullableRunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectType?), TypeInfoPropertyName = "NullableRunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectStatus?), TypeInfoPropertyName = "NullableRunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastErrorCode?), TypeInfoPropertyName = "NullableRunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaObjectObject?), TypeInfoPropertyName = "NullableRunStepDeltaObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDeltaStepDetailsMessageCreationObjectRunStepDeltaStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectRunStepDeltaStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType?), TypeInfoPropertyName = "NullableRunStepDeltaStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfterAnchor?), TypeInfoPropertyName = "NullableVectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectObject?), TypeInfoPropertyName = "NullableVectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker?), TypeInfoPropertyName = "NullableVectorStoreSearchRequestRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultContentObjectType?), TypeInfoPropertyName = "NullableVectorStoreSearchResultContentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreSearchResultsPageObject?), TypeInfoPropertyName = "NullableVectorStoreSearchResultsPageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VoiceIdsShared?), TypeInfoPropertyName = "NullableVoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VoiceIdsSharedEnum?), TypeInfoPropertyName = "NullableVoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WaitType?), TypeInfoPropertyName = "NullableWaitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchContextSize?), TypeInfoPropertyName = "NullableWebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>?), TypeInfoPropertyName = "NullableAllOfWebSearchLocationWebSearchToolUserLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocationType?), TypeInfoPropertyName = "NullableWebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallType?), TypeInfoPropertyName = "NullableWebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallStatus?), TypeInfoPropertyName = "NullableWebSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>?), TypeInfoPropertyName = "NullableOneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TypeType1?), TypeInfoPropertyName = "NullableTypeType12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitationType?), TypeInfoPropertyName = "NullableUrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?), TypeInfoPropertyName = "NullableVectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>?), TypeInfoPropertyName = "NullableOneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableOtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableAutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChunkingStrategyRequestParam?), TypeInfoPropertyName = "NullableChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantStreamEvent?), TypeInfoPropertyName = "NullableAssistantStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadStreamEvent?), TypeInfoPropertyName = "NullableThreadStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEvent?), TypeInfoPropertyName = "NullableRunStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEvent?), TypeInfoPropertyName = "NullableRunStepStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEvent?), TypeInfoPropertyName = "NullableMessageStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ThreadStreamEventVariant1Event?), TypeInfoPropertyName = "NullableThreadStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunctionType?), TypeInfoPropertyName = "NullableToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypesType?), TypeInfoPropertyName = "NullableToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant1Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant2Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant3Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant4Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant5Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant6Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant6Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant7Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant7Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant8Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant8Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant9Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant9Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStreamEventVariant10Event?), TypeInfoPropertyName = "NullableRunStreamEventVariant10Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant1Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant2Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant3Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant4Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant5Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant6Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant6Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepStreamEventVariant7Event?), TypeInfoPropertyName = "NullableRunStepStreamEventVariant7Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant1Event?), TypeInfoPropertyName = "NullableMessageStreamEventVariant1Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant2Event?), TypeInfoPropertyName = "NullableMessageStreamEventVariant2Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant3Event?), TypeInfoPropertyName = "NullableMessageStreamEventVariant3Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant4Event?), TypeInfoPropertyName = "NullableMessageStreamEventVariant4Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageStreamEventVariant5Event?), TypeInfoPropertyName = "NullableMessageStreamEventVariant5Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ErrorEventEvent?), TypeInfoPropertyName = "NullableErrorEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitationType?), TypeInfoPropertyName = "NullableFileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePathType?), TypeInfoPropertyName = "NullableFilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoneEventEvent?), TypeInfoPropertyName = "NullableDoneEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoneEventData?), TypeInfoPropertyName = "NullableDoneEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchObject?), TypeInfoPropertyName = "NullableBatchObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestInputMethod?), TypeInfoPropertyName = "NullableBatchRequestInputMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponseObject?), TypeInfoPropertyName = "NullableListBatchesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType?), TypeInfoPropertyName = "NullableRateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit?), TypeInfoPropertyName = "NullableRateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType?), TypeInfoPropertyName = "NullableUsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfiguration?), TypeInfoPropertyName = "NullableSageMakerConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponse?), TypeInfoPropertyName = "NullableIntegrationDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?), TypeInfoPropertyName = "NullableAzureOpenAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfigurationAwsAuthType?), TypeInfoPropertyName = "NullableBedrockConfigurationAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfigurationVertexAuthType?), TypeInfoPropertyName = "NullableVertexAIConfigurationVertexAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?), TypeInfoPropertyName = "NullableAzureAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat?), TypeInfoPropertyName = "NullableSecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestManagerType?), TypeInfoPropertyName = "NullableCreateSecretReferenceRequestManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuthConfig?), TypeInfoPropertyName = "NullableAuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?), TypeInfoPropertyName = "NullableCreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemManagerType?), TypeInfoPropertyName = "NullableSecretReferenceListItemManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemStatus?), TypeInfoPropertyName = "NullableSecretReferenceListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemObject?), TypeInfoPropertyName = "NullableSecretReferenceListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseManagerType?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseStatus?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseObject?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsAccessKeyAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsAssumedRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsServiceRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureEntraAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureManagedAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureDefaultAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpTokenAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpAppRoleAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpKubernetesAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListStatus?), TypeInfoPropertyName = "NullableIntegrationListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListObject?), TypeInfoPropertyName = "NullableIntegrationListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingConfigType?), TypeInfoPropertyName = "NullablePricingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ProvidersStatus?), TypeInfoPropertyName = "NullableProvidersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ProvidersObject?), TypeInfoPropertyName = "NullableProvidersObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysStatus?), TypeInfoPropertyName = "NullableVirtualKeysStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysObject?), TypeInfoPropertyName = "NullableVirtualKeysObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole2?), TypeInfoPropertyName = "NullableInviteRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteStatus?), TypeInfoPropertyName = "NullableInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteListObject?), TypeInfoPropertyName = "NullableInviteListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserObject?), TypeInfoPropertyName = "NullableUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserRole?), TypeInfoPropertyName = "NullableUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UserListObject?), TypeInfoPropertyName = "NullableUserListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject?), TypeInfoPropertyName = "NullableWorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole?), TypeInfoPropertyName = "NullableWorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole?), TypeInfoPropertyName = "NullableWorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus?), TypeInfoPropertyName = "NullableWorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberListObject?), TypeInfoPropertyName = "NullableWorkspaceMemberListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaultsObject?), TypeInfoPropertyName = "NullableWorkspaceDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceListObject?), TypeInfoPropertyName = "NullableWorkspaceListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?), TypeInfoPropertyName = "NullableWorkspaceWithUsersDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMappingRole?), TypeInfoPropertyName = "NullableScimWorkspaceMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionStatus?), TypeInfoPropertyName = "NullableCollectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithDetails?), TypeInfoPropertyName = "NullableCollectionWithDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CollectionWithChildCollections?), TypeInfoPropertyName = "NullableCollectionWithChildCollections2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummaryObject?), TypeInfoPropertyName = "NullablePromptSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPromptVersionStatus?), TypeInfoPropertyName = "NullablePromptPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryStatus?), TypeInfoPropertyName = "NullablePromptVersionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryObject?), TypeInfoPropertyName = "NullablePromptVersionSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialSummaryStatus?), TypeInfoPropertyName = "NullablePromptPartialSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialSummaryObject?), TypeInfoPropertyName = "NullablePromptPartialSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialStatus?), TypeInfoPropertyName = "NullablePromptPartialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialVersionPromptVersionStatus?), TypeInfoPropertyName = "NullablePromptPartialVersionPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPartialVersionObject?), TypeInfoPropertyName = "NullablePromptPartialVersionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponseObject?), TypeInfoPropertyName = "NullableExportListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemStatus?), TypeInfoPropertyName = "NullableExportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemObject?), TypeInfoPropertyName = "NullableExportItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponseObject?), TypeInfoPropertyName = "NullableUpdateExportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponseObject?), TypeInfoPropertyName = "NullableExportTaskResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogRequestMethod?), TypeInfoPropertyName = "NullableLogRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogExportsRequestedDataItem?), TypeInfoPropertyName = "NullableLogExportsRequestedDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListRecordMethod?), TypeInfoPropertyName = "NullableAuditLogObjectListRecordMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListRecordUserType?), TypeInfoPropertyName = "NullableAuditLogObjectListRecordUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuditLogObjectListObject?), TypeInfoPropertyName = "NullableAuditLogObjectListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectType?), TypeInfoPropertyName = "NullableApiKeyObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectStatus?), TypeInfoPropertyName = "NullableApiKeyObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectCreationMode?), TypeInfoPropertyName = "NullableApiKeyObjectCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectObject?), TypeInfoPropertyName = "NullableApiKeyObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ApiKeyObjectListObject?), TypeInfoPropertyName = "NullableApiKeyObjectListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRateLimitType?), TypeInfoPropertyName = "NullableCreateApiKeyObjectRateLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit?), TypeInfoPropertyName = "NullableCreateApiKeyObjectRateLimitUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod?), TypeInfoPropertyName = "NullableCreateApiKeyObjectRotationPolicyRotationPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRateLimitType?), TypeInfoPropertyName = "NullableUpdateApiKeyObjectRateLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit?), TypeInfoPropertyName = "NullableUpdateApiKeyObjectRateLimitUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod?), TypeInfoPropertyName = "NullableUpdateApiKeyObjectRotationPolicyRotationPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestCreateCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailCheckId?), TypeInfoPropertyName = "NullableGuardrailCheckId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailSummaryStatus?), TypeInfoPropertyName = "NullableGuardrailSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GuardrailDetails?), TypeInfoPropertyName = "NullableGuardrailDetails2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobCompletionWindow?), TypeInfoPropertyName = "NullableOpenAIBatchJobCompletionWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobEndpoint?), TypeInfoPropertyName = "NullableOpenAIBatchJobEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>?), TypeInfoPropertyName = "NullableAnyOfPortkeyBatchJobProviderOptionsBedrockOptionsPortkeyBatchJobProviderOptionsVertexOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?), TypeInfoPropertyName = "NullableCreateUsageLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?), TypeInfoPropertyName = "NullableCreateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?), TypeInfoPropertyName = "NullableUpdateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestType?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?), TypeInfoPropertyName = "NullableUpdateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyType?), TypeInfoPropertyName = "NullableUsageLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPolicyPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyStatus?), TypeInfoPropertyName = "NullableUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsageStatus?), TypeInfoPropertyName = "NullableValueKeyUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyType?), TypeInfoPropertyName = "NullableRateLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyUnit?), TypeInfoPropertyName = "NullableRateLimitsPolicyUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyStatus?), TypeInfoPropertyName = "NullableRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyTarget?), TypeInfoPropertyName = "NullableRateLimitsPolicyTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponse?), TypeInfoPropertyName = "NullableUsageLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponse?), TypeInfoPropertyName = "NullableRateLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationAuthType?), TypeInfoPropertyName = "NullableCreateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationTransport?), TypeInfoPropertyName = "NullableCreateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationAuthType?), TypeInfoPropertyName = "NullableMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationTransport?), TypeInfoPropertyName = "NullableMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationType?), TypeInfoPropertyName = "NullableMcpIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemType?), TypeInfoPropertyName = "NullableMcpIntegrationListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemAuthType?), TypeInfoPropertyName = "NullableMcpIntegrationListItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemTransport?), TypeInfoPropertyName = "NullableMcpIntegrationListItemTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationAuthType?), TypeInfoPropertyName = "NullableUpdateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationTransport?), TypeInfoPropertyName = "NullableUpdateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilityItemType?), TypeInfoPropertyName = "NullableMcpIntegrationCapabilityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType?), TypeInfoPropertyName = "NullableBulkUpdateMcpIntegrationCapabilitiesCapabilitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilityItemType?), TypeInfoPropertyName = "NullableMcpServerCapabilityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType?), TypeInfoPropertyName = "NullableBulkUpdateMcpServerCapabilitiesCapabilitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessItemConnectionStatus?), TypeInfoPropertyName = "NullableMcpServerUserAccessItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess?), TypeInfoPropertyName = "NullableMcpServerUserAccessListResponseDefaultUserAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess?), TypeInfoPropertyName = "NullableBulkUpdateMcpServerUserAccessDefaultUserAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequestType?), TypeInfoPropertyName = "NullableCreateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestType?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestStatus?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>?), TypeInfoPropertyName = "NullableAllOfDeploymentAuthSettingsInputUpdateDeploymentRequestAuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponseObject?), TypeInfoPropertyName = "NullableDeploymentCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemType?), TypeInfoPropertyName = "NullableDeploymentListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemStatus?), TypeInfoPropertyName = "NullableDeploymentListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemConnectionStatus?), TypeInfoPropertyName = "NullableDeploymentListItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemObject?), TypeInfoPropertyName = "NullableDeploymentListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponse?), TypeInfoPropertyName = "NullableDeploymentDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>?), TypeInfoPropertyName = "NullableAllOfDeploymentAuthSettingsDeploymentDetailResponseVariant2AuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutboundStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseOutboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInboundStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseInboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseObject?), TypeInfoPropertyName = "NullableDeploymentPingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>?), TypeInfoPropertyName = "NullableAnyOfOpenAIFinetuneJobBedrockFinetuneJobPortkeyFinetuneJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>?), TypeInfoPropertyName = "NullableAnyOfOpenAIBatchJobBedrockBatchJobVertexBatchJobPortkeyBatchJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestProvider?), TypeInfoPropertyName = "NullableCreateVirtualKeysRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminUsersRequestRole?), TypeInfoPropertyName = "NullablePutAdminUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?), TypeInfoPropertyName = "NullableCreateAdminWorkspacesUsersRequestUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?), TypeInfoPropertyName = "NullablePutAdminWorkspacesUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequestRole?), TypeInfoPropertyName = "NullableCreateScimWorkspacesRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>?), TypeInfoPropertyName = "NullableOneOfCustomLogIListCustomLog2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsSort?), TypeInfoPropertyName = "NullableListModelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListModelsOrder?), TypeInfoPropertyName = "NullableListModelsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListAssistantsOrder?), TypeInfoPropertyName = "NullableListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListInputItemsOrder?), TypeInfoPropertyName = "NullableListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListMessagesOrder?), TypeInfoPropertyName = "NullableListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunsOrder?), TypeInfoPropertyName = "NullableListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsOrder?), TypeInfoPropertyName = "NullableListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresOrder?), TypeInfoPropertyName = "NullableListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesOrder?), TypeInfoPropertyName = "NullableListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesFilter?), TypeInfoPropertyName = "NullableListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsType?), TypeInfoPropertyName = "NullableGetIntegrationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesRole?), TypeInfoPropertyName = "NullableGetAdminUsersInvitesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesStatus?), TypeInfoPropertyName = "NullableGetAdminUsersInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersRole?), TypeInfoPropertyName = "NullableGetAdminUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesUsersRole?), TypeInfoPropertyName = "NullableGetAdminWorkspacesUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesStatus?), TypeInfoPropertyName = "NullableGetAdminWorkspacesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesRole?), TypeInfoPropertyName = "NullableGetScimWorkspacesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationsListType?), TypeInfoPropertyName = "NullableMcpIntegrationsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesListType?), TypeInfoPropertyName = "NullableMcpIntegrationCapabilitiesListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesListType?), TypeInfoPropertyName = "NullableMcpServerCapabilitiesListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetLogsPathFormat?), TypeInfoPropertyName = "NullableGetLogsPathFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetLogsType?), TypeInfoPropertyName = "NullableGetLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAuditLogsMethod?), TypeInfoPropertyName = "NullableGetAuditLogsMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAuditLogsUserType?), TypeInfoPropertyName = "NullableGetAuditLogsUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysType?), TypeInfoPropertyName = "NullableCreateKeysType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysSubType?), TypeInfoPropertyName = "NullableCreateKeysSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesStatus?), TypeInfoPropertyName = "NullableListUsageLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesType?), TypeInfoPropertyName = "NullableListUsageLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetUsageLimitsPolicyStatus?), TypeInfoPropertyName = "NullableGetUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?), TypeInfoPropertyName = "NullableListUsageLimitsPolicyEntitiesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesStatus?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesType?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesUnit?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesTarget?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetRateLimitsPolicyStatus?), TypeInfoPropertyName = "NullableGetRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsProviderIncludeTotal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesManagerType?), TypeInfoPropertyName = "NullableListSecretReferencesManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsStatus?), TypeInfoPropertyName = "NullableListDeploymentsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsType?), TypeInfoPropertyName = "NullableListDeploymentsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponseObject?), TypeInfoPropertyName = "NullableCreatePromptResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionResponseCreateCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>?), TypeInfoPropertyName = "NullableOneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>?), TypeInfoPropertyName = "NullableOneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponseObject?), TypeInfoPropertyName = "NullableGetIntegrationsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetProvidersResponseObject?), TypeInfoPropertyName = "NullableGetProvidersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseObject?), TypeInfoPropertyName = "NullableGetVirtualKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?), TypeInfoPropertyName = "NullableGetScimWorkspacesResponseMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>?), TypeInfoPropertyName = "NullableOneOfMcpIntegrationWorkspacesListResponseMcpIntegrationWorkspacesLegacyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateKeysResponseObject?), TypeInfoPropertyName = "NullableCreateKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCostResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsTokensResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsUsersRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsStacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsStatusCodesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsRequestsRescuedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCacheHitRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCacheLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksScoresResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksWeightedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsSummaryCacheResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsUsersResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsAiModelsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsProviderResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMetadataResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMetadataResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponseObject?), TypeInfoPropertyName = "NullableListSecretReferencesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponseObject?), TypeInfoPropertyName = "NullableCreateSecretReferenceResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponseObject?), TypeInfoPropertyName = "NullableListDeploymentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Model11>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FileSearchToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionFunctionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Includable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OpenAIFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RerankDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RerankResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OcrPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OcrPageImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Coordinate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ResponseModalitiesTextOnlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ThreadObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AzureDeploymentConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.IntegrationModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ModelUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.IntegrationWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChildCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ExportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.LogExportsRequestedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AuditLogObjectListRecord>))]
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ApiKeyObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UpdateApiKeyObjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GuardrailCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GuardrailSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersAllowedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersBlockedType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PillarScanParametersScanner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PortkeyModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PortkeyPIIParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MistralModerationParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersPiiCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersSecretsCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AzureContentSafetyParametersCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicyEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpIntegrationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpIntegrationWorkspaceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpIntegrationCapabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerCapabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerUserAccessItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpServerConnectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.DeploymentDetailResponseVariant2Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateAdminWorkspacesUsersRequestUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.List<global::Portkey.CustomLog>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CustomLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CollectionWithDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptPartialSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptPartialVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ListConfigsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetConfigResponseDataConfigTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ListConfigVersionsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.IntegrationList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Providers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VirtualKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetScimWorkspacesResponseMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.DeploymentListItem>))]
    internal sealed partial class SourceGenerationContextChunk5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputContentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RerankDocumentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerActionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.Content3JsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ThreadStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuthConfigJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailDetailsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeploymentDetailResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>());
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>());
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>());
            options.Converters.Add(new global::Portkey.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Portkey.ModelPricingConfigCurrency)

                    || typeToConvert == typeof(global::Portkey.ModelPricingConfigCurrency?)

                    || typeToConvert == typeof(global::Portkey.ModelCalculateOperationOperation)

                    || typeToConvert == typeof(global::Portkey.ModelCalculateOperationOperation?)

                    || typeToConvert == typeof(global::Portkey.InviteRole)

                    || typeToConvert == typeof(global::Portkey.InviteRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteType)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteType?)

                    || typeToConvert == typeof(global::Portkey.ListModelsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListModelsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolType)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolType?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallType)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallType?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType?)

                    || typeToConvert == typeof(global::Portkey.OutputAudioType)

                    || typeToConvert == typeof(global::Portkey.OutputAudioType?)

                    || typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageType)

                    || typeToConvert == typeof(global::Portkey.OutputMessageType?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageRole)

                    || typeToConvert == typeof(global::Portkey.OutputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageStatus)

                    || typeToConvert == typeof(global::Portkey.OutputMessageStatus?)

                    || typeToConvert == typeof(global::Portkey.OutputTextType)

                    || typeToConvert == typeof(global::Portkey.OutputTextType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallChunkType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallChunkType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestQuality)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestQuality?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestSize?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestStyle)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestStyle?)

                    || typeToConvert == typeof(global::Portkey.Includable)

                    || typeToConvert == typeof(global::Portkey.Includable?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::Portkey.InputAudioType)

                    || typeToConvert == typeof(global::Portkey.InputAudioType?)

                    || typeToConvert == typeof(global::Portkey.InputAudioFormat)

                    || typeToConvert == typeof(global::Portkey.InputAudioFormat?)

                    || typeToConvert == typeof(global::Portkey.InputFileType)

                    || typeToConvert == typeof(global::Portkey.InputFileType?)

                    || typeToConvert == typeof(global::Portkey.InputImageType)

                    || typeToConvert == typeof(global::Portkey.InputImageType?)

                    || typeToConvert == typeof(global::Portkey.InputImageDetail)

                    || typeToConvert == typeof(global::Portkey.InputImageDetail?)

                    || typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.InputMessageType)

                    || typeToConvert == typeof(global::Portkey.InputMessageType?)

                    || typeToConvert == typeof(global::Portkey.InputMessageRole)

                    || typeToConvert == typeof(global::Portkey.InputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.InputMessageStatus)

                    || typeToConvert == typeof(global::Portkey.InputMessageStatus?)

                    || typeToConvert == typeof(global::Portkey.InputTextType)

                    || typeToConvert == typeof(global::Portkey.InputTextType?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize?)

                    || typeToConvert == typeof(global::Portkey.CreateModerationRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateModerationRequestModel?)

                    || typeToConvert == typeof(global::Portkey.ListFilesResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListFilesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateFileRequestPurpose)

                    || typeToConvert == typeof(global::Portkey.CreateFileRequestPurpose?)

                    || typeToConvert == typeof(global::Portkey.DeleteFileResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteFileResponseObject?)

                    || typeToConvert == typeof(global::Portkey.OpenAIFinetuneJobMethodType)

                    || typeToConvert == typeof(global::Portkey.OpenAIFinetuneJobMethodType?)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateRerankResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateRerankResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateOcrRequestDocumentType)

                    || typeToConvert == typeof(global::Portkey.CreateOcrRequestDocumentType?)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.ModelObject)

                    || typeToConvert == typeof(global::Portkey.ModelObject?)

                    || typeToConvert == typeof(global::Portkey.MoveType)

                    || typeToConvert == typeof(global::Portkey.MoveType?)

                    || typeToConvert == typeof(global::Portkey.OpenAIFileObject)

                    || typeToConvert == typeof(global::Portkey.OpenAIFileObject?)

                    || typeToConvert == typeof(global::Portkey.OpenAIFilePurpose)

                    || typeToConvert == typeof(global::Portkey.OpenAIFilePurpose?)

                    || typeToConvert == typeof(global::Portkey.OpenAIFileStatus)

                    || typeToConvert == typeof(global::Portkey.OpenAIFileStatus?)

                    || typeToConvert == typeof(global::Portkey.DoubleClickType)

                    || typeToConvert == typeof(global::Portkey.DoubleClickType?)

                    || typeToConvert == typeof(global::Portkey.DragType)

                    || typeToConvert == typeof(global::Portkey.DragType?)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageRole)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageType)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageType?)

                    || typeToConvert == typeof(global::Portkey.EmbeddingObject)

                    || typeToConvert == typeof(global::Portkey.EmbeddingObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobStatus)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobStatus?)

                    || typeToConvert == typeof(global::Portkey.FineTuningIntegrationType)

                    || typeToConvert == typeof(global::Portkey.FineTuningIntegrationType?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject?)

                    || typeToConvert == typeof(global::Portkey.ClickType)

                    || typeToConvert == typeof(global::Portkey.ClickType?)

                    || typeToConvert == typeof(global::Portkey.ClickButton)

                    || typeToConvert == typeof(global::Portkey.ClickButton?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.ComparisonFilterType)

                    || typeToConvert == typeof(global::Portkey.ComparisonFilterType?)

                    || typeToConvert == typeof(global::Portkey.CompoundFilterType)

                    || typeToConvert == typeof(global::Portkey.CompoundFilterType?)

                    || typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType)

                    || typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolEnvironment)

                    || typeToConvert == typeof(global::Portkey.ComputerToolEnvironment?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::Portkey.CostsResultObject)

                    || typeToConvert == typeof(global::Portkey.CostsResultObject?)

                    || typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary)

                    || typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::Portkey.ReasoningEffort)

                    || typeToConvert == typeof(global::Portkey.ReasoningEffort?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemType)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemType?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemStatus)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::Portkey.RefusalType)

                    || typeToConvert == typeof(global::Portkey.RefusalType?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Object)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Object?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Status)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Status?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCreatedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCreatedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorCode)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorCode?)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFailedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFailedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseItemListObject)

                    || typeToConvert == typeof(global::Portkey.ResponseItemListObject?)

                    || typeToConvert == typeof(global::Portkey.ResponseModalitie)

                    || typeToConvert == typeof(global::Portkey.ResponseModalitie?)

                    || typeToConvert == typeof(global::Portkey.ResponseModalitiesTextOnlyItem)

                    || typeToConvert == typeof(global::Portkey.ResponseModalitiesTextOnlyItem?)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation)

                    || typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation?)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum?)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatType)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatType?)

                    || typeToConvert == typeof(global::Portkey.AssistantObjectObject)

                    || typeToConvert == typeof(global::Portkey.AssistantObjectObject?)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType)

                    || typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?)

                    || typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.ItemReferenceType)

                    || typeToConvert == typeof(global::Portkey.ItemReferenceType?)

                    || typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.KeyPressType)

                    || typeToConvert == typeof(global::Portkey.KeyPressType?)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsCodeType)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsCodeType?)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchType)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchType?)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType?)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFunctionType)

                    || typeToConvert == typeof(global::Portkey.AssistantToolsFunctionType?)

                    || typeToConvert == typeof(global::Portkey.TruncationObjectType)

                    || typeToConvert == typeof(global::Portkey.TruncationObjectType?)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::Portkey.AssistantsNamedToolChoiceType)

                    || typeToConvert == typeof(global::Portkey.AssistantsNamedToolChoiceType?)

                    || typeToConvert == typeof(global::Portkey.RunObjectObject)

                    || typeToConvert == typeof(global::Portkey.RunObjectObject?)

                    || typeToConvert == typeof(global::Portkey.RunObjectStatus)

                    || typeToConvert == typeof(global::Portkey.RunObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.RunObjectRequiredActionType)

                    || typeToConvert == typeof(global::Portkey.RunObjectRequiredActionType?)

                    || typeToConvert == typeof(global::Portkey.RunObjectLastErrorCode)

                    || typeToConvert == typeof(global::Portkey.RunObjectLastErrorCode?)

                    || typeToConvert == typeof(global::Portkey.RunObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::Portkey.RunObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::Portkey.CreateRunRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateRunRequestModel?)

                    || typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Portkey.RunToolCallObjectType)

                    || typeToConvert == typeof(global::Portkey.RunToolCallObjectType?)

                    || typeToConvert == typeof(global::Portkey.ScreenshotType)

                    || typeToConvert == typeof(global::Portkey.ScreenshotType?)

                    || typeToConvert == typeof(global::Portkey.ScrollType)

                    || typeToConvert == typeof(global::Portkey.ScrollType?)

                    || typeToConvert == typeof(global::Portkey.CreateThreadAndRunRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateThreadAndRunRequestModel?)

                    || typeToConvert == typeof(global::Portkey.ThreadObjectObject)

                    || typeToConvert == typeof(global::Portkey.ThreadObjectObject?)

                    || typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType)

                    || typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?)

                    || typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType)

                    || typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?)

                    || typeToConvert == typeof(global::Portkey.DeleteThreadResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteThreadResponseObject?)

                    || typeToConvert == typeof(global::Portkey.MessageObjectObject)

                    || typeToConvert == typeof(global::Portkey.MessageObjectObject?)

                    || typeToConvert == typeof(global::Portkey.MessageObjectStatus)

                    || typeToConvert == typeof(global::Portkey.MessageObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.MessageObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::Portkey.MessageObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::Portkey.MessageObjectRole)

                    || typeToConvert == typeof(global::Portkey.MessageObjectRole?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaObjectObject)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaObjectObject?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaObjectDeltaRole)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaObjectDeltaRole?)

                    || typeToConvert == typeof(global::Portkey.CreateMessageRequestRole)

                    || typeToConvert == typeof(global::Portkey.CreateMessageRequestRole?)

                    || typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectObject)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectObject?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectStatus)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaObjectObject)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaObjectObject?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor)

                    || typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchResultContentObjectType)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchResultContentObjectType?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchResultsPageObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreSearchResultsPageObject?)

                    || typeToConvert == typeof(global::Portkey.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::Portkey.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::Portkey.WaitType)

                    || typeToConvert == typeof(global::Portkey.WaitType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchContextSize)

                    || typeToConvert == typeof(global::Portkey.WebSearchContextSize?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.TypeType1)

                    || typeToConvert == typeof(global::Portkey.TypeType1?)

                    || typeToConvert == typeof(global::Portkey.UrlCitationType)

                    || typeToConvert == typeof(global::Portkey.UrlCitationType?)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?)

                    || typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.ThreadStreamEventVariant1Event)

                    || typeToConvert == typeof(global::Portkey.ThreadStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceOptions)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceTypesType)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceTypesType?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant1Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant2Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant3Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant4Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant5Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant6Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant6Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant7Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant7Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant8Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant8Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant9Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant9Event?)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant10Event)

                    || typeToConvert == typeof(global::Portkey.RunStreamEventVariant10Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant1Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant2Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant3Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant4Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant5Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant6Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant6Event?)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant7Event)

                    || typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant7Event?)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant1Event)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant2Event)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant3Event)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant4Event)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant5Event)

                    || typeToConvert == typeof(global::Portkey.MessageStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::Portkey.ErrorEventEvent)

                    || typeToConvert == typeof(global::Portkey.ErrorEventEvent?)

                    || typeToConvert == typeof(global::Portkey.FileCitationType)

                    || typeToConvert == typeof(global::Portkey.FileCitationType?)

                    || typeToConvert == typeof(global::Portkey.FilePathType)

                    || typeToConvert == typeof(global::Portkey.FilePathType?)

                    || typeToConvert == typeof(global::Portkey.DoneEventEvent)

                    || typeToConvert == typeof(global::Portkey.DoneEventEvent?)

                    || typeToConvert == typeof(global::Portkey.DoneEventData)

                    || typeToConvert == typeof(global::Portkey.DoneEventData?)

                    || typeToConvert == typeof(global::Portkey.BatchObject)

                    || typeToConvert == typeof(global::Portkey.BatchObject?)

                    || typeToConvert == typeof(global::Portkey.BatchStatus)

                    || typeToConvert == typeof(global::Portkey.BatchStatus?)

                    || typeToConvert == typeof(global::Portkey.BatchRequestInputMethod)

                    || typeToConvert == typeof(global::Portkey.BatchRequestInputMethod?)

                    || typeToConvert == typeof(global::Portkey.ListBatchesResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListBatchesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType)

                    || typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType?)

                    || typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType?)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject?)

                    || typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.IntegrationListStatus)

                    || typeToConvert == typeof(global::Portkey.IntegrationListStatus?)

                    || typeToConvert == typeof(global::Portkey.IntegrationListObject)

                    || typeToConvert == typeof(global::Portkey.IntegrationListObject?)

                    || typeToConvert == typeof(global::Portkey.PricingConfigType)

                    || typeToConvert == typeof(global::Portkey.PricingConfigType?)

                    || typeToConvert == typeof(global::Portkey.ProvidersStatus)

                    || typeToConvert == typeof(global::Portkey.ProvidersStatus?)

                    || typeToConvert == typeof(global::Portkey.ProvidersObject)

                    || typeToConvert == typeof(global::Portkey.ProvidersObject?)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysStatus)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysStatus?)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysObject)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysObject?)

                    || typeToConvert == typeof(global::Portkey.InviteRole2)

                    || typeToConvert == typeof(global::Portkey.InviteRole2?)

                    || typeToConvert == typeof(global::Portkey.InviteStatus)

                    || typeToConvert == typeof(global::Portkey.InviteStatus?)

                    || typeToConvert == typeof(global::Portkey.InviteListObject)

                    || typeToConvert == typeof(global::Portkey.InviteListObject?)

                    || typeToConvert == typeof(global::Portkey.UserObject)

                    || typeToConvert == typeof(global::Portkey.UserObject?)

                    || typeToConvert == typeof(global::Portkey.UserRole)

                    || typeToConvert == typeof(global::Portkey.UserRole?)

                    || typeToConvert == typeof(global::Portkey.UserListObject)

                    || typeToConvert == typeof(global::Portkey.UserListObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceListObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceListObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?)

                    || typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole)

                    || typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole?)

                    || typeToConvert == typeof(global::Portkey.CollectionStatus)

                    || typeToConvert == typeof(global::Portkey.CollectionStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptSummaryObject)

                    || typeToConvert == typeof(global::Portkey.PromptSummaryObject?)

                    || typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus)

                    || typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject?)

                    || typeToConvert == typeof(global::Portkey.PromptPartialSummaryStatus)

                    || typeToConvert == typeof(global::Portkey.PromptPartialSummaryStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptPartialSummaryObject)

                    || typeToConvert == typeof(global::Portkey.PromptPartialSummaryObject?)

                    || typeToConvert == typeof(global::Portkey.PromptPartialStatus)

                    || typeToConvert == typeof(global::Portkey.PromptPartialStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptPartialVersionPromptVersionStatus)

                    || typeToConvert == typeof(global::Portkey.PromptPartialVersionPromptVersionStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptPartialVersionObject)

                    || typeToConvert == typeof(global::Portkey.PromptPartialVersionObject?)

                    || typeToConvert == typeof(global::Portkey.ExportListResponseObject)

                    || typeToConvert == typeof(global::Portkey.ExportListResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ExportItemStatus)

                    || typeToConvert == typeof(global::Portkey.ExportItemStatus?)

                    || typeToConvert == typeof(global::Portkey.ExportItemObject)

                    || typeToConvert == typeof(global::Portkey.ExportItemObject?)

                    || typeToConvert == typeof(global::Portkey.UpdateExportResponseObject)

                    || typeToConvert == typeof(global::Portkey.UpdateExportResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ExportTaskResponseObject)

                    || typeToConvert == typeof(global::Portkey.ExportTaskResponseObject?)

                    || typeToConvert == typeof(global::Portkey.LogRequestMethod)

                    || typeToConvert == typeof(global::Portkey.LogRequestMethod?)

                    || typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem)

                    || typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem?)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordMethod)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordMethod?)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordUserType)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordUserType?)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListObject)

                    || typeToConvert == typeof(global::Portkey.AuditLogObjectListObject?)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectType)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectType?)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectStatus)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectCreationMode)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectCreationMode?)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectObject)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectObject?)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectListObject)

                    || typeToConvert == typeof(global::Portkey.ApiKeyObjectListObject?)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitType)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitType?)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit?)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod)

                    || typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod?)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitType)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitType?)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit?)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod)

                    || typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod?)

                    || typeToConvert == typeof(global::Portkey.GuardrailCheckId)

                    || typeToConvert == typeof(global::Portkey.GuardrailCheckId?)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus)

                    || typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus?)

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

                    || typeToConvert == typeof(global::Portkey.AzurePIIParametersDomain?)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow?)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint?)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType?)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?)

                    || typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit)

                    || typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus)

                    || typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget?)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport?)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationCapabilityItemType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationCapabilityItemType?)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType?)

                    || typeToConvert == typeof(global::Portkey.McpServerCapabilityItemType)

                    || typeToConvert == typeof(global::Portkey.McpServerCapabilityItemType?)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType?)

                    || typeToConvert == typeof(global::Portkey.McpServerUserAccessItemConnectionStatus)

                    || typeToConvert == typeof(global::Portkey.McpServerUserAccessItemConnectionStatus?)

                    || typeToConvert == typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess)

                    || typeToConvert == typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess?)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess)

                    || typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess?)

                    || typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType?)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType?)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemType)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemType?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemObject?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider)

                    || typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider?)

                    || typeToConvert == typeof(global::Portkey.PutAdminUsersRequestRole)

                    || typeToConvert == typeof(global::Portkey.PutAdminUsersRequestRole?)

                    || typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole)

                    || typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?)

                    || typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole)

                    || typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?)

                    || typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole)

                    || typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole?)

                    || typeToConvert == typeof(global::Portkey.ListModelsSort)

                    || typeToConvert == typeof(global::Portkey.ListModelsSort?)

                    || typeToConvert == typeof(global::Portkey.ListModelsOrder)

                    || typeToConvert == typeof(global::Portkey.ListModelsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListAssistantsOrder)

                    || typeToConvert == typeof(global::Portkey.ListAssistantsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListInputItemsOrder)

                    || typeToConvert == typeof(global::Portkey.ListInputItemsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListMessagesOrder)

                    || typeToConvert == typeof(global::Portkey.ListMessagesOrder?)

                    || typeToConvert == typeof(global::Portkey.ListRunsOrder)

                    || typeToConvert == typeof(global::Portkey.ListRunsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListRunStepsOrder)

                    || typeToConvert == typeof(global::Portkey.ListRunStepsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoresOrder)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoresOrder?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter?)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsType)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsType?)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus?)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersRole)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus?)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationsListType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationsListType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationCapabilitiesListType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationCapabilitiesListType?)

                    || typeToConvert == typeof(global::Portkey.McpServerCapabilitiesListType)

                    || typeToConvert == typeof(global::Portkey.McpServerCapabilitiesListType?)

                    || typeToConvert == typeof(global::Portkey.GetLogsPathFormat)

                    || typeToConvert == typeof(global::Portkey.GetLogsPathFormat?)

                    || typeToConvert == typeof(global::Portkey.GetLogsType)

                    || typeToConvert == typeof(global::Portkey.GetLogsType?)

                    || typeToConvert == typeof(global::Portkey.GetAuditLogsMethod)

                    || typeToConvert == typeof(global::Portkey.GetAuditLogsMethod?)

                    || typeToConvert == typeof(global::Portkey.GetAuditLogsUserType)

                    || typeToConvert == typeof(global::Portkey.GetAuditLogsUserType?)

                    || typeToConvert == typeof(global::Portkey.CreateKeysType)

                    || typeToConvert == typeof(global::Portkey.CreateKeysType?)

                    || typeToConvert == typeof(global::Portkey.CreateKeysSubType)

                    || typeToConvert == typeof(global::Portkey.CreateKeysSubType?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType?)

                    || typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget?)

                    || typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsStatus)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsStatus?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsType)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsType?)

                    || typeToConvert == typeof(global::Portkey.CreatePromptResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreatePromptResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetProvidersResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetProvidersResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?)

                    || typeToConvert == typeof(global::Portkey.CreateKeysResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateKeysResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.ModelPricingConfigCurrency))
                {
                    return new global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelPricingConfigCurrency?))
                {
                    return new global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelCalculateOperationOperation))
                {
                    return new global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelCalculateOperationOperation?))
                {
                    return new global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole))
                {
                    return new global::Portkey.JsonConverters.InviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole?))
                {
                    return new global::Portkey.JsonConverters.InviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteType))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteType?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolType))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolType?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallType))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallType?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole))
                {
                    return new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputAudioType))
                {
                    return new global::Portkey.JsonConverters.OutputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputAudioType?))
                {
                    return new global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.OutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.OutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageType))
                {
                    return new global::Portkey.JsonConverters.OutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageType?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageRole))
                {
                    return new global::Portkey.JsonConverters.OutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageStatus))
                {
                    return new global::Portkey.JsonConverters.OutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageStatus?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputTextType))
                {
                    return new global::Portkey.JsonConverters.OutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputTextType?))
                {
                    return new global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallChunkType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallChunkType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionStreamResponseDeltaRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionFunctionResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionStreamResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestQuality))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestQuality?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestStyle))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestStyle?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.Includable))
                {
                    return new global::Portkey.JsonConverters.IncludableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.Includable?))
                {
                    return new global::Portkey.JsonConverters.IncludableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputAudioType))
                {
                    return new global::Portkey.JsonConverters.InputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputAudioType?))
                {
                    return new global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputAudioFormat))
                {
                    return new global::Portkey.JsonConverters.InputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputAudioFormat?))
                {
                    return new global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputFileType))
                {
                    return new global::Portkey.JsonConverters.InputFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputFileType?))
                {
                    return new global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageType))
                {
                    return new global::Portkey.JsonConverters.InputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageType?))
                {
                    return new global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageDetail))
                {
                    return new global::Portkey.JsonConverters.InputImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageDetail?))
                {
                    return new global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.InputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.InputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageType))
                {
                    return new global::Portkey.JsonConverters.InputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageType?))
                {
                    return new global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageRole))
                {
                    return new global::Portkey.JsonConverters.InputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageStatus))
                {
                    return new global::Portkey.JsonConverters.InputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageStatus?))
                {
                    return new global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputTextType))
                {
                    return new global::Portkey.JsonConverters.InputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputTextType?))
                {
                    return new global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateModerationRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateModerationRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateFileRequestPurpose))
                {
                    return new global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateFileRequestPurpose?))
                {
                    return new global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteFileResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteFileResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFinetuneJobMethodType))
                {
                    return new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFinetuneJobMethodType?))
                {
                    return new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRerankResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRerankResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateOcrRequestDocumentType))
                {
                    return new global::Portkey.JsonConverters.CreateOcrRequestDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateOcrRequestDocumentType?))
                {
                    return new global::Portkey.JsonConverters.CreateOcrRequestDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelObject))
                {
                    return new global::Portkey.JsonConverters.ModelObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelObject?))
                {
                    return new global::Portkey.JsonConverters.ModelObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MoveType))
                {
                    return new global::Portkey.JsonConverters.MoveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MoveType?))
                {
                    return new global::Portkey.JsonConverters.MoveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFileObject))
                {
                    return new global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFileObject?))
                {
                    return new global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFilePurpose))
                {
                    return new global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFilePurpose?))
                {
                    return new global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFileStatus))
                {
                    return new global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIFileStatus?))
                {
                    return new global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoubleClickType))
                {
                    return new global::Portkey.JsonConverters.DoubleClickTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoubleClickType?))
                {
                    return new global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DragType))
                {
                    return new global::Portkey.JsonConverters.DragTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DragType?))
                {
                    return new global::Portkey.JsonConverters.DragTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageRole))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageType))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageType?))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EmbeddingObject))
                {
                    return new global::Portkey.JsonConverters.EmbeddingObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EmbeddingObject?))
                {
                    return new global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobStatus))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobStatus?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningIntegrationType))
                {
                    return new global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningIntegrationType?))
                {
                    return new global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickType))
                {
                    return new global::Portkey.JsonConverters.ClickTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickType?))
                {
                    return new global::Portkey.JsonConverters.ClickTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickButton))
                {
                    return new global::Portkey.JsonConverters.ClickButtonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickButton?))
                {
                    return new global::Portkey.JsonConverters.ClickButtonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComparisonFilterType))
                {
                    return new global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComparisonFilterType?))
                {
                    return new global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CompoundFilterType))
                {
                    return new global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CompoundFilterType?))
                {
                    return new global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType))
                {
                    return new global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType?))
                {
                    return new global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolEnvironment))
                {
                    return new global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolEnvironment?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CostsResultObject))
                {
                    return new global::Portkey.JsonConverters.CostsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CostsResultObject?))
                {
                    return new global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary))
                {
                    return new global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary?))
                {
                    return new global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningEffort))
                {
                    return new global::Portkey.JsonConverters.ReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningEffort?))
                {
                    return new global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemType))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemType?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemStatus))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemStatus?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RefusalType))
                {
                    return new global::Portkey.JsonConverters.RefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RefusalType?))
                {
                    return new global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Object))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Object?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Status))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Status?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCreatedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCreatedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorCode))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorCode?))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFailedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFailedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseItemListObject))
                {
                    return new global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseItemListObject?))
                {
                    return new global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseModalitie))
                {
                    return new global::Portkey.JsonConverters.ResponseModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseModalitie?))
                {
                    return new global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseModalitiesTextOnlyItem))
                {
                    return new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseModalitiesTextOnlyItem?))
                {
                    return new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation))
                {
                    return new global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation?))
                {
                    return new global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum?))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatType))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatType?))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantObjectObject))
                {
                    return new global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantObjectObject?))
                {
                    return new global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum))
                {
                    return new global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum?))
                {
                    return new global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemReferenceType))
                {
                    return new global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemReferenceType?))
                {
                    return new global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.KeyPressType))
                {
                    return new global::Portkey.JsonConverters.KeyPressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.KeyPressType?))
                {
                    return new global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsCodeType))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsCodeType?))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchType))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchType?))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFunctionType))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantToolsFunctionType?))
                {
                    return new global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TruncationObjectType))
                {
                    return new global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TruncationObjectType?))
                {
                    return new global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum?))
                {
                    return new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsNamedToolChoiceType))
                {
                    return new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AssistantsNamedToolChoiceType?))
                {
                    return new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectObject))
                {
                    return new global::Portkey.JsonConverters.RunObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectObject?))
                {
                    return new global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectStatus))
                {
                    return new global::Portkey.JsonConverters.RunObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectRequiredActionType))
                {
                    return new global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectRequiredActionType?))
                {
                    return new global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectLastErrorCode))
                {
                    return new global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectLastErrorCode?))
                {
                    return new global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectIncompleteDetailsReason))
                {
                    return new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunObjectIncompleteDetailsReason?))
                {
                    return new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRunRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRunRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType))
                {
                    return new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType?))
                {
                    return new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunToolCallObjectType))
                {
                    return new global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunToolCallObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScreenshotType))
                {
                    return new global::Portkey.JsonConverters.ScreenshotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScreenshotType?))
                {
                    return new global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScrollType))
                {
                    return new global::Portkey.JsonConverters.ScrollTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScrollType?))
                {
                    return new global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadAndRunRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadAndRunRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ThreadObjectObject))
                {
                    return new global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ThreadObjectObject?))
                {
                    return new global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteThreadResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteThreadResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectObject))
                {
                    return new global::Portkey.JsonConverters.MessageObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectObject?))
                {
                    return new global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectStatus))
                {
                    return new global::Portkey.JsonConverters.MessageObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectIncompleteDetailsReason))
                {
                    return new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectIncompleteDetailsReason?))
                {
                    return new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectRole))
                {
                    return new global::Portkey.JsonConverters.MessageObjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageObjectRole?))
                {
                    return new global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaObjectObject))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaObjectObject?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaObjectDeltaRole))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaObjectDeltaRole?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMessageRequestRole))
                {
                    return new global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMessageRequestRole?))
                {
                    return new global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail?))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?))
                {
                    return new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectObject))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectObject?))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectStatus))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode?))
                {
                    return new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaObjectObject))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaObjectObject?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor))
                {
                    return new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchResultContentObjectType))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchResultContentObjectType?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchResultsPageObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreSearchResultsPageObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VoiceIdsSharedEnum))
                {
                    return new global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VoiceIdsSharedEnum?))
                {
                    return new global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WaitType))
                {
                    return new global::Portkey.JsonConverters.WaitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WaitType?))
                {
                    return new global::Portkey.JsonConverters.WaitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchContextSize))
                {
                    return new global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchContextSize?))
                {
                    return new global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TypeType1))
                {
                    return new global::Portkey.JsonConverters.TypeType1JsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TypeType1?))
                {
                    return new global::Portkey.JsonConverters.TypeType1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UrlCitationType))
                {
                    return new global::Portkey.JsonConverters.UrlCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UrlCitationType?))
                {
                    return new global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType))
                {
                    return new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType?))
                {
                    return new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType?))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType))
                {
                    return new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType?))
                {
                    return new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType?))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ThreadStreamEventVariant1Event))
                {
                    return new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ThreadStreamEventVariant1Event?))
                {
                    return new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceOptions))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceOptions?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceTypesType))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceTypesType?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant1Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant1Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant2Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant2Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant3Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant3Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant4Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant4Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant5Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant5Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant6Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant6Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant7Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant7Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant8Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant8Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant9Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant9Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant10Event))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStreamEventVariant10Event?))
                {
                    return new global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant1Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant1Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant2Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant2Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant3Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant3Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant4Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant4Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant5Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant5Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant6Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant6Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant7Event))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepStreamEventVariant7Event?))
                {
                    return new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant1Event))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant1Event?))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant2Event))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant2Event?))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant3Event))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant3Event?))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant4Event))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant4Event?))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant5Event))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MessageStreamEventVariant5Event?))
                {
                    return new global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ErrorEventEvent))
                {
                    return new global::Portkey.JsonConverters.ErrorEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ErrorEventEvent?))
                {
                    return new global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileCitationType))
                {
                    return new global::Portkey.JsonConverters.FileCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileCitationType?))
                {
                    return new global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FilePathType))
                {
                    return new global::Portkey.JsonConverters.FilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FilePathType?))
                {
                    return new global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoneEventEvent))
                {
                    return new global::Portkey.JsonConverters.DoneEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoneEventEvent?))
                {
                    return new global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoneEventData))
                {
                    return new global::Portkey.JsonConverters.DoneEventDataJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoneEventData?))
                {
                    return new global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchObject))
                {
                    return new global::Portkey.JsonConverters.BatchObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchObject?))
                {
                    return new global::Portkey.JsonConverters.BatchObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchStatus))
                {
                    return new global::Portkey.JsonConverters.BatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchStatus?))
                {
                    return new global::Portkey.JsonConverters.BatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchRequestInputMethod))
                {
                    return new global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchRequestInputMethod?))
                {
                    return new global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListBatchesResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListBatchesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsType))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsType?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType))
                {
                    return new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType?))
                {
                    return new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListStatus))
                {
                    return new global::Portkey.JsonConverters.IntegrationListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListStatus?))
                {
                    return new global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListObject))
                {
                    return new global::Portkey.JsonConverters.IntegrationListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListObject?))
                {
                    return new global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PricingConfigType))
                {
                    return new global::Portkey.JsonConverters.PricingConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PricingConfigType?))
                {
                    return new global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ProvidersStatus))
                {
                    return new global::Portkey.JsonConverters.ProvidersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ProvidersStatus?))
                {
                    return new global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ProvidersObject))
                {
                    return new global::Portkey.JsonConverters.ProvidersObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ProvidersObject?))
                {
                    return new global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysStatus))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysStatus?))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysObject))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysObject?))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole2))
                {
                    return new global::Portkey.JsonConverters.InviteRole2JsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole2?))
                {
                    return new global::Portkey.JsonConverters.InviteRole2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteStatus))
                {
                    return new global::Portkey.JsonConverters.InviteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteStatus?))
                {
                    return new global::Portkey.JsonConverters.InviteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteListObject))
                {
                    return new global::Portkey.JsonConverters.InviteListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteListObject?))
                {
                    return new global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserObject))
                {
                    return new global::Portkey.JsonConverters.UserObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserObject?))
                {
                    return new global::Portkey.JsonConverters.UserObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserRole))
                {
                    return new global::Portkey.JsonConverters.UserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserRole?))
                {
                    return new global::Portkey.JsonConverters.UserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserListObject))
                {
                    return new global::Portkey.JsonConverters.UserListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UserListObject?))
                {
                    return new global::Portkey.JsonConverters.UserListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceListObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceListObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole))
                {
                    return new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole?))
                {
                    return new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CollectionStatus))
                {
                    return new global::Portkey.JsonConverters.CollectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CollectionStatus?))
                {
                    return new global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptSummaryObject))
                {
                    return new global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptSummaryObject?))
                {
                    return new global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus))
                {
                    return new global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject?))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialSummaryStatus))
                {
                    return new global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialSummaryStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialSummaryObject))
                {
                    return new global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialSummaryObject?))
                {
                    return new global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialStatus))
                {
                    return new global::Portkey.JsonConverters.PromptPartialStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialVersionPromptVersionStatus))
                {
                    return new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialVersionPromptVersionStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialVersionObject))
                {
                    return new global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPartialVersionObject?))
                {
                    return new global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportListResponseObject))
                {
                    return new global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportListResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemStatus))
                {
                    return new global::Portkey.JsonConverters.ExportItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemStatus?))
                {
                    return new global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemObject))
                {
                    return new global::Portkey.JsonConverters.ExportItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemObject?))
                {
                    return new global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateExportResponseObject))
                {
                    return new global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateExportResponseObject?))
                {
                    return new global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportTaskResponseObject))
                {
                    return new global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportTaskResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogRequestMethod))
                {
                    return new global::Portkey.JsonConverters.LogRequestMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogRequestMethod?))
                {
                    return new global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem))
                {
                    return new global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem?))
                {
                    return new global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordMethod))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordMethod?))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordUserType))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListRecordUserType?))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListObject))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AuditLogObjectListObject?))
                {
                    return new global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectType))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectType?))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectStatus))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectCreationMode))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectCreationMode?))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectObject))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectObject?))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectListObject))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ApiKeyObjectListObject?))
                {
                    return new global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitType))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitType?))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRateLimitUnit?))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod?))
                {
                    return new global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitType))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitType?))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRateLimitUnit?))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod?))
                {
                    return new global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailCheckId))
                {
                    return new global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailCheckId?))
                {
                    return new global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GuardrailSummaryStatus?))
                {
                    return new global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow?))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint?))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit))
                {
                    return new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?))
                {
                    return new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus))
                {
                    return new global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus?))
                {
                    return new global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyType))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyType?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationCapabilityItemType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationCapabilityItemType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType?))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerCapabilityItemType))
                {
                    return new global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerCapabilityItemType?))
                {
                    return new global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType?))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerUserAccessItemConnectionStatus))
                {
                    return new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerUserAccessItemConnectionStatus?))
                {
                    return new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess))
                {
                    return new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerUserAccessListResponseDefaultUserAccess?))
                {
                    return new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess?))
                {
                    return new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateDeploymentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateDeploymentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType?))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus?))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentCreateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentCreateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemType))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemType?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseOutboundStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseOutboundStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseInboundStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseInboundStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider))
                {
                    return new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider?))
                {
                    return new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminUsersRequestRole))
                {
                    return new global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminUsersRequestRole?))
                {
                    return new global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole))
                {
                    return new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?))
                {
                    return new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole))
                {
                    return new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?))
                {
                    return new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole))
                {
                    return new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole?))
                {
                    return new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsSort))
                {
                    return new global::Portkey.JsonConverters.ListModelsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsSort?))
                {
                    return new global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsOrder))
                {
                    return new global::Portkey.JsonConverters.ListModelsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListModelsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListAssistantsOrder))
                {
                    return new global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListAssistantsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListInputItemsOrder))
                {
                    return new global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListInputItemsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListMessagesOrder))
                {
                    return new global::Portkey.JsonConverters.ListMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListMessagesOrder?))
                {
                    return new global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRunsOrder))
                {
                    return new global::Portkey.JsonConverters.ListRunsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRunsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRunStepsOrder))
                {
                    return new global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRunStepsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoresOrder))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoresOrder?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsType))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsType?))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole?))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus?))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersRole))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersRole?))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole?))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus?))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole?))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationsListType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationsListType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationCapabilitiesListType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationCapabilitiesListType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerCapabilitiesListType))
                {
                    return new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpServerCapabilitiesListType?))
                {
                    return new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetLogsPathFormat))
                {
                    return new global::Portkey.JsonConverters.GetLogsPathFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetLogsPathFormat?))
                {
                    return new global::Portkey.JsonConverters.GetLogsPathFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetLogsType))
                {
                    return new global::Portkey.JsonConverters.GetLogsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetLogsType?))
                {
                    return new global::Portkey.JsonConverters.GetLogsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAuditLogsMethod))
                {
                    return new global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAuditLogsMethod?))
                {
                    return new global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAuditLogsUserType))
                {
                    return new global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAuditLogsUserType?))
                {
                    return new global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysType))
                {
                    return new global::Portkey.JsonConverters.CreateKeysTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysType?))
                {
                    return new global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysSubType))
                {
                    return new global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysSubType?))
                {
                    return new global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderIncludeTotalJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderIncludeTotalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType?))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsStatus))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsStatus?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsType))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsType?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreatePromptResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreatePromptResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetProvidersResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetProvidersResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateKeysResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsSummaryCacheResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsResponseObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[6];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new SourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),

                    5 => new SourceGenerationContextChunk5(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}