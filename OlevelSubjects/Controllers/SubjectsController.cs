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
    public class SubjectsController : ControllerBase
    {
        private readonly OdinaryContext _context;

        public SubjectsController(OdinaryContext context)
        {
            _context = context;
        }

        // GET: api/Subjects
        [HttpGet]
        public ActionResult<IEnumerable<Subject>> GetSubjects()
        {
            List<Subject> sft = _context.Subjects.Select(x => x).Include(x => x.Notes).ToList<Subject>();
           
            return Ok(sft);
        }

        // GET: api/Subjects/5
        [HttpGet("{id}")]
        public string GetSubject(int id)
        {
            return "subject";
        }

        // PUT: api/Subjects/5
        [HttpPut("{id}")]
        public void PutSubject(int id, Subject subject)
        {
           
        }

        // POST: api/Subjects
        [HttpPost]
        public void PostSubject(Subject subject)
        {
           
        }

        // DELETE: api/Subjects/5
        [HttpDelete("{id}")]
        public void DeleteSubject(int id)
        {
           
        }

       
    }
}
