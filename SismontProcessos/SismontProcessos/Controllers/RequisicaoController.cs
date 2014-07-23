using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SismontProcessos.Controllers
{
    [Authorize]
    public class RequisicaoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edicao()
        {
            return View();
        }

        public ActionResult Funcionario()
        {
            return View();
        }

        public ActionResult Ferias()
        {
            return View();
        }

        public ActionResult Rescisao()
        {
            return View();
        }
	}
}