using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockPortfolioApp.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public Contact() { }
    }
}