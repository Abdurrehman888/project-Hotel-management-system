using hotel_managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace hotel_managment
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var functions = new Functions(); // You might need to change this depending on how your Models.Functions class is constructed.
            HttpContext.Current.Application["Functions"] = functions;
        }

    }
}