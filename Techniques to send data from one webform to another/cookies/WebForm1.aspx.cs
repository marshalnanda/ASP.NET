using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Techniques_to_send_data_from_one_webform_to_another.cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnSendData_Click(object sender, EventArgs e)
        {
            // Create the cookie object
            HttpCookie cookie = new HttpCookie("UserDetails");
            cookie["Name"] = txtName.Text;
            cookie["Email"] = txtEmail.Text;
            // Cookie will be persisted for 30 days
            cookie.Expires = DateTime.Now.AddDays(30);
            // Add the cookie to the client machine
            Response.Cookies.Add(cookie);

            Response.Redirect("WebForm2.aspx");
        }
    }
}