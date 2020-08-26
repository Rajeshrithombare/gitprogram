using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int i = 1;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                i = i + 1;
                Response.Write("i is= " + i);
            }
            else
            {
                Response.Write("this is else");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int square = num * num;
            Label2.Text = "Square of Number is:= " + square;

        }
    }
}