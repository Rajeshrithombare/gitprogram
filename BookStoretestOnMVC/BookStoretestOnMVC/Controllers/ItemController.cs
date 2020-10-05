using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoretestOnMVC;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BookStoretestOnMVC.Models;
using System.Net.Configuration;

namespace BookStoretestOnMVC.Controllers
{
    public class ItemController : Controller
    {
        string connect = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        // GET: Item
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(BookUserClass obj)
        {
            SqlConnection con = new SqlConnection(connect);

            con.Open();
            string qr = "insert into BookStoreMVC(BookName,Mrp,Author,Category,Publisher)values('" + obj.BookName + "','" + obj.Mrp + "','" + obj.Author + "','" + obj.Category + "','" + obj.Publisher + "')";
            SqlCommand com = new SqlCommand(qr, con);
            com.ExecuteNonQuery();
            //ModelState.Clear();
            con.Close();
            ViewBag.Msg = "Record Save Successsfully";


            return View(obj);
        }




        
        public ActionResult ShowList(BookUserClass obj2)
        {

            SqlConnection con2 = new SqlConnection(connect);
            string query = "select BookName,Mrp,Author,Category,Publisher from BookStoreMVC";
            SqlCommand com2 = new SqlCommand(query, con2);
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataSet ds = new DataSet();
            
            con2.Open();
             da.Fill(ds, "BookStoreMVC");
            
            con2.Close();

            var userclass = new List<BookUserClass>();
            
            foreach (DataRow dr in ds.Tables["BookStoreMVC"].Rows)
            {
                userclass.Add(new BookUserClass
                {
                   BookName = Convert.ToString(dr["BookName"]),
                    Mrp = Convert.ToString(dr["Mrp"]),
                    Author = Convert.ToString(dr["Author"]),
                    Category = Convert.ToString(dr["Category"]),
                    Publisher = Convert.ToString(dr["Publisher"]),

                }) ;
            }


            return View(userclass);
        }


    }

}

