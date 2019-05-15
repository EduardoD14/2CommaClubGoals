using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwoCommaClubGoals.Controllers
{
    public class CalculatorsController: Controller
    {    
        public ActionResult MortgageAmoratization()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult CarPayment()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult DebtPayoff()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult InterestCalc()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult SavingsGoal()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult WageCalc()
        {
            ViewBag.Message = "";

            return View();
        }

    }
}