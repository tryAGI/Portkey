
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
        public global::System.DateTimeOffset? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCompletionResponseObject? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsage? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPart? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartText? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageType? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartTextType? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinking? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinkingType? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessage? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessage? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessage? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessage? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessage? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessage? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessage? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessageRole? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessageRole? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessageRole? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageRole? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchTool? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilter? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilter? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptions? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptionsRanker? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCall? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallType? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallStatus? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCallResult? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileAttributes? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessage? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageFunctionCall? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessageRole? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessageRole? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestFunctionMessage? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionParameters? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctions? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctionCallOption? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTool? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolType? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionObject? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOption? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOptionEnum? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoice? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceType? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceFunction? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudio? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudioType? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputContent? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputText? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Refusal? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItem? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessage? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCall? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCall? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCall? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItem? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItemDiscriminator? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageType? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageRole? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputContent>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageStatus? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputTextType? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Annotation>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Annotation? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCall? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallType? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallFunction? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunk? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkType? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkFunction? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRole? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentBlock? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessage? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageRole? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageFunctionCall? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDelta? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaRole? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequest? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestModel? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatText? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchema? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObject? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinking? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinkingType? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestFunctionCall? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoice? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceFinishReason? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceLogprobs? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprob? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseObject? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponse? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoice? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseObject? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprobTopLogprob? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponse? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJob? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponseObject? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponse? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoice? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseObject? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseUsage? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionImageResponse? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequest? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestModel? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestQuality? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestResponseFormat? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestSize? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestStyle? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ImagesResponse? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Image>? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Image? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Includable? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionTool? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolType? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallType? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallStatus? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutput? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputType? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputStatus? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResource? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResourceVariant2? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResource? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResourceVariant2? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudio? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioType? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioFormat? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputContent? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputText? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImage? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFile? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFileType? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageType? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageDetail? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItem? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessage? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Item? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReference? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItemDiscriminator? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessage? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageType? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageRole? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageStatus? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputContent>? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResource? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResourceVariant2? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputTextType? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequest? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestModel? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestSize? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestResponseFormat? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequest? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestModel? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestResponseFormat? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestSize? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModelResponseProperties? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelResponseProperties? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequest? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequestModel? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResult? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategories? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategoryScores? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponse? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseProperties? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponseVariant3? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputItem>? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Includable>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponse? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFile? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponseObject? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequest? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequestPurpose? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponse? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponseObject? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockFinetuneJob? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJob? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethod? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodType? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockParams? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyFinetuneJob? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyOptions? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexFinetuneJob? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponse? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEvent? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponseObject? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponse? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpoint? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponseObject? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequest? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestModel? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestEncodingFormat? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponse? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Embedding>? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Embedding? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseObject? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseUsage? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankDocument? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankDocumentObject? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankDocument>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankResult? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankResultDocument? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankUsage? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankResponse? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankResponseObject? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankResult>? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequest? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionWord? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelObject? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Move? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MoveType? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClick? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClickType? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Drag? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DragType? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Coordinate? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EmbeddingObject? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobError? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Click? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickType? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickButton? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilterType? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerAction? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPress? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Screenshot? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Scroll? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Type? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Wait? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerTool? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolType? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Content3? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResult? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultObject? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultAmount? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Reasoning? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningEffort? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemType? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RefusalType? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Response? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseError? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsage? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaSchema? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemList? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResource? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitie? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Tool? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitation? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitation? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePath? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObject? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReferenceType? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPressType? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObject? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObjectType? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObject? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectObject? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectStatus? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObject? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastError? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequest? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsResponse? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScreenshotType? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScrollType? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObject? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObject? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectObject? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectRole? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObject? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectType? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObjectType? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectType? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfter? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfterAnchor? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObject? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectObject? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectFileCounts? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectStatus? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequest? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptions? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObject? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObjectType? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultItem? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPage? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPageObject? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsShared? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsSharedEnum? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WaitType? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchContextSize? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchLocation? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchTool? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolType? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocation? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocationType? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallType? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallStatus? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreRequest? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParam? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParam? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TypeType1? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateVectorStoreRequest? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitationType? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresResponse? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponse? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponseObject? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObject? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectObject? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectStatus? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastError? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastErrorCode? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParam? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParam? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParamType? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParamType? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategy? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParamType? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParamType? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChunkingStrategyRequestParam? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileRequest? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesResponse? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponse? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponseObject? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObject? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectObject? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectStatus? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectFileCounts? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileBatchRequest? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantStreamEvent? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEvent? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEvent? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEvent? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEvent? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEvent? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEvent? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1Event? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunctionType? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypesType? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1Event? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2Event? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3Event? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4Event? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5Event? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6Event? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7Event? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8Event? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9Event? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10Event? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1Event? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2Event? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3Event? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4Event? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5Event? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6Event? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7Event? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1Event? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2Event? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3Event? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4Event? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5Event? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEventEvent? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitationType? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePathType? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventEvent? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventData? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Batch? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchObject? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrors? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrorsDataItem? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchStatus? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestCounts? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInput? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInputMethod? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutput? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputResponse? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputError? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponse? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Batch>? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponseObject? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackRequest? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackResponse? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackUpdateRequest? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimits? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsType? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsUnit? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimits? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsType? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPeriodicReset? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationRequest? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIConfiguration? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfiguration? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfiguration? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfiguration? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfiguration? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkersAIConfiguration? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfiguration? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HuggingFaceConfiguration? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CortexConfiguration? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomHostConfiguration? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretMapping? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingAdjustments? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateIntegrationRequest? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponse? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationList? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GlobalWorkspaceAccess? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingMultiplier? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingMultiplierImage? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuthConfig? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemObject? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponse? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseManagerType? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseStatus? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseObject? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfigAwsAuthType? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfigAwsAuthType? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfigAzureAuthMode? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfigAzureAuthMode? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfigAzureAuthMode? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfigVaultAuthType? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListStatus? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListObject? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModelsResponse? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModel? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfig? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfigType? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PayAsYouGoPricing? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TokenPricing? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelConfigurations? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateModelsRequest? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Providers? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersStatus? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersObject? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeys? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Invite? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteRole2? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteStatus? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteList? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteListObject? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.User? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserObject? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserRole? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserList? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserListObject? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMember? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Workspace? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceList? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScimWorkspaceMapping? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScimWorkspaceMappingRole? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Collection? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionStatus? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionDetails? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChildCollection? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Label? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummary? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Prompt2? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartial? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLog? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponse? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItem? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemObject? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogObject? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequest? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogResponse? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitType? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitUnit? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicy? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitType? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitUnit? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicy? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RotateApiKeyRequest? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RotateApiKeyResponse? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActions? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JWTParameters? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WordCountParameters? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParameters? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebhookParameters? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AporiaParameters? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusParameters? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BasicParameters? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchParams? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Condition? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GroupBy? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegration? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServer? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListItem? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionItem? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionsListResponse? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerConnectionItem>? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionDeleteResponse? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequest? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequestRole? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsSort? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetScimWorkspacesRole? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysType? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponse? Type1458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>? Type1459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMapping? Type1460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMappingRole? Type1461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteScimWorkspacesResponse? Type1462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1576 { get; set; }

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
        public global::System.Collections.Generic.List<global::Portkey.RerankDocument>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RerankResult>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Coordinate>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputItem>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ItemResource>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitie>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitiesTextOnlyItem>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Tool>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AssistantObject>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunObject>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ThreadObject>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObject>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunStepObject>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultContentObject>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultItem>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreObject>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreFileObject>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BatchErrorsDataItem>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Batch>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretMapping>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimits>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimits>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureDeploymentConfig>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationModel>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ModelUpdateRequest>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationWorkspace>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceUpdateRequest>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Invite>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.User>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Workspace>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChildCollection>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Label>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ExportItem>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.LogExportsRequestedDataItem>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AuditLogObjectListRecord>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObjectRateLimit>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObject>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateApiKeyObjectRateLimit>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UpdateApiKeyObjectRateLimit>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailCheck>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailSummary>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersAllowedType>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersBlockedType>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PillarScanParametersScanner>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyModerationParametersCategorie>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyPIIParametersCategorie>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MistralModerationParametersCategorie>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersPiiCategorie>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersSecretsCategorie>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureContentSafetyParametersCategorie>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Condition>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GroupBy>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicy>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicyEntity>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimitsPolicy>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationListItem>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationWorkspaceItem>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationCapabilityItem>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerListItem>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerCapabilityItem>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerUserAccessItem>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerConnectionItem>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.List<global::Portkey.CustomLog>>? ListType136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CustomLog>? ListType137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CollectionWithDetails>? ListType138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptSummary>? ListType139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptVersionSummary>? ListType140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialSummary>? ListType141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialVersion>? ListType142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigsResponseDataItem>? ListType143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetConfigResponseDataConfigTarget>? ListType144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigVersionsResponseDataItem>? ListType145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationList>? ListType146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Providers>? ListType147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VirtualKeys>? ListType148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetScimWorkspacesResponseMapping>? ListType149 { get; set; }
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