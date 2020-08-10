using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Paged<Usuario> BuscarUsuariosPaginado(RequestPagination<Usuario> obj);
        void ExcluirTodosUsuarios();
        Usuario Atualizar(Usuario obj);
    }
}
