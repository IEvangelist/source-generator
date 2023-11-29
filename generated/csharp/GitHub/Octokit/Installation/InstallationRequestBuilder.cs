// <auto-generated/>
using GitHub.Octokit.Installation.Repositories;
using GitHub.Octokit.Installation.Token;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Installation {
    /// <summary>
    /// Builds and executes requests for operations under \installation
    /// </summary>
    public class InstallationRequestBuilder : BaseRequestBuilder {
        /// <summary>The repositories property</summary>
        public RepositoriesRequestBuilder Repositories { get =>
            new RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The token property</summary>
        public TokenRequestBuilder Token { get =>
            new TokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new InstallationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/installation", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new InstallationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/installation", rawUrl) {
        }
    }
}
