using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Globalization;
using System.Data.SqlClient;

namespace StudentRegistration
{
    public partial class StudRegister : System.Web.UI.Page
    {

       
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Button2_Click(object sender, EventArgs e)
        {
           

        }
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
      
        //SqlConnection con2 = new SqlConnection("data source=DESKTOP-6RGINGV\\SQLEXPRESS;integrated security=true;database=MyDB");
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);

            try
            {
                con.Open();
                string fn = TextBox1.Text;
                string mn = TextBox2.Text;
                string ln = TextBox3.Text;
                string gen="";
                if(RadioButton1.Checked)
                {
                    gen=RadioButton1.Text;
                }
                else if (RadioButton2.Checked)
                {
                    gen = RadioButton2.Text;
                }
                else if(RadioButton3.Checked)
                {
                    gen = RadioButton3.Text;
                }
                string dob = TextBox4.Text;
                string eml = TextBox6.Text;
               // string pas = TextBox9.Text;
                string mno = TextBox7.Text;
                string cource = CheckBoxList1.Text;
                string Add = TextBox8.Text;
                string cont = DropDownList1.Text;
                string city = DropDownList2.Text;
                string state = DropDownList3.Text;
                string query= "insert into MyNewRegister2(First_Name,Middle_Name,Last_Name,Gender,Date_of_birth,Emaile,Mobile,Cource,Address,Country,City,State)values('" + fn + "','" + mn+ "','" + ln + "','" + gen + "','" + dob + "','" + eml +  "','" + mno + "','" + cource + "','" + Add + "','" + cont+ "','" + city + "','" + state + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                Label1.Text = "Record save";
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            Response.Redirect("CreatePassword.aspx");
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
            DateTime dob = Convert.ToDateTime(TextBox4.Text);
            TextBox9.Text = Convert.ToString(Calculate_age(dob));
            
        }

     

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        public int Calculate_age(DateTime db)
        {

            int age = 0;
            age = DateTime.Now.Subtract(db).Days;
            age = age / 365;
            return age;
        }
       

      
    }
}