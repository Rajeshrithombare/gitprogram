using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace StudentRegistration
{

    public partial class UpdateRecord : System.Web.UI.Page
    {
        //StudRegister s = new StudRegister();
        
       static string consting = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection con = new SqlConnection(consting);

        protected void Page_Load(object sender, EventArgs e)
        {
          if(!IsPostBack)
            {
                Show();
            }
        }

        public void Show()
        {

            string query = "select User_id,First_Name,Middle_Name,Last_Name,Gender,Date_of_birth,Emaile,Mobile,Cource,Address,Country,City,State from MyNewRegister2";

           // string query = "select * from MyNewRegister2";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // string eml =GridView1.DataKeys[e.RowIndex].Values["Emaile"].ToString();

            /* int eml= Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["User_id"]);
             //Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
             SqlCommand cmd = new SqlCommand("delete from MyNewRegister2 where @User_id='"+eml+"'",con);

            // SqlCommand cmd = new SqlCommand("delete from MyNewRegister2 where @User_id=",con);

             cmd.Parameters.AddWithValue("@User_id", eml);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();
             GridView1.EditIndex = -1;
             Show();*/

            string Emaile = Convert.ToString(GridView1.DataKeys[e.RowIndex].Values["Emaile"].ToString());
            SqlCommand cmd = new SqlCommand("delete from MyNewRegister2 where Emaile=@Emaile", con);
            cmd.Parameters.AddWithValue("@Emaile", Emaile);
            con.Open();
            cmd.ExecuteNonQuery();
            Show();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Show();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["User_id"].ToString());
            Label txtid = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            //string id = GridView1.DataKeys[e.RowIndex].Values["Emaile"].ToString();

            TextBox txtfname = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox txtmname = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox txtlname = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox txtgen = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox txtdob = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox txteml = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox txtmob = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
            TextBox txtcour = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;
            TextBox txtadd = GridView1.Rows[e.RowIndex].FindControl("TextBox9") as TextBox;
            TextBox txtcont = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
            TextBox txtcity = GridView1.Rows[e.RowIndex].FindControl("TextBox11") as TextBox;
            TextBox txtsta = GridView1.Rows[e.RowIndex].FindControl("TextBox12") as TextBox;
            
              SqlCommand cmd = new SqlCommand("update MyNewRegister2 set First_Name=@First_Name,Middle_Name=@Middle_Name,Last_Name=@Last_Name,Gender=@Gender,Date_of_birth=@Date_of_birth,Mobile=@Mobile,Cource=@Cource,Address=@Address,Country=@Country,City=@City,State=@State where Emaile=@Emaile", con);
            //SqlCommand cmd = new SqlCommand("update MyNewRegister2 set Middle_Name=@Middle_Name,Last_Name=@Last_Name,Gender=@Gender,Date_of_birth=@Date_of_birth,Emaile=@Emaile,Mobile=@Mobile,Cource=@Cource,Address=@Address,Country=@Country,City=@City,State=@State where First_Name=@id", con);
            cmd.Parameters.AddWithValue("@User_id", txtid.Text);
            cmd.Parameters.AddWithValue("@First_Name", txtfname.Text);
            cmd.Parameters.AddWithValue("@Middle_Name", txtmname.Text);
            cmd.Parameters.AddWithValue("@Last_Name", txtlname.Text);
            cmd.Parameters.AddWithValue("@Gender", txtgen.Text);
            cmd.Parameters.AddWithValue("@Date_of_birth", txtdob.Text);
            cmd.Parameters.AddWithValue("@Emaile", txteml.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtmob.Text);
            cmd.Parameters.AddWithValue("@Cource", txtcour.Text);
            cmd.Parameters.AddWithValue("@Address", txtadd.Text);
            cmd.Parameters.AddWithValue("@Country", txtcont.Text);
            cmd.Parameters.AddWithValue("@City", txtcity.Text);
            cmd.Parameters.AddWithValue("@State", txtsta.Text);
            //cmd.Parameters.AddWithValue("@id",txtid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            Show();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Show();
        }
    }
}