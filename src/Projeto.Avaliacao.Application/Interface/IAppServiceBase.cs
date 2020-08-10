using System.Collections.Generic;

namespace Projeto.Avaliacao.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity RetornarPorId(int id);
        IEnumerable<TEntity> RetornarTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
