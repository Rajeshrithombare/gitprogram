using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStoreTest
{
    public partial class Login : System.Web.UI.Page
    {

        string Connectn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(Connectn);
            //string um = TextBox1.Text;
            Session["um"] = TextBox1.Text;

            //Session ["um"].ToString();

            string pas = TextBox2.Text;
            try
            {
                con2.Open();
                // string qre = "select count(*) from Logintable where User_Name='" + um + "'and Password='" + pas + "'";
                string qre = "select count(*) from Logintable where User_Name='" +Session["um"]+ "'and Password='" + pas + "'";

                SqlCommand com2 = new SqlCommand(qre,con2);
                int i = Convert.ToInt32(com2.ExecuteScalar());
                string res;
               // int i = com2.ExecuteNonQuery();
                if(i==1)
                {
                    Response.Redirect("BookEntryRegistration.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

                TextBox1.Text = "";
                TextBox2.Text = "";          
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con2.Close();
            }
        }
    }
}