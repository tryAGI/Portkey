#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// A tool that searches for relevant content from uploaded files.<br/>
        /// Learn more about the [file search tool](/docs/guides/tools-file-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FileSearchTool? FileSearch { get; init; }
#else
        public global::Portkey.FileSearchTool? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FileSearchTool? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        /// Defines a function in your own code the model can choose to call. Learn more<br/>
        /// about [function calling](/docs/guides/function-calling).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.FunctionTool? Function { get; init; }
#else
        public global::Portkey.FunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.FunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// A tool that controls a virtual computer. Learn more about the <br/>
        /// [computer tool](/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ComputerTool? ComputerUse { get; init; }
#else
        public global::Portkey.ComputerTool? ComputerUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUse))]
#endif
        public bool IsComputerUse => ComputerUse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ComputerTool? value)
        {
            value = ComputerUse;
            return IsComputerUse;
        }

        /// <summary>
        /// This tool searches the web for relevant results to use in a response.<br/>
        /// Learn more about the [web search tool](/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.WebSearchTool? WebSearch { get; init; }
#else
        public global::Portkey.WebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.WebSearchTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Portkey.FileSearchTool value) => new Tool((global::Portkey.FileSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FileSearchTool?(Tool @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Portkey.FileSearchTool? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool FromFileSearch(global::Portkey.FileSearchTool? value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Portkey.FunctionTool value) => new Tool((global::Portkey.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.FunctionTool?(Tool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Portkey.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool FromFunction(global::Portkey.FunctionTool? value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Portkey.ComputerTool value) => new Tool((global::Portkey.ComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ComputerTool?(Tool @this) => @this.ComputerUse;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Portkey.ComputerTool? value)
        {
            ComputerUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool FromComputerUse(global::Portkey.ComputerTool? value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Portkey.WebSearchTool value) => new Tool((global::Portkey.WebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.WebSearchTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Portkey.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool FromWebSearch(global::Portkey.WebSearchTool? value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::Portkey.FileSearchTool? fileSearch,
            global::Portkey.FunctionTool? function,
            global::Portkey.ComputerTool? computerUse,
            global::Portkey.WebSearchTool? webSearch
            )
        {
            FileSearch = fileSearch;
            Function = function;
            ComputerUse = computerUse;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            ComputerUse as object ??
            Function as object ??
            FileSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearch?.ToString() ??
            Function?.ToString() ??
            ComputerUse?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearch && !IsFunction && !IsComputerUse && !IsWebSearch || !IsFileSearch && IsFunction && !IsComputerUse && !IsWebSearch || !IsFileSearch && !IsFunction && IsComputerUse && !IsWebSearch || !IsFileSearch && !IsFunction && !IsComputerUse && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.FileSearchTool, TResult>? fileSearch = null,
            global::System.Func<global::Portkey.FunctionTool, TResult>? function = null,
            global::System.Func<global::Portkey.ComputerTool, TResult>? computerUse = null,
            global::System.Func<global::Portkey.WebSearchTool, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsComputerUse && computerUse != null)
            {
                return computerUse(ComputerUse!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.FileSearchTool>? fileSearch = null,

            global::System.Action<global::Portkey.FunctionTool>? function = null,

            global::System.Action<global::Portkey.ComputerTool>? computerUse = null,

            global::System.Action<global::Portkey.WebSearchTool>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsComputerUse)
            {
                computerUse?.Invoke(ComputerUse!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.FileSearchTool>? fileSearch = null,
            global::System.Action<global::Portkey.FunctionTool>? function = null,
            global::System.Action<global::Portkey.ComputerTool>? computerUse = null,
            global::System.Action<global::Portkey.WebSearchTool>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsComputerUse)
            {
                computerUse?.Invoke(ComputerUse!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearch,
                typeof(global::Portkey.FileSearchTool),
                Function,
                typeof(global::Portkey.FunctionTool),
                ComputerUse,
                typeof(global::Portkey.ComputerTool),
                WebSearch,
                typeof(global::Portkey.WebSearchTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ComputerTool?>.Default.Equals(ComputerUse, other.ComputerUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
