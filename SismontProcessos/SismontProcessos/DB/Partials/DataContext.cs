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

        public xerife_usuario UsuarioAtual
        {
            get { return this.xerife_usuario.FirstOrDefault(x => x.usuario_id == GlobalVars.UsuarioId); }
        }

        public xerife_filial FilialAtual
        {
            get { return this.xerife_filial.FirstOrDefault(x => x.filial_id == GlobalVars.FilialId); }
        }

        public bool IsAutenticate(string login, string cnpj, string senha, out xerife_usuario usuario, out xerife_filial filial)
        {
            filial = this.xerife_filial.FirstOrDefault(x => x.cnpj_cei.Equals(cnpj));
            bool liberado = false;
            var user = GetUsuario(login);
            if(filial!=null)
            {
                if (user != null)
                {
                    if (IsAcessoFilial(user, filial))
                    {
                        senha = Security.SecurityProvider.HashPassword(senha, user.salt);
                        liberado = senha.Equals(user.senha);
                    }
                }
            }
            usuario = liberado ? user : null;
            return liberado;
        }

        private xerife_usuario GetUsuario(string login)
        {
            return this.xerife_usuario.FirstOrDefault(x => x.login.ToLower().Equals(login.ToLower()));
        }

        private bool IsAcessoFilial(xerife_usuario usuario,xerife_filial filial)
        {
            return this.xerife_permissao_filial.Any(x => x.usuario_id == usuario.usuario_id && x.xerife_filial.filial_id == filial.filial_id);
        }

        public IQueryable GetFuncionarioDados()
        {
            var funcionarios = (from x in this.xerife_funcionario_dados.Include("xerife_funcionario")
                                where x.xerife_funcionario.filial_id == GlobalVars.FilialId &&
                                x.exercicio <= DateTime.Today &&
                                !x.xerife_funcionario.xerife_funcionario_situacao.Any(y=>y.codigo_afastamento==8 && y.afastamento<=DateTime.Today)
                                orderby x.nome ascending
                                select new { x.nome,x.funcionario_id,x.xerife_funcionario.matricula }).Distinct().AsQueryable();
            return funcionarios;
        }
    }
}
