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
    
    public partial class xerife_unidade
    {
        public xerife_unidade()
        {
            this.xerife_produto = new HashSet<xerife_produto>();
            this.xerife_produto1 = new HashSet<xerife_produto>();
        }
    
        public int unidade_id { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
    
        public virtual ICollection<xerife_produto> xerife_produto { get; set; }
        public virtual ICollection<xerife_produto> xerife_produto1 { get; set; }
    }
}
