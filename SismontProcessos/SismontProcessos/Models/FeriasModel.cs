using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SismontProcessos.DB;

namespace SismontProcessos.Models
{
    [Serializable]
    public class FeriasModel
    {
        public static xerife_requisicao CreateObject(dynamic value)
        {
            var ferias = new FeriasModel();
            foreach (var p in ferias.GetType().GetProperties())
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
                    p.SetValue(ferias, valor);
                }
            }
            var requisisao = new xerife_requisicao();
            requisisao.tipo = Convert.ToInt32(value.tipo);
            requisisao.assunto_requisicao_id = Convert.ToInt32(value.assunto_requisicao_id);
            requisisao.data = DateTime.Today;
            requisisao.origem = 0;
            requisisao.situacao = 0;
            requisisao.filial_id = GlobalVars.FilialId;
            requisisao.xml = ferias.ObjectToByteArray();
            if (value.recursos != null)
            {
                foreach (var recurso in value.recursos)
                {
                    requisisao.recurso += recurso + ";";
                }
                requisisao.recurso = requisisao.recurso.TrimEnd(';');
            }
            requisisao.tipo_requisicao = (int)TipoRequisicao.Ferias;
            return requisisao;
        }

        public DateTime inicio_gozo { get; set; }
        public DateTime fim_gozo { get; set; }
        public bool abono { get; set; }
        public int dias_abono { get; set; }
        public int funcionario_id { get; set; }
    }
}