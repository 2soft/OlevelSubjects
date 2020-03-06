using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlevelSubjects.Data;
using OlevelSubjects.Models;

namespace OlevelSubjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly OdinaryContext _context;

        public NotesController(OdinaryContext context)
        {
            _context = context;
        }

        // GET: api/Notes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Note>>> GetNotes()
        {
            return await _context.Notes.ToListAsync();
        }

        // GET: api/Notes/5
        [HttpGet("{id}")]
        public string GetNote(int id)
        {
            return "note";
        }

        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public void PutNote(int id, Note note)
        {
        
        }

        // POST: api/Notes
        [HttpPost]
        public void PostNote(Note note)
        {
           
        }

        // DELETE: api/Notes/5
        [HttpDelete("{id}")]
        public void DeleteNote(int id)
        {
         
        }

     
    }
}
