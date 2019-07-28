using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cryptotourism.Data;
using Cryptotourism.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cryptotourism.Controllers
{
    public class FilterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submit(QuestionsViewModel model)
        {
            return RedirectToAction("Index", "Home", model);
        }
        
        }
    }