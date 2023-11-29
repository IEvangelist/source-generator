// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>A classification of the file. For example to identify it as generated.</summary>
    public enum CodeScanningAlertClassification {
        [EnumMember(Value = "source")]
        Source,
        [EnumMember(Value = "generated")]
        Generated,
        [EnumMember(Value = "test")]
        Test,
        [EnumMember(Value = "library")]
        Library,
    }
}