using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private readonly IUnitOfWork _uow;

        public AppServiceBase(IServiceBase<TEntity> serviceBase, IUnitOfWork uow)
        {
            _serviceBase = serviceBase;
            _uow = uow;
        }

        public void Adicionar(TEntity obj)
        {
            _serviceBase.Adicionar(obj);
        }

        public TEntity RetornarPorId(int id)
        {
            return _serviceBase.RetornarPorId(id);
        }

        public IEnumerable<TEntity> RetornarTodos()
        {
            return _serviceBase.RetornarTodos();
        }

        public void Atualizar(TEntity obj)
        {
            _serviceBase.Atualizar(obj);
        }

        public void Remover(TEntity obj)
        {
            _serviceBase.Remover(obj);
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
