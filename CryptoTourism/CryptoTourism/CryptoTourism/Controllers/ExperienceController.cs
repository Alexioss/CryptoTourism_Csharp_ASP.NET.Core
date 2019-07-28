using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cryptotourism.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cryptotourism.Controllers
{
    public class ExperienceController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ExperienceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ViewResult Index(int id)
        {
            return View(_context.Experiences.Where(experience => id == experience.Id).FirstOrDefault());
        }
    }
}