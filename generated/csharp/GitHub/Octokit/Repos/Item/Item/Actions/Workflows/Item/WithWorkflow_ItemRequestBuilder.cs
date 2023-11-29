// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Disable;
using GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Dispatches;
using GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Enable;
using GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Runs;
using GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item.Timing;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Workflows.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\actions\workflows\{workflow_id}
    /// </summary>
    public class WithWorkflow_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The disable property</summary>
        public DisableRequestBuilder Disable { get =>
            new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dispatches property</summary>
        public DispatchesRequestBuilder Dispatches { get =>
            new DispatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enable property</summary>
        public EnableRequestBuilder Enable { get =>
            new EnableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runs property</summary>
        public RunsRequestBuilder Runs { get =>
            new RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timing property</summary>
        public TimingRequestBuilder Timing { get =>
            new TimingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithWorkflow_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWorkflow_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/workflows/{workflow_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithWorkflow_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWorkflow_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/actions/workflows/{workflow_id}", rawUrl) {
        }
        /// <summary>
        /// Gets a specific workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflows#get-a-workflow" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GitHub.Octokit.Models.Workflow?> GetAsync(Action<WithWorkflow_ItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GitHub.Octokit.Models.Workflow> GetAsync(Action<WithWorkflow_ItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<GitHub.Octokit.Models.Workflow>(requestInfo, GitHub.Octokit.Models.Workflow.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a specific workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithWorkflow_ItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithWorkflow_ItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithWorkflow_ItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
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
        public WithWorkflow_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithWorkflow_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithWorkflow_ItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithWorkflow_ItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithWorkflow_ItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
