using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Breeze.ContextProvider.EF6;
using SismontProcessos.DB;
using Breeze.WebApi2;
using System.Net.Mail;

namespace SismontProcessos.Controllers
{
    
     public class ValuesController : ApiController
    {
         //public xerifeEntities _context;
         protected EFContextProvider<xerifeEntities> _context;
        internal ValuesController()
        {
            //_context = new xerifeEntities();
            _context = new EFContextProvider<xerifeEntities>();
        }

        protected virtual IQueryable<T> Get<T>(Dictionary<string, object> paramenters) where T : class
        {
            return _context.Context.GetObjects<T>(paramenters);
        }

        protected virtual IQueryable<T> Get<T>() where T : class
        {
            return _context.Context.GetObjects<T>();
        }

        protected virtual void DoPost<T>(T entity) where T : class
        {
            try
            {
                _context.Context.AddToObject<T>(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected virtual void DoDelete<T>(T entity) where T : class
        {
            _context.Context.RemoveObject<T>(entity);
        }

        /// <summary>
        /// Atualiza objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">Objeto base</param>
        /// <param name="entity2">Objeto que será atualizado</param>
        protected virtual void DoUpdate<T>(T entity,T entity2) where T : class
        {
            _context.Context.UpdateObject<T>(entity, entity2);
        }

         protected virtual void SendMail(xerife_requisicao requisicao)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 100000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("remetente@conta-t.com", "senha");
            MailMessage mail = new MailMessage();
            mail.Subject = requisicao.assunto;
            mail.Priority = (MailPriority)requisicao.prioridade;
            mail.From = new MailAddress("remetente@conta-t.com");
            mail.To.Add("destinatario@conta-t.com");
            mail.Body = "Uma nova requisição foi relizada";
            client.Send(mail);
        }
    }
}
