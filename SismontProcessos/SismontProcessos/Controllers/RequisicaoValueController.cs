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
using System.IO;

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
        [Route("api/requisicao/{id}")]
        public void Update(int id,[FromBody]dynamic value)
        {
            var original = _context.Context.xerife_requisicao.FirstOrDefault(x => x.requisicao_id == id);
            AddMovimentacao(original, value);
        }

        void AddMovimentacao(xerife_requisicao requisicao, dynamic value)
        {
            if (requisicao != null)
            {
                var movimentacao = new xerife_movimentacao_requisicao();
                movimentacao.data = DateTime.Today;
                movimentacao.anotacao = value.anotacao;
                movimentacao.solicitante = _context.Context.UsuarioAtual.login;
                if (value.arquivo != null)
                {
                    movimentacao.anexo_id = Guid.NewGuid();
                    var arquivo = new xerife_arquivo();
                    arquivo.nome = value.arquivo.nome_original;
                    string fileName = string.Format("{0}\\{1}", GlobalVars.UploadDiretorio, value.arquivo.nome_temporario);
                    arquivo.conteudo = File.ReadAllBytes(fileName);
                    var infor = new FileInfo(fileName);
                    arquivo.tamanho = (int)infor.Length;
                    _context.Context.xerife_arquivo.Add(arquivo);

                    var doc = new xerife_documento();
                    doc.anexo_id = movimentacao.anexo_id.Value;
                    doc.tabela = "xerife_movimentacao_requisicao";
                    doc.usuario = movimentacao.solicitante;
                    doc.data_documento = infor.CreationTime.Date;
                    doc.data_upload = DateTime.Today;
                    doc.data_entrega = DateTime.Today;
                    var tipo = _context.Context.xerife_tipo_documento.FirstOrDefault(x => x.descricao.ToLower().Equals("anexo"));
                    if(tipo==null)
                    {
                        tipo = new xerife_tipo_documento();
                        tipo.descricao = "Anexo";
                    }
                    doc.xerife_tipo_documento = tipo;
                    arquivo.xerife_documento.Add(doc);
                }
                requisicao.xerife_movimentacao_requisicao.Add(movimentacao);
                _context.Context.SaveChanges();
            }
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
                                //response.Headers.Location = new Uri(Request.RequestUri,Url.Route("api/requisicao",new{id=requisicao.requisicao_id}));
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
