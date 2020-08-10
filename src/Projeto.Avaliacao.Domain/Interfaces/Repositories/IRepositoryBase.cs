﻿using Projeto.Avaliacao.Domain.DTO;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity RetornarPorId(int id);
        IEnumerable<TEntity> RetornarTodos();        
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}