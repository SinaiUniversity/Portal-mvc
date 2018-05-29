using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Su_SelfServices_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Common_MainPage MenuObj = new Common_MainPage();
            List<MenuTabs> MenuLst = MenuObj.GetMainTaps();
            ViewBag.MainTabs = MenuLst;
            Session["MainTabs"] = MenuLst;
            return View(ViewBag.MainTabs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Alumni()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }
        public ActionResult Applicant()
        {
            ViewBag.LoginTitle = "Applicant ID";
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }
    }
}