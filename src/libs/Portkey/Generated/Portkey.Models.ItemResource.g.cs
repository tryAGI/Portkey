#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct ItemResource : global::System.IEquatable<ItemResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.InputMessageResource? InputMessage { get; init; }
#else
        public global::Portkey.InputMessageResource? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.InputMessageResource? value)
        {
            value = InputMessage;
            return IsInputMessage;
        }

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.OutputMessage? Message { get; init; }
#else
        public global::Portkey.OutputMessage? Message { get; }
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
            out global::Portkey.OutputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// The results of a file search tool call. See the <br/>
        /// [file search guide](/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FileSearchToolCall? FileSearchCall { get; init; }
#else
        public global::Portkey.FileSearchToolCall? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FileSearchToolCall? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        /// A tool call to a computer use tool. See the <br/>
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ComputerToolCall? ComputerCall { get; init; }
#else
        public global::Portkey.ComputerToolCall? ComputerCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ComputerToolCall? value)
        {
            value = ComputerCall;
            return IsComputerCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ComputerToolCallOutputResource? ComputerToolCallOutput { get; init; }
#else
        public global::Portkey.ComputerToolCallOutputResource? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ComputerToolCallOutputResource? value)
        {
            value = ComputerToolCallOutput;
            return IsComputerToolCallOutput;
        }

        /// <summary>
        /// The results of a web search tool call. See the <br/>
        /// [web search guide](/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.WebSearchToolCall? WebSearchCall { get; init; }
#else
        public global::Portkey.WebSearchToolCall? WebSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.WebSearchToolCall? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FunctionToolCallResource? FunctionToolCall { get; init; }
#else
        public global::Portkey.FunctionToolCallResource? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FunctionToolCallResource? value)
        {
            value = FunctionToolCall;
            return IsFunctionToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FunctionToolCallOutputResource? FunctionToolCallOutput { get; init; }
#else
        public global::Portkey.FunctionToolCallOutputResource? FunctionToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutput))]
#endif
        public bool IsFunctionToolCallOutput => FunctionToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FunctionToolCallOutputResource? value)
        {
            value = FunctionToolCallOutput;
            return IsFunctionToolCallOutput;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.InputMessageResource value) => new ItemResource((global::Portkey.InputMessageResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.InputMessageResource?(ItemResource @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.InputMessageResource? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.OutputMessage value) => new ItemResource((global::Portkey.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.OutputMessage?(ItemResource @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.OutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.FileSearchToolCall value) => new ItemResource((global::Portkey.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FileSearchToolCall?(ItemResource @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.ComputerToolCall value) => new ItemResource((global::Portkey.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ComputerToolCall?(ItemResource @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.ComputerToolCallOutputResource value) => new ItemResource((global::Portkey.ComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ComputerToolCallOutputResource?(ItemResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.ComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.WebSearchToolCall value) => new ItemResource((global::Portkey.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.WebSearchToolCall?(ItemResource @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.FunctionToolCallResource value) => new ItemResource((global::Portkey.FunctionToolCallResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FunctionToolCallResource?(ItemResource @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.FunctionToolCallResource? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::Portkey.FunctionToolCallOutputResource value) => new ItemResource((global::Portkey.FunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FunctionToolCallOutputResource?(ItemResource @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::Portkey.FunctionToolCallOutputResource? value)
        {
            FunctionToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(
            global::Portkey.InputMessageResource? inputMessage,
            global::Portkey.OutputMessage? message,
            global::Portkey.FileSearchToolCall? fileSearchCall,
            global::Portkey.ComputerToolCall? computerCall,
            global::Portkey.ComputerToolCallOutputResource? computerToolCallOutput,
            global::Portkey.WebSearchToolCall? webSearchCall,
            global::Portkey.FunctionToolCallResource? functionToolCall,
            global::Portkey.FunctionToolCallOutputResource? functionToolCallOutput
            )
        {
            InputMessage = inputMessage;
            Message = message;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerToolCallOutput = computerToolCallOutput;
            WebSearchCall = webSearchCall;
            FunctionToolCall = functionToolCall;
            FunctionToolCallOutput = functionToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionToolCallOutput as object ??
            FunctionToolCall as object ??
            WebSearchCall as object ??
            ComputerToolCallOutput as object ??
            ComputerCall as object ??
            FileSearchCall as object ??
            Message as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            Message?.ToString() ??
            FileSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerToolCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionToolCallOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && IsFunctionToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.InputMessageResource?, TResult>? inputMessage = null,
            global::System.Func<global::Portkey.OutputMessage, TResult>? message = null,
            global::System.Func<global::Portkey.FileSearchToolCall, TResult>? fileSearchCall = null,
            global::System.Func<global::Portkey.ComputerToolCall, TResult>? computerCall = null,
            global::System.Func<global::Portkey.ComputerToolCallOutputResource?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::Portkey.WebSearchToolCall, TResult>? webSearchCall = null,
            global::System.Func<global::Portkey.FunctionToolCallResource?, TResult>? functionToolCall = null,
            global::System.Func<global::Portkey.FunctionToolCallOutputResource?, TResult>? functionToolCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput && functionToolCallOutput != null)
            {
                return functionToolCallOutput(FunctionToolCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.InputMessageResource?>? inputMessage = null,

            global::System.Action<global::Portkey.OutputMessage>? message = null,

            global::System.Action<global::Portkey.FileSearchToolCall>? fileSearchCall = null,

            global::System.Action<global::Portkey.ComputerToolCall>? computerCall = null,

            global::System.Action<global::Portkey.ComputerToolCallOutputResource?>? computerToolCallOutput = null,

            global::System.Action<global::Portkey.WebSearchToolCall>? webSearchCall = null,

            global::System.Action<global::Portkey.FunctionToolCallResource?>? functionToolCall = null,

            global::System.Action<global::Portkey.FunctionToolCallOutputResource?>? functionToolCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput)
            {
                functionToolCallOutput?.Invoke(FunctionToolCallOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.InputMessageResource?>? inputMessage = null,
            global::System.Action<global::Portkey.OutputMessage>? message = null,
            global::System.Action<global::Portkey.FileSearchToolCall>? fileSearchCall = null,
            global::System.Action<global::Portkey.ComputerToolCall>? computerCall = null,
            global::System.Action<global::Portkey.ComputerToolCallOutputResource?>? computerToolCallOutput = null,
            global::System.Action<global::Portkey.WebSearchToolCall>? webSearchCall = null,
            global::System.Action<global::Portkey.FunctionToolCallResource?>? functionToolCall = null,
            global::System.Action<global::Portkey.FunctionToolCallOutputResource?>? functionToolCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput)
            {
                functionToolCallOutput?.Invoke(FunctionToolCallOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::Portkey.InputMessageResource),
                Message,
                typeof(global::Portkey.OutputMessage),
                FileSearchCall,
                typeof(global::Portkey.FileSearchToolCall),
                ComputerCall,
                typeof(global::Portkey.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::Portkey.ComputerToolCallOutputResource),
                WebSearchCall,
                typeof(global::Portkey.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::Portkey.FunctionToolCallResource),
                FunctionToolCallOutput,
                typeof(global::Portkey.FunctionToolCallOutputResource),
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
        public bool Equals(ItemResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.InputMessageResource?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FunctionToolCallResource?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemResource obj1, ItemResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemResource obj1, ItemResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemResource o && Equals(o);
        }
    }
}
