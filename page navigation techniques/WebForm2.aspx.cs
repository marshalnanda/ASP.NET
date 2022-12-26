using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.page_navigation_techniques
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the form values from the previous page
            System.Collections.Specialized.NameValueCollection nameValueCollection =Request.Form;

            lblName.Text = nameValueCollection["txtName"];
            lblEmail.Text = nameValueCollection["txtEmail"];

            //Page previousPage = this.Page.PreviousPage;
            //if (previousPage != null)
            //{
            //    TextBox previousPageNameTextBox = (TextBox)previousPage.FindControl("txtName"); //The problem with FindControl() method is that, if you mis-spell the ControlID,  
            //    lblName.Text = previousPageNameTextBox.Text;                                    //we could get a runtime NullRefernceException.

            //    TextBox previousPageEmailTextBox = (TextBox)previousPage.FindControl("txtEmail");
            //    lblEmail.Text = previousPageEmailTextBox.Text;
            //}
        }
    }
}