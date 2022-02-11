using EmailSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender
{
    public class DbWorker : IRepository

    {
        private MailsDB _context;
        public DbWorker(MailsDB context) 
        {
            _context = context;
        }
        public void GetData()
        {
            throw new NotImplementedException();
        }

        public bool Add(Mail data)
        {
            _context.Add(data);
            return true;
        }
    }
}
