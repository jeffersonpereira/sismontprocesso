﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class xerifeEntities : DbContext
    {
        public xerifeEntities()
            : base("name=xerifeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<xerife_acumulador_fiscal> xerife_acumulador_fiscal { get; set; }
        public virtual DbSet<xerife_acumulador_guia> xerife_acumulador_guia { get; set; }
        public virtual DbSet<xerife_acumulador_servico> xerife_acumulador_servico { get; set; }
        public virtual DbSet<xerife_alocacao_tomador> xerife_alocacao_tomador { get; set; }
        public virtual DbSet<xerife_anexo_mensagem> xerife_anexo_mensagem { get; set; }
        public virtual DbSet<xerife_anotacao_funcionario> xerife_anotacao_funcionario { get; set; }
        public virtual DbSet<xerife_anotacao_parceiro> xerife_anotacao_parceiro { get; set; }
        public virtual DbSet<xerife_apuracao_imposto> xerife_apuracao_imposto { get; set; }
        public virtual DbSet<xerife_arquivo> xerife_arquivo { get; set; }
        public virtual DbSet<xerife_arquivo_bancario> xerife_arquivo_bancario { get; set; }
        public virtual DbSet<xerife_assunto_requisicao> xerife_assunto_requisicao { get; set; }
        public virtual DbSet<xerife_atestado> xerife_atestado { get; set; }
        public virtual DbSet<xerife_auditoria> xerife_auditoria { get; set; }
        public virtual DbSet<xerife_banco> xerife_banco { get; set; }
        public virtual DbSet<xerife_bloqueio_mensal> xerife_bloqueio_mensal { get; set; }
        public virtual DbSet<xerife_calendario> xerife_calendario { get; set; }
        public virtual DbSet<xerife_calendario_item> xerife_calendario_item { get; set; }
        public virtual DbSet<xerife_campo_usuario> xerife_campo_usuario { get; set; }
        public virtual DbSet<xerife_cargo> xerife_cargo { get; set; }
        public virtual DbSet<xerife_categoria> xerife_categoria { get; set; }
        public virtual DbSet<xerife_categoria_financeira> xerife_categoria_financeira { get; set; }
        public virtual DbSet<xerife_centro_custo> xerife_centro_custo { get; set; }
        public virtual DbSet<xerife_ciap> xerife_ciap { get; set; }
        public virtual DbSet<xerife_ciap_item> xerife_ciap_item { get; set; }
        public virtual DbSet<xerife_classe_fiscal> xerife_classe_fiscal { get; set; }
        public virtual DbSet<xerife_cnae> xerife_cnae { get; set; }
        public virtual DbSet<xerife_codigo_fiscal> xerife_codigo_fiscal { get; set; }
        public virtual DbSet<xerife_conducao> xerife_conducao { get; set; }
        public virtual DbSet<xerife_conducao_funcionario> xerife_conducao_funcionario { get; set; }
        public virtual DbSet<xerife_conducao_item> xerife_conducao_item { get; set; }
        public virtual DbSet<xerife_configuracao> xerife_configuracao { get; set; }
        public virtual DbSet<xerife_configuracao_folha> xerife_configuracao_folha { get; set; }
        public virtual DbSet<xerife_conta_bancaria> xerife_conta_bancaria { get; set; }
        public virtual DbSet<xerife_conta_financeira> xerife_conta_financeira { get; set; }
        public virtual DbSet<xerife_contador> xerife_contador { get; set; }
        public virtual DbSet<xerife_contra_partida> xerife_contra_partida { get; set; }
        public virtual DbSet<xerife_cookie> xerife_cookie { get; set; }
        public virtual DbSet<xerife_deducoes> xerife_deducoes { get; set; }
        public virtual DbSet<xerife_departamento> xerife_departamento { get; set; }
        public virtual DbSet<xerife_dependente_funcionario> xerife_dependente_funcionario { get; set; }
        public virtual DbSet<xerife_detalhamento_fiscal> xerife_detalhamento_fiscal { get; set; }
        public virtual DbSet<xerife_documento> xerife_documento { get; set; }
        public virtual DbSet<xerife_documento_portal> xerife_documento_portal { get; set; }
        public virtual DbSet<xerife_ecf> xerife_ecf { get; set; }
        public virtual DbSet<xerife_empresa> xerife_empresa { get; set; }
        public virtual DbSet<xerife_empresa_comercial> xerife_empresa_comercial { get; set; }
        public virtual DbSet<xerife_empresa_contabil> xerife_empresa_contabil { get; set; }
        public virtual DbSet<xerife_empresa_fiscal> xerife_empresa_fiscal { get; set; }
        public virtual DbSet<xerife_empresa_folha> xerife_empresa_folha { get; set; }
        public virtual DbSet<xerife_estoque> xerife_estoque { get; set; }
        public virtual DbSet<xerife_estorno> xerife_estorno { get; set; }
        public virtual DbSet<xerife_estorno_item> xerife_estorno_item { get; set; }
        public virtual DbSet<xerife_evento> xerife_evento { get; set; }
        public virtual DbSet<xerife_evento_automatizado> xerife_evento_automatizado { get; set; }
        public virtual DbSet<xerife_evento_departamento> xerife_evento_departamento { get; set; }
        public virtual DbSet<xerife_evento_filial> xerife_evento_filial { get; set; }
        public virtual DbSet<xerife_evento_funcionario> xerife_evento_funcionario { get; set; }
        public virtual DbSet<xerife_evento_parametro> xerife_evento_parametro { get; set; }
        public virtual DbSet<xerife_evento_programado> xerife_evento_programado { get; set; }
        public virtual DbSet<xerife_evento_programado_item> xerife_evento_programado_item { get; set; }
        public virtual DbSet<xerife_evento_sindicato> xerife_evento_sindicato { get; set; }
        public virtual DbSet<xerife_evento_tomador> xerife_evento_tomador { get; set; }
        public virtual DbSet<xerife_evento_usuario> xerife_evento_usuario { get; set; }
        public virtual DbSet<xerife_exame_medico> xerife_exame_medico { get; set; }
        public virtual DbSet<xerife_exposicao_fator_risco> xerife_exposicao_fator_risco { get; set; }
        public virtual DbSet<xerife_extrato> xerife_extrato { get; set; }
        public virtual DbSet<xerife_falta> xerife_falta { get; set; }
        public virtual DbSet<xerife_favorito> xerife_favorito { get; set; }
        public virtual DbSet<xerife_ferias> xerife_ferias { get; set; }
        public virtual DbSet<xerife_filial> xerife_filial { get; set; }
        public virtual DbSet<xerife_folha> xerife_folha { get; set; }
        public virtual DbSet<xerife_folha_plano_saude_dependente> xerife_folha_plano_saude_dependente { get; set; }
        public virtual DbSet<xerife_folha_plano_saude_funcionario> xerife_folha_plano_saude_funcionario { get; set; }
        public virtual DbSet<xerife_forma_pagamento> xerife_forma_pagamento { get; set; }
        public virtual DbSet<xerife_formula> xerife_formula { get; set; }
        public virtual DbSet<xerife_fpas> xerife_fpas { get; set; }
        public virtual DbSet<xerife_funcionario> xerife_funcionario { get; set; }
        public virtual DbSet<xerife_funcionario_dados> xerife_funcionario_dados { get; set; }
        public virtual DbSet<xerife_funcionario_inativo> xerife_funcionario_inativo { get; set; }
        public virtual DbSet<xerife_funcionario_situacao> xerife_funcionario_situacao { get; set; }
        public virtual DbSet<xerife_gerador_id> xerife_gerador_id { get; set; }
        public virtual DbSet<xerife_gps> xerife_gps { get; set; }
        public virtual DbSet<xerife_grau_instrucao> xerife_grau_instrucao { get; set; }
        public virtual DbSet<xerife_historico_contabil> xerife_historico_contabil { get; set; }
        public virtual DbSet<xerife_horario> xerife_horario { get; set; }
        public virtual DbSet<xerife_horario_item> xerife_horario_item { get; set; }
        public virtual DbSet<xerife_imposto> xerife_imposto { get; set; }
        public virtual DbSet<xerife_incidencia> xerife_incidencia { get; set; }
        public virtual DbSet<xerife_incidencia_opcoes> xerife_incidencia_opcoes { get; set; }
        public virtual DbSet<xerife_indice> xerife_indice { get; set; }
        public virtual DbSet<xerife_indice_item> xerife_indice_item { get; set; }
        public virtual DbSet<xerife_infaz> xerife_infaz { get; set; }
        public virtual DbSet<xerife_integracao> xerife_integracao { get; set; }
        public virtual DbSet<xerife_integracao_fiscal> xerife_integracao_fiscal { get; set; }
        public virtual DbSet<xerife_integracao_generica> xerife_integracao_generica { get; set; }
        public virtual DbSet<xerife_item_cofins> xerife_item_cofins { get; set; }
        public virtual DbSet<xerife_item_ecf> xerife_item_ecf { get; set; }
        public virtual DbSet<xerife_item_fiscal> xerife_item_fiscal { get; set; }
        public virtual DbSet<xerife_item_icms> xerife_item_icms { get; set; }
        public virtual DbSet<xerife_item_ii> xerife_item_ii { get; set; }
        public virtual DbSet<xerife_item_ipi> xerife_item_ipi { get; set; }
        public virtual DbSet<xerife_item_issqn> xerife_item_issqn { get; set; }
        public virtual DbSet<xerife_item_lancamento_servico> xerife_item_lancamento_servico { get; set; }
        public virtual DbSet<xerife_item_parcela> xerife_item_parcela { get; set; }
        public virtual DbSet<xerife_item_pis> xerife_item_pis { get; set; }
        public virtual DbSet<xerife_item_produto> xerife_item_produto { get; set; }
        public virtual DbSet<xerife_item_regime_tributario> xerife_item_regime_tributario { get; set; }
        public virtual DbSet<xerife_item_transporte> xerife_item_transporte { get; set; }
        public virtual DbSet<xerife_lancamento_contabil> xerife_lancamento_contabil { get; set; }
        public virtual DbSet<xerife_lancamento_fiscal> xerife_lancamento_fiscal { get; set; }
        public virtual DbSet<xerife_lancamento_importado> xerife_lancamento_importado { get; set; }
        public virtual DbSet<xerife_lancamento_servico> xerife_lancamento_servico { get; set; }
        public virtual DbSet<xerife_livro_fiscal> xerife_livro_fiscal { get; set; }
        public virtual DbSet<xerife_livro_fiscal_item> xerife_livro_fiscal_item { get; set; }
        public virtual DbSet<xerife_lote_contabil> xerife_lote_contabil { get; set; }
        public virtual DbSet<xerife_mapa_tributario> xerife_mapa_tributario { get; set; }
        public virtual DbSet<xerife_mapeamento_tabela> xerife_mapeamento_tabela { get; set; }
        public virtual DbSet<xerife_mensagem> xerife_mensagem { get; set; }
        public virtual DbSet<xerife_modelo_nota_fiscal> xerife_modelo_nota_fiscal { get; set; }
        public virtual DbSet<xerife_moeda> xerife_moeda { get; set; }
        public virtual DbSet<xerife_movimentacao_requisicao> xerife_movimentacao_requisicao { get; set; }
        public virtual DbSet<xerife_movimentacao_sefip> xerife_movimentacao_sefip { get; set; }
        public virtual DbSet<xerife_municipio> xerife_municipio { get; set; }
        public virtual DbSet<xerife_nacionalidade> xerife_nacionalidade { get; set; }
        public virtual DbSet<xerife_natureza_juridica> xerife_natureza_juridica { get; set; }
        public virtual DbSet<xerife_nota_ct> xerife_nota_ct { get; set; }
        public virtual DbSet<xerife_ocorrencia> xerife_ocorrencia { get; set; }
        public virtual DbSet<xerife_outras_receitas> xerife_outras_receitas { get; set; }
        public virtual DbSet<xerife_outras_receitas_item> xerife_outras_receitas_item { get; set; }
        public virtual DbSet<xerife_parceiro> xerife_parceiro { get; set; }
        public virtual DbSet<xerife_parceiro_desconto> xerife_parceiro_desconto { get; set; }
        public virtual DbSet<xerife_parcela_servico> xerife_parcela_servico { get; set; }
        public virtual DbSet<xerife_pasta_mensagem> xerife_pasta_mensagem { get; set; }
        public virtual DbSet<xerife_patrimonio> xerife_patrimonio { get; set; }
        public virtual DbSet<xerife_permissao> xerife_permissao { get; set; }
        public virtual DbSet<xerife_permissao_filial> xerife_permissao_filial { get; set; }
        public virtual DbSet<xerife_permissao_regra> xerife_permissao_regra { get; set; }
        public virtual DbSet<xerife_piso_salarial> xerife_piso_salarial { get; set; }
        public virtual DbSet<xerife_plano_centro_custo> xerife_plano_centro_custo { get; set; }
        public virtual DbSet<xerife_plano_conta> xerife_plano_conta { get; set; }
        public virtual DbSet<xerife_plano_filial> xerife_plano_filial { get; set; }
        public virtual DbSet<xerife_plano_saude> xerife_plano_saude { get; set; }
        public virtual DbSet<xerife_plano_saude_dependente> xerife_plano_saude_dependente { get; set; }
        public virtual DbSet<xerife_plano_saude_filial> xerife_plano_saude_filial { get; set; }
        public virtual DbSet<xerife_plano_saude_funcionario> xerife_plano_saude_funcionario { get; set; }
        public virtual DbSet<xerife_ppp> xerife_ppp { get; set; }
        public virtual DbSet<xerife_produto> xerife_produto { get; set; }
        public virtual DbSet<xerife_profissiografia> xerife_profissiografia { get; set; }
        public virtual DbSet<xerife_protocolo> xerife_protocolo { get; set; }
        public virtual DbSet<xerife_rateio_financeiro> xerife_rateio_financeiro { get; set; }
        public virtual DbSet<xerife_recolhimento_sefip> xerife_recolhimento_sefip { get; set; }
        public virtual DbSet<xerife_refeicao_funcionario> xerife_refeicao_funcionario { get; set; }
        public virtual DbSet<xerife_regime_tributario> xerife_regime_tributario { get; set; }
        public virtual DbSet<xerife_regra> xerife_regra { get; set; }
        public virtual DbSet<xerife_regra_acesso> xerife_regra_acesso { get; set; }
        public virtual DbSet<xerife_regra_acesso_item> xerife_regra_acesso_item { get; set; }
        public virtual DbSet<xerife_requisicao> xerife_requisicao { get; set; }
        public virtual DbSet<xerife_rescisao> xerife_rescisao { get; set; }
        public virtual DbSet<xerife_responsavel_registro_ppp> xerife_responsavel_registro_ppp { get; set; }
        public virtual DbSet<xerife_retencao> xerife_retencao { get; set; }
        public virtual DbSet<xerife_saldo_anterior_produto> xerife_saldo_anterior_produto { get; set; }
        public virtual DbSet<xerife_saldo_centro_custo> xerife_saldo_centro_custo { get; set; }
        public virtual DbSet<xerife_saldo_patrimonio> xerife_saldo_patrimonio { get; set; }
        public virtual DbSet<xerife_saldo_produto> xerife_saldo_produto { get; set; }
        public virtual DbSet<xerife_schema> xerife_schema { get; set; }
        public virtual DbSet<xerife_sindicato> xerife_sindicato { get; set; }
        public virtual DbSet<xerife_sindicato_parametro> xerife_sindicato_parametro { get; set; }
        public virtual DbSet<xerife_sip> xerife_sip { get; set; }
        public virtual DbSet<xerife_situacao_fiscal> xerife_situacao_fiscal { get; set; }
        public virtual DbSet<xerife_situacao_folha> xerife_situacao_folha { get; set; }
        public virtual DbSet<xerife_sped_c420> xerife_sped_c420 { get; set; }
        public virtual DbSet<xerife_sped_c460> xerife_sped_c460 { get; set; }
        public virtual DbSet<xerife_sped_c470> xerife_sped_c470 { get; set; }
        public virtual DbSet<xerife_sped_c490> xerife_sped_c490 { get; set; }
        public virtual DbSet<xerife_tabela> xerife_tabela { get; set; }
        public virtual DbSet<xerife_tabela_campo> xerife_tabela_campo { get; set; }
        public virtual DbSet<xerife_tabela_item> xerife_tabela_item { get; set; }
        public virtual DbSet<xerife_tabela_servico> xerife_tabela_servico { get; set; }
        public virtual DbSet<xerife_tipo_contrato> xerife_tipo_contrato { get; set; }
        public virtual DbSet<xerife_tipo_documento> xerife_tipo_documento { get; set; }
        public virtual DbSet<xerife_tipo_evento> xerife_tipo_evento { get; set; }
        public virtual DbSet<xerife_tipo_extrato> xerife_tipo_extrato { get; set; }
        public virtual DbSet<xerife_tipo_parceiro> xerife_tipo_parceiro { get; set; }
        public virtual DbSet<xerife_titulo> xerife_titulo { get; set; }
        public virtual DbSet<xerife_titulo_tag> xerife_titulo_tag { get; set; }
        public virtual DbSet<xerife_tomador> xerife_tomador { get; set; }
        public virtual DbSet<xerife_tomador_mensal> xerife_tomador_mensal { get; set; }
        public virtual DbSet<xerife_total_contabil> xerife_total_contabil { get; set; }
        public virtual DbSet<xerife_total_contabil_usuario> xerife_total_contabil_usuario { get; set; }
        public virtual DbSet<xerife_uf> xerife_uf { get; set; }
        public virtual DbSet<xerife_unidade> xerife_unidade { get; set; }
        public virtual DbSet<xerife_usuario> xerife_usuario { get; set; }
        public virtual DbSet<xerife_usuario_regra> xerife_usuario_regra { get; set; }
        public virtual DbSet<xerife_vale_refeicao> xerife_vale_refeicao { get; set; }
        public virtual DbSet<xerife_vale_valor> xerife_vale_valor { get; set; }
        public virtual DbSet<xerife_variavel> xerife_variavel { get; set; }
        public virtual DbSet<xerife_variavel_valor> xerife_variavel_valor { get; set; }
        public virtual DbSet<xerife_vinculo> xerife_vinculo { get; set; }
    }
}
