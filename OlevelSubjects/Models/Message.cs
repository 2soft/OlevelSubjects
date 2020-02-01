using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OlevelSubjects.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime Expaire {get;set;}
    }
}
