
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The Portkey REST API. Please see https://portkey.ai/docs/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class PortkeyClient : global::Portkey.IPortkeyClient, global::System.IDisposable
    {
        /// <summary>
        /// Portkey API Public Endpoint
        /// </summary>
        public const string DefaultBaseUrl = "https://api.portkey.ai/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Portkey.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Portkey.JsonConverters.ModelPricingConfigCurrencyJsonConverter(),
                    new global::Portkey.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ModelCalculateOperationOperationJsonConverter(),
                    new global::Portkey.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InviteRoleJsonConverter(),
                    new global::Portkey.JsonConverters.InviteRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceInviteTypeJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceInviteTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter(),
                    new global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OutputAudioTypeJsonConverter(),
                    new global::Portkey.JsonConverters.OutputAudioTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageStatusJsonConverter(),
                    new global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OutputTextTypeJsonConverter(),
                    new global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.IncludableJsonConverter(),
                    new global::Portkey.JsonConverters.IncludableNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputAudioTypeJsonConverter(),
                    new global::Portkey.JsonConverters.InputAudioTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputAudioFormatJsonConverter(),
                    new global::Portkey.JsonConverters.InputAudioFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputFileTypeJsonConverter(),
                    new global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputImageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputImageDetailJsonConverter(),
                    new global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageStatusJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InputTextTypeJsonConverter(),
                    new global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateModerationRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateModerationRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ModelObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ModelObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MoveTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MoveTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFileObjectJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFileObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFilePurposeJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFilePurposeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFileStatusJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIFileStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DoubleClickTypeJsonConverter(),
                    new global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DragTypeJsonConverter(),
                    new global::Portkey.JsonConverters.DragTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter(),
                    new global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ClickTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ClickTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ClickButtonJsonConverter(),
                    new global::Portkey.JsonConverters.ClickButtonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CostsResultObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CostsResultObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningEffortJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RefusalTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseModalitieJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseModalitieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter(),
                    new global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter(),
                    new global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.KeyPressTypeJsonConverter(),
                    new global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsCodeTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.TruncationObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.TruncationObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectRequiredActionTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectLastErrorCodeJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),
                    new global::Portkey.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRunRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRunRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunToolCallObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunToolCallObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ScreenshotTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ScrollTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ThreadObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ThreadObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteThreadResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectRoleJsonConverter(),
                    new global::Portkey.JsonConverters.MessageObjectRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMessageRequestRoleJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMessageRequestRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteMessageResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VoiceIdsSharedEnumJsonConverter(),
                    new global::Portkey.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WaitTypeJsonConverter(),
                    new global::Portkey.JsonConverters.WaitTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter(),
                    new global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.TypeType1JsonConverter(),
                    new global::Portkey.JsonConverters.TypeType1NullableJsonConverter(),
                    new global::Portkey.JsonConverters.UrlCitationTypeJsonConverter(),
                    new global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventJsonConverter(),
                    new global::Portkey.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant1EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant2EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant3EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant4EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant5EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant6EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant7EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant8EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant9EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant10EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant1EventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant3EventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant4EventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant5EventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ErrorEventEventJsonConverter(),
                    new global::Portkey.JsonConverters.ErrorEventEventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FileCitationTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.FilePathTypeJsonConverter(),
                    new global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DoneEventEventJsonConverter(),
                    new global::Portkey.JsonConverters.DoneEventEventNullableJsonConverter(),
                    new global::Portkey.JsonConverters.DoneEventDataJsonConverter(),
                    new global::Portkey.JsonConverters.DoneEventDataNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BatchObjectJsonConverter(),
                    new global::Portkey.JsonConverters.BatchObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BatchStatusJsonConverter(),
                    new global::Portkey.JsonConverters.BatchStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::Portkey.JsonConverters.BatchRequestInputMethodNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsUnitJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter(),
                    new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter(),
                    new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter(),
                    new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter(),
                    new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter(),
                    new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.IntegrationListStatusJsonConverter(),
                    new global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.IntegrationListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PricingConfigTypeJsonConverter(),
                    new global::Portkey.JsonConverters.PricingConfigTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ProvidersStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ProvidersStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ProvidersObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ProvidersObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter(),
                    new global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter(),
                    new global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InviteRole2JsonConverter(),
                    new global::Portkey.JsonConverters.InviteRole2NullableJsonConverter(),
                    new global::Portkey.JsonConverters.InviteStatusJsonConverter(),
                    new global::Portkey.JsonConverters.InviteStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.InviteListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UserObjectJsonConverter(),
                    new global::Portkey.JsonConverters.UserObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UserRoleJsonConverter(),
                    new global::Portkey.JsonConverters.UserRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UserListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.UserListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter(),
                    new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CollectionStatusJsonConverter(),
                    new global::Portkey.JsonConverters.CollectionStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter(),
                    new global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter(),
                    new global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter(),
                    new global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialSummaryStatusJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialSummaryObjectJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialStatusJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialVersionObjectJsonConverter(),
                    new global::Portkey.JsonConverters.PromptPartialVersionObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ExportItemStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ExportItemObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.LogRequestMethodJsonConverter(),
                    new global::Portkey.JsonConverters.LogRequestMethodNullableJsonConverter(),
                    new global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter(),
                    new global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.AuditLogObjectListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectCreationModeJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectListObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GuardrailCheckIdJsonConverter(),
                    new global::Portkey.JsonConverters.GuardrailCheckIdNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GuardrailSummaryStatusJsonConverter(),
                    new global::Portkey.JsonConverters.GuardrailSummaryStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.JSONKeysParametersOperatorJsonConverter(),
                    new global::Portkey.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter(),
                    new global::Portkey.JsonConverters.ContainsParametersOperatorNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ContainsCodeParametersFormatJsonConverter(),
                    new global::Portkey.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter(),
                    new global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter(),
                    new global::Portkey.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PillarScanParametersScannerJsonConverter(),
                    new global::Portkey.JsonConverters.PillarScanParametersScannerNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.MistralModerationParametersCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter(),
                    new global::Portkey.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter(),
                    new global::Portkey.JsonConverters.AzurePIIParametersDomainJsonConverter(),
                    new global::Portkey.JsonConverters.AzurePIIParametersDomainNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter(),
                    new global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter(),
                    new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter(),
                    new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter(),
                    new global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter(),
                    new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerCapabilityItemTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter(),
                    new global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter(),
                    new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PutAdminUsersRequestRoleJsonConverter(),
                    new global::Portkey.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter(),
                    new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter(),
                    new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsSortJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsSortNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListModelsOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListAssistantsOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListAssistantsOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListRunStepsOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListRunStepsOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter(),
                    new global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter(),
                    new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter(),
                    new global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersRoleJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminUsersRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter(),
                    new global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeJsonConverter(),
                    new global::Portkey.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAuditLogsMethodJsonConverter(),
                    new global::Portkey.JsonConverters.GetAuditLogsMethodNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAuditLogsUserTypeJsonConverter(),
                    new global::Portkey.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysSubTypeJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysSubTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter(),
                    new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter(),
                    new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter(),
                    new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter(),
                    new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetProvidersResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetProvidersResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateKeysResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter(),
                    new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter(),
                    new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter(),
                    new global::Portkey.JsonConverters.FineTuneChatCompletionRequestFunctionMessageJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter(),
                    new global::Portkey.JsonConverters.OutputContentJsonConverter(),
                    new global::Portkey.JsonConverters.OutputItemJsonConverter(),
                    new global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter(),
                    new global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter(),
                    new global::Portkey.JsonConverters.InputContentJsonConverter(),
                    new global::Portkey.JsonConverters.InputItemJsonConverter(),
                    new global::Portkey.JsonConverters.InputMessageResourceJsonConverter(),
                    new global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter(),
                    new global::Portkey.JsonConverters.CreateResponseJsonConverter(),
                    new global::Portkey.JsonConverters.VertexFinetuneJobJsonConverter(),
                    new global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerActionJsonConverter(),
                    new global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter(),
                    new global::Portkey.JsonConverters.Content3JsonConverter(),
                    new global::Portkey.JsonConverters.ResponseJsonConverter(),
                    new global::Portkey.JsonConverters.ResponseStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter(),
                    new global::Portkey.JsonConverters.AnnotationJsonConverter(),
                    new global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter(),
                    new global::Portkey.JsonConverters.ItemJsonConverter(),
                    new global::Portkey.JsonConverters.ItemResourceJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter(),
                    new global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter(),
                    new global::Portkey.JsonConverters.VoiceIdsSharedJsonConverter(),
                    new global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter(),
                    new global::Portkey.JsonConverters.AssistantStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.ThreadStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.ToolJsonConverter(),
                    new global::Portkey.JsonConverters.RunStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.RunStepStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.MessageStreamEventJsonConverter(),
                    new global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter(),
                    new global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter(),
                    new global::Portkey.JsonConverters.AuthConfigJsonConverter(),
                    new global::Portkey.JsonConverters.CollectionWithDetailsJsonConverter(),
                    new global::Portkey.JsonConverters.CollectionWithChildCollectionsJsonConverter(),
                    new global::Portkey.JsonConverters.GuardrailDetailsJsonConverter(),
                    new global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter(),
                    new global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateModerationRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateAssistantRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateRunRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateThreadAndRunRequestModel?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>(),
                    new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>(),
                    new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>(),
                    new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>(),
                    new global::Portkey.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Get data points for graphical representation.
        /// </summary>
        public AnalyticsGraphsClient AnalyticsGraphs => new AnalyticsGraphsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get grouped metrics for the selected time bucket.
        /// </summary>
        public AnalyticsGroupsClient AnalyticsGroups => new AnalyticsGroupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get overall summary for the selected time bucket.
        /// </summary>
        public AnalyticsSummaryClient AnalyticsSummary => new AnalyticsSummaryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey API keys.
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get audit logs for your Portkey account.
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete collections of prompts.
        /// </summary>
        public CollectionsClient Collections => new CollectionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, and Update your Portkey Configs.
        /// </summary>
        public ConfigsClient Configs => new ConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Send and Update any feedback.
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FinetuneClient Finetune => new FinetuneClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt Guardrails.
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Integrations.
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage model access for your Portkey Integrations.
        /// </summary>
        public IntegrationsModelsClient IntegrationsModels => new IntegrationsModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage workspace access for your Portkey Integrations.
        /// </summary>
        public IntegrationsWorkspacesClient IntegrationsWorkspaces => new IntegrationsWorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete labels.
        /// </summary>
        public LabelsClient Labels => new LabelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Custom Logger to add external logs to Portkey.
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Exports logs service.
        /// </summary>
        public LogsExportClient LogsExport => new LogsExportClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Integrations.
        /// </summary>
        public McpIntegrationsClient McpIntegrations => new McpIntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage capabilities for MCP Integrations.
        /// </summary>
        public McpIntegrationsCapabilitiesClient McpIntegrationsCapabilities => new McpIntegrationsCapabilitiesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get MCP Integration metadata and sync info.
        /// </summary>
        public McpIntegrationsMetadataClient McpIntegrationsMetadata => new McpIntegrationsMetadataClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage workspace access for MCP Integrations.
        /// </summary>
        public McpIntegrationsWorkspacesClient McpIntegrationsWorkspaces => new McpIntegrationsWorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Servers (workspace instances of MCP Integrations).
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage capabilities for MCP Servers.
        /// </summary>
        public McpServersCapabilitiesClient McpServersCapabilities => new McpServersCapabilitiesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage user access for MCP Servers.
        /// </summary>
        public McpServersUserAccessClient McpServersUserAccess => new McpServersUserAccessClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Model pricing configurations for 2300+ LLMs across 40+ providers
        /// </summary>
        public ModelPricingClient ModelPricing => new ModelPricingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations => new ModerationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt partials.
        /// </summary>
        public PromptPartialsClient PromptPartials => new PromptPartialsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt template ID and variables, will run the saved prompt template and return a response.
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Providers.
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage rate limits policies to control request or token rates
        /// </summary>
        public RateLimitsPoliciesClient RateLimitsPolicies => new RateLimitsPoliciesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// WebSocket proxy for provider Realtime APIs
        /// </summary>
        public RealtimeClient Realtime => new RealtimeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses => new ResponsesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete secret references to external secret managers.
        /// </summary>
        public SecretReferencesClient SecretReferences => new SecretReferencesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage usage limits policies to control total usage over time
        /// </summary>
        public UsageLimitsPoliciesClient UsageLimitsPolicies => new UsageLimitsPoliciesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage user invites.
        /// </summary>
        public UserInvitesClient UserInvites => new UserInvitesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage users.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores => new VectorStoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Virtual keys.
        /// </summary>
        public VirtualKeysClient VirtualKeys => new VirtualKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage workspaces.
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage workspace members.
        /// </summary>
        public WorkspacesMembersClient WorkspacesMembers => new WorkspacesMembersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the PortkeyClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PortkeyClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Portkey.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Portkey.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}