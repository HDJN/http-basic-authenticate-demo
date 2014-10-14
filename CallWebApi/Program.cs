using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CallWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(CallWebApi());
        }


        static async Task CallWebApi()
        {
            var client = new HttpClient();
            var user = string.Format("{0}:{1}", "u", "p");
            var auth = string.Format("Basic {0}", Convert.ToBase64String(Encoding.Default.GetBytes(user)));
            client.DefaultRequestHeaders.Add("Authorization", auth);

            var requestUri = "http://localhost:4811/api/Test/";

            var response = await client.GetStringAsync(requestUri);

            Console.WriteLine(response);
        }
    }
}
