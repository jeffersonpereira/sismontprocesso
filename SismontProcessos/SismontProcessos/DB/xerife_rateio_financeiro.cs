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
    
    public partial class xerife_rateio_financeiro
    {
        public int rateio_financeiro_id { get; set; }
        public decimal valor { get; set; }
        public byte[] controlversion { get; set; }
        public int conta_financeira_id { get; set; }
        public int centro_custo_id { get; set; }
        public int titulo_id { get; set; }
    
        public virtual xerife_centro_custo xerife_centro_custo { get; set; }
        public virtual xerife_conta_financeira xerife_conta_financeira { get; set; }
        public virtual xerife_titulo xerife_titulo { get; set; }
    }
}