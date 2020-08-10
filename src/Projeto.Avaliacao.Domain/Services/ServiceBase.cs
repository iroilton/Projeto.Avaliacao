using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Adicionar(TEntity obj)
        {
            return _repository.Adicionar(obj);
        }

        public TEntity RetornarPorId(int id)
        {
            return _repository.RetornarPorId(id);
        }

        public IEnumerable<TEntity> RetornarTodos()
        {
            return _repository.RetornarTodos();
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Remover(TEntity obj)
        {
            _repository.Remover(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
