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
    
    public partial class xerife_mapeamento_tabela
    {
        public int mapeamento_tabela_id { get; set; }
        public Nullable<int> codigo_fiscal_id { get; set; }
        public int filial_id { get; set; }
        public int item_regime_tributario_id { get; set; }
        public int tipo { get; set; }
        public int tabela_id { get; set; }
    
        public virtual xerife_codigo_fiscal xerife_codigo_fiscal { get; set; }
        public virtual xerife_filial xerife_filial { get; set; }
        public virtual xerife_item_regime_tributario xerife_item_regime_tributario { get; set; }
        public virtual xerife_tabela xerife_tabela { get; set; }
    }
}
