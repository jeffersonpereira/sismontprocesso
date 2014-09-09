using SismontProcessos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SismontProcessos.DB
{
    public partial class xerife_requisicao
    {
        public static xerife_requisicao CreateRequisicao(TipoRequisicao tipo, object objSerialize, int assuntoId, int prioridade, int requisicao, dynamic recursos)
        {
            var requisisao = new xerife_requisicao();
            requisisao.tipo = requisicao;
            requisisao.prioridade = prioridade;
            requisisao.assunto_requisicao_id = assuntoId;
            requisisao.data = DateTime.Today;
            requisisao.origem = 0;
            requisisao.situacao = 0;
            requisisao.filial_id = GlobalVars.FilialId;
            requisisao.xml = Extensions.SerializeToXml(objSerialize);
            requisisao.tipo_requisicao = (int)tipo;
            foreach (var recurso in recursos)
            {
                requisisao.recurso += recurso + ";";
            }
            requisisao.recurso = requisisao.recurso.TrimEnd(';');
            return requisisao;
        }
        public dynamic Tag { get; set; }
        public string prioridade_descricao
        {
            get
            {
                switch(this.prioridade)
                {
                    case 0: return "Baixa";
                        break;
                    case 1: return "Média";
                        break;
                    case 2: return "Alta";
                        break;
                }
                return string.Empty;
            }
        }

        public string descricao_tipo
        {
            get
            {
                switch(this.tipo)
                {
                    case 0: return "Solicitação";
                        break;
                    case 1: return "Tarefa";
                        break;
                }
                return string.Empty;
            }
        }

        public string assunto
        {
            get
            {
                using(var context = new xerifeEntities())
                {
                    var assunto = context.xerife_assunto_requisicao.FirstOrDefault(x => x.assunto_requisicao_id == this.assunto_requisicao_id);
                    return assunto.descricao;
                }
            }
        }

        public bool isdetail
        {
            get
            {
                using (var context = new xerifeEntities())
                {
                    var isdetail = context.xerife_movimentacao_requisicao.Any(x => x.requisicao_id == this.requisicao_id);
                    return isdetail;
                }
            }
        }
    }
}
