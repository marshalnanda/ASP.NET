using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Techniques_to_send_data_from_one_webform_to_another.application_state
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Main code in global.asax file
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["UsersOnline"] != null)
            {
                Response.Write("Number of Users Online = " +
                    Application["UsersOnline"].ToString());
            }
        }
    }
}