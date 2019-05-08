using Henry_s_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Controllers
{
    public class ContactController : Controller
    {
        asp23Entities _context = new asp23Entities();
        // GET: Contact
        public ActionResult Index()
        {
            ContactModel contact = new ContactModel();
            var braches = _context.BRANCHes.ToList();
            braches.Insert(0, new BRANCH { BRANCH_NAME = "Please choose a location", BRANCH_NUM = 0});
            contact.Branchs = new SelectList(braches, "BRANCH_NUM", "BRANCH_NAME");
            return View("~/Views/Home/Contact.cshtml", contact);
        }

        [HttpPost]
        public JsonResult Index(ContactModel contact)
        {
            if (String.IsNullOrEmpty(contact.FirstName))
            {
                ModelState.AddModelError("", "Please enter your first name");
            }
            if (String.IsNullOrEmpty(contact.LastName))
            {
                ModelState.AddModelError("", "Please enter your last name");
            }
            if (String.IsNullOrEmpty(contact.EmailAddress))
            {
                ModelState.AddModelError("", "Please enter your email address");
            }
            if (String.IsNullOrEmpty(contact.ConfirmEmailAddress))
            {
                ModelState.AddModelError("", "Please enter your your email address");
            }
            if (!String.IsNullOrEmpty(contact.ConfirmEmailAddress) && !String.IsNullOrEmpty(contact.EmailAddress) && contact.ConfirmEmailAddress != contact.EmailAddress)
            {
                ModelState.AddModelError("", "Please enter the same email address in both fields.");
            }
            if (contact.BranchNumber == 0)
            {
                ModelState.AddModelError("", "Please select branch.");
            }
            if (String.IsNullOrEmpty(contact.Comments))
            {
                ModelState.AddModelError("", "Please enter your comment.");
            }
            var braches = _context.BRANCHes.ToList();
            braches.Insert(0, new BRANCH { BRANCH_NAME = "Please choose a location", BRANCH_NUM = 0 });
            contact.Branchs = new SelectList(braches, "BRANCH_NUM", "BRANCH_NAME");
            return Json(contact);
        }
    }
}