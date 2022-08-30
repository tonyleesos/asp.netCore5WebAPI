using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.netCore5WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.netCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public MVC_UserDB2Context _db = new MVC_UserDB2Context();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<UserTable2> Get()
        {
            List<UserTable2> studentList = _db.UserTable2s.ToList();
            return studentList;
            // return new string[] { "value1", "value2" }; 
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "OK-GET..." + id.ToString();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public string Post()
        {
            return "POST-OK";
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
