using HttpBasicAuthenticateDemo.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HttpBasicAuthenticateDemo.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> CallWebApi()
        {
            HttpClient client = new HttpClient();
            var user = string.Format("{0}:{1}", "nmtree", "888888");
            var authorization = string.Format("Basic {0}", Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(user)));
            client.DefaultRequestHeaders.Add("Authorization", authorization);

            var requestUri = "http://localhost:4811/api/Test/";

            var response = await client.GetStringAsync(requestUri);

            return Content(response);
        }
    }
}
