using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Su_SelfServices_MVC.Controllers
{
    public class ApplicantController : Controller
    {
        // GET: Applicant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewApplication()
        {
            return View();
        }

        public ActionResult ApplicationStatus()
        {
            return View();
        }
        public ActionResult QualificationExams()
        {
            return View();
        }
        public ActionResult ApplicationDetails()
        {
            return View();
        }

        public ActionResult RequestTest()
        {
            return View();
        }

         public ActionResult UpComingAction()
        {
            return View();
        }

        public ActionResult ApplicationPayments()
        {
            return View();
        }
        public ActionResult Attachments()
        {
            return View();
        }

        #region MailBox
        public ActionResult SentMails()
        {
            return View();
        }
        #endregion

        public ActionResult ViewApplication()
        {
            return View();
        }
    }
}