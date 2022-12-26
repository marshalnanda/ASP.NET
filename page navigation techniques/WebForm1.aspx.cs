using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.page_navigation_techniques
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            //Send the user to webform2 using Server.Transfer
            //Set the boolean parameter preserveForm=true
            //This ensures that the posted form values can be retrieved
            //Since the default value for this parameter is true, the 
            //form values are preserved, even if this parameter is not used.
            Server.Transfer("WebForm2.aspx", true);
        }
        protected void btnTransferToExternalWebsite_Click(object sender, EventArgs e)
        {
            //Transfer to websites/pages on a different web server causes
            //runtime error
            Server.Transfer("http://pragimtech.com/home.aspx");
        }
    }
}