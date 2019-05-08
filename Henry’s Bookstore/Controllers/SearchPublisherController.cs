using Henry_s_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Controllers
{
    public class SearchPublisherController : Controller
    {
        asp23Entities _context = new asp23Entities();

        public ActionResult Index()
        {
            var publishers = _context.PUBLISHERs.ToList().Select(s => new SelectListItem
            {
                Text = s.PUBLISHER_NAME,
                Value = s.PUBLISHER_CODE.ToString()
            });
            return PartialView("~/Views/Shared/_SearchByPublisher.cshtml", new
           PublisherDropDown
            { AllPublisherOptions = publishers });
        }

        [HttpPost]
        public ActionResult Search(PublisherDropDown publisherFilter) 
        {
            PUBLISHER publisher = _context.PUBLISHERs.Where(o => o.PUBLISHER_CODE == publisherFilter.PublisherSelected).FirstOrDefault();

            return View("~/Views/Home/Publisher.cshtml", publisher);
        }
    }
}