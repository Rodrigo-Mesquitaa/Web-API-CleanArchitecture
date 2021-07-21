using System.Threading.Tasks;

namespace Ginasio.Core.Interfaces.Services
{
    public interface IFileStorageService
    {
        Task AddFile(byte[] content, string fileName);
    }
}
