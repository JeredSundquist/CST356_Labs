using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MyAppApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Jered\source\repos\CST356_Labs\[CST356] - Lab9\[CST356] - Lab4\App_Data");
        }
    }
}
