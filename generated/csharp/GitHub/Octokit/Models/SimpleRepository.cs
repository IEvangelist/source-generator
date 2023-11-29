// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// A GitHub repository.
    /// </summary>
    public class SimpleRepository : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A template for the API URL to download the repository as an archive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchiveUrl { get; set; }
#nullable restore
#else
        public string ArchiveUrl { get; set; }
#endif
        /// <summary>A template for the API URL to list the available assignees for issues in the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneesUrl { get; set; }
#nullable restore
#else
        public string AssigneesUrl { get; set; }
#endif
        /// <summary>A template for the API URL to create or retrieve a raw Git blob in the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BlobsUrl { get; set; }
#nullable restore
#else
        public string BlobsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about branches in the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchesUrl { get; set; }
#nullable restore
#else
        public string BranchesUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about collaborators of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CollaboratorsUrl { get; set; }
#nullable restore
#else
        public string CollaboratorsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about comments on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about commits on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitsUrl { get; set; }
#nullable restore
#else
        public string CommitsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to compare two commits or refs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompareUrl { get; set; }
#nullable restore
#else
        public string CompareUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get the contents of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentsUrl { get; set; }
#nullable restore
#else
        public string ContentsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to list the contributors to the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContributorsUrl { get; set; }
#nullable restore
#else
        public string ContributorsUrl { get; set; }
#endif
        /// <summary>The API URL to list the deployments of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeploymentsUrl { get; set; }
#nullable restore
#else
        public string DeploymentsUrl { get; set; }
#endif
        /// <summary>The repository description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The API URL to list the downloads on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadsUrl { get; set; }
#nullable restore
#else
        public string DownloadsUrl { get; set; }
#endif
        /// <summary>The API URL to list the events of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>Whether the repository is a fork.</summary>
        public bool? Fork { get; set; }
        /// <summary>The API URL to list the forks of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForksUrl { get; set; }
#nullable restore
#else
        public string ForksUrl { get; set; }
#endif
        /// <summary>The full, globally unique, name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullName { get; set; }
#nullable restore
#else
        public string FullName { get; set; }
#endif
        /// <summary>A template for the API URL to get information about Git commits of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitCommitsUrl { get; set; }
#nullable restore
#else
        public string GitCommitsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about Git refs of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitRefsUrl { get; set; }
#nullable restore
#else
        public string GitRefsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about Git tags of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitTagsUrl { get; set; }
#nullable restore
#else
        public string GitTagsUrl { get; set; }
#endif
        /// <summary>The API URL to list the hooks on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HooksUrl { get; set; }
#nullable restore
#else
        public string HooksUrl { get; set; }
#endif
        /// <summary>The URL to view the repository on GitHub.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>A unique identifier of the repository.</summary>
        public int? Id { get; set; }
        /// <summary>A template for the API URL to get information about issue comments on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueCommentUrl { get; set; }
#nullable restore
#else
        public string IssueCommentUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about issue events on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueEventsUrl { get; set; }
#nullable restore
#else
        public string IssueEventsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about issues on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuesUrl { get; set; }
#nullable restore
#else
        public string IssuesUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about deploy keys on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeysUrl { get; set; }
#nullable restore
#else
        public string KeysUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about labels of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelsUrl { get; set; }
#nullable restore
#else
        public string LabelsUrl { get; set; }
#endif
        /// <summary>The API URL to get information about the languages of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguagesUrl { get; set; }
#nullable restore
#else
        public string LanguagesUrl { get; set; }
#endif
        /// <summary>The API URL to merge branches in the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MergesUrl { get; set; }
#nullable restore
#else
        public string MergesUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about milestones of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MilestonesUrl { get; set; }
#nullable restore
#else
        public string MilestonesUrl { get; set; }
#endif
        /// <summary>The name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The GraphQL identifier of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>A template for the API URL to get information about notifications on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationsUrl { get; set; }
#nullable restore
#else
        public string NotificationsUrl { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Owner { get; set; }
#nullable restore
#else
        public SimpleUser Owner { get; set; }
#endif
        /// <summary>Whether the repository is private.</summary>
        public bool? Private { get; set; }
        /// <summary>A template for the API URL to get information about pull requests on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullsUrl { get; set; }
#nullable restore
#else
        public string PullsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about releases on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReleasesUrl { get; set; }
#nullable restore
#else
        public string ReleasesUrl { get; set; }
#endif
        /// <summary>The API URL to list the stargazers on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StargazersUrl { get; set; }
#nullable restore
#else
        public string StargazersUrl { get; set; }
#endif
        /// <summary>A template for the API URL to get information about statuses of a commit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusesUrl { get; set; }
#nullable restore
#else
        public string StatusesUrl { get; set; }
#endif
        /// <summary>The API URL to list the subscribers on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscribersUrl { get; set; }
#nullable restore
#else
        public string SubscribersUrl { get; set; }
#endif
        /// <summary>The API URL to subscribe to notifications for this repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionUrl { get; set; }
#nullable restore
#else
        public string SubscriptionUrl { get; set; }
#endif
        /// <summary>The API URL to get information about tags on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TagsUrl { get; set; }
#nullable restore
#else
        public string TagsUrl { get; set; }
#endif
        /// <summary>The API URL to list the teams on the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsUrl { get; set; }
#nullable restore
#else
        public string TeamsUrl { get; set; }
#endif
        /// <summary>A template for the API URL to create or retrieve a raw Git tree of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TreesUrl { get; set; }
#nullable restore
#else
        public string TreesUrl { get; set; }
#endif
        /// <summary>The URL to get more information about the repository from the GitHub API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new simpleRepository and sets the default values.
        /// </summary>
        public SimpleRepository() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimpleRepository CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimpleRepository();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archive_url", n => { ArchiveUrl = n.GetStringValue(); } },
                {"assignees_url", n => { AssigneesUrl = n.GetStringValue(); } },
                {"blobs_url", n => { BlobsUrl = n.GetStringValue(); } },
                {"branches_url", n => { BranchesUrl = n.GetStringValue(); } },
                {"collaborators_url", n => { CollaboratorsUrl = n.GetStringValue(); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"commits_url", n => { CommitsUrl = n.GetStringValue(); } },
                {"compare_url", n => { CompareUrl = n.GetStringValue(); } },
                {"contents_url", n => { ContentsUrl = n.GetStringValue(); } },
                {"contributors_url", n => { ContributorsUrl = n.GetStringValue(); } },
                {"deployments_url", n => { DeploymentsUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"downloads_url", n => { DownloadsUrl = n.GetStringValue(); } },
                {"events_url", n => { EventsUrl = n.GetStringValue(); } },
                {"fork", n => { Fork = n.GetBoolValue(); } },
                {"forks_url", n => { ForksUrl = n.GetStringValue(); } },
                {"full_name", n => { FullName = n.GetStringValue(); } },
                {"git_commits_url", n => { GitCommitsUrl = n.GetStringValue(); } },
                {"git_refs_url", n => { GitRefsUrl = n.GetStringValue(); } },
                {"git_tags_url", n => { GitTagsUrl = n.GetStringValue(); } },
                {"hooks_url", n => { HooksUrl = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"issue_comment_url", n => { IssueCommentUrl = n.GetStringValue(); } },
                {"issue_events_url", n => { IssueEventsUrl = n.GetStringValue(); } },
                {"issues_url", n => { IssuesUrl = n.GetStringValue(); } },
                {"keys_url", n => { KeysUrl = n.GetStringValue(); } },
                {"labels_url", n => { LabelsUrl = n.GetStringValue(); } },
                {"languages_url", n => { LanguagesUrl = n.GetStringValue(); } },
                {"merges_url", n => { MergesUrl = n.GetStringValue(); } },
                {"milestones_url", n => { MilestonesUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"notifications_url", n => { NotificationsUrl = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"private", n => { Private = n.GetBoolValue(); } },
                {"pulls_url", n => { PullsUrl = n.GetStringValue(); } },
                {"releases_url", n => { ReleasesUrl = n.GetStringValue(); } },
                {"stargazers_url", n => { StargazersUrl = n.GetStringValue(); } },
                {"statuses_url", n => { StatusesUrl = n.GetStringValue(); } },
                {"subscribers_url", n => { SubscribersUrl = n.GetStringValue(); } },
                {"subscription_url", n => { SubscriptionUrl = n.GetStringValue(); } },
                {"tags_url", n => { TagsUrl = n.GetStringValue(); } },
                {"teams_url", n => { TeamsUrl = n.GetStringValue(); } },
                {"trees_url", n => { TreesUrl = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archive_url", ArchiveUrl);
            writer.WriteStringValue("assignees_url", AssigneesUrl);
            writer.WriteStringValue("blobs_url", BlobsUrl);
            writer.WriteStringValue("branches_url", BranchesUrl);
            writer.WriteStringValue("collaborators_url", CollaboratorsUrl);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteStringValue("commits_url", CommitsUrl);
            writer.WriteStringValue("compare_url", CompareUrl);
            writer.WriteStringValue("contents_url", ContentsUrl);
            writer.WriteStringValue("contributors_url", ContributorsUrl);
            writer.WriteStringValue("deployments_url", DeploymentsUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("downloads_url", DownloadsUrl);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteBoolValue("fork", Fork);
            writer.WriteStringValue("forks_url", ForksUrl);
            writer.WriteStringValue("full_name", FullName);
            writer.WriteStringValue("git_commits_url", GitCommitsUrl);
            writer.WriteStringValue("git_refs_url", GitRefsUrl);
            writer.WriteStringValue("git_tags_url", GitTagsUrl);
            writer.WriteStringValue("hooks_url", HooksUrl);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issue_comment_url", IssueCommentUrl);
            writer.WriteStringValue("issue_events_url", IssueEventsUrl);
            writer.WriteStringValue("issues_url", IssuesUrl);
            writer.WriteStringValue("keys_url", KeysUrl);
            writer.WriteStringValue("labels_url", LabelsUrl);
            writer.WriteStringValue("languages_url", LanguagesUrl);
            writer.WriteStringValue("merges_url", MergesUrl);
            writer.WriteStringValue("milestones_url", MilestonesUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("notifications_url", NotificationsUrl);
            writer.WriteObjectValue<SimpleUser>("owner", Owner);
            writer.WriteBoolValue("private", Private);
            writer.WriteStringValue("pulls_url", PullsUrl);
            writer.WriteStringValue("releases_url", ReleasesUrl);
            writer.WriteStringValue("stargazers_url", StargazersUrl);
            writer.WriteStringValue("statuses_url", StatusesUrl);
            writer.WriteStringValue("subscribers_url", SubscribersUrl);
            writer.WriteStringValue("subscription_url", SubscriptionUrl);
            writer.WriteStringValue("tags_url", TagsUrl);
            writer.WriteStringValue("teams_url", TeamsUrl);
            writer.WriteStringValue("trees_url", TreesUrl);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
