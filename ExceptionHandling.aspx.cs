using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ExceptionHandling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("Countries.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            // Catch specific exceptions first
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
                //Log the exception information
                lblError.Text = "Access to the file denied";
            }
            catch (System.IO.FileNotFoundException fileNotFoundException)
            {
                //Log the exception information
                lblError.Text = "File does not exist";
            }
            catch (Exception ex)
            {
                //Log the exception information
                lblError.Text = "There is an unkown problem. IT team is working on this issue. Please check back after some time";
            }
            finally
            {
                // Code to clean up resources like closing file handles
                // and database connection objects
            }
        }
    }
}