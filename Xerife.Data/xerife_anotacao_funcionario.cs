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
    
    public partial class xerife_anotacao_funcionario
    {
        public int anotacao_funcionario_id { get; set; }
        public System.DateTime data_anotacao { get; set; }
        public string anotacao { get; set; }
        public string usuario { get; set; }
        public int funcionario_id { get; set; }
    
        public virtual xerife_funcionario xerife_funcionario { get; set; }
    }
}
