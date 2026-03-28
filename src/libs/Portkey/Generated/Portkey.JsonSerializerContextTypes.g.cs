
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
        public global::Portkey.CreateTranscriptionRequest? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TranscriptionWord? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelObject? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Move? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MoveType? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClick? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DoubleClickType? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Drag? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DragType? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Coordinate? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EmbeddingObject? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobError? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>>? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ChatCompletionRequestSystemMessage, global::Portkey.ChatCompletionRequestUserMessage, global::Portkey.FineTuneChatCompletionRequestAssistantMessage, global::Portkey.FineTuneChatCompletionRequestFunctionMessage?>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Click? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickType? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ClickButton? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CompoundFilterType? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerAction? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPress? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Screenshot? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Scroll? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Type? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Wait? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerTool? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolType? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Content3? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResult? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultObject? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CostsResultAmount? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Reasoning? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningEffort? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemType? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RefusalType? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Response? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseError? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsage? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaSchema? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemList? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResource? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitie? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Tool? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FileCitation? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UrlCitation? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FilePath? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObject? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemReferenceType? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.KeyPressType? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObject? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TruncationObjectType? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObject? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectObject? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectStatus? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObject? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastError? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequest? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsResponse? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScreenshotType? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ScrollType? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObject? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObject? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectObject? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectRole? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObject? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectType? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>>? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeObject, global::Portkey.RunStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDetailsToolCallsFunctionObject>? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>>? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject>? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? Type742 { get; set; }
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
        public global::Portkey.CreateIntegrationRequest? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>? Type906 { get; set; }
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
        public global::Portkey.UpdateIntegrationRequest? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponse? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationList? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GlobalWorkspaceAccess? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuthConfig? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type951 { get; set; }
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
        public global::Portkey.BulkUpdateModelsRequest? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Providers? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersStatus? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ProvidersObject? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeys? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Invite? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteRole2? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteStatus? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteList? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InviteListObject? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.User? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserObject? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserRole? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserList? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UserListObject? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMember? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Workspace? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceList? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Collection? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionStatus? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionDetails? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ChildCollection? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Label? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummary? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Prompt2? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartial? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLog? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponse? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItem? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportItemObject? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogObject? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequest? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogResponse? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActions? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.JWTParameters, global::Portkey.ModelWhitelistParameters, global::Portkey.RegexMatchParameters, global::Portkey.SentenceCountParameters, global::Portkey.WordCountParameters, global::Portkey.CharacterCountParameters, global::Portkey.JSONSchemaParameters, global::Portkey.JSONKeysParameters, global::Portkey.ContainsParameters, global::Portkey.ValidUrlsParameters, global::Portkey.ContainsCodeParameters, global::Portkey.WebhookParameters, global::Portkey.EndsWithParameters, global::Portkey.UppercaseParameters, global::Portkey.RequiredMetadataKeysParameters, global::Portkey.AllowedRequestTypesParameters, global::Portkey.SydeGuardParameters, global::Portkey.AporiaParameters, global::Portkey.PillarScanParameters, global::Portkey.PatronusParameters, global::Portkey.PatronusCustomParameters, global::Portkey.PortkeyModerationParameters, global::Portkey.PortkeyLanguageParameters, global::Portkey.PortkeyPIIParameters, global::Portkey.MistralModerationParameters, global::Portkey.BedrockGuardParameters, global::Portkey.PromptfooParameters, global::Portkey.AcuvityScanParameters, global::Portkey.AzureContentSafetyParameters, global::Portkey.AzurePIIParameters, global::Portkey.PANWPrismaParameters, global::Portkey.BasicParameters>? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JWTParameters? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WordCountParameters? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParameters? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.WebhookParameters? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AporiaParameters? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusParameters? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BasicParameters? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.VertexBatchParams? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.Condition? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GroupBy? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegration? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServer? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListItem? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsSort? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysType? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1550 { get; set; }

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