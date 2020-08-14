using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcRegistration.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            con = new SqlConnection(constring);
        }

        //Insert item Query

        public bool InsertItem(ItemModel iList)
        {
            Connection();
            string query = "insert into MvcRegister5 (First_name,Middle_name,Last_name,Gender,Date_Of_Birth,City,State,Address,Adhar_no)values('" + iList.First_name + "','" + iList.Middle_name + "','" + iList.Last_name + "','" + iList.Gender + "','" + iList.Date_Of_Birth + "','" + iList.City + "','" + iList.State + "','" + iList.Address + "','" + iList.Adhar_no + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}