//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xerife.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class xerife_tabela
    {
        public xerife_tabela()
        {
            this.xerife_evento = new HashSet<xerife_evento>();
            this.xerife_item_fiscal = new HashSet<xerife_item_fiscal>();
            this.xerife_item_lancamento_servico = new HashSet<xerife_item_lancamento_servico>();
            this.xerife_item_regime_tributario = new HashSet<xerife_item_regime_tributario>();
            this.xerife_mapeamento_tabela = new HashSet<xerife_mapeamento_tabela>();
            this.xerife_tabela_item = new HashSet<xerife_tabela_item>();
        }
    
        public int tabela_id { get; set; }
        public string descricao { get; set; }
        public byte[] controlversion { get; set; }
        public int tipo { get; set; }
        public string anexo { get; set; }
        public string secao { get; set; }
        public string tabela { get; set; }
    
        public virtual ICollection<xerife_evento> xerife_evento { get; set; }
        public virtual ICollection<xerife_item_fiscal> xerife_item_fiscal { get; set; }
        public virtual ICollection<xerife_item_lancamento_servico> xerife_item_lancamento_servico { get; set; }
        public virtual ICollection<xerife_item_regime_tributario> xerife_item_regime_tributario { get; set; }
        public virtual ICollection<xerife_mapeamento_tabela> xerife_mapeamento_tabela { get; set; }
        public virtual ICollection<xerife_tabela_item> xerife_tabela_item { get; set; }
    }
}
