using Microsoft.EntityFrameworkCore;
using OlevelSubjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlevelSubjects.Data
{
    public class OdinaryContext:DbContext
    {
        public OdinaryContext(DbContextOptions<OdinaryContext> options): base(options)
        {
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
