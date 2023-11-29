// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Composed type wrapper for classes addedToProjectIssueEvent, assignedIssueEvent, convertedNoteToIssueIssueEvent, demilestonedIssueEvent, labeledIssueEvent, lockedIssueEvent, milestonedIssueEvent, movedColumnInProjectIssueEvent, removedFromProjectIssueEvent, renamedIssueEvent, reviewDismissedIssueEvent, reviewRequestedIssueEvent, reviewRequestRemovedIssueEvent, unassignedIssueEvent, unlabeledIssueEvent
    /// </summary>
    public class IssueEventForIssue : IComposedTypeWrapper, IParsable {
        /// <summary>Composed type representation for type addedToProjectIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.AddedToProjectIssueEvent AddedToProjectIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type assignedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.AssignedIssueEvent? AssignedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.AssignedIssueEvent AssignedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type convertedNoteToIssueIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.ConvertedNoteToIssueIssueEvent ConvertedNoteToIssueIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type demilestonedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.DemilestonedIssueEvent? DemilestonedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.DemilestonedIssueEvent DemilestonedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type labeledIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.LabeledIssueEvent? LabeledIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.LabeledIssueEvent LabeledIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type lockedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.LockedIssueEvent? LockedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.LockedIssueEvent LockedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type milestonedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.MilestonedIssueEvent? MilestonedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.MilestonedIssueEvent MilestonedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type movedColumnInProjectIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.MovedColumnInProjectIssueEvent MovedColumnInProjectIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type removedFromProjectIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.RemovedFromProjectIssueEvent RemovedFromProjectIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type renamedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.RenamedIssueEvent? RenamedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.RenamedIssueEvent RenamedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type reviewDismissedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.ReviewDismissedIssueEvent ReviewDismissedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type reviewRequestedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.ReviewRequestedIssueEvent ReviewRequestedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type reviewRequestRemovedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.ReviewRequestRemovedIssueEvent ReviewRequestRemovedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type unassignedIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.UnassignedIssueEvent? UnassignedIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.UnassignedIssueEvent UnassignedIssueEvent { get; set; }
#endif
        /// <summary>Composed type representation for type unlabeledIssueEvent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.UnlabeledIssueEvent? UnlabeledIssueEvent { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.UnlabeledIssueEvent UnlabeledIssueEvent { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueEventForIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var result = new IssueEventForIssue();
            result.AddedToProjectIssueEvent = new GitHub.Octokit.Models.AddedToProjectIssueEvent();
            result.AssignedIssueEvent = new GitHub.Octokit.Models.AssignedIssueEvent();
            result.ConvertedNoteToIssueIssueEvent = new GitHub.Octokit.Models.ConvertedNoteToIssueIssueEvent();
            result.DemilestonedIssueEvent = new GitHub.Octokit.Models.DemilestonedIssueEvent();
            result.LabeledIssueEvent = new GitHub.Octokit.Models.LabeledIssueEvent();
            result.LockedIssueEvent = new GitHub.Octokit.Models.LockedIssueEvent();
            result.MilestonedIssueEvent = new GitHub.Octokit.Models.MilestonedIssueEvent();
            result.MovedColumnInProjectIssueEvent = new GitHub.Octokit.Models.MovedColumnInProjectIssueEvent();
            result.RemovedFromProjectIssueEvent = new GitHub.Octokit.Models.RemovedFromProjectIssueEvent();
            result.RenamedIssueEvent = new GitHub.Octokit.Models.RenamedIssueEvent();
            result.ReviewDismissedIssueEvent = new GitHub.Octokit.Models.ReviewDismissedIssueEvent();
            result.ReviewRequestedIssueEvent = new GitHub.Octokit.Models.ReviewRequestedIssueEvent();
            result.ReviewRequestRemovedIssueEvent = new GitHub.Octokit.Models.ReviewRequestRemovedIssueEvent();
            result.UnassignedIssueEvent = new GitHub.Octokit.Models.UnassignedIssueEvent();
            result.UnlabeledIssueEvent = new GitHub.Octokit.Models.UnlabeledIssueEvent();
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            if(AddedToProjectIssueEvent != null || AssignedIssueEvent != null || ConvertedNoteToIssueIssueEvent != null || DemilestonedIssueEvent != null || LabeledIssueEvent != null || LockedIssueEvent != null || MilestonedIssueEvent != null || MovedColumnInProjectIssueEvent != null || RemovedFromProjectIssueEvent != null || RenamedIssueEvent != null || ReviewDismissedIssueEvent != null || ReviewRequestedIssueEvent != null || ReviewRequestRemovedIssueEvent != null || UnassignedIssueEvent != null || UnlabeledIssueEvent != null) {
                return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(AddedToProjectIssueEvent, AssignedIssueEvent, ConvertedNoteToIssueIssueEvent, DemilestonedIssueEvent, LabeledIssueEvent, LockedIssueEvent, MilestonedIssueEvent, MovedColumnInProjectIssueEvent, RemovedFromProjectIssueEvent, RenamedIssueEvent, ReviewDismissedIssueEvent, ReviewRequestedIssueEvent, ReviewRequestRemovedIssueEvent, UnassignedIssueEvent, UnlabeledIssueEvent);
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GitHub.Octokit.Models.AddedToProjectIssueEvent>(null, AddedToProjectIssueEvent, AssignedIssueEvent, ConvertedNoteToIssueIssueEvent, DemilestonedIssueEvent, LabeledIssueEvent, LockedIssueEvent, MilestonedIssueEvent, MovedColumnInProjectIssueEvent, RemovedFromProjectIssueEvent, RenamedIssueEvent, ReviewDismissedIssueEvent, ReviewRequestedIssueEvent, ReviewRequestRemovedIssueEvent, UnassignedIssueEvent, UnlabeledIssueEvent);
        }
    }
}
