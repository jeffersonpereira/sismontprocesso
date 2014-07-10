using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SismontProcessos.DB;

namespace SismontProcessos.Controllers
{
    public class AssuntoValueController : ValuesController
    {
        [HttpGet]
        public IQueryable<xerife_assunto_requisicao> GetAssunto()
        {
            return Get<xerife_assunto_requisicao>();
        }
    }
}
