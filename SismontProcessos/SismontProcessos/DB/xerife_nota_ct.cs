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
    
    public partial class xerife_nota_ct
    {
        public int nota_ct_id { get; set; }
        public int lancamento_fiscal_id { get; set; }
        public System.DateTime data_emissao { get; set; }
        public int modelo_nota_fiscal_id { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public decimal valor { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual xerife_lancamento_fiscal xerife_lancamento_fiscal { get; set; }
        public virtual xerife_modelo_nota_fiscal xerife_modelo_nota_fiscal { get; set; }
    }
}