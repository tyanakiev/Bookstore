using Henry_s_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Controllers
{
    public class SearchBranchController : Controller
    {
        // GET: SearchBranch
        asp23Entities _context = new asp23Entities();
        public ActionResult Index()
        {
            var branches = _context.BRANCHes.ToList().Select(s => new SelectListItem
            {
                Text = s.BRANCH_NAME,
                Value = s.BRANCH_NUM.ToString()
            });
            return PartialView("~/Views/Shared/_SearchByBranch.cshtml", new BranchDropDown { AllBranchOptions = branches });
        }

        [HttpPost]
        public ActionResult Search(BranchDropDown branchFilter)
        {
            int num = Int32.Parse(branchFilter.BranchSelected);
            BRANCH branch = _context.BRANCHes.Where(o => o.BRANCH_NUM == num).FirstOrDefault();

            return View("~/Views/Home/Location.cshtml", branch);
        }
    }
}