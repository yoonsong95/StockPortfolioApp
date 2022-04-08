using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockPortfolioApp.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CompanyInfo()
        {
            return View();
        }

        public ActionResult StockInfo()
        {
            return View();
        }

        // these don't necessary have to return view, can be an api route for AJAX call
        public ActionResult FinancialMetrics()
        {
            return View();
        }

    }
}