using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Testing_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlaBlaController : ControllerBase
    {
        // GET: api/BlaBla
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BlaBla/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BlaBla
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/BlaBla/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
