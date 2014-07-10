using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SismontProcessos.DB;

namespace SismontProcessos.Controllers
{
    public class DocumentoController : ValuesController
    {
        [HttpGet]
        public IQueryable<xerife_documento> GetDocumentos()
        {
            return Get<xerife_documento>();
        }

        [HttpGet]
        public IQueryable<xerife_documento> GetDocumentos(Guid id)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("anexo_id", id);
            p.Add("tabela", "xerife_movimentacao_requisicao");
            return Get<xerife_documento>(p);
        }

    }
}
