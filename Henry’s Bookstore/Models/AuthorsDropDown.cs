using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Models
{
    public class AuthorsDropDown
    {
        public string AuthorSelected { get; set; }
        public IEnumerable<SelectListItem> AllAuthorOptions { get; set; }
    }
}