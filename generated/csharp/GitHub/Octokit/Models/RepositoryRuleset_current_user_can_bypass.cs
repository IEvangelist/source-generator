// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>The bypass type of the user making the API request for this ruleset. This field is only returned whenquerying the repository-level endpoint.</summary>
    public enum RepositoryRuleset_current_user_can_bypass {
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "pull_requests_only")]
        Pull_requests_only,
        [EnumMember(Value = "never")]
        Never,
    }
}
