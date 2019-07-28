using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cryptotourism.Controllers
{
    public class TermsAndConditionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}