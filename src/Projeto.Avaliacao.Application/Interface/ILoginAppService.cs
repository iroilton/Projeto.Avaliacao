using DomainValidation.Validation;
using Projeto.Avaliacao.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Application.Interface
{
    public interface ILoginAppService : IDisposable
    {
        LoginViewModel Adicionar(LoginViewModel obj);
        LoginViewModel RetornarPorId(int id);
        IEnumerable<LoginViewModel> RetornarTodos();
        LoginViewModel Atualizar(LoginViewModel obj);
        void Remover(LoginViewModel obj);
        LoginViewModel Verificar(LoginViewModel obj);
    }
}
