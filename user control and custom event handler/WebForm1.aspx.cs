using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.user_control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalendarUserControl1.CalendarVisibilityChanged += new CalendarVisibilityChangedEventHandler(CalendarUserControl1_CalendarVisibilityChanged); //+=  means register event handler 
            //CalendarUserControl1.CalendarVisibilityChanged -= new CalendarVisibilityChangedEventHandler(CalendarUserControl1_CalendarVisibilityChanged); //-=  means inregister event handler 

        }

        private void CalendarUserControl1_CalendarVisibilityChanged(object sender, CalendarVisibilityChangedEventArgs e)
        {
            //throw new NotImplementedException();
            Response.Write("Calendar Visible = " + e.IsCalendarVisible.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(CalendarUserControl1.SelectedDate);
        }
    }
}