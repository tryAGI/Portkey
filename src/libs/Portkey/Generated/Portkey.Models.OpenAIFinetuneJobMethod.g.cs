
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Hyperparameters for the finetune job
    /// </summary>
    public sealed partial class OpenAIFinetuneJobMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.OpenAIFinetuneJobMethodType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Supervised { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Dpo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethod" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="supervised"></param>
        /// <param name="dpo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFinetuneJobMethod(
            global::Portkey.OpenAIFinetuneJobMethodType type,
            global::Portkey.OpenAIFinetuneJobMethodSupervised? supervised,
            global::Portkey.OpenAIFinetuneJobMethodDpo? dpo)
        {
            this.Type = type;
            this.Supervised = supervised;
            this.Dpo = dpo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethod" /> class.
        /// </summary>
        public OpenAIFinetuneJobMethod()
        {
        }
    }
}