// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Hooks.Item.Deliveries.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Hooks.Item.Deliveries {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\hooks\{hook_id}\deliveries
    /// </summary>
    public class DeliveriesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.hooks.item.deliveries.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithDelivery_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("delivery_id", position);
            return new WithDelivery_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.hooks.item.deliveries.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithDelivery_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("delivery_id", position);
            return new WithDelivery_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new DeliveriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/hooks/{hook_id}/deliveries{?per_page*,cursor*,redelivery*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeliveriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/hooks/{hook_id}/deliveries{?per_page*,cursor*,redelivery*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// API method documentation <see href="https://docs.github.com/rest/repos/webhooks#list-deliveries-for-a-repository-webhook" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<HookDeliveryItem>?> GetAsync(Action<DeliveriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<HookDeliveryItem>> GetAsync(Action<DeliveriesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<HookDeliveryItem>(requestInfo, HookDeliveryItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeliveriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeliveriesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeliveriesRequestBuilderGetRequestConfiguration();
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
        public DeliveriesRequestBuilder WithUrl(string rawUrl) {
            return new DeliveriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        public class DeliveriesRequestBuilderGetQueryParameters {
            /// <summary>Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cursor")]
            public string? Cursor { get; set; }
#nullable restore
#else
            [QueryParameter("cursor")]
            public string Cursor { get; set; }
#endif
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("redelivery")]
            public bool? Redelivery { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeliveriesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeliveriesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeliveriesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deliveriesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeliveriesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
