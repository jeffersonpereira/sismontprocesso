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
        public string GetLogin()
        {
            return "Jefferson";
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
                if (_context.Context.IsAutenticate(login, cnpj, senha, out usuario))
                {
                    var response = this.Request.CreateResponse(HttpStatusCode.Created, true);
                    FormsAuthentication.SetAuthCookie(login, false);
                    //HttpContext.Current.Session.Add("bloco", user.Bloco);
                    //HttpContext.Current.Session.Add("unidade", unidade.unidade_id);
                    //HttpContext.Current.Session.Add("condominio", unidade.condominio_id);
                    return response;
                }
                return this.Request.CreateErrorResponse(HttpStatusCode.Forbidden, "Unidade não encontrada");
            }
            return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }
    }
}
