using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FilemanagerMvcDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /*記得這邊要Registration Area，否則元件也不會用*/
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}