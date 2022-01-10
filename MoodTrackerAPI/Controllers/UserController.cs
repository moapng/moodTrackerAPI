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
    public class UserController : ControllerBase
    {
        private readonly DBContext _context;

        public UserController(DBContext context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _context.Users.ToArray();
        }

        // GET id via username: api/<UserController>/moa
        [HttpGet("{UserName}")]
        public string Get(string UserName)
        {
            if (UserName != null)
            {
                var data = _context.Users.Find(UserName);
                if (data == null)
                {
                    return "error: username does not exist";
                }

                return data.ID.ToString();
            }
            return "error: enter a username";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}