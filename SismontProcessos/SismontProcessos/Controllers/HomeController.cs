using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace SismontProcessos.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var requisicoes = new RequisicaoValueController();
            ViewBag.Total = requisicoes.GetRequisicao().Count();
            return View();
        }
    }
}