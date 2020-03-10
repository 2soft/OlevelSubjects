using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OlevelSubjects.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MessageId { get; set; }
        public List<Message> Messages { get; set; }
    }
}
