using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmailSender.Models;

namespace EmailSender.Controllers
{
    public class HomeController : Controller
    {
     
        private IRepository _sender;
        public HomeController(IRepository sender)
        {
                _sender = sender;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Send(DataForSend data)
        {

            data.data = DateTime.UtcNow;
            return View();

            
        }
    }
}
