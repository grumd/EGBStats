using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBStats
{
    static class Http
    {
        public static string GET(string Url)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }
    }
}
