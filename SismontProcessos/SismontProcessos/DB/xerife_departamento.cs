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
    
    public partial class xerife_departamento
    {
        public xerife_departamento()
        {
            this.xerife_evento_departamento = new HashSet<xerife_evento_departamento>();
            this.xerife_funcionario_dados = new HashSet<xerife_funcionario_dados>();
        }
    
        public int departamento_id { get; set; }
        public string descricao { get; set; }
        public byte[] controlversion { get; set; }
        public int empresa_id { get; set; }
    
        public virtual ICollection<xerife_evento_departamento> xerife_evento_departamento { get; set; }
        public virtual ICollection<xerife_funcionario_dados> xerife_funcionario_dados { get; set; }
        public virtual xerife_empresa xerife_empresa { get; set; }
    }
}