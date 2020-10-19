using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ATMexampletest
{
    
    public partial class Withordepo : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // CurretAccount ca = new CurretAccount();
            //ca.Save();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PinGenrate.aspx");
        }
    }
}