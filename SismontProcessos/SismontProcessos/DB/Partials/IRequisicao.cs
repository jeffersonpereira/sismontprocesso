using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SismontProcessos.DB;

namespace SismontProcessos.DB
{
     public interface IRequisicao
    {
         int tipo { get; set; }
         DateTime data { get; set; }
         string solicitante { get; set; }
         int prioridade { get; set; }
         int solucao { get; set; }
         int situacao { get; set; }
         DateTime? data_revisao { get; set; }
         string revisor { get; set; }
         int origem { get; set; }
         DateTime? vencimento { get; set; }
         int assunto_requisicao_id { get; set; }
         Nullable<int> filial_id { get; set; }
         byte[] xml { get; set; }

    }
}
