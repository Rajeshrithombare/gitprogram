using Mvc_Employee_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Mvc_Employee_Registration.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(UserClass uc)
        {
            
            if(ModelState.IsValid)
            {
                DBHndlerClass handler = new DBHndlerClass();
                if(handler.InsertItem(uc))
                {
                    ViewBag.Message = "Registration done Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        //show List
        public ActionResult ShowList()
        {
            ViewBag.ItemList = "Employee Registration Records";
            DBHndlerClass db = new DBHndlerClass();
            ModelState.Clear();

            return View(db.GetItemList());
        }

        //Edit Record

        [HttpGet]
        public ActionResult Edit(string Email_id)
        {
            DBHndlerClass db = new DBHndlerClass();
            return View(db.GetItemList().Find(UserClass => UserClass.Email_id==Email_id));
        }
        [HttpPost]
        public ActionResult Edit(string Email_id,UserClass ucc)
        {
            try
            {
                DBHndlerClass db1 = new DBHndlerClass();
                db1.UpdateItem(ucc);
                return RedirectToAction("ShowList");
            }
            catch
            {
                return View();
            }
            
        }
    }
}