using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DEL_1___2___INF_272.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application login page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign up";
            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Home screen";
            return View();
        }

        public ActionResult FindHospital()
        {
            ViewBag.Message = "Find hospita;";
            return View();
        }
        public ActionResult DonateToday()
        {
            return View();
        }

        public ActionResult Covid()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        public ActionResult Checkout_Success()
        {
            return View();
        }

        public ActionResult Update_Profile()
        {
            return View();
        }

        public ActionResult Feedback_report()
        {
            return View();
        }
    }
}