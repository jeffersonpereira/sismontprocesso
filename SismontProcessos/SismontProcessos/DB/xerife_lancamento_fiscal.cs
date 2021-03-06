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
    
    public partial class xerife_lancamento_fiscal
    {
        public xerife_lancamento_fiscal()
        {
            this.xerife_ciap = new HashSet<xerife_ciap>();
            this.xerife_item_fiscal = new HashSet<xerife_item_fiscal>();
            this.xerife_item_parcela = new HashSet<xerife_item_parcela>();
            this.xerife_item_produto = new HashSet<xerife_item_produto>();
            this.xerife_nota_ct = new HashSet<xerife_nota_ct>();
            this.xerife_retencao = new HashSet<xerife_retencao>();
            this.xerife_sped_c420 = new HashSet<xerife_sped_c420>();
            this.xerife_sped_c460 = new HashSet<xerife_sped_c460>();
            this.xerife_sped_c490 = new HashSet<xerife_sped_c490>();
        }
    
        public int lancamento_fiscal_id { get; set; }
        public int tipo { get; set; }
        public int nota_fiscal { get; set; }
        public int nota_fiscal_final { get; set; }
        public string subserie { get; set; }
        public string serie { get; set; }
        public System.DateTime data_emissao { get; set; }
        public System.DateTime data_processamento { get; set; }
        public System.DateTime data_fiscal { get; set; }
        public int forma_pagamento { get; set; }
        public byte[] controlversion { get; set; }
        public int tipo_importacao { get; set; }
        public int tipo_frete { get; set; }
        public string chave_nfe { get; set; }
        public string anotacoes { get; set; }
        public int filial_id { get; set; }
        public Nullable<int> transferencia_filial_id { get; set; }
        public Nullable<int> centro_custo_id { get; set; }
        public int parceiro_id { get; set; }
        public int modelo_nota_fiscal_id { get; set; }
        public Nullable<int> estoque_id { get; set; }
        public Nullable<int> item_ecf_id { get; set; }
        public string numero_fatura { get; set; }
        public decimal total_base_calculo { get; set; }
        public decimal total_icms { get; set; }
        public decimal total_base_calculo_st { get; set; }
        public decimal total_st { get; set; }
        public decimal total_produto { get; set; }
        public decimal total_frete { get; set; }
        public decimal total_seguro { get; set; }
        public decimal total_desconto { get; set; }
        public decimal total_ii { get; set; }
        public decimal total_ipi { get; set; }
        public decimal total_pis { get; set; }
        public decimal total_cofins { get; set; }
        public decimal total_outros { get; set; }
        public decimal total_nota_fiscal { get; set; }
        public Nullable<System.DateTime> data_entrada { get; set; }
        public Nullable<System.DateTime> data_saida { get; set; }
        public int situacao { get; set; }
        public decimal valor_contabil { get; set; }
        public Nullable<int> item_transporte_id { get; set; }
        public decimal total_isento { get; set; }
        public decimal total_issqn { get; set; }
        public decimal total_cancelado { get; set; }
        public decimal total_nincidencia { get; set; }
        public decimal total_substituicao { get; set; }
        public Nullable<int> natureza_retencao { get; set; }
        public string codigo_receita_retencao { get; set; }
        public Nullable<long> importacao_id { get; set; }
        public string nfe_numero_recibo { get; set; }
        public int nfe_status { get; set; }
    
        public virtual xerife_centro_custo xerife_centro_custo { get; set; }
        public virtual ICollection<xerife_ciap> xerife_ciap { get; set; }
        public virtual xerife_estoque xerife_estoque { get; set; }
        public virtual xerife_filial xerife_filial { get; set; }
        public virtual xerife_filial xerife_filial1 { get; set; }
        public virtual xerife_item_ecf xerife_item_ecf { get; set; }
        public virtual ICollection<xerife_item_fiscal> xerife_item_fiscal { get; set; }
        public virtual ICollection<xerife_item_parcela> xerife_item_parcela { get; set; }
        public virtual ICollection<xerife_item_produto> xerife_item_produto { get; set; }
        public virtual xerife_item_transporte xerife_item_transporte { get; set; }
        public virtual ICollection<xerife_nota_ct> xerife_nota_ct { get; set; }
        public virtual ICollection<xerife_retencao> xerife_retencao { get; set; }
        public virtual ICollection<xerife_sped_c420> xerife_sped_c420 { get; set; }
        public virtual ICollection<xerife_sped_c460> xerife_sped_c460 { get; set; }
        public virtual ICollection<xerife_sped_c490> xerife_sped_c490 { get; set; }
        public virtual xerife_lancamento_importado xerife_lancamento_importado { get; set; }
        public virtual xerife_modelo_nota_fiscal xerife_modelo_nota_fiscal { get; set; }
        public virtual xerife_parceiro xerife_parceiro { get; set; }
    }
}
