#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct Item : global::System.IEquatable<Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.InputMessage? Message1 { get; init; }
#else
        public global::Portkey.InputMessage? Message1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message1))]
#endif
        public bool IsMessage1 => Message1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.InputMessage? value)
        {
            value = Message1;
            return IsMessage1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.InputMessage PickMessage1() => IsMessage1
            ? Message1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message1' but the value was {ToString()}.");

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.OutputMessage? Message2 { get; init; }
#else
        public global::Portkey.OutputMessage? Message2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message2))]
#endif
        public bool IsMessage2 => Message2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.OutputMessage? value)
        {
            value = Message2;
            return IsMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.OutputMessage PickMessage2() => IsMessage2
            ? Message2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message2' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public global::Portkey.FileSearchToolCall PickFileSearchCall() => IsFileSearchCall
            ? FileSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

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
        public global::Portkey.ComputerToolCall PickComputerCall() => IsComputerCall
            ? ComputerCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ComputerToolCallOutput? ComputerCallOutput { get; init; }
#else
        public global::Portkey.ComputerToolCallOutput? ComputerCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutput))]
#endif
        public bool IsComputerCallOutput => ComputerCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ComputerToolCallOutput? value)
        {
            value = ComputerCallOutput;
            return IsComputerCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ComputerToolCallOutput PickComputerCallOutput() => IsComputerCallOutput
            ? ComputerCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCallOutput' but the value was {ToString()}.");

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
        public global::Portkey.WebSearchToolCall PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FunctionToolCall? FunctionCall { get; init; }
#else
        public global::Portkey.FunctionToolCall? FunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FunctionToolCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCall PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FunctionToolCallOutput? FunctionCallOutput { get; init; }
#else
        public global::Portkey.FunctionToolCallOutput? FunctionCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FunctionToolCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.FunctionToolCallOutput PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ReasoningItem? Reasoning { get; init; }
#else
        public global::Portkey.ReasoningItem? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.ReasoningItem PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.InputMessage value) => new Item((global::Portkey.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.InputMessage?(Item @this) => @this.Message1;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.InputMessage? value)
        {
            Message1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromMessage1(global::Portkey.InputMessage? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.OutputMessage value) => new Item((global::Portkey.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.OutputMessage?(Item @this) => @this.Message2;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.OutputMessage? value)
        {
            Message2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromMessage2(global::Portkey.OutputMessage? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.FileSearchToolCall value) => new Item((global::Portkey.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FileSearchToolCall?(Item @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromFileSearchCall(global::Portkey.FileSearchToolCall? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.ComputerToolCall value) => new Item((global::Portkey.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ComputerToolCall?(Item @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromComputerCall(global::Portkey.ComputerToolCall? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.ComputerToolCallOutput value) => new Item((global::Portkey.ComputerToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ComputerToolCallOutput?(Item @this) => @this.ComputerCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.ComputerToolCallOutput? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromComputerCallOutput(global::Portkey.ComputerToolCallOutput? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.WebSearchToolCall value) => new Item((global::Portkey.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.WebSearchToolCall?(Item @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromWebSearchCall(global::Portkey.WebSearchToolCall? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.FunctionToolCall value) => new Item((global::Portkey.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FunctionToolCall?(Item @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.FunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromFunctionCall(global::Portkey.FunctionToolCall? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.FunctionToolCallOutput value) => new Item((global::Portkey.FunctionToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FunctionToolCallOutput?(Item @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.FunctionToolCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromFunctionCallOutput(global::Portkey.FunctionToolCallOutput? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::Portkey.ReasoningItem value) => new Item((global::Portkey.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ReasoningItem?(Item @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::Portkey.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Item FromReasoning(global::Portkey.ReasoningItem? value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public Item(
            global::Portkey.ItemDiscriminatorType? type,
            global::Portkey.InputMessage? message1,
            global::Portkey.OutputMessage? message2,
            global::Portkey.FileSearchToolCall? fileSearchCall,
            global::Portkey.ComputerToolCall? computerCall,
            global::Portkey.ComputerToolCallOutput? computerCallOutput,
            global::Portkey.WebSearchToolCall? webSearchCall,
            global::Portkey.FunctionToolCall? functionCall,
            global::Portkey.FunctionToolCallOutput? functionCallOutput,
            global::Portkey.ReasoningItem? reasoning
            )
        {
            Type = type;

            Message1 = message1;
            Message2 = message2;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerCallOutput = computerCallOutput;
            WebSearchCall = webSearchCall;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reasoning as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            WebSearchCall as object ??
            ComputerCallOutput as object ??
            ComputerCall as object ??
            FileSearchCall as object ??
            Message2 as object ??
            Message1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message1?.ToString() ??
            Message2?.ToString() ??
            FileSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            Reasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.InputMessage, TResult>? message1 = null,
            global::System.Func<global::Portkey.OutputMessage, TResult>? message2 = null,
            global::System.Func<global::Portkey.FileSearchToolCall, TResult>? fileSearchCall = null,
            global::System.Func<global::Portkey.ComputerToolCall, TResult>? computerCall = null,
            global::System.Func<global::Portkey.ComputerToolCallOutput, TResult>? computerCallOutput = null,
            global::System.Func<global::Portkey.WebSearchToolCall, TResult>? webSearchCall = null,
            global::System.Func<global::Portkey.FunctionToolCall, TResult>? functionCall = null,
            global::System.Func<global::Portkey.FunctionToolCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::Portkey.ReasoningItem, TResult>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1 && message1 != null)
            {
                return message1(Message1!);
            }
            else if (IsMessage2 && message2 != null)
            {
                return message2(Message2!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerCallOutput && computerCallOutput != null)
            {
                return computerCallOutput(ComputerCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.InputMessage>? message1 = null,

            global::System.Action<global::Portkey.OutputMessage>? message2 = null,

            global::System.Action<global::Portkey.FileSearchToolCall>? fileSearchCall = null,

            global::System.Action<global::Portkey.ComputerToolCall>? computerCall = null,

            global::System.Action<global::Portkey.ComputerToolCallOutput>? computerCallOutput = null,

            global::System.Action<global::Portkey.WebSearchToolCall>? webSearchCall = null,

            global::System.Action<global::Portkey.FunctionToolCall>? functionCall = null,

            global::System.Action<global::Portkey.FunctionToolCallOutput>? functionCallOutput = null,

            global::System.Action<global::Portkey.ReasoningItem>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1)
            {
                message1?.Invoke(Message1!);
            }
            else if (IsMessage2)
            {
                message2?.Invoke(Message2!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.InputMessage>? message1 = null,
            global::System.Action<global::Portkey.OutputMessage>? message2 = null,
            global::System.Action<global::Portkey.FileSearchToolCall>? fileSearchCall = null,
            global::System.Action<global::Portkey.ComputerToolCall>? computerCall = null,
            global::System.Action<global::Portkey.ComputerToolCallOutput>? computerCallOutput = null,
            global::System.Action<global::Portkey.WebSearchToolCall>? webSearchCall = null,
            global::System.Action<global::Portkey.FunctionToolCall>? functionCall = null,
            global::System.Action<global::Portkey.FunctionToolCallOutput>? functionCallOutput = null,
            global::System.Action<global::Portkey.ReasoningItem>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1)
            {
                message1?.Invoke(Message1!);
            }
            else if (IsMessage2)
            {
                message2?.Invoke(Message2!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message1,
                typeof(global::Portkey.InputMessage),
                Message2,
                typeof(global::Portkey.OutputMessage),
                FileSearchCall,
                typeof(global::Portkey.FileSearchToolCall),
                ComputerCall,
                typeof(global::Portkey.ComputerToolCall),
                ComputerCallOutput,
                typeof(global::Portkey.ComputerToolCallOutput),
                WebSearchCall,
                typeof(global::Portkey.WebSearchToolCall),
                FunctionCall,
                typeof(global::Portkey.FunctionToolCall),
                FunctionCallOutput,
                typeof(global::Portkey.FunctionToolCallOutput),
                Reasoning,
                typeof(global::Portkey.ReasoningItem),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.InputMessage?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.OutputMessage?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ComputerToolCallOutput?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FunctionToolCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Item obj1, Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Item obj1, Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Item o && Equals(o);
        }
    }
}
