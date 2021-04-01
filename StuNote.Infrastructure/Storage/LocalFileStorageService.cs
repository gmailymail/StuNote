using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System.Threading.Tasks;

namespace StuNote.Infrastructure.Storage
{
    //Test Comment by Shawn
    public class LocalFileStorageService : IStorageService
    {
        private readonly ILogger<LocalFileStorageService> _logger;
        public LocalFileStorageService(ILogger<LocalFileStorageService> logger) => _logger = logger;

        public async Task<bool> OpenNotes(SessionBto Session)
        {
            _logger.LogInformation("AzureStorageService.OpenNotes() method is invoked.");
            await Task.CompletedTask;
            return true;
        }

        public async Task<bool> SaveNotes(SessionBto Session, byte[] Notes)
        {
            _logger.LogInformation("AzureStorageService.SaveNotes() method is invoked.");
            await Task.CompletedTask;
            return true;

            //Test Comment
        }
    }
}
