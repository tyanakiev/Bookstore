﻿using Henry_s_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Controllers
{
    public class HomeController : Controller
    {
        asp23Entities _context = new asp23Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Inventory()
        {
            List<INVENTORY> invetory = _context.INVENTORies.ToList();
            return View(invetory);
        }
        public ActionResult Author()
        {
            List<AUTHOR> authors = _context.AUTHORs.ToList();
            return View(authors);
        }
        public ActionResult Publisher()
        {
            List<PUBLISHER> publishers = _context.PUBLISHERs.ToList();
            return View(publishers);
        }
        public ActionResult Location()
        {
            List<BRANCH> locations = _context.BRANCHes.ToList();
            return View(locations);
        }
    }
}