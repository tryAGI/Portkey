#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessage : global::System.IEquatable<ChatCompletionRequestMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestSystemMessage? SystemMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestSystemMessage? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystemMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestSystemMessage? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        /// New role by OpenAI for select models. Must be explicitly used for models that support it. When used with incompatible models or providers, Portkey automatically converts it to a system role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestDeveloperMessage? DeveloperMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestDeveloperMessage? DeveloperMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeveloperMessage))]
#endif
        public bool IsDeveloperMessage => DeveloperMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeveloperMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestDeveloperMessage? value)
        {
            value = DeveloperMessage;
            return IsDeveloperMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestUserMessage? UserMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestUserMessage? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestUserMessage? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestAssistantMessage? AssistantMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestAssistantMessage? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssistantMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestAssistantMessage? value)
        {
            value = AssistantMessage;
            return IsAssistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestToolMessage? ToolMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestToolMessage? ToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMessage))]
#endif
        public bool IsToolMessage => ToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestToolMessage? value)
        {
            value = ToolMessage;
            return IsToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestFunctionMessage? FunctionMessage { get; init; }
#else
        public global::Portkey.ChatCompletionRequestFunctionMessage? FunctionMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionMessage))]
#endif
        public bool IsFunctionMessage => FunctionMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestFunctionMessage? value)
        {
            value = FunctionMessage;
            return IsFunctionMessage;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestSystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromSystemMessage(global::Portkey.ChatCompletionRequestSystemMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestDeveloperMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestDeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestDeveloperMessage?(ChatCompletionRequestMessage @this) => @this.DeveloperMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestDeveloperMessage? value)
        {
            DeveloperMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromDeveloperMessage(global::Portkey.ChatCompletionRequestDeveloperMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestUserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromUserMessage(global::Portkey.ChatCompletionRequestUserMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestAssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromAssistantMessage(global::Portkey.ChatCompletionRequestAssistantMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.ToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestToolMessage? value)
        {
            ToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromToolMessage(global::Portkey.ChatCompletionRequestToolMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage((global::Portkey.ChatCompletionRequestFunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.FunctionMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Portkey.ChatCompletionRequestFunctionMessage? value)
        {
            FunctionMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestMessage FromFunctionMessage(global::Portkey.ChatCompletionRequestFunctionMessage? value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::Portkey.ChatCompletionRequestSystemMessage? systemMessage,
            global::Portkey.ChatCompletionRequestDeveloperMessage? developerMessage,
            global::Portkey.ChatCompletionRequestUserMessage? userMessage,
            global::Portkey.ChatCompletionRequestAssistantMessage? assistantMessage,
            global::Portkey.ChatCompletionRequestToolMessage? toolMessage,
            global::Portkey.ChatCompletionRequestFunctionMessage? functionMessage
            )
        {
            SystemMessage = systemMessage;
            DeveloperMessage = developerMessage;
            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            ToolMessage = toolMessage;
            FunctionMessage = functionMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionMessage as object ??
            ToolMessage as object ??
            AssistantMessage as object ??
            UserMessage as object ??
            DeveloperMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SystemMessage?.ToString() ??
            DeveloperMessage?.ToString() ??
            UserMessage?.ToString() ??
            AssistantMessage?.ToString() ??
            ToolMessage?.ToString() ??
            FunctionMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && IsFunctionMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ChatCompletionRequestSystemMessage, TResult>? systemMessage = null,
            global::System.Func<global::Portkey.ChatCompletionRequestDeveloperMessage, TResult>? developerMessage = null,
            global::System.Func<global::Portkey.ChatCompletionRequestUserMessage, TResult>? userMessage = null,
            global::System.Func<global::Portkey.ChatCompletionRequestAssistantMessage, TResult>? assistantMessage = null,
            global::System.Func<global::Portkey.ChatCompletionRequestToolMessage, TResult>? toolMessage = null,
            global::System.Func<global::Portkey.ChatCompletionRequestFunctionMessage, TResult>? functionMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }
            else if (IsDeveloperMessage && developerMessage != null)
            {
                return developerMessage(DeveloperMessage!);
            }
            else if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }
            else if (IsToolMessage && toolMessage != null)
            {
                return toolMessage(ToolMessage!);
            }
            else if (IsFunctionMessage && functionMessage != null)
            {
                return functionMessage(FunctionMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ChatCompletionRequestSystemMessage>? systemMessage = null,

            global::System.Action<global::Portkey.ChatCompletionRequestDeveloperMessage>? developerMessage = null,

            global::System.Action<global::Portkey.ChatCompletionRequestUserMessage>? userMessage = null,

            global::System.Action<global::Portkey.ChatCompletionRequestAssistantMessage>? assistantMessage = null,

            global::System.Action<global::Portkey.ChatCompletionRequestToolMessage>? toolMessage = null,

            global::System.Action<global::Portkey.ChatCompletionRequestFunctionMessage>? functionMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsDeveloperMessage)
            {
                developerMessage?.Invoke(DeveloperMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
            else if (IsToolMessage)
            {
                toolMessage?.Invoke(ToolMessage!);
            }
            else if (IsFunctionMessage)
            {
                functionMessage?.Invoke(FunctionMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ChatCompletionRequestSystemMessage>? systemMessage = null,
            global::System.Action<global::Portkey.ChatCompletionRequestDeveloperMessage>? developerMessage = null,
            global::System.Action<global::Portkey.ChatCompletionRequestUserMessage>? userMessage = null,
            global::System.Action<global::Portkey.ChatCompletionRequestAssistantMessage>? assistantMessage = null,
            global::System.Action<global::Portkey.ChatCompletionRequestToolMessage>? toolMessage = null,
            global::System.Action<global::Portkey.ChatCompletionRequestFunctionMessage>? functionMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsDeveloperMessage)
            {
                developerMessage?.Invoke(DeveloperMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
            else if (IsToolMessage)
            {
                toolMessage?.Invoke(ToolMessage!);
            }
            else if (IsFunctionMessage)
            {
                functionMessage?.Invoke(FunctionMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemMessage,
                typeof(global::Portkey.ChatCompletionRequestSystemMessage),
                DeveloperMessage,
                typeof(global::Portkey.ChatCompletionRequestDeveloperMessage),
                UserMessage,
                typeof(global::Portkey.ChatCompletionRequestUserMessage),
                AssistantMessage,
                typeof(global::Portkey.ChatCompletionRequestAssistantMessage),
                ToolMessage,
                typeof(global::Portkey.ChatCompletionRequestToolMessage),
                FunctionMessage,
                typeof(global::Portkey.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(ChatCompletionRequestMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestSystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestDeveloperMessage?>.Default.Equals(DeveloperMessage, other.DeveloperMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestUserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestAssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestToolMessage?>.Default.Equals(ToolMessage, other.ToolMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestFunctionMessage?>.Default.Equals(FunctionMessage, other.FunctionMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessage o && Equals(o);
        }
    }
}
