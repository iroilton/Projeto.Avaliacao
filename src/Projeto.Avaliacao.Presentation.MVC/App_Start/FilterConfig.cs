﻿using SimpleInjector;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Avaliacao.Presentation.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
