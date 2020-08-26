using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLoad19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
                arrayList.Add("four");
                arrayList.Add("five");
                arrayList.Add("six");
                DropDownList1.DataSource = arrayList;
                DropDownList1.DataBind();
            
            }
        }
    }
}