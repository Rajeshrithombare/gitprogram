using MVC_Reg_UserExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Reg_UserExample.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserClass uc)
        {
            //insert record
            // try
            //{
            if (ModelState.IsValid)
            {
                DBHandler ItemHandler = new DBHandler();
                if (ItemHandler.InsertItem(uc))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }


        //Show List

        public ActionResult ShowList()
        {
            ViewBag.ItemList = "Student Registration Detail";
            DBHandler DB = new DBHandler();
            ModelState.Clear();
            return View(DB.GetItemList());
        }

        //Update Record
        [HttpGet]
        public ActionResult Update(string UserName)
        {
            DBHandler DB2 = new DBHandler();
            return View(DB2.GetItemList().Find(UserClass => UserClass.UserName == UserName));
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
        public ActionResult Detail(string UserName)
        {
            DBHandler handler1 = new DBHandler();
            return View(handler1.GetItemList().Find(UserClass => UserClass.UserName == UserName));
        }
    }

}