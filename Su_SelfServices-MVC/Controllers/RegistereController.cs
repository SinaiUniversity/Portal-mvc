using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Su_SelfServices_MVC.Controllers
{
    public class RegistereController : Controller
    {
        // GET: Registere
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
        public ActionResult ChangeEmail()
        {
            return View();
        }
    }
}