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
    public partial class BookEntryRegistration : System.Web.UI.Page
    {

        string conct = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string bn = TextBox1.Text;
            string mrp = TextBox2.Text;
            string author = DropDownList1.SelectedValue;
            string category = DropDownList2.SelectedValue;
            string publisher = DropDownList3.SelectedValue;
            SqlConnection con = new SqlConnection(conct);
            try
            {
                con.Open();
                string query = "insert into BookStore(Book_Name,Mrp,Author,Category,Publisher) values('" + bn + "','" + mrp + "','" + author + "','" + category + "','" + publisher + "')";
                SqlCommand com = new SqlCommand(query,con);
                com.ExecuteNonQuery();
                Label1.Text = "Book Added Successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.Text="";
                DropDownList2.SelectedValue = "";
                DropDownList3.SelectedValue = "";

            }
            catch(Exception ee)
            {
                Label1.Text =ee.ToString();
                
                
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Session.Abandon();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}