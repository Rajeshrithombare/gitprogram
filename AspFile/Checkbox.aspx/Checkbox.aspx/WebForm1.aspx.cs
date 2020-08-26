using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkbox.aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int cnt1 = 0;
            double ans = 0;
            if(CheckBox1.Checked)
            {
                cnt = cnt + 1;
                if(cnt<3)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Option";
                }
            }
            if(CheckBox2.Checked)
            {
                cnt = cnt + 1;
                if(cnt<3)
                {
                    ans = ans - 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Option";
                }
            }
            if(CheckBox3.Checked)
            {
                cnt = cnt + 1;
                if(cnt<3)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Options";
                }
            }
            if (CheckBox4.Checked)
            {
                cnt1 = cnt1 + 1;
                if (cnt1 < 3)
                {
                    ans = ans - 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Option";
                }
            }
            if (CheckBox5.Checked)
            {
                cnt1 = cnt1 + 1;
                if (cnt1 < 3)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Option";
                }
            }
            if (CheckBox6.Checked)
            {
                cnt1 = cnt1 + 1;
                if (cnt1 < 3)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label3.Text = "Select Only 2 Options";
                }
            }
            if(cnt<3&& cnt1<3)
            {
                Label3.Text= "Result out of 2 is: " + ans;
            }
        }
    }
}