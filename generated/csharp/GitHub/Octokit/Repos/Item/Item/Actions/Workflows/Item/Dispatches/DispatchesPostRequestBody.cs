// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Dispatches {
    public class DispatchesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Input keys and values configured in the workflow file. The maximum number of properties is 10. Any default properties configured in the workflow file will be used when `inputs` are omitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DispatchesPostRequestBody_inputs? Inputs { get; set; }
#nullable restore
#else
        public DispatchesPostRequestBody_inputs Inputs { get; set; }
#endif
        /// <summary>The git reference for the workflow. The reference can be a branch or tag name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dispatchesPostRequestBody and sets the default values.
        /// </summary>
        public DispatchesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DispatchesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DispatchesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"inputs", n => { Inputs = n.GetObjectValue<DispatchesPostRequestBody_inputs>(DispatchesPostRequestBody_inputs.CreateFromDiscriminatorValue); } },
                {"ref", n => { Ref = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DispatchesPostRequestBody_inputs>("inputs", Inputs);
            writer.WriteStringValue("ref", Ref);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
