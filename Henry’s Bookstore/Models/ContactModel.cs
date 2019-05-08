using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henry_s_Bookstore.Models
{
    public class ContactModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [DisplayName("Confirm Email Address")]
        public string ConfirmEmailAddress { get; set; }
        
        public IEnumerable<SelectListItem> Branchs { get; set; }
        [DisplayName("Branch")]
        public int BranchNumber { get; set; }
        [DisplayName("Comments")]
        public string Comments { get; set; }
    }
}