
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOption), TypeInfoPropertyName = "AssistantsApiResponseFormatOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum), TypeInfoPropertyName = "AssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatType), TypeInfoPropertyName = "AssistantsApiResponseFormatType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponseObject), TypeInfoPropertyName = "DeleteAssistantResponseObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectType), TypeInfoPropertyName = "RunToolCallObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectFunction))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectType), TypeInfoPropertyName = "MessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail), TypeInfoPropertyName = "MessageContentImageUrlObjectImageUrlDetail2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectObject), TypeInfoPropertyName = "RunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectType), TypeInfoPropertyName = "RunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectStatus), TypeInfoPropertyName = "RunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>), TypeInfoPropertyName = "OneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastErrorCode), TypeInfoPropertyName = "RunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectType), TypeInfoPropertyName = "RunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeObjectRunStepDetailsToolCallsFileSearchObjectRunStepDetailsToolCallsFunctionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListAssistantsOrder), TypeInfoPropertyName = "ListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListMessagesOrder), TypeInfoPropertyName = "ListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunsOrder), TypeInfoPropertyName = "ListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsOrder), TypeInfoPropertyName = "ListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOption?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantsApiResponseFormatType?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AssistantObjectObject?), TypeInfoPropertyName = "NullableAssistantObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>?), TypeInfoPropertyName = "NullableOneOfAssistantToolsCodeAssistantToolsFileSearchAssistantToolsFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestModel?), TypeInfoPropertyName = "NullableCreateAssistantRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponseObject?), TypeInfoPropertyName = "NullableDeleteAssistantResponseObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunToolCallObjectType?), TypeInfoPropertyName = "NullableRunToolCallObjectType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMessageRequestRole?), TypeInfoPropertyName = "NullableCreateMessageRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>?), TypeInfoPropertyName = "NullableOneOfStringIListOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteMessageResponseObject?), TypeInfoPropertyName = "NullableDeleteMessageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectType?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectType?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextObjectType?), TypeInfoPropertyName = "NullableMessageContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentTextAnnotationsFileCitationObjectMessageContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageRequestContentTextObjectType?), TypeInfoPropertyName = "NullableMessageRequestContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectObject?), TypeInfoPropertyName = "NullableRunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectType?), TypeInfoPropertyName = "NullableRunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectStatus?), TypeInfoPropertyName = "NullableRunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepObjectLastErrorCode?), TypeInfoPropertyName = "NullableRunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListAssistantsOrder?), TypeInfoPropertyName = "NullableListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListMessagesOrder?), TypeInfoPropertyName = "NullableListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunsOrder?), TypeInfoPropertyName = "NullableListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRunStepsOrder?), TypeInfoPropertyName = "NullableListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    internal sealed partial class AssistantsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssistantsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssistantsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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
                    typeToConvert == typeof(global::Portkey.AssistantsApiResponseFormatOptionEnum)

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

                    || typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject?)

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

                    || typeToConvert == typeof(global::Portkey.RunToolCallObjectType)

                    || typeToConvert == typeof(global::Portkey.RunToolCallObjectType?)

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

                    || typeToConvert == typeof(global::Portkey.CreateMessageRequestRole)

                    || typeToConvert == typeof(global::Portkey.CreateMessageRequestRole?)

                    || typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteMessageResponseObject?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageRequestContentTextObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::Portkey.MessageContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectObject)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectObject?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectStatus)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode)

                    || typeToConvert == typeof(global::Portkey.RunStepObjectLastErrorCode?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::Portkey.ListAssistantsOrder)

                    || typeToConvert == typeof(global::Portkey.ListAssistantsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListMessagesOrder)

                    || typeToConvert == typeof(global::Portkey.ListMessagesOrder?)

                    || typeToConvert == typeof(global::Portkey.ListRunsOrder)

                    || typeToConvert == typeof(global::Portkey.ListRunsOrder?)

                    || typeToConvert == typeof(global::Portkey.ListRunStepsOrder)

                    || typeToConvert == typeof(global::Portkey.ListRunStepsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteAssistantResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Portkey.RunToolCallObjectType))
                {
                    return new global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunToolCallObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsMessageCreationObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListAssistantsOrder))
                {
                    return new global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListAssistantsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter();
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
                    0 => new AssistantsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}