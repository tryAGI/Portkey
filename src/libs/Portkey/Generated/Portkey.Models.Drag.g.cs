
#nullable enable

namespace Portkey
{
    /// <summary>
    /// A drag action.
    /// </summary>
    public sealed partial class Drag
    {
        /// <summary>
        /// Specifies the event type. For a drag action, this property is <br/>
        /// always set to `drag`.<br/>
        /// Default Value: drag
        /// </summary>
        /// <default>global::Portkey.DragType.Drag</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DragTypeJsonConverter))]
        public global::Portkey.DragType Type { get; set; } = global::Portkey.DragType.Drag;

        /// <summary>
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array<br/>
        /// of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.Coordinate> Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Drag" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a drag action, this property is <br/>
        /// always set to `drag`.<br/>
        /// Default Value: drag
        /// </param>
        /// <param name="path">
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array<br/>
        /// of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Drag(
            global::System.Collections.Generic.IList<global::Portkey.Coordinate> path,
            global::Portkey.DragType type = global::Portkey.DragType.Drag)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Drag" /> class.
        /// </summary>
        public Drag()
        {
        }
    }
}