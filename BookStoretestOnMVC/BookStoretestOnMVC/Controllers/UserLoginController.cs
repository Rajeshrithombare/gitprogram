using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using BookStoretestOnMVC;
using System.Data.SqlClient;
using System.Configuration;
using BookStoretestOnMVC.Models;

namespace BookStoretestOnMVC.Controllers
{
    public class UserLoginController : Controller
    {

        static string conn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        // GET: UserLogin

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {

            try
            {
                con.Open();
                
                string qr = "select count(*) from LogintableMVC where Email_id='" + lc.Email_id + "'";
                
                SqlCommand com = new SqlCommand(qr, con);
                int i = Convert.ToInt32(com.ExecuteScalar());

                
                if(i==0)
                {
                    string qrery = "insert into LogintableMVC (Email_id,Password)values('" + lc.Email_id + "','" + lc.Password + "')";
                    SqlCommand com2 = new SqlCommand(qrery, con);
                    com2.ExecuteNonQuery();
                    ViewBag.Msg = "Login Created Successfully";
                }
                else
                {
                    ViewBag.Msg = "This User id allready exist Please Enter anather User id";
                }


            }
            catch(Exception ee)
            {
                ee.ToString();
            }
            finally
            {
                con.Close();
            }

            return View(lc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginClass lc2)
        {

            string re = "select Email_id,Password from LogintableMVC where Email_id='" + lc2.Email_id + "'and Password='" + lc2.Password + "'";
            con.Open();
            SqlCommand com3 = new SqlCommand(re, con);
            SqlDataReader dr = com3.ExecuteReader();
            if(dr.Read())
            {
                Session["Email_id"] = lc2.Email_id.ToString();
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Msg = "Invalid Credintial";
            }
            con.Close();
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Msg = "Welcome" + Session["Email_id"] + " To User Dashboard";
            return View();
        }
    }
}