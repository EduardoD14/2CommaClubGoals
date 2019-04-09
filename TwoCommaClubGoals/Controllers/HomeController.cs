using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwoCommaClubGoals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who are we?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you would like to reach out to the 2CommaClub team \n feel free to do so using one of the methods below.";

            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
        public ViewResult Credit()
        {
            return View();
        }
        public ViewResult Investing()
        {
            return View();
        }
        public ViewResult Savings()
        {
            return View();
        }
        public ViewResult UnderConstruction()
        {
            return View();
        }
    }
}