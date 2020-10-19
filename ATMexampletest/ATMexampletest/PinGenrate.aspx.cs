using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATMexampletest
{
    public partial class PinGenrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CurretAccount ca = new CurretAccount();

            string nm = TextBox1.Text;
            string ano = TextBox2.Text;
            string pin = TextBox3.Text;
            string result;
            result=ca.Save(nm,ano,pin);

            Label1.Text = result;
        }
    }
}