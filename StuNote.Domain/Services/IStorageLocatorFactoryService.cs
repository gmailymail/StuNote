namespace StuNote.Domain.Services
{
    public interface IStorageLocatorFactoryService
    {
        IStorageService GetStorageService(StorageType storageType);
    }
}
