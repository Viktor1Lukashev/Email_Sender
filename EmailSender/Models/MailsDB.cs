using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public class MailsDB:DbContext
    {
        DbSet<Mail> Mails { get; set; }
        public MailsDB(DbContextOptions<MailsDB> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
