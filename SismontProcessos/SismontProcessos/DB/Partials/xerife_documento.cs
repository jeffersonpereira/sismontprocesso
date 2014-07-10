using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SismontProcessos.DB
{
    public partial class xerife_documento
    {
        public string nome_arquivo
        {
            get
            {
                using(var context = new xerifeEntities())
                {
                    var arquivo = context.xerife_arquivo.FirstOrDefault(x => x.arquivo_id == this.arquivo_id);
                    if(arquivo!=null)
                    {
                        return arquivo.nome;
                    }
                    return string.Empty;
                }
            }
        }
    }
}
