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
    
    public partial class xerife_piso_salarial
    {
        public int piso_salarial_id { get; set; }
        public System.DateTime exercicio { get; set; }
        public decimal valor { get; set; }
        public int cargo_id { get; set; }
        public byte[] controlversion { get; set; }
        public int sindicato_id { get; set; }
    
        public virtual xerife_cargo xerife_cargo { get; set; }
        public virtual xerife_sindicato xerife_sindicato { get; set; }
    }
}
