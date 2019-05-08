using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Models
{
    public class PublisherDropDown
    {
        public string PublisherSelected { get; set; }
        public IEnumerable<SelectListItem> AllPublisherOptions { get; set; }
    }
}