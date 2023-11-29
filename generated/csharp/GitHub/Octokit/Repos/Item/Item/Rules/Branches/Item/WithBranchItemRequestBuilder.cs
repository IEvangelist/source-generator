// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Rules.Branches.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\rules\branches\{branch}
    /// </summary>
    public class WithBranchItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithBranchItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBranchItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/rules/branches/{branch}{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithBranchItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBranchItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/rules/branches/{branch}{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// API method documentation <see href="https://docs.github.com/rest/repos/rules#get-rules-for-a-branch" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<RepositoryRuleDetailed>?> GetAsync(Action<WithBranchItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<RepositoryRuleDetailed>> GetAsync(Action<WithBranchItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<RepositoryRuleDetailed>(requestInfo, RepositoryRuleDetailed.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithBranchItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithBranchItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithBranchItemRequestBuilderGetRequestConfiguration();
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
        public WithBranchItemRequestBuilder WithUrl(string rawUrl) {
            return new WithBranchItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// </summary>
        public class WithBranchItemRequestBuilderGetQueryParameters {
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithBranchItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithBranchItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithBranchItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithBranchItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithBranchItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
