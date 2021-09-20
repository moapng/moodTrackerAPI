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
    public class OfNoteController : ControllerBase
    {
        private readonly DBContext _context;
        public OfNoteController(DBContext context)
        {
            _context = context;
        }
        // GET: api/<OfNoteController>
        [HttpGet]
        public IEnumerable<NoteDataModel> Get()
        {
            return _context.NoteData.ToArray();
        }

        // POST api/<OfNoteController>
        [HttpPost]
        public void Post([FromBody] NoteDataModel noteData)
        {
            _context.NoteData.Add(noteData);
            _context.SaveChanges();
        }
    }
}
