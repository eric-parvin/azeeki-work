using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ValidateMyInsurance
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex is ThreadAbortException)
                return;

            //Log the exception
            Utility.ExceptionOutFile(ex);

            //If the inner exception is Maximum request lenght then send to the file large page
            if(ex.InnerException.Message == "Maximum request length exceeded.")
            {
                Response.Redirect("LargeFile.html");
            }
            else
            {
                Response.Redirect("Oops.html");
            } 
            
        }
    }
}