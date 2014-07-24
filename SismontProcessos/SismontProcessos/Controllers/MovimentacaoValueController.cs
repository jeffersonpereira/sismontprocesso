using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SismontProcessos.DB;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using SismontProcessos.Models;

namespace SismontProcessos.Controllers
{
    public class MovimentacaoValueController : ValuesController
    {
        [HttpGet]
        public IQueryable<xerife_movimentacao_requisicao> GetMovimentacao()
        {
            return Get<xerife_movimentacao_requisicao>();
        }

        [HttpGet]
        public IQueryable<xerife_movimentacao_requisicao> GetMovimentacao(int id)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("requisicao_id", id);
            return Get<xerife_movimentacao_requisicao>(p);
        }

        private static readonly string uploadFolder = "~/App_Data/FileUploads";
 

        [HttpPost]
        public async Task<HttpResponseMessage> Upload()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                this.Request.CreateResponse(HttpStatusCode.UnsupportedMediaType);
            }

            var provider = GetMultipartProvider();
            var result = await Request.Content.ReadAsMultipartAsync(provider);

            /*Recupara o nome original pois o arquivo virá pois grava como "BodyPart_26d6abe1-3ae1-416a-9429-b35f15e6e5d5"*/
            var originalFileName = GetDeserializedFileName(result.FileData.First());

            /*É necessário renomear o arquivo*/
            var uploadedFileInfo = new FileInfo(result.FileData.First().LocalFileName);
            originalFileName = uploadedFileInfo.DirectoryName + @"\" + originalFileName;
            System.IO.File.Move(uploadedFileInfo.FullName, originalFileName);

            var returnData = "ReturnTest";
            return this.Request.CreateResponse(HttpStatusCode.OK, new { returnData });
        }

        // You could extract these two private methods to a separate utility class since
        // they do not really belong to a controller class but that is up to you
        private MultipartFormDataStreamProvider GetMultipartProvider()
        {
            var root = HttpContext.Current.Server.MapPath(uploadFolder);
            Directory.CreateDirectory(root);
            return new MultipartFormDataStreamProvider(root);
        }

        private string GetDeserializedFileName(MultipartFileData fileData)
        {
            var fileName = GetFileName(fileData);
            return JsonConvert.DeserializeObject(fileName).ToString();
        }

        public string GetFileName(MultipartFileData fileData)
        {
            return fileData.Headers.ContentDisposition.FileName;
        }
    }
}
