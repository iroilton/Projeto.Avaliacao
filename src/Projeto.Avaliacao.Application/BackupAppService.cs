using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Infra.Data.Interfaces;

namespace Projeto.Avaliacao.Application
{
    public class BackupAppService : IBackupAppService
    {
        private readonly IBackup _backup;
        
        public BackupAppService(IBackup backup)
        {
            _backup = backup;
        }

        public void RealizarBackup()
        {
            _backup.RealizarBackup();
        }
    }
}
