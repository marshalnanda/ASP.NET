using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.master_pages
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public TextBox TextBoxOnMasterPage
        {
            get
            {
                // Return the textbox on the master page
                return this.txtBoxOnMasterPage;
            }
        }
        public Panel SearchPanel
        {
            get
            {
                return panelSearch;
            }
        }

        public string SearchTerm
        {
            get
            {
                return txtSerach.Text;
            }
        }

        public Button SearchButton
        {
            get
            {
                return btnSearch;
            }
        }
    }
}