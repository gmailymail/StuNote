using Microsoft.Extensions.DependencyInjection;
using StuNote.Domain;
using StuNote.Domain.Services;
using System;
using System.ComponentModel;

namespace StuNote.Infrastructure.Storage
{
    public class StorageLocatorFactoryService : IStorageLocatorFactoryService
    {
        private readonly IServiceProvider _serviceProvider;

        public StorageLocatorFactoryService(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;
        public IStorageService GetStorageService(StorageType storageType) => storageType switch
        {
            StorageType.LocalFile   =>  _serviceProvider.GetRequiredService<LocalFileStorageService>(),
            StorageType.Azure       =>  _serviceProvider.GetRequiredService<AzureStorageService>(),
            _                       =>  throw new InvalidEnumArgumentException()
        };
    }
}
