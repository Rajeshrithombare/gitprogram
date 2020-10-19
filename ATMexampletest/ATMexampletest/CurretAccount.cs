using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ATMexampletest
{
    public class CurretAccount
    {
        public string Name { get; set; }
        public string AcountNo { get; set; }

        public string PinNo { get; set; }
        public string CPinno { get; set; }

        
        
        SqlConnection con;


        public CurretAccount()
        {
            //string conne = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            // SqlConnection con = new SqlConnection(conne);
            con = new SqlConnection("data source=DESKTOP-6RGINGV\\SQLEXPRESS;Integrated security=true;database=TestDatabase");
        }
       
        public string Save(string name,string ano,string pin)
        {
           // Console.WriteLine("ghsfd");

            string res=" ";
            try
            {
                con.Open();
                string qr = "insert into BankTable (Name,AcountNo,PinCode)values('" + Name + "','" + AcountNo + "','" + PinNo + "')";
                SqlCommand com = new SqlCommand(qr, con);
                com.ExecuteNonQuery();
                res = "Pin Genrated Successfully";
                

            }
            catch(Exception ee)
            {
                ee.ToString();
            }
            finally
            {
                con.Close();
            }


            return res;

        }
        




    }
}