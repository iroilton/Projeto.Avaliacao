using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Application.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Projeto.Avaliacao.Services.REST.UsuarioAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuariosController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        // GET: api/Usuarios
        [HttpGet]
        public IEnumerable<UsuarioViewModel> RetornarTodos()
        {
            return _usuarioAppService.RetornarTodos();
        }

        [HttpPost]
        public PagedViewModel<UsuarioViewModel> BuscarUsuariosPaginado(RequestPaginationViewModel<UsuarioViewModel> obj)
        {
            return _usuarioAppService.BuscarUsuariosPaginado(obj);
        }
        
        [HttpPost]
        public UsuarioLoginTelefoneViewModel AdicionarUsuario(UsuarioLoginTelefoneViewModel obj)
        {
            return _usuarioAppService.Adicionar(obj);
        }

        [HttpGet]
        public UsuarioLoginTelefoneViewModel RetornarPorId(int id)
        {
            return _usuarioAppService.RetornarPorId(id);
        }
        
        [HttpPost]
        public void RemoverUsuario(UsuarioLoginTelefoneViewModel obj)
        {
            _usuarioAppService.Remover(obj);
        }

        [HttpGet]
        public void ExcluirTodosUsuarios()
        {
            _usuarioAppService.ExcluirTodosUsuarios();
        }

        [HttpPost]
        public UsuarioLoginTelefoneViewModel AtualizarUsuario(UsuarioLoginTelefoneViewModel obj)
        {
            return _usuarioAppService.Atualizar(obj);
        }
    }
}
