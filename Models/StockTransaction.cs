using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockPortfolioApp.Models
{
    public class StockTransaction
    {
        public string Ticker { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public int Share { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDateTime { get; set; }

        public StockTransaction() { }
    }
}