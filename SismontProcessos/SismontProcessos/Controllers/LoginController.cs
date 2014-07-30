using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SismontProcessos.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
            this.RedirectToAction("Index");
        }
    }
}