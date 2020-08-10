using Projeto.Avaliacao.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Application.Interface
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioLoginTelefoneViewModel Adicionar(UsuarioLoginTelefoneViewModel obj);
        UsuarioLoginTelefoneViewModel RetornarPorId(int id);
        IEnumerable<UsuarioViewModel> RetornarTodos();
        PagedViewModel<UsuarioViewModel> BuscarUsuariosPaginado(RequestPaginationViewModel<UsuarioViewModel> obj);
        void Remover(UsuarioLoginTelefoneViewModel obj);
        void ExcluirTodosUsuarios();
        UsuarioLoginTelefoneViewModel Atualizar(UsuarioLoginTelefoneViewModel obj);
    }
}
