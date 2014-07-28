using SismontProcessos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;

namespace SismontProcessos.Controllers
{
    public class LoginValueController : ValuesController
    {
        [HttpGet]
        [Authorize]
        public IQueryable GetLogin()
        {
            return Get<xerife_usuario>();
        }

        [HttpPost]
        public HttpResponseMessage SignIn([FromBody]dynamic user)
        {
            if (this.ModelState.IsValid)
            {
                string login = user["login"];
                string cnpj = user["cnpj"];
                string senha = user["senha"];
                xerife_usuario usuario = null;
                xerife_filial filial = null;
                if (_context.Context.IsAutenticate(login, cnpj, senha, out usuario,out filial))
                {
                    var response = this.Request.CreateResponse(HttpStatusCode.Created, true);
                    FormsAuthentication.SetAuthCookie(login, false);
                    HttpContext.Current.Session.Add("usuarioId", usuario.usuario_id);
                    HttpContext.Current.Session.Add("filialId", filial.filial_id);
                    HttpContext.Current.Session.Add("empresa", filial.xerife_empresa.razao_social);
                    HttpContext.Current.Session.Add("cnpj", cnpj);
                    return response;
                }
                return this.Request.CreateErrorResponse(HttpStatusCode.Forbidden, "Unidade não encontrada");
            }
            return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        //[HttpPost]
        //public HttpResponseMessage SignOut()
        //{
        //    FormsAuthentication.SignOut();
        //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        //}
    }
}
