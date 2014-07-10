using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SismontProcessos.DB;

namespace SismontProcessos.Controllers
{
    public class MovimentacaoValueController : ValuesController
    {
        [HttpGet]
        public IQueryable<xerife_movimentacao_requisicao> GetMovimentacao()
        {
            return Get<xerife_movimentacao_requisicao>();
        }

        [HttpGet]
        public IQueryable<xerife_movimentacao_requisicao> GetMovimentacao(int id)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("requisicao_id", id);
            return Get<xerife_movimentacao_requisicao>(p);
        }
    }
}
