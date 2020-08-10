using Projeto.Avaliacao.Presentation.MVC.Connectiors;
using System.Web.Mvc;

namespace Projeto.Avaliacao.Presentation.MVC.Filters
{
    public class BackupFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Response.StatusCode == 200)
            {
                using (WebApiBackupConnect connect = new WebApiBackupConnect())
                {
                    var result = connect.RealizarBackup();
                }
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}
