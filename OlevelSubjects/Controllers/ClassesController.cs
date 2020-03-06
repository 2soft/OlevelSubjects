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
    public class ClassesController : ControllerBase
    {
        private readonly OdinaryContext _context;

        public ClassesController(OdinaryContext context)
        {
            _context = context;
        }

        // GET: api/Classes
        [HttpGet]
        public ActionResult<IEnumerable<Class>> GetClasses()
        {
            var schl = _context.Classes.Select(x => x);
            return Ok(schl);
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public string GetClass(int id)
        {
            return "value";
        }

        // PUT: api/Classes/5
        [HttpPut("{id}")]
        public void PutClass(int id, Class @class)
        {

        }

        // POST: api/Classes
        [HttpPost]
        public void PostClass(Class @class)
        {
           
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public void DeleteClass(int id)
        {
            
        }

       
    }
}
