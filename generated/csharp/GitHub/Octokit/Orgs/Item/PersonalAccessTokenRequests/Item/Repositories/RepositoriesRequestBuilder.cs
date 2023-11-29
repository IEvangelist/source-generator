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
namespace GitHub.Octokit.Orgs.Item.PersonalAccessTokenRequests.Item.Repositories {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\personal-access-token-requests\{pat_request_id}\repositories
    /// </summary>
    public class RepositoriesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RepositoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests/{pat_request_id}/repositories{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RepositoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests/{pat_request_id}/repositories{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the repositories a fine-grained personal access token request is requesting access to. Only GitHub Apps can call this API,using the `organization_personal_access_token_requests: read` permission.**Note**: Fine-grained PATs are in public beta. Related APIs, events, and functionality are subject to change.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/personal-access-tokens#list-repositories-requested-to-be-accessed-by-a-fine-grained-personal-access-token" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<MinimalRepository>?> GetAsync(Action<RepositoriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<MinimalRepository>> GetAsync(Action<RepositoriesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<MinimalRepository>(requestInfo, MinimalRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the repositories a fine-grained personal access token request is requesting access to. Only GitHub Apps can call this API,using the `organization_personal_access_token_requests: read` permission.**Note**: Fine-grained PATs are in public beta. Related APIs, events, and functionality are subject to change.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RepositoriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RepositoriesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RepositoriesRequestBuilderGetRequestConfiguration();
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
        public RepositoriesRequestBuilder WithUrl(string rawUrl) {
            return new RepositoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the repositories a fine-grained personal access token request is requesting access to. Only GitHub Apps can call this API,using the `organization_personal_access_token_requests: read` permission.**Note**: Fine-grained PATs are in public beta. Related APIs, events, and functionality are subject to change.
        /// </summary>
        public class RepositoriesRequestBuilderGetQueryParameters {
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
        public class RepositoriesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public RepositoriesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new RepositoriesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new repositoriesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public RepositoriesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
