using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

namespace StudentRegistration
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-6RGINGV\\SQLEXPRESS;integrated security=true;database=MyDB");
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string emle = TextBox1.Text;
                // string pasw = TextBox2.Text;
                string pasw = EncodePasswordToBase64(TextBox2.Text);
                string query = "select count(*) from CreatePassword where Emaile='" + emle + "'and Password='" + pasw + "'";
                SqlCommand com = new SqlCommand(query, con);
                int r = Convert.ToInt32(com.ExecuteScalar());
                string res="";
                if(r==1)
                {
                    //string query1 = "select count(*) from CreatePassword where Emaile='" + emle + "'and Password='" + pasw + "'";
                    //SqlCommand com1 = new SqlCommand(query, con);
                    res = Convert.ToString(com.ExecuteScalar());
                    

                    Label1.Text = "Login Successfull";
                    

                }
                else
                {
                    res = "false";
                    Label1.Text = "Invalid Credinshial";
                }
                
            }
            catch(Exception ee)
            {
               Label1.Text= ee.ToString();
            }
            finally
            {
                con.Close();
            }
            Response.Redirect("ShowRegDetailes.aspx");
        }
    }
}