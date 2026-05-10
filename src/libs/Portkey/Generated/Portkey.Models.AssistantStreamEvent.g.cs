#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// Represents an event emitted when streaming a Run.<br/>
    /// Each event in a server-sent events stream has an `event` and `data` property:<br/>
    /// ```<br/>
    /// event: thread.created<br/>
    /// data: {"id": "thread_123", "object": "thread", ...}<br/>
    /// ```<br/>
    /// We emit events whenever a new object is created, transitions to a new state, or is being<br/>
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run<br/>
    /// is created, `thread.run.completed` when a run completes, and so on. When an Assistant chooses<br/>
    /// to create a message during a run, we emit a `thread.message.created event`, a<br/>
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a<br/>
    /// `thread.message.completed` event.<br/>
    /// We may add additional events over time, so we recommend handling unknown events gracefully<br/>
    /// in your code. See the [Assistants API quickstart](https://platform.openai.com/docs/assistants/overview) to learn how to<br/>
    /// integrate the Assistants API with streaming.
    /// </summary>
    public readonly partial struct AssistantStreamEvent : global::System.IEquatable<AssistantStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ThreadStreamEvent? Thread { get; init; }
#else
        public global::Portkey.ThreadStreamEvent? Thread { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thread))]
#endif
        public bool IsThread => Thread != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThread(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ThreadStreamEvent? value)
        {
            value = Thread;
            return IsThread;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.RunStreamEvent? Run { get; init; }
#else
        public global::Portkey.RunStreamEvent? Run { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Run))]
#endif
        public bool IsRun => Run != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRun(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.RunStreamEvent? value)
        {
            value = Run;
            return IsRun;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.RunStepStreamEvent? RunStep { get; init; }
#else
        public global::Portkey.RunStepStreamEvent? RunStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStep))]
#endif
        public bool IsRunStep => RunStep != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunStep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.RunStepStreamEvent? value)
        {
            value = RunStep;
            return IsRunStep;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.MessageStreamEvent? Message { get; init; }
#else
        public global::Portkey.MessageStreamEvent? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.MessageStreamEvent? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// Occurs when an [error](https://platform.openai.com/docs/guides/error-codes/api-errors) occurs. This can happen due to an internal server error or a timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ErrorEvent? Error { get; init; }
#else
        public global::Portkey.ErrorEvent? Error { get; }
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
            out global::Portkey.ErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// Occurs when a stream ends.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.DoneEvent? Done { get; init; }
#else
        public global::Portkey.DoneEvent? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.DoneEvent? value)
        {
            value = Done;
            return IsDone;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.ThreadStreamEvent value) => new AssistantStreamEvent((global::Portkey.ThreadStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ThreadStreamEvent?(AssistantStreamEvent @this) => @this.Thread;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.ThreadStreamEvent? value)
        {
            Thread = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromThread(global::Portkey.ThreadStreamEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.RunStreamEvent value) => new AssistantStreamEvent((global::Portkey.RunStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.RunStreamEvent?(AssistantStreamEvent @this) => @this.Run;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.RunStreamEvent? value)
        {
            Run = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromRun(global::Portkey.RunStreamEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.RunStepStreamEvent value) => new AssistantStreamEvent((global::Portkey.RunStepStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.RunStepStreamEvent?(AssistantStreamEvent @this) => @this.RunStep;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.RunStepStreamEvent? value)
        {
            RunStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromRunStep(global::Portkey.RunStepStreamEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.MessageStreamEvent value) => new AssistantStreamEvent((global::Portkey.MessageStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.MessageStreamEvent?(AssistantStreamEvent @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.MessageStreamEvent? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromMessage(global::Portkey.MessageStreamEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.ErrorEvent value) => new AssistantStreamEvent((global::Portkey.ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ErrorEvent?(AssistantStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromError(global::Portkey.ErrorEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::Portkey.DoneEvent value) => new AssistantStreamEvent((global::Portkey.DoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.DoneEvent?(AssistantStreamEvent @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::Portkey.DoneEvent? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AssistantStreamEvent FromDone(global::Portkey.DoneEvent? value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::Portkey.ThreadStreamEvent? thread,
            global::Portkey.RunStreamEvent? run,
            global::Portkey.RunStepStreamEvent? runStep,
            global::Portkey.MessageStreamEvent? message,
            global::Portkey.ErrorEvent? error,
            global::Portkey.DoneEvent? done
            )
        {
            Thread = thread;
            Run = run;
            RunStep = runStep;
            Message = message;
            Error = error;
            Done = done;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Done as object ??
            Error as object ??
            Message as object ??
            RunStep as object ??
            Run as object ??
            Thread as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Thread?.ToString() ??
            Run?.ToString() ??
            RunStep?.ToString() ??
            Message?.ToString() ??
            Error?.ToString() ??
            Done?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ThreadStreamEvent?, TResult>? thread = null,
            global::System.Func<global::Portkey.RunStreamEvent?, TResult>? run = null,
            global::System.Func<global::Portkey.RunStepStreamEvent?, TResult>? runStep = null,
            global::System.Func<global::Portkey.MessageStreamEvent?, TResult>? message = null,
            global::System.Func<global::Portkey.ErrorEvent, TResult>? error = null,
            global::System.Func<global::Portkey.DoneEvent, TResult>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread && thread != null)
            {
                return thread(Thread!);
            }
            else if (IsRun && run != null)
            {
                return run(Run!);
            }
            else if (IsRunStep && runStep != null)
            {
                return runStep(RunStep!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ThreadStreamEvent?>? thread = null,

            global::System.Action<global::Portkey.RunStreamEvent?>? run = null,

            global::System.Action<global::Portkey.RunStepStreamEvent?>? runStep = null,

            global::System.Action<global::Portkey.MessageStreamEvent?>? message = null,

            global::System.Action<global::Portkey.ErrorEvent>? error = null,

            global::System.Action<global::Portkey.DoneEvent>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
            else if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsRunStep)
            {
                runStep?.Invoke(RunStep!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ThreadStreamEvent?>? thread = null,
            global::System.Action<global::Portkey.RunStreamEvent?>? run = null,
            global::System.Action<global::Portkey.RunStepStreamEvent?>? runStep = null,
            global::System.Action<global::Portkey.MessageStreamEvent?>? message = null,
            global::System.Action<global::Portkey.ErrorEvent>? error = null,
            global::System.Action<global::Portkey.DoneEvent>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
            else if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsRunStep)
            {
                runStep?.Invoke(RunStep!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Thread,
                typeof(global::Portkey.ThreadStreamEvent),
                Run,
                typeof(global::Portkey.RunStreamEvent),
                RunStep,
                typeof(global::Portkey.RunStepStreamEvent),
                Message,
                typeof(global::Portkey.MessageStreamEvent),
                Error,
                typeof(global::Portkey.ErrorEvent),
                Done,
                typeof(global::Portkey.DoneEvent),
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
        public bool Equals(AssistantStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ThreadStreamEvent?>.Default.Equals(Thread, other.Thread) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.RunStreamEvent?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.RunStepStreamEvent?>.Default.Equals(RunStep, other.RunStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.MessageStreamEvent?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.DoneEvent?>.Default.Equals(Done, other.Done) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantStreamEvent o && Equals(o);
        }
    }
}
