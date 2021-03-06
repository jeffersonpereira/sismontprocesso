//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SismontProcessos.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class xerife_lancamento_servico
    {
        public xerife_lancamento_servico()
        {
            this.xerife_item_lancamento_servico = new HashSet<xerife_item_lancamento_servico>();
            this.xerife_retencao = new HashSet<xerife_retencao>();
            this.xerife_parcela_servico = new HashSet<xerife_parcela_servico>();
        }
    
        public int lancamento_servico_id { get; set; }
        public int nota_fiscal_inicial { get; set; }
        public int nota_fiscal_final { get; set; }
        public string serie { get; set; }
        public string subserie { get; set; }
        public System.DateTime data_emissao { get; set; }
        public System.DateTime data_processamento { get; set; }
        public int forma_pagamento { get; set; }
        public byte[] controlversion { get; set; }
        public int tipo_importacao { get; set; }
        public decimal valor_contabil { get; set; }
        public decimal valor_desconto { get; set; }
        public decimal valor_retencao { get; set; }
        public int filial_id { get; set; }
        public Nullable<int> centro_custo_id { get; set; }
        public int parceiro_id { get; set; }
        public string discriminacao { get; set; }
        public int modelo_nota_fiscal_id { get; set; }
        public Nullable<int> cnae_id { get; set; }
        public Nullable<int> tabela_servico_id { get; set; }
        public int situacao { get; set; }
        public string chave_nfe { get; set; }
        public string anotacoes { get; set; }
        public int tipo { get; set; }
        public string protocolo_nfe { get; set; }
        public int situacao_nfe { get; set; }
        public string error_nfe { get; set; }
        public Nullable<System.DateTime> data_execucao_servico { get; set; }
        public Nullable<int> natureza_base_credito { get; set; }
        public Nullable<int> origem_credito { get; set; }
        public int cst_pis { get; set; }
        public int cst_cofins { get; set; }
        public decimal base_calculo_pis { get; set; }
        public decimal base_calculo_cofins { get; set; }
        public decimal aliquota_pis { get; set; }
        public decimal aliquota_cofins { get; set; }
        public decimal valor_pis { get; set; }
        public decimal valor_cofins { get; set; }
        public Nullable<int> natureza_retencao { get; set; }
        public string codigo_receita_retencao { get; set; }
        public System.DateTime data_recebimento { get; set; }
        public Nullable<long> importacao_id { get; set; }
    
        public virtual xerife_centro_custo xerife_centro_custo { get; set; }
        public virtual xerife_cnae xerife_cnae { get; set; }
        public virtual xerife_filial xerife_filial { get; set; }
        public virtual ICollection<xerife_item_lancamento_servico> xerife_item_lancamento_servico { get; set; }
        public virtual xerife_lancamento_importado xerife_lancamento_importado { get; set; }
        public virtual ICollection<xerife_retencao> xerife_retencao { get; set; }
        public virtual ICollection<xerife_parcela_servico> xerife_parcela_servico { get; set; }
        public virtual xerife_modelo_nota_fiscal xerife_modelo_nota_fiscal { get; set; }
        public virtual xerife_parceiro xerife_parceiro { get; set; }
        public virtual xerife_tabela_servico xerife_tabela_servico { get; set; }
    }
}
