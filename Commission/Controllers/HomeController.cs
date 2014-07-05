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

        public ActionResult Faculties(string sortBy)
        {
            logger.Info("Getting Faculties' list...");

            ViewBag.NameSort = String.IsNullOrEmpty(sortBy) ? "NameMax" : "";
            ViewBag.VacancySort = sortBy == "VacancyMin" ? "VacancyMax" : "VacancyMin";
            ViewBag.VacancyScholarshipSort = sortBy == "VacancyScholarshipMin" ? "VacancyScholarshipMax" : "VacancyScholarshipMin";
            var toView = data.GetFaculties();
            if (toView != null)
            {
                switch (sortBy)
                {
                    case "NameMax":
                        {
                            toView = toView.OrderByDescending(x => x.Name);
                            break;
                        }
                    case "Name":
                        {
                            toView = toView.OrderBy(x => x.Name);
                            break;
                        }
                    case "VacancyMax":
                        {
                            toView = toView.OrderByDescending(x => x.Vacancies);
                            break;
                        }
                    case "VacancyMin":
                        {
                            toView = toView.OrderBy(x => x.Vacancies);
                            break;
                        }
                    case "VacancyScholarshipMax":
                        {
                            toView = toView.OrderByDescending(x => x.ScholarshipVacancies);
                            break;
                        }
                    case "VacancyScholarshipMin":
                        {
                            toView = toView.OrderBy(x => x.ScholarshipVacancies);
                            break;
                        }
                    default:
                        {
                            toView = toView.OrderBy(x => x.Name);
                            break;
                        }
                }
                return View(toView);
            }
            else
                return RedirectToAction("WrongPage");
        }

        public ActionResult Contact()
        {
            logger.Info("Getting Contact information...");
            var toView = data.GetContactInfo();
            if (toView != null)
                return View(toView);
            else
                return RedirectToAction("WrongPage");
        }



        // if null object is retrieved from db
        public ActionResult WrongPage()
        {
            return View();
        }
    }
}
