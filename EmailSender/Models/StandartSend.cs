using EmailSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender
{
    public class StandartSend : IRepository

    {
        private MailsDB _context;
        public StandartSend(MailsDB context) 
        {
            _context = context;
        }
        public void GetData()
        {
            throw new NotImplementedException();
        }

        public bool Send()
        {
            throw new NotImplementedException();
        }
    }
}
