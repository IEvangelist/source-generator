// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Issue Event
    /// </summary>
    public class IssueEvent : IAdditionalDataHolder, IParsable {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Actor { get; set; }
#nullable restore
#else
        public NullableSimpleUser Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Assignee { get; set; }
#nullable restore
#else
        public NullableSimpleUser Assignee { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Assigner { get; set; }
#nullable restore
#else
        public NullableSimpleUser Assigner { get; set; }
#endif
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Octokit.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The commit_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitUrl { get; set; }
#nullable restore
#else
        public string CommitUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The dismissed_review property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueEventDismissedReview? DismissedReview { get; set; }
#nullable restore
#else
        public IssueEventDismissedReview DismissedReview { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIssue? Issue { get; set; }
#nullable restore
#else
        public NullableIssue Issue { get; set; }
#endif
        /// <summary>Issue Event Label</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueEventLabel? Label { get; set; }
#nullable restore
#else
        public IssueEventLabel Label { get; set; }
#endif
        /// <summary>The lock_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockReason { get; set; }
#nullable restore
#else
        public string LockReason { get; set; }
#endif
        /// <summary>Issue Event Milestone</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueEventMilestone? Milestone { get; set; }
#nullable restore
#else
        public IssueEventMilestone Milestone { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>Issue Event Project Card</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueEventProjectCard? ProjectCard { get; set; }
#nullable restore
#else
        public IssueEventProjectCard ProjectCard { get; set; }
#endif
        /// <summary>Issue Event Rename</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueEventRename? Rename { get; set; }
#nullable restore
#else
        public IssueEventRename Rename { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? RequestedReviewer { get; set; }
#nullable restore
#else
        public NullableSimpleUser RequestedReviewer { get; set; }
#endif
        /// <summary>Groups of organization members that gives permissions on specified repositories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Team? RequestedTeam { get; set; }
#nullable restore
#else
        public Team RequestedTeam { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? ReviewRequester { get; set; }
#nullable restore
#else
        public NullableSimpleUser ReviewRequester { get; set; }
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
        /// Instantiates a new issueEvent and sets the default values.
        /// </summary>
        public IssueEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actor", n => { Actor = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"assignee", n => { Assignee = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"assigner", n => { Assigner = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"commit_id", n => { CommitId = n.GetStringValue(); } },
                {"commit_url", n => { CommitUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"dismissed_review", n => { DismissedReview = n.GetObjectValue<IssueEventDismissedReview>(IssueEventDismissedReview.CreateFromDiscriminatorValue); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"issue", n => { Issue = n.GetObjectValue<NullableIssue>(NullableIssue.CreateFromDiscriminatorValue); } },
                {"label", n => { Label = n.GetObjectValue<IssueEventLabel>(IssueEventLabel.CreateFromDiscriminatorValue); } },
                {"lock_reason", n => { LockReason = n.GetStringValue(); } },
                {"milestone", n => { Milestone = n.GetObjectValue<IssueEventMilestone>(IssueEventMilestone.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"project_card", n => { ProjectCard = n.GetObjectValue<IssueEventProjectCard>(IssueEventProjectCard.CreateFromDiscriminatorValue); } },
                {"rename", n => { Rename = n.GetObjectValue<IssueEventRename>(IssueEventRename.CreateFromDiscriminatorValue); } },
                {"requested_reviewer", n => { RequestedReviewer = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"requested_team", n => { RequestedTeam = n.GetObjectValue<Team>(Team.CreateFromDiscriminatorValue); } },
                {"review_requester", n => { ReviewRequester = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NullableSimpleUser>("actor", Actor);
            writer.WriteObjectValue<NullableSimpleUser>("assignee", Assignee);
            writer.WriteObjectValue<NullableSimpleUser>("assigner", Assigner);
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteStringValue("commit_url", CommitUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<IssueEventDismissedReview>("dismissed_review", DismissedReview);
            writer.WriteStringValue("event", Event);
            writer.WriteLongValue("id", Id);
            writer.WriteObjectValue<NullableIssue>("issue", Issue);
            writer.WriteObjectValue<IssueEventLabel>("label", Label);
            writer.WriteStringValue("lock_reason", LockReason);
            writer.WriteObjectValue<IssueEventMilestone>("milestone", Milestone);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteObjectValue<IssueEventProjectCard>("project_card", ProjectCard);
            writer.WriteObjectValue<IssueEventRename>("rename", Rename);
            writer.WriteObjectValue<NullableSimpleUser>("requested_reviewer", RequestedReviewer);
            writer.WriteObjectValue<Team>("requested_team", RequestedTeam);
            writer.WriteObjectValue<NullableSimpleUser>("review_requester", ReviewRequester);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
