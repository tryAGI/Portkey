
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](https://platform.openai.com/docs/guides/fine-tuning) for more details.
    /// </summary>
    public sealed partial class FineTuningJobHyperparameters
    {
        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// "auto" decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::Portkey.FineTuningJobHyperparametersNEpochs.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?> NEpochs { get; set; } = global::Portkey.FineTuningJobHyperparametersNEpochs.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// "auto" decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJobHyperparameters(
            global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?> nEpochs)
        {
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        public FineTuningJobHyperparameters()
        {
        }
    }
}