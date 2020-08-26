using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Radiobutton.aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(TextBox1.Text);
            int amt = Convert.ToInt32(TextBox2.Text);
            int bal = 1000;
            if(RadioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(RadioButton2.Checked)
            {
                bal = bal - amt;
            }
            Label3.Text = "Balance for Account Number " + actno + "is" + bal.ToString();
        }
    }
}