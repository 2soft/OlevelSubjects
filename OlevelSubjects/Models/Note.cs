using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlevelSubjects.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string Url { get; set; }
        
        public Subject Subject { get; set; }
        public int Form { get; set; }
    }
}
