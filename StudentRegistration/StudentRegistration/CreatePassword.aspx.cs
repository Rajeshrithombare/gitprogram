using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace StudentRegistration
{
    public partial class Login : System.Web.UI.Page
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
                string eml = TextBox1.Text;
               // string pas = TextBox2.Text;
                string pas = EncodePasswordToBase64(TextBox2.Text);
                string rr = "select count(*) from CreatePassword where Emaile='" + eml + "'";
                SqlCommand com1 = new SqlCommand(rr, con);
                
                int r = Convert.ToInt32(com1.ExecuteScalar());

                if (r == 0)
                {
                    string query = "insert into CreatePassword(Emaile,Password)values('" + eml + "','" + pas + "')";
                    SqlCommand com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                    Label1.Text = "Password is Created Successfully";
                }
                else
                {
                    Label1.Text = "Password is allready set for this email";
                }
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            Response.Redirect("Login.aspx");


        }
    }
}