using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Paged<Usuario> RetornarTodosPaginado(RequestPagination<Usuario> obj);
        Paged<Usuario> BuscarUsuariosPaginado(RequestPagination<Usuario> obj);
        void ExcluirTodosUsuarios();
        Usuario Atualizar(Usuario obj);
    }
}
