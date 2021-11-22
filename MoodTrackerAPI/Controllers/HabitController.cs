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
    public class HabitController : ControllerBase
    {
        private readonly DBContext _context;
        public HabitController(DBContext context)
        {
            _context = context;
        }
        // GET: api/<HabitController>
        [HttpGet]
        public IEnumerable<HabitDataModel> Get()
        {
            return _context.HabitData.ToArray();
        }

        // POST api/<HabitController>
        [HttpPost]
        public void Post([FromBody] HabitDataModel habitData)
        {
            _context.Add(habitData);
            _context.SaveChanges();
        }

    }
}
