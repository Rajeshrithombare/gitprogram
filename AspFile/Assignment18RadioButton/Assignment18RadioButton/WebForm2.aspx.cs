using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment18RadioButton
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            double ans = 0;
            if(RadioButton1.Checked)
            {
                cnt = cnt + 1;
                if(cnt<2)
                {
                    ans = ans - 0.5;
                }
                else
                {
                    Label4.Text = "Select any One";
                }
            }
            if(RadioButton2.Checked)
            {
                cnt = cnt + 1;
                if(cnt<2)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label4.Text = "Select any one";
                }
            }
            if (RadioButton3.Checked)
            {
                cnt1 = cnt1 + 1;
                if (cnt1 < 2)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label4.Text = "Select any one";
                }
            }
            if (RadioButton4.Checked)
            {
                cnt1 = cnt1 + 1;
                if (cnt1 < 2)
                {
                    ans = ans - 0.5;
                }
                else
                {
                    Label4.Text = "Select any one";
                }
            }
            if (RadioButton5.Checked)
            {
                cnt2 = cnt2 + 1;
                if (cnt2 < 2)
                {
                    ans = ans + 0.5;
                }
                else
                {
                    Label4.Text = "Select any one";
                }
            }
            if (RadioButton6.Checked)
            {
                cnt2 = cnt2 + 1;
                if (cnt2 < 2)
                {
                    ans = ans - 0.5;
                }
                else
                {
                    Label4.Text = "Select any one";
                }
            }
            if(cnt<2&&cnt1<2&&cnt2<2)
            {
                Label4.Text = "Result out of two is= " + ans;
            }
        }
    }
}