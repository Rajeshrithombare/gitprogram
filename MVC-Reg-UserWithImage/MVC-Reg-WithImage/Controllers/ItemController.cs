using MVC_Reg_UserExample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Reg_UserExample.Controllers
{
    public class ItemController : Controller
    {

        UserClass oImage = new UserClass();
        List<UserClass> _oImage = new List<UserClass>();
        // GET: Item


        #region Image Save

        [HttpGet]
        public ActionResult SaveImage()
        {
           // return View();
          return View(oImage);
        }


        [HttpPost]
        public ActionResult SaveImage(UserClass oImage, HttpPostedFileBase image1)
        {
            
                // if (ModelState.IsValid)
                //{
                //DBHandler ItemHandler = new DBHandler();
           /* if (ItemHandler.InsertItem(oImage))
            {
                ViewBag.Message = "Item Added Successfully";
                ModelState.Clear();
            }

            return View(oImage);

        
            */



            //orignal code
             if(image1 !=null)
             {
                 oImage.UserImage = new byte[image1.ContentLength];
                 image1.InputStream.Read(oImage.UserImage, 0, image1.ContentLength);
             }
             string conne = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
             SqlConnection conctn = new SqlConnection(conne);
             conctn.Open();
             string qer = "insert into BinaryImage(UserName,Email_id,Password,Gender,UserImage) values(@UserName,@Email_id,@Password,@Gender,@UserImage)";
             SqlCommand coma = new SqlCommand(qer, conctn);
             coma.Parameters.AddWithValue("@UserName", oImage.UserName);
             coma.Parameters.AddWithValue("@Email_id", oImage.Email_id);
             coma.Parameters.AddWithValue("@Password", oImage.Password);
             coma.Parameters.AddWithValue("@Gender", oImage.Gender);
             coma.Parameters.AddWithValue("@UserImage", oImage.UserImage);
             coma.ExecuteNonQuery();
             conctn.Close();



             return View(oImage);
        }
        #endregion

       /* //insert record
            // try
            //{
            if (ModelState.IsValid)
            {
                DBHandler ItemHandler = new DBHandler();
                if (ItemHandler.InsertItem(uc))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }*/


           //Show List

        public ActionResult ShowList(UserClass uc1)
        {
            string connect = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            string q = "select UserName,Email_id,Password,Gender,UserImage from BinaryImage";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "BinaryImage");
            var userClass = new List<UserClass>();
            foreach(DataRow dr in ds.Tables["BinaryImage"].Rows)
            {
                userClass.Add(new UserClass(uc1.UserName = dr["UserName"].ToString(), uc1.Email_id = dr["Email_id"].ToString(), uc1.Password = dr["Password"].ToString(), uc1.Gender = dr["Gender"].ToString(), uc1.UserImage = (byte[])dr["UserImage"]));
                /*uc1.UserName = dr["UserName"].ToString();
                ViewBag.UserName = uc1.UserName;

                uc1.Email_id = dr["Email_id"].ToString();
                ViewBag.Email_id = uc1.Email_id;

                uc1.Password = dr["Password"].ToString();
                ViewBag.Password = uc1.Password;

                uc1.Gender = dr["Gender"].ToString();
                ViewBag.Gender = uc1.Gender;*/


                byte[] pic = (byte[])dr["UserImage"];
                string p = Convert.ToBase64String(pic, 0, pic.Length);
                string pi = "data:image/png;base64," + p;
                ViewBag.UserImage = pi;




            }

            return View(userClass);
           /* ViewBag.ItemList = "Student Registration Detail";
            DBHandler DB = new DBHandler();
            ModelState.Clear();
            return View(DB.GetItemList());*/
        }

        //Update Record
        [HttpGet]
        public ActionResult Update(UserClass ucc)
        {
            DBHandler DB2 = new DBHandler();
            return View(DB2.UpodateItem(ucc));
        }

        [HttpPost]
        public ActionResult Update(string UserName, UserClass ilist1)
        {
            try
            {
                DBHandler DB3 = new DBHandler();
                DB3.UpodateItem(ilist1);
                return RedirectToAction("ShowList");
            }
            catch
            {
                return View();
            }
        }
        //Delete item
        [HttpGet]
        public ActionResult DeleteRecord(string name)
        {
            ViewBag.uname = name;
            try
            {
                DBHandler hd = new DBHandler();
                if (hd.DeleteItem(name))
                {
                    ViewData["Message"] = "Record deleted Successfully";
                }
                return (RedirectToAction("ShowList"));
                //return View();
                
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult DeleteRecord()
        {
            ViewBag.Msg = "Deleted";
            return  View();
        }

        //Show detailes
       /* public ActionResult Detail(UserClass uc)
        {
            DBHandler handler1 = new DBHandler();
            return View(handler1.UpodateItem().Find(UserClass => UserClass.UserName == UserName));
        }*/
    }

}