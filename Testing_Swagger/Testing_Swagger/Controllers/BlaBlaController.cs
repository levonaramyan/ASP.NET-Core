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
        /// <summary>
        /// For getting value1 and value2
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// This is some sample request.
        /// </remarks>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns values 1 and 2</response>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Getting value by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
