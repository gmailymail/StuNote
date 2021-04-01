using System.Collections.Generic;

namespace StuNote.Domain.Btos.Course
{
    /// <summary>
    /// Record for Program
    /// e.g : MSC IT program
    /// </summary>
    public record ProgramBto : CourseBtoBase
    {
        public ProgramBto() => Semesters = new List<SemesterBto>();

        public string Name { get; set; }

        /// <summary>
        /// Semesters of the Program. A program may contain one or more
        /// Semesters
        /// </summary>
        public IEnumerable<SemesterBto> Semesters { get; set; }
    }
}
