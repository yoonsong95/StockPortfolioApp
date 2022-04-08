using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockPortfolioApp.Models;

namespace StockPortfolioApp.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StockTransaction(StockTransaction Transaction)
        {
            // for error validation - if there's error in input returned to this page ...
            return View("_PortfolioStockTransactionForm", Transaction);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult StockTransactionSubmit(StockTransaction Transaction)
        {
            if (ModelState.IsValid)
            {
                if (Transaction.TransactionType == "Buy")
                {
                    return RedirectToAction("BuyStock", Transaction);
                }
                else if (Transaction.TransactionType == "Sell")
                {
                    return RedirectToAction("SellStock", Transaction);
                }
                else
                {
                    return Content("Error");
                }
            }
            // when form input is invalid, return back to the form
            return RedirectToAction("StockTransaction");
        }

        public ActionResult BuyStock()
        {
            return View();
        }

        public ActionResult SellStock()
        {
            return View();
        }

        public ActionResult PerformanceMetrics()
        {
            return View();
        }

        public ActionResult TransactionHistory()
        {
            return View();
        }
    }
}