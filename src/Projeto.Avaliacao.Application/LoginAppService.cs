using AutoMapper;
using DomainValidation.Validation;
using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Application.ViewModels;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Application
{
    public class LoginAppService : ApplicationService, ILoginAppService
    {
        private readonly ILoginService _loginService;
        private readonly IUnitOfWork _uow;
        public LoginAppService(ILoginService loginService, IUnitOfWork uow) : base (uow)
        {
            _loginService = loginService;
            _uow = uow;
        }
        public LoginViewModel Adicionar(LoginViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public LoginViewModel Atualizar(LoginViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _loginService.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Remover(LoginViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public LoginViewModel RetornarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LoginViewModel> RetornarTodos()
        {
            throw new System.NotImplementedException();
        }

        public LoginViewModel Verificar(LoginViewModel obj)
        {
            var login = Mapper.Map<Login>(obj);

            return Mapper.Map<LoginViewModel>(_loginService.Verificar(login));
        }
    }
}
