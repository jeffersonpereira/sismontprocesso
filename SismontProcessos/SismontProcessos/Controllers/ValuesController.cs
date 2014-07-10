using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Breeze.ContextProvider.EF6;
using SismontProcessos.DB;
using Breeze.WebApi2;

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
    }
}
