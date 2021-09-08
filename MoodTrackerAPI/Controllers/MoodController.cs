using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodTrackerAPI.Context;
using MoodTrackerAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoodTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoodController : ControllerBase
    {
        private readonly DBContext _context;
        public MoodController(DBContext context)
        {
            _context = context;
        }
        // GET: api/<MoodController>
        [HttpGet]
        public IEnumerable<MoodDataModel> Get()
        {
            return _context.MoodData.ToArray();
        }

        // GET api/<MoodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoodController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
