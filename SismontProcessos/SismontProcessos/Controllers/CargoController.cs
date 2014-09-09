using SismontProcessos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SismontProcessos.Controllers
{
    public class CargoController : ValuesController
    {
        public IQueryable<xerife_cargo> GetCargos()
        {
            return Get<xerife_cargo>();
        }
    }
}
