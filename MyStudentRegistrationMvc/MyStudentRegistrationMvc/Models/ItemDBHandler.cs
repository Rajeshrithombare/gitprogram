using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyStudentRegistrationMvc.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            con = new SqlConnection(constring);
        }

        //Insert Item 

        public bool InsertItem(RegisterModel iList)
        {
            Connection();
            string query = "insert into MyMvc (First_name,Last_name,Address,Emaile,Date,City,Cource,State,Gender,Date_Of_Birth)values('" + iList.First_name + "','" + iList.Last_name + "','" + iList.Address + "','" + iList.Emaile + "','" + iList.Date + "','" + iList.City + "','" + iList.Cource + "','" + iList.State + "','" + iList.Gender + "','" + iList.Date_Of_Birth + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;

        }


        //Show list

        public List<RegisterModel> GetItemList()
        {
            Connection();
            List<RegisterModel> iList = new List<RegisterModel>();

            string query = "SELECT * FROM MyMvc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new RegisterModel
                {
                    First_name = Convert.ToString(dr["First_name"]),
                    Last_name = Convert.ToString(dr["Last_name"]),
                    Address = Convert.ToString(dr["Address"]),
                    Emaile = Convert.ToString(dr["Emaile"]),
                    Date = Convert.ToString(dr["Date"]),
                    City = Convert.ToString(dr["City"]),
                    Cource = Convert.ToString(dr["Cource"]),
                    State = Convert.ToString(dr["State"]),
                    Gender = Convert.ToString(dr["Gender"]),
                    Date_Of_Birth = Convert.ToString(dr["Date_Of_Birth"]),
                });
            }
            return iList;
        }

        //Update Record

        public bool UpdateItem(RegisterModel iList)
        {
            Connection();
            string query = "update MyMvc set Last_name='" + iList.Last_name + "',Address='" + iList.Address + "',Emaile='" + iList.Emaile + "',Date='" + iList.Date + "',City='" + iList.City + "',Cource='" + iList.Cource + "',State='" + iList.State + "',Gender='" + iList.Gender + "',Date_Of_Birth='" + iList.Date_Of_Birth + "'where First_name='"+iList.First_name+"'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }


        public bool DeleteItem(string First_name)
        {
            Connection();
            string query2 = "delete from MyMvc where First_name='"+ First_name+"'";
            SqlCommand comd = new SqlCommand(query2, con);
            con.Open();
            int i=comd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;

            



        }

    }
}