using Projeto.Avaliacao.Infra.Data.Context;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using System;

namespace Projeto.Avaliacao.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrincipalDbContext _context;
        private bool _disposed;

        public UnitOfWork(PrincipalDbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
