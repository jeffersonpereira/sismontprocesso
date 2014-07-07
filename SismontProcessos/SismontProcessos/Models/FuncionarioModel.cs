﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Xerife.Data;

namespace SismontProcessos.Models
{
    [Serializable]
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
                    if(p.PropertyType.Equals(typeof(DateTime)))
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
            var requisisao = new xerife_requisicao();
            requisisao.tipo = Convert.ToInt32(value.tipo);
            requisisao.assunto_requisicao_id = Convert.ToInt32(value.assunto_requisicao_id);
            requisisao.solicitante = "Jefferson Pereira da Silva";
            requisisao.data = DateTime.Today;
            requisisao.origem = 0;
            requisisao.situacao = 0;
            requisisao.xml = funcionario.ObjectToByteArray();
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
        public string estado_civil { get; set; }
        public string conjuge { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string pis { get; set; }
        public string ctps { get; set; }
        public string serie { get; set; }
        public DateTime admissao { get; set; }
        public string titulo_eleitor { get; set; }
        public string zona { get; set; }
        public string secao { get; set; }
        public decimal salario { get; set; }
        public IList<DependenteModel> dependentes { get; set; }
    }
    [Serializable]
    public class DependenteModel
    {
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
    }
}