
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
        public global::Portkey.VectorStoreFileAttributes? Type92 { get; set; }
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
        public object? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionParameters? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctions? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionFunctionCallOption? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTool? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionObject? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOption? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOptionEnum? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoice? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceType? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceFunction? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudio? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputAudioType? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputContent? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputText? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Refusal? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItem? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessage? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCall? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCall? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCall? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItem? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputItemDiscriminator? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageType? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageRole? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputContent>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessageStatus? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputTextType? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Annotation>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Annotation? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCall? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallType? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallFunction? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunk? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkType? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkFunction? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionRole? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentBlock? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessage? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageRole? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageFunctionCall? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDelta? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaRole? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequest? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestModel? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatText? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchema? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObject? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinking? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinkingType? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestFunctionCall? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoice? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceFinishReason? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceLogprobs? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprob? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseObject? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoice? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseObject? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprobTopLogprob? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJob? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponseObject? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoice? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseObject? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseUsage? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateChatCompletionImageResponse? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequest? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestModel? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestQuality? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestResponseFormat? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestSize? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageRequestStyle? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ImagesResponse? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Image>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Image? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Includable? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionTool? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolType? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallType? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallStatus? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutput? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputType? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputStatus? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResource? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResourceVariant2? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResource? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallResourceVariant2? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudio? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioType? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputAudioFormat? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputContent? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputText? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImage? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFile? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputFileType? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageType? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputImageDetail? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItem? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessage? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Item? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReference? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputItemDiscriminator? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessage? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageType? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageRole? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageStatus? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputContent>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResource? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessageResourceVariant2? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputTextType? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequest? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestModel? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestSize? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageEditRequestResponseFormat? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequest? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestModel? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestResponseFormat? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateImageVariationRequestSize? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModelResponseProperties? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelResponseProperties? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequest? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationRequestModel? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResult? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategories? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategoryScores? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponse? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseProperties? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateResponseVariant3? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputItem>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Includable>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponse? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFile? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesResponseObject? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequest? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateFileRequestPurpose? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponse? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteFileResponseObject? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockFinetuneJob? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJob? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethod? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodType? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockParams? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyFinetuneJob? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyOptions? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexFinetuneJob? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponse? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEvent? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponseObject? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponse? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpoint? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponseObject? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequest? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestModel? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestEncodingFormat? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponse? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Embedding>? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Embedding? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseObject? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseUsage? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankDocument? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankDocumentObject? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankRequest? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankDocument>? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankResult? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankResultDocument? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankUsage? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankResponse? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRerankResponseObject? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankResult>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequest? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionWord? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelObject? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Move? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MoveType? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClick? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClickType? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Drag? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DragType? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Coordinate? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EmbeddingObject? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobError? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Click? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickType? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickButton? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilterType? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerAction? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPress? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Screenshot? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Scroll? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Type? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Wait? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerTool? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolType? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Content3? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResult? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultObject? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultAmount? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Reasoning? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningEffort? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemType? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RefusalType? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Response? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseError? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsage? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaSchema? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemList? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResource? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitie? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Tool? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitation? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitation? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePath? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObject? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReferenceType? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPressType? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObject? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObjectType? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObject? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectObject? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectStatus? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObject? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastError? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequest? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsResponse? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScreenshotType? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScrollType? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObject? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObject? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectObject? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectRole? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObject? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectType? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObjectType? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectType? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfter? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfterAnchor? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObject? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectObject? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectFileCounts? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreObjectStatus? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequest? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptions? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObject? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObjectType? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultItem? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPage? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPageObject? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsShared? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VoiceIdsSharedEnum? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WaitType? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchContextSize? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchLocation? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchTool? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolType? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocation? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolUserLocationType? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallType? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebSearchToolCallStatus? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreRequest? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParam? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParam? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TypeType1? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateVectorStoreRequest? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitationType? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresResponse? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponse? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponseObject? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObject? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectObject? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectStatus? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastError? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastErrorCode? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParam? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParam? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParamType? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParamType? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategy? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParamType? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParamType? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChunkingStrategyRequestParam? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileRequest? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesResponse? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponse? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponseObject? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObject? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectObject? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectStatus? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectFileCounts? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVectorStoreFileBatchRequest? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantStreamEvent? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEvent? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEvent? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEvent? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEvent? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEvent? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEvent? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1Event? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunctionType? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypesType? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant1Event? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant2Event? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant3Event? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant4Event? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant5Event? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant6Event? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant7Event? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant8Event? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant9Event? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStreamEventVariant10Event? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1Event? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2Event? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3Event? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4Event? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5Event? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6Event? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7Event? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1Event? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2Event? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3Event? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4Event? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5Event? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ErrorEventEvent? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitationType? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePathType? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventEvent? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoneEventData? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Batch? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchObject? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrors? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchErrorsDataItem? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchStatus? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestCounts? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInput? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestInputMethod? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutput? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputResponse? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BatchRequestOutputError? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponse? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Batch>? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListBatchesResponseObject? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackRequest? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackResponse? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FeedbackUpdateRequest? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimits? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsType? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsUnit? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimits? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsType? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPeriodicReset? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationRequest? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIConfiguration? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfiguration? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfiguration? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfiguration? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfiguration? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkersAIConfiguration? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfiguration? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HuggingFaceConfiguration? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CortexConfiguration? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomHostConfiguration? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretMapping? Type919 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuthConfig? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemObject? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponse? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseManagerType? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseStatus? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseObject? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfigAwsAuthType? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfigAwsAuthType? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfigAzureAuthMode? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfigAzureAuthMode? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfigAzureAuthMode? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfigVaultAuthType? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListStatus? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationListObject? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModelsResponse? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationModel? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfig? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PricingConfigType? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PayAsYouGoPricing? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TokenPricing? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelConfigurations? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateModelsRequest? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Providers? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersStatus? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersObject? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeys? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Invite? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteRole2? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteStatus? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteList? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteListObject? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.User? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserObject? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserRole? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserList? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserListObject? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMember? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Workspace? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceList? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Collection? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionStatus? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionDetails? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChildCollection? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Label? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummary? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Prompt2? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartial? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLog? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponse? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItem? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemObject? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogObject? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequest? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogResponse? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitType? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitUnit? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicy? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitType? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitUnit? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicy? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RotateApiKeyRequest? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RotateApiKeyResponse? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActions? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JWTParameters? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WordCountParameters? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParameters? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebhookParameters? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AporiaParameters? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusParameters? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BasicParameters? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchParams? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Condition? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GroupBy? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegration? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServer? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListItem? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionItem? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionsListResponse? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerConnectionItem>? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerConnectionDeleteResponse? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsSort? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysType? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1564 { get; set; }

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
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? ListType149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? ListType150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? ListType151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? ListType152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? ListType153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? ListType154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? ListType155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? ListType156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? ListType157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? ListType158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? ListType159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? ListType160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? ListType161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? ListType162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? ListType163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? ListType164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? ListType165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? ListType166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? ListType167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? ListType168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? ListType169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? ListType170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>? ListType171 { get; set; }
    }
}