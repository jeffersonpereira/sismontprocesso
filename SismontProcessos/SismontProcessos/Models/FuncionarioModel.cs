using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SismontProcessos.DB;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace SismontProcessos.Models
{
    public enum TipoRequisicao
    {
        Outros,
        Funcionario,
        Ferias,
        Rescisao
    }

    [XmlRoot("funcionario")]
    public class FuncionarioModel
    {
        public static xerife_requisicao CreateObject(dynamic value)
        {
            var funcionario         = new FuncionarioModel();
            foreach (var p in funcionario.GetType().GetProperties())
            {
                var temp = value[p.Name];
                if (temp != null)
                {
                    object valor = null;
                    if (p.PropertyType.Equals(typeof(DateTime)) || (p.PropertyType.Equals(typeof(DateTime?)) && temp!=null))
                    {
                        valor = DateTime.ParseExact(temp.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        p.SetValue(funcionario, valor);
                    }
                    else if (!p.Name.Equals("dependentes"))
                    {
                        valor = Convert.ChangeType(temp, p.PropertyType, CultureInfo.InvariantCulture);
                        p.SetValue(funcionario, valor);
                        
                    }
                    else if (p.Name.Equals("dependentes"))
                    {
                        funcionario.dependentes = new List<DependenteModel>();
                        foreach (var d in temp)
                        {
                            funcionario.dependentes.Add(new DependenteModel { nome = d["nome"], nascimento = DateTime.ParseExact(d["nascimento"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture) });
                        }
                    }
                }
            }
            var requisisao = xerife_requisicao.CreateRequisicao(TipoRequisicao.Funcionario,
                funcionario,
                Convert.ToInt32(value.assunto_requisicao_id),
                Convert.ToInt32(value.prioridade),
                Convert.ToInt32(value.tipo),
                value.recursos);
            return requisisao;
        }

        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        public int estado_civil { get; set; }
        public string conjuge { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string pis { get; set; }
        public string cnh { get; set; }
        public string categoria_cnh { get; set; }
        public DateTime? validade_cnh { get; set; }
        public string ctps { get; set; }
        public string serie { get; set; }
        public DateTime admissao { get; set; }
        public DateTime? data_emissao_rg { get; set; }
        public string titulo_eleitor { get; set; }
        public string zona { get; set; }
        public string secao { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
        public string naturalidade { get; set; }
        public string uf_naturalidade { get; set; }
        public int raca { get; set; }
        public int deficiencia { get; set; }
        public int cabelo { get; set; }
        public int olhos { get; set; }
        public decimal peso { get; set; }
        public decimal altura { get; set; }
        public string tipo_sanguineo { get; set; }
        public int grau_instrucao { get; set; }
        public List<DependenteModel> dependentes { get; set; }
    }
    [Serializable]
    public class DependenteModel
    {
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string cpf { get; set; }
        public int tipo { get; set; }
        public int parentesco { get; set; }
        public string sexo { get; set; }
    }
}