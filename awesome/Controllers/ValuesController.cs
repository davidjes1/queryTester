using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace awesome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly IAwesomeRepository _awesomeRepository;


        public ValuesController(IAwesomeRepository awesomeRepository)
        {
            _awesomeRepository = awesomeRepository;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var myResult = await _awesomeRepository.GetAwesomeEntity();
            return Json(myResult);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
