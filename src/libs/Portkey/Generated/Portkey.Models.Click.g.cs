
#nullable enable

namespace Portkey
{
    /// <summary>
    /// A click action.
    /// </summary>
    public sealed partial class Click
    {
        /// <summary>
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </summary>
        /// <default>global::Portkey.ClickType.Click</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ClickTypeJsonConverter))]
        public global::Portkey.ClickType Type { get; set; } = global::Portkey.ClickType.Click;

        /// <summary>
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("button")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ClickButtonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.ClickButton Button { get; set; }

        /// <summary>
        /// The x-coordinate where the click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        /// <param name="button">
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the click occurred.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Click(
            global::Portkey.ClickButton button,
            int x,
            int y,
            global::Portkey.ClickType type = global::Portkey.ClickType.Click)
        {
            this.Type = type;
            this.Button = button;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        public Click()
        {
        }
    }
}