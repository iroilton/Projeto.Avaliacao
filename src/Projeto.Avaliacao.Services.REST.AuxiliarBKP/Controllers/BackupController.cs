using Projeto.Avaliacao.Application.Interface;
using System.Web.Http;

namespace Projeto.Avaliacao.Services.REST.AuxiliarBKP.Controllers
{
    public class BackupController : ApiController
    {
        private readonly IBackupAppService _backupAppService;

        public BackupController(IBackupAppService backupAppService)
        {
            _backupAppService = backupAppService;
        }

        [HttpGet]
        public void RealizarBackup()
        {
            _backupAppService.RealizarBackup();
        }

    }
}
