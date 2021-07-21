using Ginasio.Core.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Ginasio.Infrastructure.Servicos
{
    public class AzureFileStorageService : IFileStorageService
    {
        public Task AddFile(byte[] content, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
