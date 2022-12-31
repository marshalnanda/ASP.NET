using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1.Caching
{
    public partial class UCProductsControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("GetProducts", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet DS = new DataSet();
            da.Fill(DS);

            GridView1.DataSource = DS;
            GridView1.DataBind();
        }
    }
}