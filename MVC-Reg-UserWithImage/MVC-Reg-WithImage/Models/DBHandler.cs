using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MVC_Reg_UserExample.Models
{
    public class DBHandler
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            con = new SqlConnection(constring);
        }


        //Insert Item 

        /* public bool InsertItem(UserClass uc)
         {
             Connection();
             string query = "insert into MyMvc2 (UserName,Email_id,Password,Gender)values('" + uc.UserName + "','" + uc.Email_id + "','" + uc.Password + "','"+ uc.Gender + "')";
             SqlCommand cmd = new SqlCommand(query, con);
             con.Open();
             int i = cmd.ExecuteNonQuery();
             con.Close();
             if (i >= 1)
                 return true;
             else
                 return false;

         }*/

        //Isert item

       /* public bool InsertItem(UserClass oImage, HttpPostedFileBase image1)
        {

            
            Connection();

            if (image1 != null)
            {
                oImage.UserImage = new byte[image1.ContentLength];
                image1.InputStream.Read(oImage.UserImage, 0, image1.ContentLength);
            }
            con.Open();

           // string query = "insert into MyMvc2 (UserName,Email_id,Password,Gender)values('" + uc.UserName + "','" + uc.Email_id + "','" + uc.Password + "','" + uc.Gender + "')";
            string qer = "insert into BinaryImage(UserName,Email_id,Password,Gender,UserImage) values('" + oImage.UserName + "','" + oImage.Email_id + "','" + oImage.Password + "','" + oImage.Gender + "','"+ oImage.UserImage+"')";
            SqlCommand cmd = new SqlCommand(qer, con);
            //con.Open();
           int i= cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
            //return oImage;

        }*/

            //Show List 

        /* public List<UserClass> GetItemList()
         {
            Connection();
            List<UserClass> ilist = new List<UserClass>();
            string query1 = "select UserName, Email_id, Password, Gender from BinaryImage";
            SqlCommand com1 = new SqlCommand(query1, con);
            SqlDataAdapter da = new SqlDataAdapter(com1);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                ilist.Add(new UserClass
                {

                    UserName=Convert.ToString(dr["UserName"]),
                    Email_id=Convert.ToString(dr["Email_id"]),
                    Password=Convert.ToString(dr["Password"]),
                    Gender=Convert.ToString(dr["Gender"]),
                });
            }
            return ilist;
         }*/


        //Update Records

        public bool UpodateItem(UserClass uc2)
        {
            Connection();
            string query= "update BinaryImage set Email_id='" + uc2.Email_id+"',Password='"+uc2.Password+"',Gender='"+uc2.Gender+"' where UserName='"+uc2.UserName+"'";
            SqlCommand com2 = new SqlCommand(query, con);
            con.Open();
            int i = com2.ExecuteNonQuery();
            con.Close();
            if(i>=1)
                return true;
            else
                return false;
            

        }




        //Delete Record




        public bool DeleteItem(string UserName)
        {
            Connection();
            string query3 = "delete from BinaryImage where UserName='" + UserName+"'";
            SqlCommand comm = new SqlCommand(query3, con);
            con.Open();
            int i = comm.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }
      
    }
}