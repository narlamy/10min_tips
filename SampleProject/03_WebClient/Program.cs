using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region 프로토 타입
    class Prototype
    {
        public void Run()
        {
            using (var client = new WebClient())
            {
                Encoding _encoding = new UTF8Encoding();

                client.Encoding = _encoding;
                client.Headers[HttpRequestHeader.ContentType] = "Application/json";

                var url = "http://localhost:1234/test";
                var jsonText = @"{
                    ""Name"" : ""Kim"",
                    ""Age"" : 100
                }";

                var response = client.UploadString(url, "POST", jsonText);

                Console.WriteLine(response);
                Console.ReadKey();
            }
        }
    }
    #endregion
}
