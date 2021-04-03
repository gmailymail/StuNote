using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System.IO;
using System.Threading.Tasks;

namespace StuNote.Infrastructure.Storage
{    
    public class LocalFileStorageService : IStorageService
    {
        private readonly ILogger<LocalFileStorageService> _logger;
        private readonly IConfiguration _configuration;

        public LocalFileStorageService(
            ILogger<LocalFileStorageService> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

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
            //Get full path
            string completeSavePath = GetFullPath(Session); 

            //Save file
            File.WriteAllBytes(completeSavePath, Notes);
            await Task.CompletedTask;
            return true;
        }

        #region Helper Methods

        private string GetFileStoredFolder()
        {
            //Folder is stored in appsettings.json
            string _tempFolder = _configuration.GetValue<string>("AppTempFolder");
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
