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
    
    public partial class xerife_classe_fiscal
    {
        public xerife_classe_fiscal()
        {
            this.xerife_codigo_fiscal = new HashSet<xerife_codigo_fiscal>();
        }
    
        public int classe_fiscal_id { get; set; }
        public string descricao { get; set; }
        public int tipo_padrao { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual ICollection<xerife_codigo_fiscal> xerife_codigo_fiscal { get; set; }
    }
}
