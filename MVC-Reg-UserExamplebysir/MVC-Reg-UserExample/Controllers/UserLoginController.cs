using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Reg_UserExample.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace MVC_Reg_UserExample.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {

         string maincon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con1 = new SqlConnection(maincon);
            string querylog = "select Email_id,Password from BinaryImage where Email_id=@Email_id and Password=@Password";
            con1.Open();
            SqlCommand cmd = new SqlCommand(querylog, con1);
            cmd.Parameters.AddWithValue("@Email_id", lc.Email_id);
            cmd.Parameters.AddWithValue("@Password", lc.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                Session["Email_id"] = lc.Email_id.ToString();
                
                return RedirectToAction("welcome");

            }
            else
            {
                ViewData["Message"] = "User Login detaile failed";
            }
            con1.Close();
            return View();
        }


        public ActionResult welcome(UserClass uc1)
        {
           string maincon2 = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con2 = new SqlConnection(maincon2);
            /* string querylog2 = "select UserName,Email_id,Gender from MyMvc2 where UserName=@UserName,Email_id=@Email_id,Gender=@Gender";
              con2.Open();
              SqlCommand cmd1 = new SqlCommand(querylog2, con2);
              cmd1.Parameters.AddWithValue("@UserName", ucc.UserName);
              cmd1.Parameters.AddWithValue("@Email_id", ucc.Email_id);
              cmd1.Parameters.AddWithValue("@Gender", ucc.Gender);
              //SqlDataReader sdr1 = cmd1.ExecuteReader();
             // if (sdr1.Read())
              //{
                  Session["UserName"] = ucc.Email_id.ToString();
                  Session["Email_id"] = ucc.Email_id.ToString();
                  Session["Gender"] = ucc.Email_id.ToString();
                  //return RedirectToAction("welcome");

              //}
              //else
              //{
                // ViewData["Message"] = "User Login detaile failed";
              //}
              con2.Close();*/
            /* con2.Open();
             string log = "select UserName,Email_id,Gender from BinaryImage where Email_id='" + Session["Email_id"] + "'";
             SqlDataAdapter adapter = new SqlDataAdapter(log, con2);
             DataSet ds = new DataSet();
             adapter.Fill(ds, "BinaryImage");
             foreach (DataRow dr in ds.Tables["BinaryImage"].Rows)
             {
                 ViewData["uname"] = dr["UserName"].ToString();
                 ViewData["Email_id"] = dr["Email_id"].ToString();
                 ViewData["Gender"] = dr["Gender"].ToString();

             }
             con2.Close();*/




            con2.Open();
            string log = "select UserName,Email_id,Password,Gender,UserImage from BinaryImage where Email_id='" + Session["Email_id"] + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(log, con2);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BinaryImage");
            var userclass = new List<UserClass>();
            foreach (DataRow dr in ds.Tables["BinaryImage"].Rows)
            {
                ViewData["uname"] = dr["UserName"].ToString();
                ViewData["Email_id"] = dr["Email_id"].ToString();
                ViewData["Gender"] = dr["Gender"].ToString();
                userclass.Add(new UserClass(uc1.UserName = dr["UserName"].ToString(), uc1.Email_id = dr["Email_id"].ToString(), uc1.Password = dr["Password"].ToString(), uc1.Gender = dr["Gender"].ToString(), uc1.UserImage = (byte[])dr["UserImage"]));
                byte[] pic = (byte[])dr["UserImage"];
                string p = Convert.ToBase64String(pic, 0, pic.Length);
                string pi = "data:image/png;base64," + p;
                ViewBag.UserImage = pi;



                /*string imgPath = Server.MapPath("~/images/self-discipline.png");
                // Convert image to byte array  
                byte[] byteData = System.IO.File.ReadAllBytes(imgPath);
                //Convert byte arry to base64string   
                string imreBase64Data = Convert.ToBase64String(byteData);
                string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
                //Passing image data in viewbag to view  
                ViewBag.ImageData = imgDataURL;*/

            }
            con2.Close();

            return View(userclass);
        }

        [HttpGet]
        public ActionResult ForgetPas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPas(LoginClass lcf)
        {

            string cons = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            string qr = "update BinaryImage set Password='" + lcf.Password + "' where Email_id='" + lcf.Email_id + "'";
            SqlCommand command = new SqlCommand(qr, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                ViewData["Message"] = "Password chenge successfully";
            else
                ViewData["Message"] = "Password is wrong";

            return View();
               
            
        }


    }
}