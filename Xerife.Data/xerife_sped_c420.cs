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
    
    public partial class xerife_sped_c420
    {
        public int sped_c420_id { get; set; }
        public string codigo_totalizador { get; set; }
        public decimal total_acumulado { get; set; }
        public int numero_totalizador { get; set; }
        public string descricao_totalizador { get; set; }
        public int lancamento_fiscal_id { get; set; }
    
        public virtual xerife_lancamento_fiscal xerife_lancamento_fiscal { get; set; }
    }
}
