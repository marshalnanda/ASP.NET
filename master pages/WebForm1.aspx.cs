using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.master_pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
    // Retrieve the master page associated with this content page using
    // Master property and typecast to the actual master page and then
    // reference the property
    ((Site1)Master).TextBoxOnMasterPage.Text = TextBox1.Text;
        }
    }
}