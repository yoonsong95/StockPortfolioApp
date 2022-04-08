using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockPortfolioApp.Models
{
    public class Stock
    {
        public string Ticker { get; set; }
        public string Company { get; set; }

        public Stock() {}
    }
}
