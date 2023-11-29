// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
    /// </summary>
    public class NullableIssue : IAdditionalDataHolder, IParsable {
        /// <summary>The active_lock_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveLockReason { get; set; }
#nullable restore
#else
        public string ActiveLockReason { get; set; }
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
        /// <summary>The assignees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? Assignees { get; set; }
#nullable restore
#else
        public List<SimpleUser> Assignees { get; set; }
#endif
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Octokit.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>Contents of the issue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>The closed_at property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? ClosedBy { get; set; }
#nullable restore
#else
        public NullableSimpleUser ClosedBy { get; set; }
#endif
        /// <summary>The comments property</summary>
        public int? Comments { get; set; }
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The draft property</summary>
        public bool? Draft { get; set; }
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Labels { get; set; }
#nullable restore
#else
        public List<string> Labels { get; set; }
#endif
        /// <summary>The labels_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelsUrl { get; set; }
#nullable restore
#else
        public string LabelsUrl { get; set; }
#endif
        /// <summary>The locked property</summary>
        public bool? Locked { get; set; }
        /// <summary>A collection of related issues and pull requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableMilestone? Milestone { get; set; }
#nullable restore
#else
        public NullableMilestone Milestone { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>Number uniquely identifying the issue within its repository</summary>
        public int? Number { get; set; }
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>The pull_request property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIssue_pull_request? PullRequest { get; set; }
#nullable restore
#else
        public NullableIssue_pull_request PullRequest { get; set; }
#endif
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public ReactionRollup Reactions { get; set; }
#endif
        /// <summary>A repository on GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.Repository? Repository { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.Repository Repository { get; set; }
#endif
        /// <summary>The repository_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryUrl { get; set; }
#nullable restore
#else
        public string RepositoryUrl { get; set; }
#endif
        /// <summary>State of the issue; either &apos;open&apos; or &apos;closed&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The reason for the current state</summary>
        public NullableIssue_state_reason? StateReason { get; set; }
        /// <summary>The timeline_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimelineUrl { get; set; }
#nullable restore
#else
        public string TimelineUrl { get; set; }
#endif
        /// <summary>Title of the issue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>URL for the issue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new nullableIssue and sets the default values.
        /// </summary>
        public NullableIssue() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NullableIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NullableIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active_lock_reason", n => { ActiveLockReason = n.GetStringValue(); } },
                {"assignee", n => { Assignee = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"assignees", n => { Assignees = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"body_html", n => { BodyHtml = n.GetStringValue(); } },
                {"body_text", n => { BodyText = n.GetStringValue(); } },
                {"closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                {"closed_by", n => { ClosedBy = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"comments", n => { Comments = n.GetIntValue(); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"draft", n => { Draft = n.GetBoolValue(); } },
                {"events_url", n => { EventsUrl = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"labels_url", n => { LabelsUrl = n.GetStringValue(); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
                {"milestone", n => { Milestone = n.GetObjectValue<NullableMilestone>(NullableMilestone.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"number", n => { Number = n.GetIntValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"pull_request", n => { PullRequest = n.GetObjectValue<NullableIssue_pull_request>(NullableIssue_pull_request.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetObjectValue<ReactionRollup>(ReactionRollup.CreateFromDiscriminatorValue); } },
                {"repository", n => { Repository = n.GetObjectValue<GitHub.Octokit.Models.Repository>(GitHub.Octokit.Models.Repository.CreateFromDiscriminatorValue); } },
                {"repository_url", n => { RepositoryUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"state_reason", n => { StateReason = n.GetEnumValue<NullableIssue_state_reason>(); } },
                {"timeline_url", n => { TimelineUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("active_lock_reason", ActiveLockReason);
            writer.WriteObjectValue<NullableSimpleUser>("assignee", Assignee);
            writer.WriteCollectionOfObjectValues<SimpleUser>("assignees", Assignees);
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteObjectValue<NullableSimpleUser>("closed_by", ClosedBy);
            writer.WriteIntValue("comments", Comments);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteStringValue("labels_url", LabelsUrl);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteObjectValue<NullableMilestone>("milestone", Milestone);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteObjectValue<NullableIssue_pull_request>("pull_request", PullRequest);
            writer.WriteObjectValue<ReactionRollup>("reactions", Reactions);
            writer.WriteObjectValue<GitHub.Octokit.Models.Repository>("repository", Repository);
            writer.WriteStringValue("repository_url", RepositoryUrl);
            writer.WriteStringValue("state", State);
            writer.WriteEnumValue<NullableIssue_state_reason>("state_reason", StateReason);
            writer.WriteStringValue("timeline_url", TimelineUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
