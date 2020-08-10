using Projeto.Avaliacao.Application.ViewModels;
using Projeto.Avaliacao.Presentation.MVC.Connectiors;
using Projeto.Avaliacao.Presentation.MVC.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Projeto.Avaliacao.Presentation.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public async Task<ActionResult> Index(PagedViewModel<UsuarioViewModel> usuario)
        {
            using (WebApiConnect connect = new WebApiConnect())
            {
                var result = await connect.BuscarUsuariosPaginado(new RequestPaginationViewModel<UsuarioViewModel>() { Filtro = usuario.Filtro, PageNumber = usuario.PageNumber == 0 ? 1 : usuario.PageNumber });

                ViewBag.TotalCount = result.Count;
                ViewBag.PageNumber = result.PageNumber;
                ViewBag.PageSize = usuario.PageSize;
                ViewBag.Filtro = result.Filtro;

                return View(result);
            }
        }

        public ActionResult PesquisarUsuario()
        {
            return View();
        }

        public async Task<ActionResult> DeletarUsuario(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (WebApiConnect connect = new WebApiConnect())
            {
                var usuario = await connect.RetornarPorId(id);

                if (usuario == null)
                {
                    return HttpNotFound();
                }

                return View(usuario);
            }
        }

        [HttpPost, ActionName("DeletarUsuario")]
        [ValidateAntiForgeryToken]
        [BackupFilter]
        public async Task<ActionResult> DeletarUsuarioConfirmado(int id)
        {
            using (WebApiConnect connect = new WebApiConnect())
            {
                var usuario = await connect.RetornarPorId(id);
                var confirm = await connect.RemoverUsuario(usuario);

                if (usuario == null)
                {
                    return HttpNotFound();
                }

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<ActionResult> CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        [BackupFilter]
        public async Task<ActionResult> CadastrarUsuario(UsuarioLoginTelefoneViewModel request)
        {
            if (ModelState.IsValid)
            {
                using (WebApiConnect connect = new WebApiConnect())
                {
                    var usuario = await connect.AdicionarUsuario(request);

                    if (!usuario.ValidationResult.IsValid)
                    {
                        foreach (var erro in usuario.ValidationResult.Erros)
                        {
                            ModelState.AddModelError(string.Empty, erro.Message);
                        }

                        return View(usuario);
                    }
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult ExcluirTodosUsuarios()
        {
            return View();
        }

        [HttpPost, ActionName("ExcluirTodosUsuarios")]
        [ValidateAntiForgeryToken]
        [BackupFilter]
        public async Task<ActionResult> ExcluirTodosUsuariosConfirmado()
        {
            using (WebApiConnect connect = new WebApiConnect())
            {
                var confirm = await connect.ExcluirTodosUsuarios();

                return RedirectToAction("Index");
            }
        }

        public async Task<ActionResult> Alterar(int id)
        {
            using (WebApiConnect connect = new WebApiConnect())
            {
                var usuario = await connect.RetornarPorId(id);

                return View(usuario);
            }
            
        }

        public async Task<ActionResult> AlterarConfirmado(UsuarioLoginTelefoneViewModel obj)
        {
            using (WebApiConnect connect = new WebApiConnect())
            {
                var usuario = await connect.AtualizarUsuario(obj);

                return View(usuario);
            }

        }
    }
}