using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Caching
{
    public partial class Controlling__caching_through_code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //<%@ OutputCache Duration="60" VaryByParam="None" Location="Server" %> equivalent to
            Label1.Text = "This page is cached by the server @ " + DateTime.Now.ToString();
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
            Response.Cache.VaryByParams["None"] = true;
            Response.Cache.SetCacheability(HttpCacheability.Server);
        }
    }
}