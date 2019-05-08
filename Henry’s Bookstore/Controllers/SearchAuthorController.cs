using Henry_s_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Controllers
{
    public class SearchAuthorController : Controller
    {
        asp23Entities _context = new asp23Entities();
        // GET: SearchAuthor
        public ActionResult Index()
        {
            //AuthorsDropDown authorsDropDown = new AuthorsDropDown();
            var authors = _context.AUTHORs.ToList().Select(s => new SelectListItem
            {
                Text = s.AUTHOR_FIRST + " " + s.AUTHOR_LAST,
                Value = s.AUTHOR_NUM.ToString()
            });
            return PartialView("~/Views/Shared/_SearchByAuthor.cshtml", new
           AuthorsDropDown { AllAuthorOptions = authors });
        }

        public ActionResult GetSpecificAuthor(int id)
        {
            AUTHOR author = _context.AUTHORs.Where(o => o.AUTHOR_NUM == id).FirstOrDefault();

            return View("~/Views/Home/Author.cshtml", author);
        }

        [HttpPost]
        public ActionResult Search(AuthorsDropDown authorFilter) //expecting model as input
        {
            //get model variables from the HTTP Post & convert to an integer since COURSE_ID is int
            int id = Int32.Parse(authorFilter.AuthorSelected);
            AUTHOR author = _context.AUTHORs.Where(o => o.AUTHOR_NUM == id).FirstOrDefault();

            return View("~/Views/Home/Author.cshtml", author);
        }
    }
}