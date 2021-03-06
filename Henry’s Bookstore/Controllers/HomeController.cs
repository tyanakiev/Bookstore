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
            AUTHOR author = new AUTHOR();
            return View(author);
        }
        public ActionResult Publisher()
        {
            PUBLISHER publishers = new PUBLISHER();
            return View(publishers);
        }
        public ActionResult Location()
        {
            BRANCH locations = new BRANCH();
            return View(locations);
        }

        public ActionResult Details(string id)
        {
            BOOK currentBook = _context.BOOKs.Where(o => o.BOOK_CODE == id).FirstOrDefault();
            ViewBag.Locations = _context.INVENTORies.Where(o => o.BOOK_CODE == id).ToList();
            var authorNumber = _context.WROTEs.Where(o => o.BOOK_CODE == id).FirstOrDefault();
            ViewBag.Author = _context.AUTHORs.Where(o => o.AUTHOR_NUM == authorNumber.AUTHOR_NUM).FirstOrDefault();
            return View("BookDetails", currentBook);
        }
    }
}