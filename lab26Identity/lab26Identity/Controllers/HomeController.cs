using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab26Identity.Models;

namespace lab26Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly lab26IdentityContext _context;

        public HomeController(lab26IdentityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.CMS;

            return View(result.ToList());
        }
    }
}