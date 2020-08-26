using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Series.aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            int i = Convert.ToInt32(TextBox1.Text);
            for(  i=0;i<60;i=i+3)
            {
                Label2.Text = "Series is:= " + i;
            }
        }
    }
}