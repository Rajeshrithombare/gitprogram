using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SwitchDay.aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(TextBox1.Text);
            switch(day)
            {
                case 1:
                    Label2.Text = "Sunday";
                    break;
                case 2:
                    Label2.Text = "Monday";
                    break;
                case 3:
                    Label2.Text = "Tuseday";
                    break;
                case 4:
                    Label2.Text = "Wednsday";
                    break;
                case 5:
                    Label2.Text = "Thusday";
                    break;
                case 6:
                    Label2.Text = "Friday";
                    break;
                case 7:
                    Label2.Text = "Satarday";
                    break;

            }
        }
    }
}