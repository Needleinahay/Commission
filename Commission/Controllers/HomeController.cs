using Data_layer;
using Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Commission.Controllers
{
    public class HomeController : Controller
    {
        Repository data;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public HomeController()
        {
            data = new Repository(new CommissionContext());
        }

        public ActionResult Index()
        {
            logger.Info("Getting Home page...");
            ViewBag.WelcomeMessage = "Welcome to our college!";
            return View();
        }

        public ActionResult Faculties()
        {
            logger.Info("Getting Faculties' list...");
            return View(data.GetFaculties());
        }

        public ActionResult Contact()
        {
            logger.Info("Getting Contact informatio...");
            return View(data.GetContactInfo());
        }
    }
}
