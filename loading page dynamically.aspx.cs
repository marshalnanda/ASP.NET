﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class loading_page_dynamically : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox TB = new TextBox();
            TB.ID = "TB1";
            PlaceHolder1.Controls.Add(TB);
            TB.Visible = false;

            DropDownList DDL = new DropDownList();
            DDL.ID = "DDL1";
            DDL.Items.Add("New York");
            DDL.Items.Add("New Jersey");
            DDL.Items.Add("Washington DC");
            PlaceHolder1.Controls.Add(DDL);
            DDL.Visible = false;

            if (DropDownList1.SelectedValue == "TB")
            {
                TB.Visible = true;
            }
            else if (DropDownList1.SelectedValue == "DDL")
            {
                DDL.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "TB")
            {
                Response.Write(((TextBox)PlaceHolder1.FindControl("TB1")).Text);
            }
            else if (DropDownList1.SelectedValue == "DDL")
            {
                Response.Write(((DropDownList)PlaceHolder1.FindControl("DDL1")).SelectedItem.Text);
            }
        }
    }
}