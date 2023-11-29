// <auto-generated/>
using GitHub.Octokit.Advisories.Item;
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Advisories {
    /// <summary>
    /// Builds and executes requests for operations under \advisories
    /// </summary>
    public class AdvisoriesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.advisories.item collection</summary>
        /// <param name="position">The GHSA (GitHub Security Advisory) identifier of the advisory.</param>
        public WithGhsa_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("ghsa_id", position);
            return new WithGhsa_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AdvisoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdvisoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/advisories{?ghsa_id*,type*,cve_id*,ecosystem*,severity*,cwes*,is_withdrawn*,affects*,published*,updated*,modified*,before*,after*,direction*,per_page*,sort*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AdvisoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdvisoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/advisories{?ghsa_id*,type*,cve_id*,ecosystem*,severity*,cwes*,is_withdrawn*,affects*,published*,updated*,modified*,before*,after*,direction*,per_page*,sort*}", rawUrl) {
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/security-advisories/global-advisories#list-global-security-advisories" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<GlobalAdvisory>?> GetAsync(Action<AdvisoriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<GlobalAdvisory>> GetAsync(Action<AdvisoriesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationErrorSimple.CreateFromDiscriminatorValue},
                {"429", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<GlobalAdvisory>(requestInfo, GlobalAdvisory.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AdvisoriesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AdvisoriesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AdvisoriesRequestBuilderGetRequestConfiguration();
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
        public AdvisoriesRequestBuilder WithUrl(string rawUrl) {
            return new AdvisoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// </summary>
        public class AdvisoriesRequestBuilderGetQueryParameters {
            /// <summary>If specified, only return advisories that affect any of `package` or `package@version`. A maximum of 1000 packages can be specified.If the query parameter causes the URL to exceed the maximum URL length supported by your client, you must specify fewer packages.Example: `affects=package1,package2@1.0.0,package3@^2.0.0` or `affects[]=package1&amp;affects[]=package2@1.0.0`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("affects")]
            public string? Affects { get; set; }
#nullable restore
#else
            [QueryParameter("affects")]
            public string Affects { get; set; }
#endif
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
            /// <summary>If specified, only advisories with this CVE (Common Vulnerabilities and Exposures) identifier will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cve_id")]
            public string? CveId { get; set; }
#nullable restore
#else
            [QueryParameter("cve_id")]
            public string CveId { get; set; }
#endif
            /// <summary>If specified, only advisories with these Common Weakness Enumerations (CWEs) will be returned.Example: `cwes=79,284,22` or `cwes[]=79&amp;cwes[]=284&amp;cwes[]=22`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cwes")]
            public string? Cwes { get; set; }
#nullable restore
#else
            [QueryParameter("cwes")]
            public string Cwes { get; set; }
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
            /// <summary>If specified, only advisories for these ecosystems will be returned.</summary>
            [Obsolete("This property is deprecated, use ecosystemAsGetEcosystemQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ecosystem")]
            public string? Ecosystem { get; set; }
#nullable restore
#else
            [QueryParameter("ecosystem")]
            public string Ecosystem { get; set; }
#endif
            /// <summary>If specified, only advisories for these ecosystems will be returned.</summary>
            [QueryParameter("ecosystem")]
            public GetEcosystemQueryParameterType? EcosystemAsGetEcosystemQueryParameterType { get; set; }
            /// <summary>If specified, only advisories with this GHSA (GitHub Security Advisory) identifier will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ghsa_id")]
            public string? GhsaId { get; set; }
#nullable restore
#else
            [QueryParameter("ghsa_id")]
            public string GhsaId { get; set; }
#endif
            /// <summary>Whether to only return advisories that have been withdrawn.</summary>
            [QueryParameter("is_withdrawn")]
            public bool? IsWithdrawn { get; set; }
            /// <summary>If specified, only show advisories that were updated or published on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("modified")]
            public string? Modified { get; set; }
#nullable restore
#else
            [QueryParameter("modified")]
            public string Modified { get; set; }
#endif
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>If specified, only return advisories that were published on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("published")]
            public string? Published { get; set; }
#nullable restore
#else
            [QueryParameter("published")]
            public string Published { get; set; }
#endif
            /// <summary>If specified, only advisories with these severities will be returned.</summary>
            [Obsolete("This property is deprecated, use severityAsGetSeverityQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("severity")]
            public string? Severity { get; set; }
#nullable restore
#else
            [QueryParameter("severity")]
            public string Severity { get; set; }
#endif
            /// <summary>If specified, only advisories with these severities will be returned.</summary>
            [QueryParameter("severity")]
            public GetSeverityQueryParameterType? SeverityAsGetSeverityQueryParameterType { get; set; }
            /// <summary>The property to sort the results by.</summary>
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
            /// <summary>The property to sort the results by.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>If specified, only advisories of this type will be returned. By default, a request with no other parameters defined will only return reviewed advisories that are not malware.</summary>
            [Obsolete("This property is deprecated, use typeAsGetTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            /// <summary>If specified, only advisories of this type will be returned. By default, a request with no other parameters defined will only return reviewed advisories that are not malware.</summary>
            [QueryParameter("type")]
            public GetTypeQueryParameterType? TypeAsGetTypeQueryParameterType { get; set; }
            /// <summary>If specified, only return advisories that were updated on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("updated")]
            public string? Updated { get; set; }
#nullable restore
#else
            [QueryParameter("updated")]
            public string Updated { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AdvisoriesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AdvisoriesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AdvisoriesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new advisoriesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AdvisoriesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
