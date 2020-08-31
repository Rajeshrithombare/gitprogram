using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Mvc_Employee_Registration.Models
{
    public class DBHndlerClass
    {
        public bool InsertItem(UserClass uc)
        {

            string connect = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            string hb = string.Empty;
            foreach (var h in uc.hobbie)
            {
                hb = hb + " " + h.ToString();
            }

            //string querry = "insert into Employee-Registration(EmployeeName,Salary,Address,Email_id,Password,Date_of_join,Hobbies,Gender,State,City)values(@EmployeeName,@Salary,@Address,@Email_id,@Password,@Date_of_join,@Hobbies,@Gender,@State,@City)";
            //string querry = "insert into Employee-Registration (EmployeeName,Salary,Address,Email_id,Password,Date_of_join,Hobbies,Gender,State,City)values('" + uc.EmployeeName + "','" + uc.Salary + "','" + uc.Address + "','" + uc.Email_id + "','" + uc.Password + "','" + uc.Date_of_join + "','" + uc.Hobbies + "','" + uc.Gender + "','" + uc.State + "','" + uc.City + "')";
            con.Open();
            string querry= "insert into EmployeeRegistration (EmployeeName,Salary,Address,Email_id,Password,Date_of_join,Hobbies,Gender,State,City)values('" + uc.EmployeeName + "','" + uc.Salary + "','"+ uc.Address + "','"+uc.Email_id+ "','"+uc.Password+"','"+uc.Date_of_join+"','"+hb+"','"+uc.Gender+"','" + uc.State + "','"+ uc.City + "')";
            SqlCommand command = new SqlCommand(querry, con);
            //con.Open();

            /*command.Parameters.AddWithValue("@EmployeeName", uc.EmployeeName);
            command.Parameters.AddWithValue("@Salary", uc.Salary);
            command.Parameters.AddWithValue("@Address", uc.Address);
            command.Parameters.AddWithValue("@Email_id", uc.Email_id);
            command.Parameters.AddWithValue("@Password", uc.Password);
            command.Parameters.AddWithValue("@Date_of_join", uc.Date_of_join);
            command.Parameters.AddWithValue("@Hobbies", uc.Hobbies);
            command.Parameters.AddWithValue("@Gender", uc.Gender);
            command.Parameters.AddWithValue("@State", uc.State);
            command.Parameters.AddWithValue("@City", uc.City);*/

           
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;

        }
        //Show List
        public List<UserClass> GetItemList()
        {
            string connect2 = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connect2);
            List<UserClass> ilist = new List<UserClass>();
            string que = "select EmployeeName,Salary,Address,Email_id,Password,Date_of_join,Hobbies,Gender,State,City from EmployeeRegistration";
            SqlCommand comm = new SqlCommand(que, con2);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            con2.Open();
            da.Fill(dt);
            con2.Close();
            foreach(DataRow dr in dt.Rows)
            {
                ilist.Add(new UserClass
                {
                    EmployeeName=Convert.ToString(dr["EmployeeName"]),
                    Salary=Convert.ToString(dr["Salary"]),
                    Address=Convert.ToString(dr["Address"]),
                    Email_id=Convert.ToString(dr["Email_id"]),
                    Password=Convert.ToString(dr["Password"]),
                    Date_of_join=Convert.ToString(dr["Date_of_join"]),
                    hobbie=Convert.ToString(dr["Hobbies"]),
                    Gender=Convert.ToString(dr["Gender"]),
                    State=Convert.ToString(dr["State"]),
                    City=Convert.ToString(dr["City"]),

                });
                
            }
            return ilist;


        }

        public bool UpdateItem(UserClass uc1)
        {
            string conn1 = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con1 = new SqlConnection(conn1);
            string q = "update EmployeeRegistration set EmployeeName='" + uc1.EmployeeName + "',Salary='" + uc1.Salary + "',Address='" + uc1.Address + "',Date_of_join='" + uc1.Date_of_join + "',Hobbies='" + uc1.Hobbies + "',Gender='" + uc1.Gender + "',State='" + uc1.State + "',City='" + uc1.City + "'where Email_id='" + uc1.Email_id + "'";
            SqlCommand com1 = new SqlCommand(q, con1);
            con1.Open();
            int i = com1.ExecuteNonQuery();
            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}