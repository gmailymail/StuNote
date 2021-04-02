using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuNote.Infrastructure.Storage
{
    public class AzureStorageService : IStorageService
    {
        private readonly ILogger<AzureStorageService> _logger;

        public AzureStorageService(ILogger<AzureStorageService> logger) => _logger = logger;

        public async Task<byte[]> OpenNotes(SessionBto Session)
        {
            byte[] returnValue = null;
            _logger.LogInformation("AzureStorageService.OpenNotes() method is invoked.");
            await Task.CompletedTask;
            return returnValue;
        }
       
        public async Task<bool> SaveNotes(SessionBto Session, byte[] Notes)
        {
            _logger.LogInformation("AzureStorageService.SaveNotes() method is invoked.");
            await Task.CompletedTask;
            return true;
        }
    }
}
