
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Usage information for the request.
    /// </summary>
    public sealed partial class CreateOcrResponseUsageInfo
    {
        /// <summary>
        /// Number of pages processed.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_processed")]
        public int? PagesProcessed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrResponseUsageInfo" /> class.
        /// </summary>
        /// <param name="pagesProcessed">
        /// Number of pages processed.<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOcrResponseUsageInfo(
            int? pagesProcessed)
        {
            this.PagesProcessed = pagesProcessed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrResponseUsageInfo" /> class.
        /// </summary>
        public CreateOcrResponseUsageInfo()
        {
        }

    }
}