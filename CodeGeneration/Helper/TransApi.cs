using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodeGeneration.Helper
{
    /// <summary>
    /// 翻译api
    /// </summary>
    public class TransApi
    {

        public static Translation GetTransResult(string query)
        {
            string url =
                @"http://fanyi.youdao.com/openapi.do?keyfrom=testappweb&key=2124816549&type=data&doctype=json&version=1.1&q=" +
                HttpUtility.UrlEncode(query);
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;

            HttpWebResponse res = req.GetResponse() as HttpWebResponse;

            string xmlJson = new StreamReader(res.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(xmlJson));

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Translation));
            Translation trans = (Translation)jsonSerializer.ReadObject(ms);

            return trans;
        }
    }
}
