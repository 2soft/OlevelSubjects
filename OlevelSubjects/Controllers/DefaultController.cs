using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OlevelSubjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IEnumerable <string> GetDefault()
        {
            return new string[] { "laini", "value2" };
        }

        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        [HttpPut]
        public void Put (int id, [FromBody]string value)
        {

        }
        [HttpDelete]
        public void Delete(int id)
        {

        }

    }
}