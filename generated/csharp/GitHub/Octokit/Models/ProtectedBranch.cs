// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Branch protections protect branches
    /// </summary>
    public class ProtectedBranch : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_deletions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_allow_deletions? AllowDeletions { get; set; }
#nullable restore
#else
        public ProtectedBranch_allow_deletions AllowDeletions { get; set; }
#endif
        /// <summary>The allow_force_pushes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_allow_force_pushes? AllowForcePushes { get; set; }
#nullable restore
#else
        public ProtectedBranch_allow_force_pushes AllowForcePushes { get; set; }
#endif
        /// <summary>Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_allow_fork_syncing? AllowForkSyncing { get; set; }
#nullable restore
#else
        public ProtectedBranch_allow_fork_syncing AllowForkSyncing { get; set; }
#endif
        /// <summary>The block_creations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_block_creations? BlockCreations { get; set; }
#nullable restore
#else
        public ProtectedBranch_block_creations BlockCreations { get; set; }
#endif
        /// <summary>The enforce_admins property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_enforce_admins? EnforceAdmins { get; set; }
#nullable restore
#else
        public ProtectedBranch_enforce_admins EnforceAdmins { get; set; }
#endif
        /// <summary>Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_lock_branch? LockBranch { get; set; }
#nullable restore
#else
        public ProtectedBranch_lock_branch LockBranch { get; set; }
#endif
        /// <summary>The required_conversation_resolution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_required_conversation_resolution? RequiredConversationResolution { get; set; }
#nullable restore
#else
        public ProtectedBranch_required_conversation_resolution RequiredConversationResolution { get; set; }
#endif
        /// <summary>The required_linear_history property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_required_linear_history? RequiredLinearHistory { get; set; }
#nullable restore
#else
        public ProtectedBranch_required_linear_history RequiredLinearHistory { get; set; }
#endif
        /// <summary>The required_pull_request_reviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_required_pull_request_reviews? RequiredPullRequestReviews { get; set; }
#nullable restore
#else
        public ProtectedBranch_required_pull_request_reviews RequiredPullRequestReviews { get; set; }
#endif
        /// <summary>The required_signatures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectedBranch_required_signatures? RequiredSignatures { get; set; }
#nullable restore
#else
        public ProtectedBranch_required_signatures RequiredSignatures { get; set; }
#endif
        /// <summary>Status Check Policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StatusCheckPolicy? RequiredStatusChecks { get; set; }
#nullable restore
#else
        public StatusCheckPolicy RequiredStatusChecks { get; set; }
#endif
        /// <summary>Branch Restriction Policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BranchRestrictionPolicy? Restrictions { get; set; }
#nullable restore
#else
        public BranchRestrictionPolicy Restrictions { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new protectedBranch and sets the default values.
        /// </summary>
        public ProtectedBranch() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectedBranch CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectedBranch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allow_deletions", n => { AllowDeletions = n.GetObjectValue<ProtectedBranch_allow_deletions>(ProtectedBranch_allow_deletions.CreateFromDiscriminatorValue); } },
                {"allow_force_pushes", n => { AllowForcePushes = n.GetObjectValue<ProtectedBranch_allow_force_pushes>(ProtectedBranch_allow_force_pushes.CreateFromDiscriminatorValue); } },
                {"allow_fork_syncing", n => { AllowForkSyncing = n.GetObjectValue<ProtectedBranch_allow_fork_syncing>(ProtectedBranch_allow_fork_syncing.CreateFromDiscriminatorValue); } },
                {"block_creations", n => { BlockCreations = n.GetObjectValue<ProtectedBranch_block_creations>(ProtectedBranch_block_creations.CreateFromDiscriminatorValue); } },
                {"enforce_admins", n => { EnforceAdmins = n.GetObjectValue<ProtectedBranch_enforce_admins>(ProtectedBranch_enforce_admins.CreateFromDiscriminatorValue); } },
                {"lock_branch", n => { LockBranch = n.GetObjectValue<ProtectedBranch_lock_branch>(ProtectedBranch_lock_branch.CreateFromDiscriminatorValue); } },
                {"required_conversation_resolution", n => { RequiredConversationResolution = n.GetObjectValue<ProtectedBranch_required_conversation_resolution>(ProtectedBranch_required_conversation_resolution.CreateFromDiscriminatorValue); } },
                {"required_linear_history", n => { RequiredLinearHistory = n.GetObjectValue<ProtectedBranch_required_linear_history>(ProtectedBranch_required_linear_history.CreateFromDiscriminatorValue); } },
                {"required_pull_request_reviews", n => { RequiredPullRequestReviews = n.GetObjectValue<ProtectedBranch_required_pull_request_reviews>(ProtectedBranch_required_pull_request_reviews.CreateFromDiscriminatorValue); } },
                {"required_signatures", n => { RequiredSignatures = n.GetObjectValue<ProtectedBranch_required_signatures>(ProtectedBranch_required_signatures.CreateFromDiscriminatorValue); } },
                {"required_status_checks", n => { RequiredStatusChecks = n.GetObjectValue<StatusCheckPolicy>(StatusCheckPolicy.CreateFromDiscriminatorValue); } },
                {"restrictions", n => { Restrictions = n.GetObjectValue<BranchRestrictionPolicy>(BranchRestrictionPolicy.CreateFromDiscriminatorValue); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ProtectedBranch_allow_deletions>("allow_deletions", AllowDeletions);
            writer.WriteObjectValue<ProtectedBranch_allow_force_pushes>("allow_force_pushes", AllowForcePushes);
            writer.WriteObjectValue<ProtectedBranch_allow_fork_syncing>("allow_fork_syncing", AllowForkSyncing);
            writer.WriteObjectValue<ProtectedBranch_block_creations>("block_creations", BlockCreations);
            writer.WriteObjectValue<ProtectedBranch_enforce_admins>("enforce_admins", EnforceAdmins);
            writer.WriteObjectValue<ProtectedBranch_lock_branch>("lock_branch", LockBranch);
            writer.WriteObjectValue<ProtectedBranch_required_conversation_resolution>("required_conversation_resolution", RequiredConversationResolution);
            writer.WriteObjectValue<ProtectedBranch_required_linear_history>("required_linear_history", RequiredLinearHistory);
            writer.WriteObjectValue<ProtectedBranch_required_pull_request_reviews>("required_pull_request_reviews", RequiredPullRequestReviews);
            writer.WriteObjectValue<ProtectedBranch_required_signatures>("required_signatures", RequiredSignatures);
            writer.WriteObjectValue<StatusCheckPolicy>("required_status_checks", RequiredStatusChecks);
            writer.WriteObjectValue<BranchRestrictionPolicy>("restrictions", Restrictions);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
