using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Interfaces.Services;

namespace Projeto.Avaliacao.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Paged<Usuario> BuscarUsuariosPaginado(RequestPagination<Usuario> obj)
        {
            if(obj.Filtro == null)
            {
                return _usuarioRepository.RetornarTodosPaginado(obj);
            }

            return _usuarioRepository.BuscarUsuariosPaginado(obj);
        }

        public void ExcluirTodosUsuarios()
        {
            _usuarioRepository.ExcluirTodosUsuarios();
        }

        public new Usuario RetornarPorId(int id)
        {
            return _usuarioRepository.RetornarPorId(id);
        }

        public new Usuario Atualizar(Usuario obj)
        {
            return _usuarioRepository.Atualizar(obj);
        }
    }
}
