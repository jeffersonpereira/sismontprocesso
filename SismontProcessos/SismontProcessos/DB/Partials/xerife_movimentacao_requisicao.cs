using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SismontProcessos.DB
{
    public partial class xerife_movimentacao_requisicao
    {
        public bool isanexo
        {
            get
            {
                using(var context = new xerifeEntities())
                {
                    return context.xerife_documento.Any(x => x.anexo_id == this.anexo_id && x.tabela.Equals("xerife_movimentacao_requisicao"));
                }
            }
        }

        public int qtd
        {
            get
            {
                using (var context = new xerifeEntities())
                {
                    return context.xerife_documento.Where(x => x.anexo_id == this.anexo_id && x.tabela.Equals("xerife_movimentacao_requisicao")).Count();
                }
            }
        }
    }
}
