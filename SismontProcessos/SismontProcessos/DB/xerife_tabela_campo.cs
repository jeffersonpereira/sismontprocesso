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
    
    public partial class xerife_tabela_campo
    {
        public xerife_tabela_campo()
        {
            this.xerife_campo_usuario = new HashSet<xerife_campo_usuario>();
        }
    
        public int campo_id { get; set; }
        public string tabela { get; set; }
        public string campo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public string formato { get; set; }
        public byte[] controlversion { get; set; }
        public bool ischave { get; set; }
        public bool isvisivel { get; set; }
        public bool ispadrao { get; set; }
    
        public virtual ICollection<xerife_campo_usuario> xerife_campo_usuario { get; set; }
    }
}
