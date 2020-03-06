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
    public class NoticeficationController : ControllerBase
    {
        private readonly OdinaryContext _context;

        public NoticeficationController(OdinaryContext context)
        {
            _context = context;
        }

        // GET: api/Noticefication
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var text =
                     _context.Users.Select(x => x);//.Include(x=>x.Messages.Select(y=>y.Text));
            return Ok(text);
        }

        // GET: api/Noticefication/5
        [HttpGet("{id}")]
        public string GetUser(string id)
        {
           

            return "user";
        }

        // PUT: api/Noticefication/5
        [HttpPut("{id}")]
        public void PutUser(string id, User user)
        {
           
        }

        // POST: api/Noticefication
        [HttpPost]
        public void PostUser(User user)
        {
            
        }

        // DELETE: api/Noticefication/5
        [HttpDelete("{id}")]
        public void DeleteUser(string id)
        {
           
        }

        
    }
}
