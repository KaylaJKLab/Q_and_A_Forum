﻿using System.Web;
using System.Web.Mvc;

namespace Q_and_A_Forum
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
