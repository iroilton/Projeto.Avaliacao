using Projeto.Avaliacao.Application.AutoMapper;
using System.Web.Http;

namespace Projeto.Avaliacao.Services.REST.UsuarioAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
