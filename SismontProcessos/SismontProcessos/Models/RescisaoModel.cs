using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SismontProcessos.DB;

namespace SismontProcessos.Models
{
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
            var requisisao = new xerife_requisicao();
            requisisao.tipo = Convert.ToInt32(value.tipo);
            requisisao.data = DateTime.Today;
            requisisao.xml = rescisao.ObjectToByteArray();
            return requisisao;
        }

    }
}