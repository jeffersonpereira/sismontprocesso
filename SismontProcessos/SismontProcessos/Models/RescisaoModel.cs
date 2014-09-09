using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SismontProcessos.DB;
using System.Xml.Serialization;

namespace SismontProcessos.Models
{
    [XmlRoot("rescisao")]
    public class RescisaoModel
    {
        public static xerife_requisicao CreateObject(dynamic value)
        {
            var rescisao = new RescisaoModel();
            foreach (var p in rescisao.GetType().GetProperties())
            {
                var temp = value[p.Name];
                if (temp != null)
                {
                    object valor = null;
                    if (p.PropertyType.Equals(typeof(DateTime)))
                    {
                        valor = DateTime.ParseExact(temp.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        valor = Convert.ChangeType(temp, p.PropertyType, CultureInfo.InvariantCulture);
                    }
                    p.SetValue(rescisao, valor);
                }
            }
            var requisisao = xerife_requisicao.CreateRequisicao(TipoRequisicao.Rescisao,
                rescisao,
                Convert.ToInt32(value.assunto_requisicao_id),
                Convert.ToInt32(value.prioridade),
                Convert.ToInt32(value.tipo),
                value.recursos);
            return requisisao;
        }

        public int funcionario_id { get; set; }
        public DateTime data_afastamento { get; set; }
        public string aviso { get; set; }
        public int codigo_aviso { get; set; }
        public string afastamento { get; set; }
        public int codigo_afastamento { get; set; }
        public string observacao { get; set; }
    }
}