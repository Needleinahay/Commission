using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Commission.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.WelcomeMessage = "Welcome to our college!";
            ViewBag.Slogan = "We'll teach you how to do it!";
            return View();
        }

        public ActionResult Faculties()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
