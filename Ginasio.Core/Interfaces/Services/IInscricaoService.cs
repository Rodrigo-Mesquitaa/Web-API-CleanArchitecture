using Ginasio.Core.DTOs;
using Ginasio.Core.Entidades;

namespace Ginasio.Core.Interfaces.Services
{
    public interface IInscricaoService
    {
        ResultadoInscricaoDTO Realizar(Aluno aluno, Unidade unidade, TurmaAtividade turmaAtividade);
    }
}
