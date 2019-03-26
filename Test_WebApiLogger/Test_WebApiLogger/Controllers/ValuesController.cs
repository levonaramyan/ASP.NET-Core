using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace Test_WebApiLogger.Controllers
{
    public class A
    {
        public string value;
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInformation("Hello from action Get");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            _logger.LogInformation($"Called action Get(id) with id={id}");
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string a)
        {
            _logger.LogInformation("Post Action is executed");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogInformation("This is Put action");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogInformation("Action delete is called");

            try
            {
                int z = 10 / id;
                _logger.LogTrace(new EventId(0), "division was ok");
            }
            catch (Exception e)
            {
                _logger.LogError(e,"divide by 0 case");
            }
        }
    }
}
