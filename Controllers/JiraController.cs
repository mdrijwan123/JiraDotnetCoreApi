using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using poc.Model;

namespace poc.Controllers
{
    [ApiController]
    public class JiraController : ControllerBase
    {
        // GET api/values
        [Route("jira")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // POST api/values
        [Route("pingjira")]
        [HttpPost]
        public outputfromJIRA Post([FromBody] inputtoJiRA inputjira)
        {
            RequestModel objreq = new RequestModel();
            var result = objreq.ApiCall(inputjira);
            return result;
        }


    }
}
