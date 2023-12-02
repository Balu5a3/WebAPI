using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>
        {
            "value0","value1","value3"
        };

        // GET api/values
        [RequireHttps]
        public HttpResponseMessage Get()
        {
            string userName = Thread.CurrentPrincipal.Identity.Name;
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return strings[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id); 
        }
    }
}
