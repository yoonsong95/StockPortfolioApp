using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockPortfolioApp.Models;

namespace StockPortfolioApp.Controllers
{
    public class WatchlistController : Controller
    {
        // GET: Watchlist
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WatchlistTransaction(string Ticker)
        {
            // for error validation - if there's error in input ...
            return View("_WatchlistStockTransactionForm", Ticker);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult WatchlistTransactionSubmit(WatchlistTransaction Transaction)
        {
            if (ModelState.IsValid)
            {
                if (Transaction.TransactionType == "Add")
                {
                    return RedirectToAction("AddStock", Transaction.Ticker);
                }
                else if (Transaction.TransactionType == "Remove")
                {
                    return RedirectToAction("RemoveStock", Transaction.Ticker);
                }
                else
                {
                    return Content("Error");
                }
            }
            // when form input is invalid, return back to the form
            return RedirectToAction("WatchlistTransaction");
        }


        public ActionResult AddStock()
        {
            return View();
        }

        public ActionResult RemoveStock()
        {
            return View();
        }


    }
}