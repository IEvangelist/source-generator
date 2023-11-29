// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Runs {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\actions\workflows\{workflow_id}\runs
    /// </summary>
    public class RunsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RunsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs{?actor*,branch*,event*,status*,per_page*,page*,created*,exclude_pull_requests*,check_suite_id*,head_sha*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RunsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs{?actor*,branch*,event*,status*,per_page*,page*,created*,exclude_pull_requests*,check_suite_id*,head_sha*}", rawUrl) {
        }
        /// <summary>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflow-runs#list-workflow-runs-for-a-workflow" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RunsGetResponse?> GetAsRunsGetResponseAsync(Action<RunsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RunsGetResponse> GetAsRunsGetResponseAsync(Action<RunsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<RunsGetResponse>(requestInfo, RunsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflow-runs#list-workflow-runs-for-a-workflow" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsRunsGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RunsResponse?> GetAsync(Action<RunsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RunsResponse> GetAsync(Action<RunsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<RunsResponse>(requestInfo, RunsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RunsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RunsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RunsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RunsRequestBuilder WithUrl(string rawUrl) {
            return new RunsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.
        /// </summary>
        public class RunsRequestBuilderGetQueryParameters {
            /// <summary>Returns someone&apos;s workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("actor")]
            public string? Actor { get; set; }
#nullable restore
#else
            [QueryParameter("actor")]
            public string Actor { get; set; }
#endif
            /// <summary>Returns workflow runs associated with a branch. Use the name of the branch of the `push`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("branch")]
            public string? Branch { get; set; }
#nullable restore
#else
            [QueryParameter("branch")]
            public string Branch { get; set; }
#endif
            /// <summary>Returns workflow runs with the `check_suite_id` that you specify.</summary>
            [QueryParameter("check_suite_id")]
            public int? CheckSuiteId { get; set; }
            /// <summary>Returns workflow runs created within the given date-time range. For more information on the syntax, see &quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
            [QueryParameter("created")]
            public DateTimeOffset? Created { get; set; }
            /// <summary>Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see &quot;[Events that trigger workflows](https://docs.github.com/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("event")]
            public string? Event { get; set; }
#nullable restore
#else
            [QueryParameter("event")]
            public string Event { get; set; }
#endif
            /// <summary>If `true` pull requests are omitted from the response (empty array).</summary>
            [QueryParameter("exclude_pull_requests")]
            public bool? ExcludePullRequests { get; set; }
            /// <summary>Only returns workflow runs that are associated with the specified `head_sha`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("head_sha")]
            public string? HeadSha { get; set; }
#nullable restore
#else
            [QueryParameter("head_sha")]
            public string HeadSha { get; set; }
#endif
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`.</summary>
            [Obsolete("This property is deprecated, use statusAsGetStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public string? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public string Status { get; set; }
#endif
            /// <summary>Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`.</summary>
            [QueryParameter("status")]
            public GetStatusQueryParameterType? StatusAsGetStatusQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RunsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public RunsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new RunsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new runsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public RunsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
