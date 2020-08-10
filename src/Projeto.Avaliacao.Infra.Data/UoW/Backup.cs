using Projeto.Avaliacao.Infra.Data.Context;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using System;
using System.Data.Entity;

namespace Projeto.Avaliacao.Infra.Data.UoW
{
    public class Backup : IBackup
    {
        private readonly PrincipalDbContext _context;


        public Backup(PrincipalDbContext context)
        {
            _context = context;
        }

        public void RealizarBackup()
        {
            string dbname = _context.Database.Connection.Database;
            string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = N'{1}' WITH NOFORMAT, NOINIT,  NAME = N'MyAir-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            _context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, "Auxiliar.bak"));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
