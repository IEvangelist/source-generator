// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Environments.Item.Deployment_protection_rules {
    [Obsolete("This class is obsolete. Use deployment_protection_rulesGetResponse instead.")]
    public class Deployment_protection_rulesResponse : Deployment_protection_rulesGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Deployment_protection_rulesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Deployment_protection_rulesResponse();
        }
    }
}
