using StuNote.Domain.Btos.Course;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    public interface ICourseService
    {
        public Task<IEnumerable<SessionBto>> GetSessionsAsync(SessionFilterBto sessionFilter=null);

        public Task<ProgramBto> GetEnrolledProgramAsync();
    }
}
