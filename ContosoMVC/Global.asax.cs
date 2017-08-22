﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContosoMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public void Application_Error(object sender, EventArgs e)
        {
            var exe = Server.GetLastError();
            //Log this error to a text file using log4net.
            //Send the notification to the concerned parties.
            Server.ClearError();

        }
        public void Application_BeginRequest()
        {


        }
    }

}
