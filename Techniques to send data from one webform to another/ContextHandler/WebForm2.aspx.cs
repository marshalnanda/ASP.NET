using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Techniques_to_send_data_from_one_webform_to_another.ContextHandler
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page lastpage = (Page)Context.Handler;
                if (lastpage is WebForm1)
                {
                    //Use FindControl() if public properties does not exist on the 
                    //previous page(WebForm1). FindControl() may cause 
                    //NullRefernceExceptions due to mis-spelled conrol Id's

                    //lblName.Text = ((TextBox)lastpage.FindControl("txtName")).Text;
                    //lblEmail.Text = ((TextBox)lastpage.FindControl("txtEmail")).Text;

                    //Using public properties can eliminate NullRefernceExceptions 
                    lblName.Text = ((WebForm1)lastpage).Name;
                    lblEmail.Text = ((WebForm1)lastpage).Email;
                }
            }
        }
    }
}