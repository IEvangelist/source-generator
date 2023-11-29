// <auto-generated/>
using GitHub.Octokit.Repos.Item.Item.Rules.Branches;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Rules {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\rules
    /// </summary>
    public class RulesRequestBuilder : BaseRequestBuilder {
        /// <summary>The branches property</summary>
        public BranchesRequestBuilder Branches { get =>
            new BranchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new RulesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/rules", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RulesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/rules", rawUrl) {
        }
    }
}
