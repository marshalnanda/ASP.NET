using System;
using System.Web.Security;

namespace WebApplication1.Authentication.From_Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txtUserName.Text, txtPassword.Text))
            {
                // Create the authentication cookie and redirect the user to welcome page
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, CheckBox1.Checked);
            }
            else
            {
                Label1.Text = "Invalid UserName and/or password";
            }
        }
    }
}