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
    
    public partial class xerife_evento_tomador
    {
        public int evento_tomador_id { get; set; }
        public System.DateTime exercicio { get; set; }
        public int repetir { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor { get; set; }
        public string modelo_bloqueio { get; set; }
        public byte[] controlversion { get; set; }
        public int evento_id { get; set; }
        public int tomador_id { get; set; }
        public Nullable<System.DateTime> validade { get; set; }
    
        public virtual xerife_evento xerife_evento { get; set; }
        public virtual xerife_tomador xerife_tomador { get; set; }
    }
}
