using System;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace ClassLibrary1
{
    public static class ESIConnection
    {

        public static string GetJsonFromUri(string uri)
        {
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }
    }

}
