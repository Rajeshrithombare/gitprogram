using MvcRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcRegistration.Controllers
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
        public ActionResult Create(ItemModel iList)
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler handler = new ItemDBHandler();
                if(handler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfuly";
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}