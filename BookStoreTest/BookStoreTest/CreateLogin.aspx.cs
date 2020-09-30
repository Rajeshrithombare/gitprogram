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
    public partial class CreateLogin : System.Web.UI.Page
    {

        string connec = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(connec);
            string Username = TextBox1.Text;
            string Pass = TextBox2.Text;
            //string cpas = TextBox3.Text;
            try
            {
                con1.Open();
                //int i=0;

                string qr1 = "select count(*) from Logintable where User_Name='" + Username+"'";
                SqlCommand com2 = new SqlCommand(qr1, con1);
                //string res;

                //int i=com1.ExecuteNonQuery();
                int i = Convert.ToInt32(com2.ExecuteScalar());


                if(i==0)
                {
                    string qr = "insert into Logintable(User_Name,Password)values('" + Username + "','" + Pass + "')";
                    SqlCommand com1 = new SqlCommand(qr, con1);
                    com1.ExecuteNonQuery();

                    Label1.Text="Login Created Successfully";

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
                else
                {
                    Label1.Text = "This User Name Allready exist please select anather ";
                }
                    
                
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();

            }
            finally
            {
                con1.Close();
            }
        }
    }
}