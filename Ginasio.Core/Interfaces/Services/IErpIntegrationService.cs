using Ginasio.Core.DTOs;
using System.Threading.Tasks;

namespace Ginasio.Core.Interfaces.Services
{
    public interface IErpIntegrationService
    {
        Task AdicionarPessoa(AdicionarPessoaErpDTO pessoa);
    }
}
