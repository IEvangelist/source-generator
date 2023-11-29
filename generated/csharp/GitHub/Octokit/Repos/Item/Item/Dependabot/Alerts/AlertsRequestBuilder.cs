// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Dependabot.Alerts.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Dependabot.Alerts {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\dependabot\alerts
    /// </summary>
    public class AlertsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.dependabot.alerts.item collection</summary>
        /// <param name="position">The number that identifies a Dependabot alert in its repository.You can find this at the end of the URL for a Dependabot alert within GitHub,or in `number` fields in the response from the`GET /repos/{owner}/{repo}/dependabot/alerts` operation.</param>
        public WithAlert_numberItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("alert_number", position);
            return new WithAlert_numberItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.dependabot.alerts.item collection</summary>
        /// <param name="position">The number that identifies a Dependabot alert in its repository.You can find this at the end of the URL for a Dependabot alert within GitHub,or in `number` fields in the response from the`GET /repos/{owner}/{repo}/dependabot/alerts` operation.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithAlert_numberItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("alert_number", position);
            return new WithAlert_numberItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AlertsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/dependabot/alerts{?state*,severity*,ecosystem*,package*,manifest*,scope*,sort*,direction*,page*,per_page*,before*,after*,first*,last*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AlertsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/dependabot/alerts{?state*,severity*,ecosystem*,package*,manifest*,scope*,sort*,direction*,page*,per_page*,before*,after*,first*,last*}", rawUrl) {
        }
        /// <summary>
        /// You must use an access token with the `security_events` scope to use this endpoint with private repositories.You can also use tokens with the `public_repo` scope for public repositories only.GitHub Apps must have **Dependabot alerts** read permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/dependabot/alerts#list-dependabot-alerts-for-a-repository" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<DependabotAlert>?> GetAsync(Action<AlertsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<DependabotAlert>> GetAsync(Action<AlertsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationErrorSimple.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<DependabotAlert>(requestInfo, DependabotAlert.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// You must use an access token with the `security_events` scope to use this endpoint with private repositories.You can also use tokens with the `public_repo` scope for public repositories only.GitHub Apps must have **Dependabot alerts** read permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AlertsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AlertsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AlertsRequestBuilderGetRequestConfiguration();
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
        public AlertsRequestBuilder WithUrl(string rawUrl) {
            return new AlertsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// You must use an access token with the `security_events` scope to use this endpoint with private repositories.You can also use tokens with the `public_repo` scope for public repositories only.GitHub Apps must have **Dependabot alerts** read permission to use this endpoint.
        /// </summary>
        public class AlertsRequestBuilderGetQueryParameters {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [Obsolete("This property is deprecated, use directionAsGetDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>A comma-separated list of ecosystems. If specified, only alerts for these ecosystems will be returned.Can be: `composer`, `go`, `maven`, `npm`, `nuget`, `pip`, `pub`, `rubygems`, `rust`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ecosystem")]
            public string? Ecosystem { get; set; }
#nullable restore
#else
            [QueryParameter("ecosystem")]
            public string Ecosystem { get; set; }
#endif
            /// <summary>**Deprecated**. The number of results per page (max 100), starting from the first matching result.This parameter must not be used in combination with `last`.Instead, use `per_page` in combination with `after` to fetch the first page of results.</summary>
            [QueryParameter("first")]
            public int? First { get; set; }
            /// <summary>**Deprecated**. The number of results per page (max 100), starting from the last matching result.This parameter must not be used in combination with `first`.Instead, use `per_page` in combination with `before` to fetch the last page of results.</summary>
            [QueryParameter("last")]
            public int? Last { get; set; }
            /// <summary>A comma-separated list of full manifest paths. If specified, only alerts for these manifests will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("manifest")]
            public string? Manifest { get; set; }
#nullable restore
#else
            [QueryParameter("manifest")]
            public string Manifest { get; set; }
#endif
            /// <summary>A comma-separated list of package names. If specified, only alerts for these packages will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("package")]
            public string? Package { get; set; }
#nullable restore
#else
            [QueryParameter("package")]
            public string Package { get; set; }
#endif
            /// <summary>**Deprecated**. Page number of the results to fetch. Use cursor-based pagination with `before` or `after` instead.</summary>
            [Obsolete("")]
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [Obsolete("")]
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The scope of the vulnerable dependency. If specified, only alerts with this scope will be returned.</summary>
            [Obsolete("This property is deprecated, use scopeAsGetScopeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
            /// <summary>The scope of the vulnerable dependency. If specified, only alerts with this scope will be returned.</summary>
            [QueryParameter("scope")]
            public GetScopeQueryParameterType? ScopeAsGetScopeQueryParameterType { get; set; }
            /// <summary>A comma-separated list of severities. If specified, only alerts with these severities will be returned.Can be: `low`, `medium`, `high`, `critical`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("severity")]
            public string? Severity { get; set; }
#nullable restore
#else
            [QueryParameter("severity")]
            public string Severity { get; set; }
#endif
            /// <summary>The property by which to sort the results.`created` means when the alert was created.`updated` means when the alert&apos;s state last changed.</summary>
            [Obsolete("This property is deprecated, use sortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>The property by which to sort the results.`created` means when the alert was created.`updated` means when the alert&apos;s state last changed.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>A comma-separated list of states. If specified, only alerts with these states will be returned.Can be: `auto_dismissed`, `dismissed`, `fixed`, `open`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AlertsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AlertsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AlertsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new alertsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AlertsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
