﻿using System.Web;
using System.Web.Mvc;

namespace COM2007_S2016_Lesson8B
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
