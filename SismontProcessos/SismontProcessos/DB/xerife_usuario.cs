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
    
    public partial class xerife_usuario
    {
        public xerife_usuario()
        {
            this.xerife_pasta_mensagem = new HashSet<xerife_pasta_mensagem>();
            this.xerife_permissao_filial = new HashSet<xerife_permissao_filial>();
            this.xerife_usuario_regra = new HashSet<xerife_usuario_regra>();
        }
    
        public int usuario_id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public int formato { get; set; }
        public string salt { get; set; }
        public bool ativo { get; set; }
        public bool bloqueado { get; set; }
        public Nullable<System.DateTime> ultimo_login { get; set; }
        public Nullable<System.DateTime> ultimo_logout { get; set; }
        public Nullable<System.DateTime> ultima_mudanca_senha { get; set; }
        public int numero_falhas_senha { get; set; }
        public Nullable<System.DateTime> inicio_falha_senha { get; set; }
        public byte[] controlversion { get; set; }
        public bool uso_interno { get; set; }
        public bool limitado_por_computador { get; set; }
        public string computador { get; set; }
        public Nullable<int> regra_acesso_id { get; set; }
        public string email { get; set; }
        public bool bloquear_acesso_simultaneo { get; set; }
        public bool modulo_requisicao { get; set; }
    
        public virtual ICollection<xerife_pasta_mensagem> xerife_pasta_mensagem { get; set; }
        public virtual ICollection<xerife_permissao_filial> xerife_permissao_filial { get; set; }
        public virtual xerife_regra_acesso xerife_regra_acesso { get; set; }
        public virtual ICollection<xerife_usuario_regra> xerife_usuario_regra { get; set; }
    }
}
