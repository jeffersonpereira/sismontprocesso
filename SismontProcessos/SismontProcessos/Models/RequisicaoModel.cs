using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SismontProcessos.DB;

namespace SismontProcessos.Models
{
    public class RequisicaoModel : IRequisicao
    {
        public byte[] xml { get; set; }
        public int tipo { get; set; }
        public DateTime data { get; set; }
        public string solicitante { get; set; }
        public int prioridade { get; set; }
        public int solucao { get; set; }
        public int situacao { get; set; }
        public DateTime? data_revisao { get; set; }
        public string revisor { get; set; }
        public int origem { get; set; }
        public DateTime? vencimento { get; set; }
        public int assunto_requisicao_id { get; set; }
        public Nullable<int> filial_id { get; set; }
    }
}