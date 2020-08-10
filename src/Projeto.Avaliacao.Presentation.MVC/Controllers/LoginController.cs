using Microsoft.Ajax.Utilities;
using Projeto.Avaliacao.Application.Interface;
using Projeto.Avaliacao.Application.ViewModels;
using System.Net;
using System.Web.Mvc;

namespace Projeto.Avaliacao.Presentation.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginAppService _loginAppService;
        public LoginController(ILoginAppService loginAppService)
        {
            _loginAppService = loginAppService;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verificar(LoginViewModel login)
        {
            if (login == null || login.LoginUsuario.IsNullOrWhiteSpace() || login.Senha.IsNullOrWhiteSpace())
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            login = _loginAppService.Verificar(login);

            if (!login.ValidationResult.IsValid)
            {
                foreach (var erro in login.ValidationResult.Erros)
                {
                    ModelState.AddModelError(string.Empty, erro.Message);
                }

                return View("Index", login);
            }
            
            return RedirectToAction("Index", "Usuario", login);
        }
    }
}