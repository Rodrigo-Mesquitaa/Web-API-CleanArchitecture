using Ginasio.Core.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ginasio.Core.Interfaces.Repository
{
    public interface IUnidadeRepository
    {
        Task<int> Adicionar(Unidade unidade);
        Task<List<Unidade>> ObterTodos();
        Task<Unidade> ObterPorId(int id);
    }
}
