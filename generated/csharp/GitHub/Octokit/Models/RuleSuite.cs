// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Response
    /// </summary>
    public class RuleSuite : IAdditionalDataHolder, IParsable {
        /// <summary>The number that identifies the user.</summary>
        public int? ActorId { get; set; }
        /// <summary>The handle for the GitHub user account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActorName { get; set; }
#nullable restore
#else
        public string ActorName { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The last commit sha in the push evaluation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AfterSha { get; set; }
#nullable restore
#else
        public string AfterSha { get; set; }
#endif
        /// <summary>The first commit sha before the push evaluation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BeforeSha { get; set; }
#nullable restore
#else
        public string BeforeSha { get; set; }
#endif
        /// <summary>The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.</summary>
        public RuleSuite_evaluation_result? EvaluationResult { get; set; }
        /// <summary>The unique identifier of the rule insight.</summary>
        public int? Id { get; set; }
        /// <summary>The pushed_at property</summary>
        public DateTimeOffset? PushedAt { get; set; }
        /// <summary>The ref name that the evaluation ran on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>The ID of the repository associated with the rule evaluation.</summary>
        public int? RepositoryId { get; set; }
        /// <summary>The name of the repository without the `.git` extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryName { get; set; }
#nullable restore
#else
        public string RepositoryName { get; set; }
#endif
        /// <summary>The result of the rule evaluations for rules with the `active` enforcement status.</summary>
        public RuleSuite_result? Result { get; set; }
        /// <summary>Details on the evaluated rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RuleSuite_rule_evaluations>? RuleEvaluations { get; set; }
#nullable restore
#else
        public List<RuleSuite_rule_evaluations> RuleEvaluations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ruleSuite and sets the default values.
        /// </summary>
        public RuleSuite() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RuleSuite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RuleSuite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actor_id", n => { ActorId = n.GetIntValue(); } },
                {"actor_name", n => { ActorName = n.GetStringValue(); } },
                {"after_sha", n => { AfterSha = n.GetStringValue(); } },
                {"before_sha", n => { BeforeSha = n.GetStringValue(); } },
                {"evaluation_result", n => { EvaluationResult = n.GetEnumValue<RuleSuite_evaluation_result>(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"pushed_at", n => { PushedAt = n.GetDateTimeOffsetValue(); } },
                {"ref", n => { Ref = n.GetStringValue(); } },
                {"repository_id", n => { RepositoryId = n.GetIntValue(); } },
                {"repository_name", n => { RepositoryName = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<RuleSuite_result>(); } },
                {"rule_evaluations", n => { RuleEvaluations = n.GetCollectionOfObjectValues<RuleSuite_rule_evaluations>(RuleSuite_rule_evaluations.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("actor_id", ActorId);
            writer.WriteStringValue("actor_name", ActorName);
            writer.WriteStringValue("after_sha", AfterSha);
            writer.WriteStringValue("before_sha", BeforeSha);
            writer.WriteEnumValue<RuleSuite_evaluation_result>("evaluation_result", EvaluationResult);
            writer.WriteIntValue("id", Id);
            writer.WriteDateTimeOffsetValue("pushed_at", PushedAt);
            writer.WriteStringValue("ref", Ref);
            writer.WriteIntValue("repository_id", RepositoryId);
            writer.WriteStringValue("repository_name", RepositoryName);
            writer.WriteEnumValue<RuleSuite_result>("result", Result);
            writer.WriteCollectionOfObjectValues<RuleSuite_rule_evaluations>("rule_evaluations", RuleEvaluations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
