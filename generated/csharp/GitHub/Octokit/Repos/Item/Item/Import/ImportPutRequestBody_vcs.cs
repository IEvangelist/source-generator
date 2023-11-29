// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Import {
    /// <summary>The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.</summary>
    public enum ImportPutRequestBody_vcs {
        [EnumMember(Value = "subversion")]
        Subversion,
        [EnumMember(Value = "git")]
        Git,
        [EnumMember(Value = "mercurial")]
        Mercurial,
        [EnumMember(Value = "tfvc")]
        Tfvc,
    }
}
