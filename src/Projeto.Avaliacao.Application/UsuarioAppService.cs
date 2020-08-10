using AutoMapper;
using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Application.ViewModels;
using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Application
{
    public class UsuarioAppService : ApplicationService, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IUnitOfWork _uow;
        public UsuarioAppService(IUsuarioService usuarioService, IUnitOfWork uow) : base(uow)
        {
            _usuarioService = usuarioService;
            _uow = uow;
        }

        public UsuarioLoginTelefoneViewModel Adicionar(UsuarioLoginTelefoneViewModel obj)
        {
            BeginTransaction();

            var usuario = Mapper.Map<Usuario>(obj);
            var telefone = Mapper.Map<Telefone>(obj);
            var login = Mapper.Map<Login>(obj);

            usuario.Telefones.Add(telefone);
            usuario.Login = login;

            var result = _usuarioService.Adicionar(usuario);

            Commit();

            result.ValidationResult.Message = "Usuario cadastrado com sucesso!";

            return Mapper.Map<UsuarioLoginTelefoneViewModel>(result); 
        }

        public UsuarioLoginTelefoneViewModel Atualizar(UsuarioLoginTelefoneViewModel obj)
        {
            return Mapper.Map<UsuarioLoginTelefoneViewModel>(_usuarioService.Atualizar(Mapper.Map<Usuario>(obj)));
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Remover(UsuarioLoginTelefoneViewModel obj)
        {
            _usuarioService.Remover(Mapper.Map<Usuario>(obj));
        }

        public UsuarioLoginTelefoneViewModel RetornarPorId(int id)
        {
            return Mapper.Map<UsuarioLoginTelefoneViewModel>(_usuarioService.RetornarPorId(id));
        }

        public IEnumerable<UsuarioViewModel> RetornarTodos()
        {
            return Mapper.Map<IEnumerable<UsuarioViewModel>>(_usuarioService.RetornarTodos());
        }

        public PagedViewModel<UsuarioViewModel> BuscarUsuariosPaginado(RequestPaginationViewModel<UsuarioViewModel> obj)
        {
            return Mapper.Map<PagedViewModel<UsuarioViewModel>>(_usuarioService.BuscarUsuariosPaginado(Mapper.Map<RequestPagination<Usuario>>(obj)));
        }

        public void ExcluirTodosUsuarios()
        {
            _usuarioService.ExcluirTodosUsuarios();
        }
    }
}
