using StuNote.Domain.Btos.Course;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    /// <summary>
    /// Stores given Note Pad in a storage system.
    /// This is an abstract method.
    /// Service implementation is located in Infrastructure class.
    /// Multiple storage mechanisms can be implemented.
    /// i.e : Local File storage, SQLite Storage,
    /// Azure for Online Storage.
    /// </summary>
    public interface IStorageService
    {
        /// <summary>
        /// SaveNotes implements save mechanism to store the file.
        /// </summary>
        /// <param name="Notes">Notes content must converted to byte[] array before 
        /// pass into the method.
        /// </param>
        /// <returns></returns>
        Task<bool> SaveNotes(SessionBto Session, byte[] Notes);

        Task<bool> OpenNotes(SessionBto Session);
    }
}
