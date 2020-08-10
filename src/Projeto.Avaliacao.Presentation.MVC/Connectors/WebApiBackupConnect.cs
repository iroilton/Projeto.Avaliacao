using Projeto.Avaliacao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projeto.Avaliacao.Presentation.MVC.Connectiors
{
    public class WebApiBackupConnect : IDisposable
    {
        static HttpClient client;
        public WebApiBackupConnect()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44384/api/Backup/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task RealizarBackup()
        {
            HttpResponseMessage response = await client.GetAsync("RealizarBackup/");
        }
    }
}