using MyStudentRegistrationMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStudentRegistrationMvc.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RegisterModel iList)
        {
            //insert record
            // try
            //{
            if (ModelState.IsValid)
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                if (ItemHandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            /* }
             catch { return View();  }*/
        }

        //show list
        public ActionResult Index()
        {
            ViewBag.Itemlist = "Student Registration detailes";
            ItemDBHandler IHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }


        //update records

        [HttpGet]
        public ActionResult Edit(string First_name)
        {
            ItemDBHandler itemHandler = new ItemDBHandler();
            return View(itemHandler.GetItemList().Find(RegisterModel => RegisterModel.First_name == First_name));

        }
        [HttpPost]
        public ActionResult Edit(string First_name,RegisterModel iList)
        {
            try
            {
                ItemDBHandler itemHandler = new ItemDBHandler();
                itemHandler.UpdateItem(iList);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string First_name)
        {
            try
            {
                ItemDBHandler handler = new ItemDBHandler();
                if (handler.DeleteItem(First_name))
                {
                    ViewBag.AlertMsg = "Record delete Successfully";

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       public ActionResult Detail(string First_name)
        {
            ItemDBHandler handler1 = new ItemDBHandler();
            return View(handler1.GetItemList().Find(RegisterModel=> RegisterModel.First_name==First_name));
        }
    }
}