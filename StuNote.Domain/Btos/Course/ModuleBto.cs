using System.Collections.Generic;

namespace StuNote.Domain.Btos.Course
{
    /// <summary>
    /// Record for Modules
    /// e.g : TSD module
    /// </summary>
    public sealed record ModuleBto : CourseBtoBase
    {
        public ModuleBto() => Sessions = new List<SessionBto>();

        public string Name { get; set; }

        /// <summary>
        /// A module may contain one ore more Sessions.
        /// e.g : Session 04 of the ISM
        /// </summary>
        public IEnumerable<SessionBto> Sessions { get; set; }
    }
}
