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
    
    public partial class xerife_folha_plano_saude_dependente
    {
        public int folha_plano_saude_id { get; set; }
        public System.DateTime exercicio { get; set; }
        public decimal desconto { get; set; }
        public int dependente_funcionario_id { get; set; }
        public int plano_saude_id { get; set; }
        public byte[] controlversion { get; set; }
        public bool informado { get; set; }
    
        public virtual xerife_dependente_funcionario xerife_dependente_funcionario { get; set; }
        public virtual xerife_plano_saude xerife_plano_saude { get; set; }
    }
}
