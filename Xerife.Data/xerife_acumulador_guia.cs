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
    
    public partial class xerife_acumulador_guia
    {
        public int acumulador_guia_id { get; set; }
        public int filial_id { get; set; }
        public int guia { get; set; }
        public string exercicio { get; set; }
        public decimal minimo { get; set; }
        public decimal valor { get; set; }
        public decimal saldo { get; set; }
        public byte[] controlversion { get; set; }
    
        public virtual xerife_filial xerife_filial { get; set; }
    }
}
