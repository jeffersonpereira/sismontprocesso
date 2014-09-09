using SismontProcessos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SismontProcessos.Controllers
{
    public class GrauInstrucaoValueController : ValuesController
    {
        public IQueryable<xerife_grau_instrucao> GetCargos()
        {
            return Get<xerife_grau_instrucao>();
        }
    }
}
