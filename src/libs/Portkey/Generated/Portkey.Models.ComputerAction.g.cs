#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputerAction : global::System.IEquatable<ComputerAction>
    {
        /// <summary>
        /// A click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Click? Click { get; init; }
#else
        public global::Portkey.Click? Click { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Click))]
#endif
        public bool IsClick => Click != null;

        /// <summary>
        /// A double click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.DoubleClick? DoubleClick { get; init; }
#else
        public global::Portkey.DoubleClick? DoubleClick { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoubleClick))]
#endif
        public bool IsDoubleClick => DoubleClick != null;

        /// <summary>
        /// A drag action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Drag? Drag { get; init; }
#else
        public global::Portkey.Drag? Drag { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Drag))]
#endif
        public bool IsDrag => Drag != null;

        /// <summary>
        /// A collection of keypresses the model would like to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.KeyPress? KeyPress { get; init; }
#else
        public global::Portkey.KeyPress? KeyPress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyPress))]
#endif
        public bool IsKeyPress => KeyPress != null;

        /// <summary>
        /// A mouse move action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Move? Move { get; init; }
#else
        public global::Portkey.Move? Move { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Move))]
#endif
        public bool IsMove => Move != null;

        /// <summary>
        /// A screenshot action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Screenshot? Screenshot { get; init; }
#else
        public global::Portkey.Screenshot? Screenshot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Screenshot))]
#endif
        public bool IsScreenshot => Screenshot != null;

        /// <summary>
        /// A scroll action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Scroll? Scroll { get; init; }
#else
        public global::Portkey.Scroll? Scroll { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scroll))]
#endif
        public bool IsScroll => Scroll != null;

        /// <summary>
        /// An action to type in text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Type? Type { get; init; }
#else
        public global::Portkey.Type? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// A wait action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Wait? Wait { get; init; }
#else
        public global::Portkey.Wait? Wait { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wait))]
#endif
        public bool IsWait => Wait != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Click value) => new ComputerAction((global::Portkey.Click?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Click?(ComputerAction @this) => @this.Click;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Click? value)
        {
            Click = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.DoubleClick value) => new ComputerAction((global::Portkey.DoubleClick?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.DoubleClick?(ComputerAction @this) => @this.DoubleClick;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.DoubleClick? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Drag value) => new ComputerAction((global::Portkey.Drag?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Drag?(ComputerAction @this) => @this.Drag;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Drag? value)
        {
            Drag = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.KeyPress value) => new ComputerAction((global::Portkey.KeyPress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.KeyPress?(ComputerAction @this) => @this.KeyPress;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.KeyPress? value)
        {
            KeyPress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Move value) => new ComputerAction((global::Portkey.Move?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Move?(ComputerAction @this) => @this.Move;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Move? value)
        {
            Move = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Screenshot value) => new ComputerAction((global::Portkey.Screenshot?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Screenshot?(ComputerAction @this) => @this.Screenshot;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Screenshot? value)
        {
            Screenshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Scroll value) => new ComputerAction((global::Portkey.Scroll?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Scroll?(ComputerAction @this) => @this.Scroll;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Scroll? value)
        {
            Scroll = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Type value) => new ComputerAction((global::Portkey.Type?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Type?(ComputerAction @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Type? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::Portkey.Wait value) => new ComputerAction((global::Portkey.Wait?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Wait?(ComputerAction @this) => @this.Wait;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::Portkey.Wait? value)
        {
            Wait = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(
            global::Portkey.Click? click,
            global::Portkey.DoubleClick? doubleClick,
            global::Portkey.Drag? drag,
            global::Portkey.KeyPress? keyPress,
            global::Portkey.Move? move,
            global::Portkey.Screenshot? screenshot,
            global::Portkey.Scroll? scroll,
            global::Portkey.Type? type,
            global::Portkey.Wait? wait
            )
        {
            Click = click;
            DoubleClick = doubleClick;
            Drag = drag;
            KeyPress = keyPress;
            Move = move;
            Screenshot = screenshot;
            Scroll = scroll;
            Type = type;
            Wait = wait;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Wait as object ??
            Type as object ??
            Scroll as object ??
            Screenshot as object ??
            Move as object ??
            KeyPress as object ??
            Drag as object ??
            DoubleClick as object ??
            Click as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Click?.ToString() ??
            DoubleClick?.ToString() ??
            Drag?.ToString() ??
            KeyPress?.ToString() ??
            Move?.ToString() ??
            Screenshot?.ToString() ??
            Scroll?.ToString() ??
            Type?.ToString() ??
            Wait?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && IsWait;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.Click?, TResult>? click = null,
            global::System.Func<global::Portkey.DoubleClick?, TResult>? doubleClick = null,
            global::System.Func<global::Portkey.Drag?, TResult>? drag = null,
            global::System.Func<global::Portkey.KeyPress?, TResult>? keyPress = null,
            global::System.Func<global::Portkey.Move?, TResult>? move = null,
            global::System.Func<global::Portkey.Screenshot?, TResult>? screenshot = null,
            global::System.Func<global::Portkey.Scroll?, TResult>? scroll = null,
            global::System.Func<global::Portkey.Type?, TResult>? type = null,
            global::System.Func<global::Portkey.Wait?, TResult>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick && click != null)
            {
                return click(Click!);
            }
            else if (IsDoubleClick && doubleClick != null)
            {
                return doubleClick(DoubleClick!);
            }
            else if (IsDrag && drag != null)
            {
                return drag(Drag!);
            }
            else if (IsKeyPress && keyPress != null)
            {
                return keyPress(KeyPress!);
            }
            else if (IsMove && move != null)
            {
                return move(Move!);
            }
            else if (IsScreenshot && screenshot != null)
            {
                return screenshot(Screenshot!);
            }
            else if (IsScroll && scroll != null)
            {
                return scroll(Scroll!);
            }
            else if (IsType && type != null)
            {
                return type(Type!);
            }
            else if (IsWait && wait != null)
            {
                return wait(Wait!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.Click?>? click = null,
            global::System.Action<global::Portkey.DoubleClick?>? doubleClick = null,
            global::System.Action<global::Portkey.Drag?>? drag = null,
            global::System.Action<global::Portkey.KeyPress?>? keyPress = null,
            global::System.Action<global::Portkey.Move?>? move = null,
            global::System.Action<global::Portkey.Screenshot?>? screenshot = null,
            global::System.Action<global::Portkey.Scroll?>? scroll = null,
            global::System.Action<global::Portkey.Type?>? type = null,
            global::System.Action<global::Portkey.Wait?>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick)
            {
                click?.Invoke(Click!);
            }
            else if (IsDoubleClick)
            {
                doubleClick?.Invoke(DoubleClick!);
            }
            else if (IsDrag)
            {
                drag?.Invoke(Drag!);
            }
            else if (IsKeyPress)
            {
                keyPress?.Invoke(KeyPress!);
            }
            else if (IsMove)
            {
                move?.Invoke(Move!);
            }
            else if (IsScreenshot)
            {
                screenshot?.Invoke(Screenshot!);
            }
            else if (IsScroll)
            {
                scroll?.Invoke(Scroll!);
            }
            else if (IsType)
            {
                type?.Invoke(Type!);
            }
            else if (IsWait)
            {
                wait?.Invoke(Wait!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Click,
                typeof(global::Portkey.Click),
                DoubleClick,
                typeof(global::Portkey.DoubleClick),
                Drag,
                typeof(global::Portkey.Drag),
                KeyPress,
                typeof(global::Portkey.KeyPress),
                Move,
                typeof(global::Portkey.Move),
                Screenshot,
                typeof(global::Portkey.Screenshot),
                Scroll,
                typeof(global::Portkey.Scroll),
                Type,
                typeof(global::Portkey.Type),
                Wait,
                typeof(global::Portkey.Wait),
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
        public bool Equals(ComputerAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Click?>.Default.Equals(Click, other.Click) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.DoubleClick?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Drag?>.Default.Equals(Drag, other.Drag) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.KeyPress?>.Default.Equals(KeyPress, other.KeyPress) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Move?>.Default.Equals(Move, other.Move) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Screenshot?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Scroll?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Type?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Wait?>.Default.Equals(Wait, other.Wait) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputerAction obj1, ComputerAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputerAction obj1, ComputerAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerAction o && Equals(o);
        }
    }
}
