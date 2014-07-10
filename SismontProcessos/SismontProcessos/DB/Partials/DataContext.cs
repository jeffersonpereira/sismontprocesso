using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Objects;

namespace SismontProcessos.DB
{
    public partial class xerifeEntities
    {
        public IQueryable<T> GetObjects<T>() where T : class
        {
            return GetObjects<T>(null);
        }
        public IQueryable<T> GetObjects<T>(Dictionary<string, object> parameters) where T : class
        {
            var sql = string.Format("select * from {0}",typeof(T).Name);
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    var condition = sql.Contains("where") ? " and" : " where";
                    sql += string.Format("{0} {1}={2} ", condition, p.Key, p.Value);
                }
            }
            return this.Database.SqlQuery<T>(sql).AsQueryable<T>();
        }

        /// <summary>
        /// Adiciona um objeto ao contexto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void AddToObject<T>(T entity) where T : class
        {
            this.Set<T>().Add(entity);
        }

        /// <summary>
        /// Remove um objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void RemoveObject<T>(T entity) where T : class
        {
            this.Set<T>().Remove(entity);
        }
        /// <summary>
        /// Atualiza objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="entity2">Objeto que será atualizado</param>
        public void UpdateObject<T>(T entity,T entity2) where T : class
        {
            this.Entry<T>(entity2).CurrentValues.SetValues(entity);
            try
            {
                this.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível atualizado o objeto. " + ex.Message);
            }
            
        }
    }
}
