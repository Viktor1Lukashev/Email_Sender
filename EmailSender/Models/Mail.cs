using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public class Mail
        
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public List<string> Recipients { get; set; }
        public DateTime Date { get; set; }


    }
}
