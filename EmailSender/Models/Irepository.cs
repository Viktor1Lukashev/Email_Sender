using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public interface IRepository
    {
        public bool Add(Mail data);
        public void GetData();
    }
}
