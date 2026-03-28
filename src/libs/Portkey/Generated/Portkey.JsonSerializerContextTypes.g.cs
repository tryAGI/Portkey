
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelPricingConfig? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelPayAsYouGo? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelCalculateConfig? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelPricingConfigCurrency? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelFinetuneConfig? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelTokenPrice? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelCalculateOperation? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelCalculateOperationOperation? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelValueReference? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Error? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorResponse? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateInvite? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceInvite? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteRole? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateInviteWorkspaceApiKeyDetails? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceInviteRole? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceInviteType? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SuccessInvite? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsResponse? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsResponseObject? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Model11>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Model11? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteModelResponse? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionRequestModel? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamOptions? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponse? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateCompletionResponseChoice>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoice? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceFinishReason? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceLogprobs? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponseObject? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsage? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPart? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartText? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageType? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartTextType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinking? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinkingType? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessage? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessage? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessage? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessage? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessage? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessage? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessage? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessageRole? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessageRole? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessageRole? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageRole? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchTool? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolType? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilter? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilter? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptions? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptionsRanker? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCall? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallType? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallStatus? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallResult? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessage? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageFunctionCall? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessageRole? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessageRole? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestFunctionMessage? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctions? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctionCallOption? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTool? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolType? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionObject? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOption? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOptionEnum? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoice? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceType? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceFunction? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudio? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudioType? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputContent? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputText? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Refusal? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItem? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessage? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCall? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCall? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCall? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItem? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItemDiscriminator? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageType? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageRole? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputContent>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageStatus? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputTextType? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Annotation>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Annotation? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCall? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallType? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallFunction? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunk? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkType? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkFunction? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRole? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentBlock? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessage? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageRole? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageFunctionCall? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDelta? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaRole? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequest? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestModel? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatText? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchema? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObject? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinking? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinkingType? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestFunctionCall? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponse? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoice? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceFinishReason? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceLogprobs? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprob? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseObject? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponse? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoice? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseObject? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprobTopLogprob? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponse? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJob? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponseObject? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponse? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoice? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseObject? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseUsage? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequest? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestModel? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestQuality? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestResponseFormat? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestSize? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestStyle? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ImagesResponse? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Image>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Image? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Includable? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionTool? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolType? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallType? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallStatus? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutput? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputType? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputStatus? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResource? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResourceVariant2? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResource? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResourceVariant2? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudio? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioType? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioFormat? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputContent? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputText? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImage? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFile? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFileType? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageType? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageDetail? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItem? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessage? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Item? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReference? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItemDiscriminator? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessage? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageType? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageRole? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageStatus? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputContent>? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResource? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResourceVariant2? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputTextType? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequest? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestModel? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestSize? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestResponseFormat? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequest? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestModel? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestResponseFormat? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestSize? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModelResponseProperties? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelResponseProperties? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequest? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequestModel? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponse? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResult? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategories? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategoryScores? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponse? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseProperties? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponseVariant3? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputItem>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Includable>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponse? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFile? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponseObject? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequest? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequestPurpose? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponse? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponseObject? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockFinetuneJob? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJob? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethod? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodType? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockParams? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyFinetuneJob? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyOptions? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexFinetuneJob? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponse? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEvent? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponseObject? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpoint? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponseObject? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequest? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestModel? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestEncodingFormat? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponse? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Embedding>? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Embedding? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseObject? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseUsage? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequest? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionWord? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelObject? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Move? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MoveType? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClick? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClickType? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Drag? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DragType? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Coordinate? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EmbeddingObject? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobError? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Click? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickType? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickButton? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilterType? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerAction? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPress? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Screenshot? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Scroll? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Type? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Wait? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerTool? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolType? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Content3? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResult? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultObject? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultAmount? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Reasoning? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningEffort? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemType? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RefusalType? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Response? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseError? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsage? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemList? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResource? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitie? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Tool? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitation? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitation? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePath? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObject? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReferenceType? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPressType? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObject? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObjectType? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObject? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectObject? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectStatus? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObject? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastError? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequest? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsResponse? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScreenshotType? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScrollType? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObject? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObject? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectObject? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectRole? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObject? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectType? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObjectType? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectType? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfter? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfterAnchor? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObject? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectObject? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectFileCounts? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectStatus? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequest? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptions? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObject? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObjectType? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultItem? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPage? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPageObject? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsShared? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsSharedEnum? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WaitType? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchContextSize? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchLocation? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchTool? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolType? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocation? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocationType? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallType? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallStatus? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreRequest? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParam? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParam? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TypeType1? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateVectorStoreRequest? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitationType? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresResponse? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponse? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponseObject? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObject? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectObject? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectStatus? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastError? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastErrorCode? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParam? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParam? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParamType? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParamType? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategy? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParamType? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParamType? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChunkingStrategyRequestParam? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileRequest? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesResponse? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponse? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponseObject? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObject? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectObject? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectStatus? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectFileCounts? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileBatchRequest? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantStreamEvent? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEvent? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEvent? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEvent? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEvent? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEvent? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEvent? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1Event? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunctionType? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypesType? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1Event? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2Event? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3Event? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4Event? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5Event? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6Event? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7Event? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8Event? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9Event? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10Event? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1Event? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2Event? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3Event? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4Event? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5Event? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6Event? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7Event? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1Event? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2Event? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3Event? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4Event? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5Event? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEventEvent? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitationType? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePathType? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventEvent? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventData? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Batch? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchObject? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrors? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrorsDataItem? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchStatus? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestCounts? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInput? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInputMethod? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutput? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputResponse? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputError? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponse? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Batch>? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponseObject? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackRequest? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackResponse? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackUpdateRequest? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimits? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsType? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsUnit? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimits? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsType? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPeriodicReset? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationRequest? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIConfiguration? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfiguration? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfiguration? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfiguration? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfiguration? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkersAIConfiguration? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfiguration? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HuggingFaceConfiguration? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CortexConfiguration? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomHostConfiguration? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretMapping? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateIntegrationRequest? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponse? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationList? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GlobalWorkspaceAccess? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuthConfig? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemObject? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponse? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseManagerType? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseStatus? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseObject? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfigAwsAuthType? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfigAwsAuthType? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfigAzureAuthMode? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfigAzureAuthMode? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfigAzureAuthMode? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfigVaultAuthType? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListStatus? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListObject? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModelsResponse? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModel? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfig? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfigType? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PayAsYouGoPricing? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TokenPricing? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateModelsRequest? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Providers? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersStatus? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersObject? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeys? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Invite? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteRole2? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteStatus? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteList? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteListObject? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.User? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserObject? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserRole? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserList? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserListObject? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMember? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Workspace? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceList? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Collection? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionStatus? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionDetails? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChildCollection? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Label? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummary? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Prompt2? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartial? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLog? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponse? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItem? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemObject? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogObject? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequest? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogResponse? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActions? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, object>? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JWTParameters? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WordCountParameters? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParameters? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebhookParameters? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AporiaParameters? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusParameters? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Condition? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GroupBy? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegration? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServer? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListItem? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsSort? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysType? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1544 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Model11>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateCompletionResponseChoice>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCall>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FileSearchToolCallResult>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputContent>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Annotation>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageContentBlock>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCallChunk>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessage>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTool>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionFunctions>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionResponseChoice>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprob>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionFunctionResponseChoice>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJob>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionStreamResponseChoice>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Image>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputContent>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateModerationResponseResult>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputItem>>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputItem>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Includable>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OpenAIFile>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobEvent>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobCheckpoint>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Embedding>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Coordinate>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputItem>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ItemResource>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitie>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitiesTextOnlyItem>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Tool>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AssistantObject>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunObject>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ThreadObject>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObject>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunStepObject>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultContentObject>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultItem>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreObject>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreFileObject>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BatchErrorsDataItem>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Batch>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretMapping>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimits>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimits>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureDeploymentConfig>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationModel>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ModelUpdateRequest>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationWorkspace>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceUpdateRequest>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Invite>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.User>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Workspace>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChildCollection>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Label>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ExportItem>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.LogExportsRequestedDataItem>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AuditLogObjectListRecord>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObjectRateLimit>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObject>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateApiKeyObjectRateLimit>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UpdateApiKeyObjectRateLimit>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailCheck>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailSummary>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersAllowedType>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersBlockedType>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PillarScanParametersScanner>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyModerationParametersCategorie>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyPIIParametersCategorie>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MistralModerationParametersCategorie>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersPiiCategorie>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersSecretsCategorie>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureContentSafetyParametersCategorie>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Condition>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GroupBy>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicy>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicyEntity>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimitsPolicy>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationListItem>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationWorkspaceItem>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationCapabilityItem>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerListItem>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerCapabilityItem>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerUserAccessItem>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? ListType136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.List<global::Portkey.CustomLog>>? ListType137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CustomLog>? ListType138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CollectionWithDetails>? ListType139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptSummary>? ListType140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptVersionSummary>? ListType141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialSummary>? ListType142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialVersion>? ListType143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigsResponseDataItem>? ListType144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetConfigResponseDataConfigTarget>? ListType145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigVersionsResponseDataItem>? ListType146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationList>? ListType147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Providers>? ListType148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VirtualKeys>? ListType149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? ListType150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? ListType151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? ListType152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? ListType153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? ListType154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? ListType155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? ListType156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? ListType157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? ListType158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? ListType159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? ListType160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? ListType161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? ListType162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? ListType163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? ListType164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? ListType165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? ListType166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? ListType167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? ListType168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? ListType169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? ListType170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? ListType171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>? ListType172 { get; set; }
    }
}