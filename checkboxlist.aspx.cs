using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class checkboxlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in checkboxListEducation.Items)
            {
                // If the list item is selected
                if (li.Selected)
                {
                    // Retrieve the text of the selected list item
                    Response.Write("Text = " + li.Text + ", ");
                    // Retrieve the value of the selected list item
                    Response.Write("Value = " + li.Value + ", ");
                    // Retrieve the index of the selected list item
                    Response.Write("Index = " + checkboxListEducation.Items.IndexOf(li).ToString());
                    Response.Write("<br/>");
                }
            }
        }

        protected void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in checkboxListEducation.Items)
            {
                li.Selected = true;
            }
        }
        protected void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in checkboxListEducation.Items)
            {
                li.Selected = false;
            }
        }
    }
}