using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Breeze.ContextProvider.EF6;
using SismontProcessos.DB;
using SismontProcessos.Models;

namespace SismontProcessos.Controllers
{
    public class RequisicaoValueController : ValuesController
    {
        [Route("api/requisicao")]
        public IQueryable<xerife_requisicao> GetRequisicao()
        {
            var requisicoes = Get<xerife_requisicao>();
            requisicoes = requisicoes.Where(x => x.filial_id == _context.Context.FilialAtual.filial_id);
            return requisicoes;
        }

        [Route("api/requisicao/{id:int}")]
        public IQueryable<xerife_requisicao> GetRequisicao(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("requisicao_id", id);
            return Get<xerife_requisicao>(parameters);
        }

        [HttpGet]
        [Route("api/assunto/")]
        public IQueryable<xerife_assunto_requisicao> GetAssunto()
        {
            return Get<xerife_assunto_requisicao>();
        }

        [HttpPut]
        [Route("api/requisicao")]
        public void Update([FromBody]xerife_requisicao requisicao)
        {
            var original = _context.Context.xerife_requisicao.FirstOrDefault(x => x.requisicao_id == requisicao.requisicao_id);
            DoUpdate<xerife_requisicao>(requisicao, original);
        }

        [HttpPost]
        [Route("api/requisicao")]
        public HttpResponseMessage AdicionarFuncionario([FromBody]dynamic value)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (value != null)
                    {
                        xerife_requisicao requisicao = null;
                        string tipo = value.tipo_requisicao.ToString() ?? string.Empty;
                        switch (tipo)
                        {
                            case "funcionario": requisicao = FuncionarioModel.CreateObject(value);
                                break;
                            case "ferias": requisicao = FeriasModel.CreateObject(value);
                                break;
                            case "rescisao": requisicao = RescisaoModel.CreateObject(value);
                                break;
                        }
                        if (requisicao != null)
                        {
                            DoPost<xerife_requisicao>(requisicao);
                            requisicao.solicitante = _context.Context.UsuarioAtual.login;
                            if (_context.Context.SaveChanges() > 0)
                            {
                                //SendMail(requisicao);
                                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, requisicao);
                                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = requisicao.requisicao_id }));
                                return response;
                            }

                        }
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
