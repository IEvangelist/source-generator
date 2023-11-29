// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Orgs.Item.Item.Item {
    /// <summary>CodeQL query suite to be used. If you specify the `query_suite` parameter, the default setup will be configured with this query suite only on all repositories that didn&apos;t have default setup already configured. It will not change the query suite on repositories that already have default setup configured.If you don&apos;t specify any `query_suite` in your request, the preferred query suite of the organization will be applied.</summary>
    public enum WithEnablementPostRequestBody_query_suite {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "extended")]
        Extended,
    }
}
