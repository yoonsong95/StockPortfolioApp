using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockPortfolioApp.Models
{
    public class WatchlistTransaction
    {
        public string Ticker { get; set; }
        public string TransactionType { get; set; }

        public WatchlistTransaction() { }
    }
}