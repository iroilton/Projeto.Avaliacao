using Projeto.Avaliacao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projeto.Avaliacao.Presentation.MVC.Connectiors
{
    public class WebApiConnect : IDisposable
    {
        static HttpClient client;
        public WebApiConnect()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44342/api/Usuarios/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<List<UsuarioViewModel>> GetUsuarios(string uri)
        {
            List<UsuarioViewModel> usuario = null;
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<List<UsuarioViewModel>>();
            }
            return usuario;
        }

        public async Task<HttpStatusCode> Delete(Guid id)
        {
            HttpResponseMessage response = await client.DeleteAsync("Delete/" + id);
            return response.StatusCode;
        }

        public async Task<UsuarioViewModel> Logar(UsuarioViewModel objeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("Logar/", objeto);

            UsuarioViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioViewModel>();
            }

            return usuario;
        }

        public async Task<PagedViewModel<UsuarioViewModel>> BuscarUsuariosPaginado(RequestPaginationViewModel<UsuarioViewModel> objeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("BuscarUsuariosPaginado/", objeto);

            PagedViewModel<UsuarioViewModel> usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<PagedViewModel<UsuarioViewModel>>();
            }

            return usuario;
        }

        public async Task<UsuarioLoginTelefoneViewModel> AdicionarUsuario(UsuarioLoginTelefoneViewModel objeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("AdicionarUsuario/", objeto);

            UsuarioLoginTelefoneViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioLoginTelefoneViewModel>();
            }

            return usuario;
        }
        
        public async Task<UsuarioLoginTelefoneViewModel> RetornarPorId(int id)
        {
            HttpResponseMessage response = await client.GetAsync("RetornarPorId/" + id);

            UsuarioLoginTelefoneViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioLoginTelefoneViewModel>();
            }

            return usuario;
        }

        public async Task<UsuarioLoginTelefoneViewModel> RemoverUsuario(UsuarioLoginTelefoneViewModel objeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("RemoverUsuario/" , objeto);

            UsuarioLoginTelefoneViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioLoginTelefoneViewModel>();
            }

            return usuario;
        }

        public async Task<UsuarioViewModel> ExcluirTodosUsuarios()
        {
            HttpResponseMessage response = await client.GetAsync("ExcluirTodosUsuarios/");

            UsuarioViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioViewModel>();
            }

            return usuario;
        }

        public async Task<UsuarioLoginTelefoneViewModel> AtualizarUsuario(UsuarioLoginTelefoneViewModel objeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("AtualizarUsuario/", objeto);

            UsuarioLoginTelefoneViewModel usuario = null;
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioLoginTelefoneViewModel>();
            }

            return usuario;
        }
    }
}