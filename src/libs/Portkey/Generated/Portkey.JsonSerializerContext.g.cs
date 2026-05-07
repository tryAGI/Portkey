
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
            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1JsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2JsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.InputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.InputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter),

            typeof(global::Portkey.JsonConverters.RerankDocumentJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerActionJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.Content3JsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.AnnotationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.AuthConfigJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>),

            typeof(global::Portkey.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegration), TypeInfoPropertyName = "FineTuningIntegration2")]
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
            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1JsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2JsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.InputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.InputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter),

            typeof(global::Portkey.JsonConverters.RerankDocumentJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerActionJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.Content3JsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.AnnotationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.AuthConfigJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>),

            typeof(global::Portkey.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponses), TypeInfoPropertyName = "ModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponsesEnum), TypeInfoPropertyName = "ModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModifyAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteAssistantResponseObject), TypeInfoPropertyName = "DeleteAssistantResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReferenceType), TypeInfoPropertyName = "ItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequest))]
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
            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1JsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2JsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.InputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.InputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter),

            typeof(global::Portkey.JsonConverters.RerankDocumentJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerActionJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.Content3JsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.AnnotationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.AuthConfigJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>),

            typeof(global::Portkey.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptPartialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptPartialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptPartialDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptCompletionRequest2), TypeInfoPropertyName = "CreatePromptCompletionRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRenderRequest2), TypeInfoPropertyName = "CreatePromptRenderRequest22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationsListType), TypeInfoPropertyName = "McpIntegrationsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCapabilitiesListType), TypeInfoPropertyName = "McpIntegrationCapabilitiesListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpServerCapabilitiesListType), TypeInfoPropertyName = "McpServerCapabilitiesListType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetRateLimitsPolicyStatus), TypeInfoPropertyName = "GetRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesManagerType), TypeInfoPropertyName = "ListSecretReferencesManagerType2")]
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
            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableJsonConverter),

            typeof(global::Portkey.JsonConverters.IncludableNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MoveTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.DragTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonJsonConverter),

            typeof(global::Portkey.JsonConverters.ClickButtonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WaitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1JsonConverter),

            typeof(global::Portkey.JsonConverters.TypeType1NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataJsonConverter),

            typeof(global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2JsonConverter),

            typeof(global::Portkey.JsonConverters.InviteRole2NullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.UserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UserListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter),

            typeof(global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter),

            typeof(global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter),

            typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter),

            typeof(global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter),

            typeof(global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter),

            typeof(global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter),

            typeof(global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter),

            typeof(global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter),

            typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),

            typeof(global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter),

            typeof(global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter),

            typeof(global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter),

            typeof(global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.OutputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.InputContentJsonConverter),

            typeof(global::Portkey.JsonConverters.InputItemJsonConverter),

            typeof(global::Portkey.JsonConverters.InputMessageResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter),

            typeof(global::Portkey.JsonConverters.CreateResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter),

            typeof(global::Portkey.JsonConverters.RerankDocumentJsonConverter),

            typeof(global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerActionJsonConverter),

            typeof(global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.Content3JsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.AnnotationJsonConverter),

            typeof(global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemJsonConverter),

            typeof(global::Portkey.JsonConverters.ItemResourceJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),

            typeof(global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter),

            typeof(global::Portkey.JsonConverters.AssistantStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ThreadStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.ToolJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.RunStepStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter),

            typeof(global::Portkey.JsonConverters.AuthConfigJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter),

            typeof(global::Portkey.JsonConverters.GuardrailDetailsJsonConverter),

            typeof(global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>),

            typeof(global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>),

            typeof(global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>),

            typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>),

            typeof(global::Portkey.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_8bdfb68d714d7b89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_e3b878686b59ca1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_95e54e44510b0009")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_d5b932e79734fe15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_746b999d3264bfec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>), TypeInfoPropertyName = "BasicParameters_7d207863ae46619e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>?), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_2c63885c957eec9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_e709669a9d6096a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_41e2b51f1fff9f7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>?), TypeInfoPropertyName = "BasicParameters_b9f37200e2abf3e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>), TypeInfoPropertyName = "FineTuneChatCompletionRequestFunctionMessage_12be480b1039da9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>), TypeInfoPropertyName = "RunStepDeltaStepDetailsToolCallsFunctionObject_5640d9ed7ecfcd45")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default,

            SourceGenerationContextChunk3.Default
            );

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
            options.Converters.Add(new global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputAudioTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputTextTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IncludableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IncludableNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputAudioTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputAudioFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputFileTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputImageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputImageDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputTextTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRerankResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MoveTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MoveTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoubleClickTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DragTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DragTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EmbeddingObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ClickTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ClickTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ClickButtonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ClickButtonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CostsResultObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningEffortJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RefusalTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseModalitieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.KeyPressTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScreenshotTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScrollTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WaitTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WaitTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TypeType1JsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TypeType1NullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UrlCitationTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ErrorEventEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileCitationTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FilePathTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoneEventEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoneEventDataJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationListStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PricingConfigTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ProvidersStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ProvidersObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteRole2JsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteRole2NullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UserListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CollectionStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportItemStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportItemObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.LogRequestMethodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRateLimitUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateApiKeyObjectRotationPolicyRotationPeriodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsSortJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListMessagesOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRunsOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter());
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

            return options;
        }
    }
}