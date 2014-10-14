using HttpBasicAuthenticateDemo.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpBasicAuthenticateDemo.Controllers
{

    public class TestController : ApiController
    {
        [HttpBasicAuthenticate]
        public string Get()
        {
            return "认证通过";
        }

    }
}
