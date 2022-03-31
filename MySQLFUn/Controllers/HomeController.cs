using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLFUn.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFUn.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        //Constructor
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Bowlers
                .ToList();

            return View(blah);
        }
    }
}
