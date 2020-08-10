using Projeto.Avaliacao.Application;
using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Infra.Data.Context;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using Projeto.Avaliacao.Infra.Data.UoW;
using SimpleInjector;

namespace Projeto.Avaliacao.CrossCutting.IoC
{
    public class BootStrapperBackup
    {
        public static void RegisterServices(Container container)
        {
            // App
            container.Register<IBackupAppService, BackupAppService>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<IBackup, Backup>(Lifestyle.Scoped);
            container.Register<PrincipalDbContext>(Lifestyle.Scoped);


        }
    }
}
