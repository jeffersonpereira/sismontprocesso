using SismontProcessos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SismontProcessos.Controllers
{
    public class FuncionarioValueController : ValuesController
    {
        [HttpGet]
        public IQueryable GetFuncionarios()
        { 
            return _context.Context.GetFuncionarioDados();
        }
    }
}
