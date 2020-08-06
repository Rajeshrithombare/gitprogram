using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentRegistration
{


    public partial class ShowRegDetailes : System.Web.UI.Page
    {


        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter("select * from MyNewRegister2", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "MyNewRegister2");
            Response.Write("<h1 align=center>Welcome to Student Dashboard</h1> ");
            Response.Write("<h1 align=center>Detailes of Registration Are</h1><hr>");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<tr>");
            //Response.Write("<th>User Id</th>");
            Response.Write("<th>First Name</th>");
            Response.Write("<th>Middle Name</th>");
            Response.Write("<th>Last Name</th>");
            Response.Write("<th>Gender</th>");
            Response.Write("<th>Date Of Birth</th>");
            Response.Write("<th>Email Id</th>");
            Response.Write("<th>Mobile No</th>");
            Response.Write("<th>Cource</th>");
            Response.Write("<th>Address</th>");
            Response.Write("<th>Country</th>");
            Response.Write("<th>City</th>");
            Response.Write("<th>State</th>");
            Response.Write("<tr>");
            foreach(DataRow dr in ds.Tables["MyNewRegister2"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["First_Name"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Middle_Name"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Last_Name"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Gender"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Date_of_birth"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Emaile"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Mobile"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Cource"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Address"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["Country"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["City"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["State"].ToString());
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*StudRegister stu = new StudRegister();
            SqlConnection con1 = new SqlConnection("data source=DESKTOP-6RGINGV\\SQLEXPRESS;integrated security=true;database=MyDB");
            
            SqlDataAdapter da = new SqlDataAdapter("update MyNewRegister2 set First_Name='Rashi',Middle_Name='Shankar',Last_Name='Thombare',Gender='Female',Date_of_birth='1997-11-26',Mobile='4546575474',Cource='Python',Address='Zinga bai takli faras',Country='India',City='Bhopal',State='MP' where Emaile='raj@gmail.com'", con1);
            DataSet ds = new DataSet();
            da.Fill(ds, "MyNewRegister2");*/

        }
    }
}