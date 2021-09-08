using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodTrackerAPI.Models;
using MoodTrackerAPI.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoodTrackerAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DBContext _context;
        public CategoryController(DBContext context)
        {
            _context = context;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<CategoryModel> Get()
        {
            return _context.Categories.ToArray();
        }

        // GET category med ID, onödigt? 
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
