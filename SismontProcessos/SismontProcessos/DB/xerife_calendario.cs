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
    
    public partial class xerife_calendario
    {
        public xerife_calendario()
        {
            this.xerife_funcionario_dados = new HashSet<xerife_funcionario_dados>();
            this.xerife_funcionario_dados1 = new HashSet<xerife_funcionario_dados>();
            this.xerife_calendario_item = new HashSet<xerife_calendario_item>();
            this.xerife_funcionario_dados2 = new HashSet<xerife_funcionario_dados>();
            this.xerife_funcionario_dados3 = new HashSet<xerife_funcionario_dados>();
        }
    
        public int calendario_id { get; set; }
        public string descricao { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual ICollection<xerife_funcionario_dados> xerife_funcionario_dados { get; set; }
        public virtual ICollection<xerife_funcionario_dados> xerife_funcionario_dados1 { get; set; }
        public virtual ICollection<xerife_calendario_item> xerife_calendario_item { get; set; }
        public virtual ICollection<xerife_funcionario_dados> xerife_funcionario_dados2 { get; set; }
        public virtual ICollection<xerife_funcionario_dados> xerife_funcionario_dados3 { get; set; }
    }
}