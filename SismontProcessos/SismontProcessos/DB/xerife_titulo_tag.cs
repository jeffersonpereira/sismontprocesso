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
    
    public partial class xerife_titulo_tag
    {
        public int tag_id { get; set; }
        public int titulo_id { get; set; }
        public int categoria_financeira_id { get; set; }
    
        public virtual xerife_categoria_financeira xerife_categoria_financeira { get; set; }
        public virtual xerife_titulo xerife_titulo { get; set; }
    }
}