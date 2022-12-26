﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RadioButtonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // If the user has made a choice
            if (ColorRadioButtonList.SelectedIndex != -1)
            {
                Response.Write("Text = " + ColorRadioButtonList.SelectedItem.Text + "<br/>");
                Response.Write("Value = " + ColorRadioButtonList.SelectedItem.Value + "<br/>");
                Response.Write("Index = " + ColorRadioButtonList.SelectedIndex.ToString());
            }
            // If the user has not selected anything
            else
            {
                Response.Write("Please select your favourite color");
            }
        }

        protected void btnClearSelection_Click(object sender, EventArgs e)
        {
            ColorRadioButtonList.SelectedIndex = -1;
        }
    }
}