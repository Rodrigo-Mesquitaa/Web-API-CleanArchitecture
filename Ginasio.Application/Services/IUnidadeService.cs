using Ginasio.Application.InputModels;
using Ginasio.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ginasio.Application.Services
{
    public interface IUnidadeService
    {
        Task<int> Adicionar(UnidadeInputModel unidadeInputModel);
        Task<List<UnidadeItemViewModel>> ObterTodos();
        Task<UnidadeViewModel> ObterPorId(int id);
    }
}
