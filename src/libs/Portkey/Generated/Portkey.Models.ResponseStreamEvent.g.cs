#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseStreamEvent : global::System.IEquatable<ResponseStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseAudioDeltaEvent? ResponseAudioDelta { get; init; }
#else
        public global::Portkey.ResponseAudioDeltaEvent? ResponseAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseAudioDeltaEvent? value)
        {
            value = ResponseAudioDelta;
            return IsResponseAudioDelta;
        }

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseAudioDoneEvent? ResponseAudioDone { get; init; }
#else
        public global::Portkey.ResponseAudioDoneEvent? ResponseAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseAudioDoneEvent? value)
        {
            value = ResponseAudioDone;
            return IsResponseAudioDone;
        }

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseAudioTranscriptDeltaEvent? value)
        {
            value = ResponseAudioTranscriptDelta;
            return IsResponseAudioTranscriptDelta;
        }

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; init; }
#else
        public global::Portkey.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseAudioTranscriptDoneEvent? value)
        {
            value = ResponseAudioTranscriptDone;
            return IsResponseAudioTranscriptDone;
        }

        /// <summary>
        /// Emitted when a partial code snippet is added by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; init; }
#else
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDelta))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDelta => ResponseCodeInterpreterCallCodeDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDelta;
            return IsResponseCodeInterpreterCallCodeDelta;
        }

        /// <summary>
        /// Emitted when code snippet output is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; init; }
#else
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDone))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDone => ResponseCodeInterpreterCallCodeDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDone;
            return IsResponseCodeInterpreterCallCodeDone;
        }

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; init; }
#else
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCompleted))]
#endif
        public bool IsResponseCodeInterpreterCallCompleted => ResponseCodeInterpreterCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            value = ResponseCodeInterpreterCallCompleted;
            return IsResponseCodeInterpreterCallCompleted;
        }

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; init; }
#else
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInProgress))]
#endif
        public bool IsResponseCodeInterpreterCallInProgress => ResponseCodeInterpreterCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            value = ResponseCodeInterpreterCallInProgress;
            return IsResponseCodeInterpreterCallInProgress;
        }

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; init; }
#else
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInterpreting))]
#endif
        public bool IsResponseCodeInterpreterCallInterpreting => ResponseCodeInterpreterCallInterpreting != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInterpreting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            value = ResponseCodeInterpreterCallInterpreting;
            return IsResponseCodeInterpreterCallInterpreting;
        }

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCompletedEvent? ResponseCompleted { get; init; }
#else
        public global::Portkey.ResponseCompletedEvent? ResponseCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompleted))]
#endif
        public bool IsResponseCompleted => ResponseCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCompletedEvent? value)
        {
            value = ResponseCompleted;
            return IsResponseCompleted;
        }

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; init; }
#else
        public global::Portkey.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseContentPartAddedEvent? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseContentPartDoneEvent? ResponseContentPartDone { get; init; }
#else
        public global::Portkey.ResponseContentPartDoneEvent? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseContentPartDoneEvent? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseCreatedEvent? ResponseCreated { get; init; }
#else
        public global::Portkey.ResponseCreatedEvent? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseCreatedEvent? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        /// Emitted when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseErrorEvent? Error { get; init; }
#else
        public global::Portkey.ResponseErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; init; }
#else
        public global::Portkey.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallCompleted))]
#endif
        public bool IsResponseFileSearchCallCompleted => ResponseFileSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFileSearchCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFileSearchCallCompletedEvent? value)
        {
            value = ResponseFileSearchCallCompleted;
            return IsResponseFileSearchCallCompleted;
        }

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; init; }
#else
        public global::Portkey.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallInProgress))]
#endif
        public bool IsResponseFileSearchCallInProgress => ResponseFileSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFileSearchCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFileSearchCallInProgressEvent? value)
        {
            value = ResponseFileSearchCallInProgress;
            return IsResponseFileSearchCallInProgress;
        }

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; init; }
#else
        public global::Portkey.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallSearching))]
#endif
        public bool IsResponseFileSearchCallSearching => ResponseFileSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFileSearchCallSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFileSearchCallSearchingEvent? value)
        {
            value = ResponseFileSearchCallSearching;
            return IsResponseFileSearchCallSearching;
        }

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseInProgressEvent? ResponseInProgress { get; init; }
#else
        public global::Portkey.ResponseInProgressEvent? ResponseInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInProgress))]
#endif
        public bool IsResponseInProgress => ResponseInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseInProgressEvent? value)
        {
            value = ResponseInProgress;
            return IsResponseInProgress;
        }

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseFailedEvent? ResponseFailed { get; init; }
#else
        public global::Portkey.ResponseFailedEvent? ResponseFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFailed))]
#endif
        public bool IsResponseFailed => ResponseFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseFailedEvent? value)
        {
            value = ResponseFailed;
            return IsResponseFailed;
        }

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseIncompleteEvent? ResponseIncomplete { get; init; }
#else
        public global::Portkey.ResponseIncompleteEvent? ResponseIncomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseIncomplete))]
#endif
        public bool IsResponseIncomplete => ResponseIncomplete != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseIncomplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseIncompleteEvent? value)
        {
            value = ResponseIncomplete;
            return IsResponseIncomplete;
        }

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; init; }
#else
        public global::Portkey.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseOutputItemAddedEvent? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; init; }
#else
        public global::Portkey.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseOutputItemDoneEvent? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; init; }
#else
        public global::Portkey.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDelta))]
#endif
        public bool IsResponseRefusalDelta => ResponseRefusalDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseRefusalDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseRefusalDeltaEvent? value)
        {
            value = ResponseRefusalDelta;
            return IsResponseRefusalDelta;
        }

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseRefusalDoneEvent? ResponseRefusalDone { get; init; }
#else
        public global::Portkey.ResponseRefusalDoneEvent? ResponseRefusalDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDone))]
#endif
        public bool IsResponseRefusalDone => ResponseRefusalDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseRefusalDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseRefusalDoneEvent? value)
        {
            value = ResponseRefusalDone;
            return IsResponseRefusalDone;
        }

        /// <summary>
        /// Emitted when a text annotation is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseTextAnnotationDeltaEvent? ResponseOutputTextAnnotationAdded { get; init; }
#else
        public global::Portkey.ResponseTextAnnotationDeltaEvent? ResponseOutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextAnnotationAdded))]
#endif
        public bool IsResponseOutputTextAnnotationAdded => ResponseOutputTextAnnotationAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputTextAnnotationAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseTextAnnotationDeltaEvent? value)
        {
            value = ResponseOutputTextAnnotationAdded;
            return IsResponseOutputTextAnnotationAdded;
        }

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; init; }
#else
        public global::Portkey.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseTextDeltaEvent? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseTextDoneEvent? ResponseOutputTextDone { get; init; }
#else
        public global::Portkey.ResponseTextDoneEvent? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseTextDoneEvent? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; init; }
#else
        public global::Portkey.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallCompleted))]
#endif
        public bool IsResponseWebSearchCallCompleted => ResponseWebSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseWebSearchCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseWebSearchCallCompletedEvent? value)
        {
            value = ResponseWebSearchCallCompleted;
            return IsResponseWebSearchCallCompleted;
        }

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; init; }
#else
        public global::Portkey.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallInProgress))]
#endif
        public bool IsResponseWebSearchCallInProgress => ResponseWebSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseWebSearchCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseWebSearchCallInProgressEvent? value)
        {
            value = ResponseWebSearchCallInProgress;
            return IsResponseWebSearchCallInProgress;
        }

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; init; }
#else
        public global::Portkey.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallSearching))]
#endif
        public bool IsResponseWebSearchCallSearching => ResponseWebSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseWebSearchCallSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseWebSearchCallSearchingEvent? value)
        {
            value = ResponseWebSearchCallSearching;
            return IsResponseWebSearchCallSearching;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseAudioDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseAudioDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseAudioDeltaEvent? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseAudioDelta(global::Portkey.ResponseAudioDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseAudioDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseAudioDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseAudioDoneEvent? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseAudioDone(global::Portkey.ResponseAudioDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseAudioTranscriptDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseAudioTranscriptDeltaEvent? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseAudioTranscriptDelta(global::Portkey.ResponseAudioTranscriptDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseAudioTranscriptDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseAudioTranscriptDoneEvent? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseAudioTranscriptDone(global::Portkey.ResponseAudioTranscriptDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            ResponseCodeInterpreterCallCodeDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCodeDelta(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            ResponseCodeInterpreterCallCodeDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCodeDone(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCodeInterpreterCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            ResponseCodeInterpreterCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCompleted(global::Portkey.ResponseCodeInterpreterCallCompletedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCodeInterpreterCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            ResponseCodeInterpreterCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCodeInterpreterCallInProgress(global::Portkey.ResponseCodeInterpreterCallInProgressEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCodeInterpreterCallInterpretingEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInterpreting;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            ResponseCodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCodeInterpreterCallInterpreting(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCompletedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCompletedEvent? value)
        {
            ResponseCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCompleted(global::Portkey.ResponseCompletedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseContentPartAddedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseContentPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseContentPartAddedEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseContentPartAddedEvent? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseContentPartAdded(global::Portkey.ResponseContentPartAddedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseContentPartDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseContentPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseContentPartDoneEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseContentPartDoneEvent? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseContentPartDone(global::Portkey.ResponseContentPartDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseCreatedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseCreatedEvent?(ResponseStreamEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseCreated(global::Portkey.ResponseCreatedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseErrorEvent value) => new ResponseStreamEvent((global::Portkey.ResponseErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseErrorEvent?(ResponseStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromError(global::Portkey.ResponseErrorEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFileSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFileSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFileSearchCallCompletedEvent? value)
        {
            ResponseFileSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFileSearchCallCompleted(global::Portkey.ResponseFileSearchCallCompletedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFileSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFileSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFileSearchCallInProgressEvent? value)
        {
            ResponseFileSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFileSearchCallInProgress(global::Portkey.ResponseFileSearchCallInProgressEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFileSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFileSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFileSearchCallSearchingEvent? value)
        {
            ResponseFileSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFileSearchCallSearching(global::Portkey.ResponseFileSearchCallSearchingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFunctionCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFunctionCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFunctionCallArgumentsDelta(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFunctionCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFunctionCallArgumentsDone(global::Portkey.ResponseFunctionCallArgumentsDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseInProgressEvent value) => new ResponseStreamEvent((global::Portkey.ResponseInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseInProgressEvent? value)
        {
            ResponseInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseInProgress(global::Portkey.ResponseInProgressEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseFailedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseFailedEvent?(ResponseStreamEvent @this) => @this.ResponseFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseFailedEvent? value)
        {
            ResponseFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseFailed(global::Portkey.ResponseFailedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseIncompleteEvent value) => new ResponseStreamEvent((global::Portkey.ResponseIncompleteEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseIncompleteEvent?(ResponseStreamEvent @this) => @this.ResponseIncomplete;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseIncompleteEvent? value)
        {
            ResponseIncomplete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseIncomplete(global::Portkey.ResponseIncompleteEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseOutputItemAddedEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputItemAdded(global::Portkey.ResponseOutputItemAddedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseOutputItemDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseOutputItemDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseOutputItemDoneEvent? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputItemDone(global::Portkey.ResponseOutputItemDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseRefusalDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseRefusalDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseRefusalDeltaEvent? value)
        {
            ResponseRefusalDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseRefusalDelta(global::Portkey.ResponseRefusalDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseRefusalDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseRefusalDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseRefusalDoneEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseRefusalDoneEvent? value)
        {
            ResponseRefusalDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseRefusalDone(global::Portkey.ResponseRefusalDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseTextAnnotationDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseTextAnnotationDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseTextAnnotationDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextAnnotationAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseTextAnnotationDeltaEvent? value)
        {
            ResponseOutputTextAnnotationAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputTextAnnotationAdded(global::Portkey.ResponseTextAnnotationDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseTextDeltaEvent value) => new ResponseStreamEvent((global::Portkey.ResponseTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseTextDeltaEvent? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputTextDelta(global::Portkey.ResponseTextDeltaEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseTextDoneEvent value) => new ResponseStreamEvent((global::Portkey.ResponseTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseTextDoneEvent? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputTextDone(global::Portkey.ResponseTextDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent((global::Portkey.ResponseWebSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseWebSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseWebSearchCallCompletedEvent? value)
        {
            ResponseWebSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseWebSearchCallCompleted(global::Portkey.ResponseWebSearchCallCompletedEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent((global::Portkey.ResponseWebSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseWebSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseWebSearchCallInProgressEvent? value)
        {
            ResponseWebSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseWebSearchCallInProgress(global::Portkey.ResponseWebSearchCallInProgressEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::Portkey.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent((global::Portkey.ResponseWebSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseWebSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::Portkey.ResponseWebSearchCallSearchingEvent? value)
        {
            ResponseWebSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponseStreamEvent FromResponseWebSearchCallSearching(global::Portkey.ResponseWebSearchCallSearchingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(
            global::Portkey.ResponseStreamEventDiscriminatorType? type,
            global::Portkey.ResponseAudioDeltaEvent? responseAudioDelta,
            global::Portkey.ResponseAudioDoneEvent? responseAudioDone,
            global::Portkey.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta,
            global::Portkey.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone,
            global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::Portkey.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::Portkey.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::Portkey.ResponseCompletedEvent? responseCompleted,
            global::Portkey.ResponseContentPartAddedEvent? responseContentPartAdded,
            global::Portkey.ResponseContentPartDoneEvent? responseContentPartDone,
            global::Portkey.ResponseCreatedEvent? responseCreated,
            global::Portkey.ResponseErrorEvent? error,
            global::Portkey.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted,
            global::Portkey.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress,
            global::Portkey.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching,
            global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta,
            global::Portkey.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::Portkey.ResponseInProgressEvent? responseInProgress,
            global::Portkey.ResponseFailedEvent? responseFailed,
            global::Portkey.ResponseIncompleteEvent? responseIncomplete,
            global::Portkey.ResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::Portkey.ResponseOutputItemDoneEvent? responseOutputItemDone,
            global::Portkey.ResponseRefusalDeltaEvent? responseRefusalDelta,
            global::Portkey.ResponseRefusalDoneEvent? responseRefusalDone,
            global::Portkey.ResponseTextAnnotationDeltaEvent? responseOutputTextAnnotationAdded,
            global::Portkey.ResponseTextDeltaEvent? responseOutputTextDelta,
            global::Portkey.ResponseTextDoneEvent? responseOutputTextDone,
            global::Portkey.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted,
            global::Portkey.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress,
            global::Portkey.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching
            )
        {
            Type = type;

            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseCodeInterpreterCallCodeDelta = responseCodeInterpreterCallCodeDelta;
            ResponseCodeInterpreterCallCodeDone = responseCodeInterpreterCallCodeDone;
            ResponseCodeInterpreterCallCompleted = responseCodeInterpreterCallCompleted;
            ResponseCodeInterpreterCallInProgress = responseCodeInterpreterCallInProgress;
            ResponseCodeInterpreterCallInterpreting = responseCodeInterpreterCallInterpreting;
            ResponseCompleted = responseCompleted;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            Error = error;
            ResponseFileSearchCallCompleted = responseFileSearchCallCompleted;
            ResponseFileSearchCallInProgress = responseFileSearchCallInProgress;
            ResponseFileSearchCallSearching = responseFileSearchCallSearching;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseInProgress = responseInProgress;
            ResponseFailed = responseFailed;
            ResponseIncomplete = responseIncomplete;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseRefusalDelta = responseRefusalDelta;
            ResponseRefusalDone = responseRefusalDone;
            ResponseOutputTextAnnotationAdded = responseOutputTextAnnotationAdded;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseWebSearchCallCompleted = responseWebSearchCallCompleted;
            ResponseWebSearchCallInProgress = responseWebSearchCallInProgress;
            ResponseWebSearchCallSearching = responseWebSearchCallSearching;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseWebSearchCallSearching as object ??
            ResponseWebSearchCallInProgress as object ??
            ResponseWebSearchCallCompleted as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseOutputTextAnnotationAdded as object ??
            ResponseRefusalDone as object ??
            ResponseRefusalDelta as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseIncomplete as object ??
            ResponseFailed as object ??
            ResponseInProgress as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseFileSearchCallSearching as object ??
            ResponseFileSearchCallInProgress as object ??
            ResponseFileSearchCallCompleted as object ??
            Error as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseCompleted as object ??
            ResponseCodeInterpreterCallInterpreting as object ??
            ResponseCodeInterpreterCallInProgress as object ??
            ResponseCodeInterpreterCallCompleted as object ??
            ResponseCodeInterpreterCallCodeDone as object ??
            ResponseCodeInterpreterCallCodeDelta as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseCodeInterpreterCallCodeDelta?.ToString() ??
            ResponseCodeInterpreterCallCodeDone?.ToString() ??
            ResponseCodeInterpreterCallCompleted?.ToString() ??
            ResponseCodeInterpreterCallInProgress?.ToString() ??
            ResponseCodeInterpreterCallInterpreting?.ToString() ??
            ResponseCompleted?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            Error?.ToString() ??
            ResponseFileSearchCallCompleted?.ToString() ??
            ResponseFileSearchCallInProgress?.ToString() ??
            ResponseFileSearchCallSearching?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseInProgress?.ToString() ??
            ResponseFailed?.ToString() ??
            ResponseIncomplete?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseRefusalDelta?.ToString() ??
            ResponseRefusalDone?.ToString() ??
            ResponseOutputTextAnnotationAdded?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseWebSearchCallCompleted?.ToString() ??
            ResponseWebSearchCallInProgress?.ToString() ??
            ResponseWebSearchCallSearching?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseAudioDelta || IsResponseAudioDone || IsResponseAudioTranscriptDelta || IsResponseAudioTranscriptDone || IsResponseCodeInterpreterCallCodeDelta || IsResponseCodeInterpreterCallCodeDone || IsResponseCodeInterpreterCallCompleted || IsResponseCodeInterpreterCallInProgress || IsResponseCodeInterpreterCallInterpreting || IsResponseCompleted || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsError || IsResponseFileSearchCallCompleted || IsResponseFileSearchCallInProgress || IsResponseFileSearchCallSearching || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseInProgress || IsResponseFailed || IsResponseIncomplete || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseRefusalDelta || IsResponseRefusalDone || IsResponseOutputTextAnnotationAdded || IsResponseOutputTextDelta || IsResponseOutputTextDone || IsResponseWebSearchCallCompleted || IsResponseWebSearchCallInProgress || IsResponseWebSearchCallSearching;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ResponseAudioDeltaEvent, TResult>? responseAudioDelta = null,
            global::System.Func<global::Portkey.ResponseAudioDoneEvent, TResult>? responseAudioDone = null,
            global::System.Func<global::Portkey.ResponseAudioTranscriptDeltaEvent, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::Portkey.ResponseAudioTranscriptDoneEvent, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::Portkey.ResponseCodeInterpreterCallCompletedEvent, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::Portkey.ResponseCodeInterpreterCallInProgressEvent, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::Portkey.ResponseCompletedEvent, TResult>? responseCompleted = null,
            global::System.Func<global::Portkey.ResponseContentPartAddedEvent, TResult>? responseContentPartAdded = null,
            global::System.Func<global::Portkey.ResponseContentPartDoneEvent, TResult>? responseContentPartDone = null,
            global::System.Func<global::Portkey.ResponseCreatedEvent, TResult>? responseCreated = null,
            global::System.Func<global::Portkey.ResponseErrorEvent, TResult>? error = null,
            global::System.Func<global::Portkey.ResponseFileSearchCallCompletedEvent, TResult>? responseFileSearchCallCompleted = null,
            global::System.Func<global::Portkey.ResponseFileSearchCallInProgressEvent, TResult>? responseFileSearchCallInProgress = null,
            global::System.Func<global::Portkey.ResponseFileSearchCallSearchingEvent, TResult>? responseFileSearchCallSearching = null,
            global::System.Func<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::Portkey.ResponseFunctionCallArgumentsDoneEvent, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::Portkey.ResponseInProgressEvent, TResult>? responseInProgress = null,
            global::System.Func<global::Portkey.ResponseFailedEvent, TResult>? responseFailed = null,
            global::System.Func<global::Portkey.ResponseIncompleteEvent, TResult>? responseIncomplete = null,
            global::System.Func<global::Portkey.ResponseOutputItemAddedEvent, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::Portkey.ResponseOutputItemDoneEvent, TResult>? responseOutputItemDone = null,
            global::System.Func<global::Portkey.ResponseRefusalDeltaEvent, TResult>? responseRefusalDelta = null,
            global::System.Func<global::Portkey.ResponseRefusalDoneEvent, TResult>? responseRefusalDone = null,
            global::System.Func<global::Portkey.ResponseTextAnnotationDeltaEvent, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::Portkey.ResponseTextDeltaEvent, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::Portkey.ResponseTextDoneEvent, TResult>? responseOutputTextDone = null,
            global::System.Func<global::Portkey.ResponseWebSearchCallCompletedEvent, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::Portkey.ResponseWebSearchCallInProgressEvent, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::Portkey.ResponseWebSearchCallSearchingEvent, TResult>? responseWebSearchCallSearching = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta && responseAudioDelta != null)
            {
                return responseAudioDelta(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone && responseAudioDone != null)
            {
                return responseAudioDone(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta && responseCodeInterpreterCallCodeDelta != null)
            {
                return responseCodeInterpreterCallCodeDelta(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone && responseCodeInterpreterCallCodeDone != null)
            {
                return responseCodeInterpreterCallCodeDone(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted && responseCodeInterpreterCallCompleted != null)
            {
                return responseCodeInterpreterCallCompleted(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress && responseCodeInterpreterCallInProgress != null)
            {
                return responseCodeInterpreterCallInProgress(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting && responseCodeInterpreterCallInterpreting != null)
            {
                return responseCodeInterpreterCallInterpreting(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted && responseCompleted != null)
            {
                return responseCompleted(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded && responseContentPartAdded != null)
            {
                return responseContentPartAdded(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone && responseContentPartDone != null)
            {
                return responseContentPartDone(ResponseContentPartDone!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsResponseFileSearchCallCompleted && responseFileSearchCallCompleted != null)
            {
                return responseFileSearchCallCompleted(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress && responseFileSearchCallInProgress != null)
            {
                return responseFileSearchCallInProgress(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching && responseFileSearchCallSearching != null)
            {
                return responseFileSearchCallSearching(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress && responseInProgress != null)
            {
                return responseInProgress(ResponseInProgress!);
            }
            else if (IsResponseFailed && responseFailed != null)
            {
                return responseFailed(ResponseFailed!);
            }
            else if (IsResponseIncomplete && responseIncomplete != null)
            {
                return responseIncomplete(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseRefusalDelta && responseRefusalDelta != null)
            {
                return responseRefusalDelta(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone && responseRefusalDone != null)
            {
                return responseRefusalDone(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextAnnotationAdded && responseOutputTextAnnotationAdded != null)
            {
                return responseOutputTextAnnotationAdded(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseOutputTextDelta && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone && responseOutputTextDone != null)
            {
                return responseOutputTextDone(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted && responseWebSearchCallCompleted != null)
            {
                return responseWebSearchCallCompleted(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress && responseWebSearchCallInProgress != null)
            {
                return responseWebSearchCallInProgress(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching && responseWebSearchCallSearching != null)
            {
                return responseWebSearchCallSearching(ResponseWebSearchCallSearching!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ResponseAudioDeltaEvent>? responseAudioDelta = null,

            global::System.Action<global::Portkey.ResponseAudioDoneEvent>? responseAudioDone = null,

            global::System.Action<global::Portkey.ResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,

            global::System.Action<global::Portkey.ResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,

            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,

            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,

            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,

            global::System.Action<global::Portkey.ResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,

            global::System.Action<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,

            global::System.Action<global::Portkey.ResponseCompletedEvent>? responseCompleted = null,

            global::System.Action<global::Portkey.ResponseContentPartAddedEvent>? responseContentPartAdded = null,

            global::System.Action<global::Portkey.ResponseContentPartDoneEvent>? responseContentPartDone = null,

            global::System.Action<global::Portkey.ResponseCreatedEvent>? responseCreated = null,

            global::System.Action<global::Portkey.ResponseErrorEvent>? error = null,

            global::System.Action<global::Portkey.ResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,

            global::System.Action<global::Portkey.ResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,

            global::System.Action<global::Portkey.ResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,

            global::System.Action<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::Portkey.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::Portkey.ResponseInProgressEvent>? responseInProgress = null,

            global::System.Action<global::Portkey.ResponseFailedEvent>? responseFailed = null,

            global::System.Action<global::Portkey.ResponseIncompleteEvent>? responseIncomplete = null,

            global::System.Action<global::Portkey.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,

            global::System.Action<global::Portkey.ResponseOutputItemDoneEvent>? responseOutputItemDone = null,

            global::System.Action<global::Portkey.ResponseRefusalDeltaEvent>? responseRefusalDelta = null,

            global::System.Action<global::Portkey.ResponseRefusalDoneEvent>? responseRefusalDone = null,

            global::System.Action<global::Portkey.ResponseTextAnnotationDeltaEvent>? responseOutputTextAnnotationAdded = null,

            global::System.Action<global::Portkey.ResponseTextDeltaEvent>? responseOutputTextDelta = null,

            global::System.Action<global::Portkey.ResponseTextDoneEvent>? responseOutputTextDone = null,

            global::System.Action<global::Portkey.ResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,

            global::System.Action<global::Portkey.ResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,

            global::System.Action<global::Portkey.ResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted)
            {
                responseCodeInterpreterCallCompleted?.Invoke(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress)
            {
                responseCodeInterpreterCallInProgress?.Invoke(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted)
            {
                responseCompleted?.Invoke(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseFileSearchCallCompleted)
            {
                responseFileSearchCallCompleted?.Invoke(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress)
            {
                responseFileSearchCallInProgress?.Invoke(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching)
            {
                responseFileSearchCallSearching?.Invoke(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress)
            {
                responseInProgress?.Invoke(ResponseInProgress!);
            }
            else if (IsResponseFailed)
            {
                responseFailed?.Invoke(ResponseFailed!);
            }
            else if (IsResponseIncomplete)
            {
                responseIncomplete?.Invoke(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseRefusalDelta)
            {
                responseRefusalDelta?.Invoke(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone)
            {
                responseRefusalDone?.Invoke(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextAnnotationAdded)
            {
                responseOutputTextAnnotationAdded?.Invoke(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseOutputTextDelta)
            {
                responseOutputTextDelta?.Invoke(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone)
            {
                responseOutputTextDone?.Invoke(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted)
            {
                responseWebSearchCallCompleted?.Invoke(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress)
            {
                responseWebSearchCallInProgress?.Invoke(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching)
            {
                responseWebSearchCallSearching?.Invoke(ResponseWebSearchCallSearching!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ResponseAudioDeltaEvent>? responseAudioDelta = null,
            global::System.Action<global::Portkey.ResponseAudioDoneEvent>? responseAudioDone = null,
            global::System.Action<global::Portkey.ResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,
            global::System.Action<global::Portkey.ResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,
            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::Portkey.ResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::Portkey.ResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::Portkey.ResponseCompletedEvent>? responseCompleted = null,
            global::System.Action<global::Portkey.ResponseContentPartAddedEvent>? responseContentPartAdded = null,
            global::System.Action<global::Portkey.ResponseContentPartDoneEvent>? responseContentPartDone = null,
            global::System.Action<global::Portkey.ResponseCreatedEvent>? responseCreated = null,
            global::System.Action<global::Portkey.ResponseErrorEvent>? error = null,
            global::System.Action<global::Portkey.ResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,
            global::System.Action<global::Portkey.ResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,
            global::System.Action<global::Portkey.ResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,
            global::System.Action<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::Portkey.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::Portkey.ResponseInProgressEvent>? responseInProgress = null,
            global::System.Action<global::Portkey.ResponseFailedEvent>? responseFailed = null,
            global::System.Action<global::Portkey.ResponseIncompleteEvent>? responseIncomplete = null,
            global::System.Action<global::Portkey.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,
            global::System.Action<global::Portkey.ResponseOutputItemDoneEvent>? responseOutputItemDone = null,
            global::System.Action<global::Portkey.ResponseRefusalDeltaEvent>? responseRefusalDelta = null,
            global::System.Action<global::Portkey.ResponseRefusalDoneEvent>? responseRefusalDone = null,
            global::System.Action<global::Portkey.ResponseTextAnnotationDeltaEvent>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::Portkey.ResponseTextDeltaEvent>? responseOutputTextDelta = null,
            global::System.Action<global::Portkey.ResponseTextDoneEvent>? responseOutputTextDone = null,
            global::System.Action<global::Portkey.ResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,
            global::System.Action<global::Portkey.ResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,
            global::System.Action<global::Portkey.ResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted)
            {
                responseCodeInterpreterCallCompleted?.Invoke(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress)
            {
                responseCodeInterpreterCallInProgress?.Invoke(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted)
            {
                responseCompleted?.Invoke(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseFileSearchCallCompleted)
            {
                responseFileSearchCallCompleted?.Invoke(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress)
            {
                responseFileSearchCallInProgress?.Invoke(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching)
            {
                responseFileSearchCallSearching?.Invoke(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress)
            {
                responseInProgress?.Invoke(ResponseInProgress!);
            }
            else if (IsResponseFailed)
            {
                responseFailed?.Invoke(ResponseFailed!);
            }
            else if (IsResponseIncomplete)
            {
                responseIncomplete?.Invoke(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseRefusalDelta)
            {
                responseRefusalDelta?.Invoke(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone)
            {
                responseRefusalDone?.Invoke(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextAnnotationAdded)
            {
                responseOutputTextAnnotationAdded?.Invoke(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseOutputTextDelta)
            {
                responseOutputTextDelta?.Invoke(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone)
            {
                responseOutputTextDone?.Invoke(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted)
            {
                responseWebSearchCallCompleted?.Invoke(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress)
            {
                responseWebSearchCallInProgress?.Invoke(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching)
            {
                responseWebSearchCallSearching?.Invoke(ResponseWebSearchCallSearching!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseAudioDelta,
                typeof(global::Portkey.ResponseAudioDeltaEvent),
                ResponseAudioDone,
                typeof(global::Portkey.ResponseAudioDoneEvent),
                ResponseAudioTranscriptDelta,
                typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent),
                ResponseAudioTranscriptDone,
                typeof(global::Portkey.ResponseAudioTranscriptDoneEvent),
                ResponseCodeInterpreterCallCodeDelta,
                typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent),
                ResponseCodeInterpreterCallCodeDone,
                typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent),
                ResponseCodeInterpreterCallCompleted,
                typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent),
                ResponseCodeInterpreterCallInProgress,
                typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent),
                ResponseCodeInterpreterCallInterpreting,
                typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent),
                ResponseCompleted,
                typeof(global::Portkey.ResponseCompletedEvent),
                ResponseContentPartAdded,
                typeof(global::Portkey.ResponseContentPartAddedEvent),
                ResponseContentPartDone,
                typeof(global::Portkey.ResponseContentPartDoneEvent),
                ResponseCreated,
                typeof(global::Portkey.ResponseCreatedEvent),
                Error,
                typeof(global::Portkey.ResponseErrorEvent),
                ResponseFileSearchCallCompleted,
                typeof(global::Portkey.ResponseFileSearchCallCompletedEvent),
                ResponseFileSearchCallInProgress,
                typeof(global::Portkey.ResponseFileSearchCallInProgressEvent),
                ResponseFileSearchCallSearching,
                typeof(global::Portkey.ResponseFileSearchCallSearchingEvent),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent),
                ResponseInProgress,
                typeof(global::Portkey.ResponseInProgressEvent),
                ResponseFailed,
                typeof(global::Portkey.ResponseFailedEvent),
                ResponseIncomplete,
                typeof(global::Portkey.ResponseIncompleteEvent),
                ResponseOutputItemAdded,
                typeof(global::Portkey.ResponseOutputItemAddedEvent),
                ResponseOutputItemDone,
                typeof(global::Portkey.ResponseOutputItemDoneEvent),
                ResponseRefusalDelta,
                typeof(global::Portkey.ResponseRefusalDeltaEvent),
                ResponseRefusalDone,
                typeof(global::Portkey.ResponseRefusalDoneEvent),
                ResponseOutputTextAnnotationAdded,
                typeof(global::Portkey.ResponseTextAnnotationDeltaEvent),
                ResponseOutputTextDelta,
                typeof(global::Portkey.ResponseTextDeltaEvent),
                ResponseOutputTextDone,
                typeof(global::Portkey.ResponseTextDoneEvent),
                ResponseWebSearchCallCompleted,
                typeof(global::Portkey.ResponseWebSearchCallCompletedEvent),
                ResponseWebSearchCallInProgress,
                typeof(global::Portkey.ResponseWebSearchCallInProgressEvent),
                ResponseWebSearchCallSearching,
                typeof(global::Portkey.ResponseWebSearchCallSearchingEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseAudioDeltaEvent?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseAudioDoneEvent?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseAudioTranscriptDeltaEvent?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseAudioTranscriptDoneEvent?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDelta, other.ResponseCodeInterpreterCallCodeDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDone, other.ResponseCodeInterpreterCallCodeDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(ResponseCodeInterpreterCallCompleted, other.ResponseCodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(ResponseCodeInterpreterCallInProgress, other.ResponseCodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(ResponseCodeInterpreterCallInterpreting, other.ResponseCodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCompletedEvent?>.Default.Equals(ResponseCompleted, other.ResponseCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseContentPartAddedEvent?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseContentPartDoneEvent?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFileSearchCallCompletedEvent?>.Default.Equals(ResponseFileSearchCallCompleted, other.ResponseFileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFileSearchCallInProgressEvent?>.Default.Equals(ResponseFileSearchCallInProgress, other.ResponseFileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFileSearchCallSearchingEvent?>.Default.Equals(ResponseFileSearchCallSearching, other.ResponseFileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseInProgressEvent?>.Default.Equals(ResponseInProgress, other.ResponseInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseFailedEvent?>.Default.Equals(ResponseFailed, other.ResponseFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseIncompleteEvent?>.Default.Equals(ResponseIncomplete, other.ResponseIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseOutputItemDoneEvent?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseRefusalDeltaEvent?>.Default.Equals(ResponseRefusalDelta, other.ResponseRefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseRefusalDoneEvent?>.Default.Equals(ResponseRefusalDone, other.ResponseRefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseTextAnnotationDeltaEvent?>.Default.Equals(ResponseOutputTextAnnotationAdded, other.ResponseOutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseTextDeltaEvent?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseTextDoneEvent?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseWebSearchCallCompletedEvent?>.Default.Equals(ResponseWebSearchCallCompleted, other.ResponseWebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseWebSearchCallInProgressEvent?>.Default.Equals(ResponseWebSearchCallInProgress, other.ResponseWebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseWebSearchCallSearchingEvent?>.Default.Equals(ResponseWebSearchCallSearching, other.ResponseWebSearchCallSearching) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseStreamEvent o && Equals(o);
        }
    }
}
