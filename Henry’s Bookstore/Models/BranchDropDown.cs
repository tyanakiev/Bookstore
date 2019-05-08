using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Models
{
    public class BranchDropDown
    {
        public string BranchSelected { get; set; }
        public IEnumerable<SelectListItem> AllBranchOptions { get; set; }
    }
}