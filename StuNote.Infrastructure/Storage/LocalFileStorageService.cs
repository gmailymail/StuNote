using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System.IO;
using System.Threading.Tasks;

namespace StuNote.Infrastructure.Storage
{
    //Test Comment by Shawn
    public class LocalFileStorageService : IStorageService
    {
        private readonly ILogger<LocalFileStorageService> _logger;
        public LocalFileStorageService(ILogger<LocalFileStorageService> logger) => _logger = logger;

        public async Task<byte[]> OpenNotes(SessionBto Session)
        {
            byte[] returnValue = null;
            string completeOpenPath = GetFullPath(Session); //Get complete path
            if (File.Exists(completeOpenPath))
                returnValue = File.ReadAllBytes(completeOpenPath);
            
            await Task.CompletedTask;
            return returnValue;
        }

        public async Task<bool> SaveNotes(SessionBto Session, byte[] Notes)
        {
            
            string completeSavePath = GetFullPath(Session); //Get complete path

            //Save file
            File.WriteAllBytes(completeSavePath, Notes);
            await Task.CompletedTask;
            return true;
        }

        #region Helper Methods

        private string GetFileStoredFolder()
        {
            string _tempFolder = "TempStuNote";
            string tempDirectoryPath = Path.Combine(Path.GetTempPath(), _tempFolder);
            if (!Directory.Exists(tempDirectoryPath))
                Directory.CreateDirectory(tempDirectoryPath);
            return tempDirectoryPath;
        }

        private string GetFileName(SessionBto Session) => $"{Session.ModuleId}_{Session.Id}.docx";

        private string GetFullPath(SessionBto Session) =>
            Path.Combine(GetFileStoredFolder(), GetFileName(Session));


        #endregion Helper Methods
    }
}
