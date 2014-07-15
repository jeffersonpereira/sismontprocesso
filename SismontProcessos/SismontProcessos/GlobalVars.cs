using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SismontProcessos
{
    public static class GlobalVars
    {
        /// <summary>
        /// Retorna o Id da Filial da sessão
        /// </summary>
        public static int FilialId
        {
            get
            {
                int? id = HttpContext.Current.Session["filialId"] as int?;
                return id.GetValueOrDefault(0);
            }
        }

        /// <summary>
        /// Retorna o Id do usuário da sessão
        /// </summary>
        public static int UsuarioId
        {
            get
            {
                int? id = HttpContext.Current.Session["usuarioId"] as int?;
                return id.GetValueOrDefault(0);
            }
        }
    }
}