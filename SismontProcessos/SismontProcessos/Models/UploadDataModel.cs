using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SismontProcessos.Models
{
    public class UploadDataModel
    {
        public string nome_original { get; set; }
        public string nome_temporario { get; set; }
        public string url_download { get; set; }
    }
}