using Projeto.Avaliacao.Application;
using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using Projeto.Avaliacao.Domain.Services;
using Projeto.Avaliacao.Infra.Data.Context;
using Projeto.Avaliacao.Infra.Data.Interfaces;
using Projeto.Avaliacao.Infra.Data.Repositories;
using Projeto.Avaliacao.Infra.Data.UoW;
using SimpleInjector;

namespace Projeto.Avaliacao.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // App
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<ILoginAppService, LoginAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<ILoginService, LoginService>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<ILoginRepository, LoginRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<IBackup, Backup>(Lifestyle.Scoped);
            container.Register<PrincipalDbContext>(Lifestyle.Scoped);


        }
    }
}
