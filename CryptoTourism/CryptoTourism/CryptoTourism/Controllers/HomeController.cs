using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cryptotourism.Models;
using Cryptotourism.Data;
using Newtonsoft.Json;

namespace Cryptotourism.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(QuestionsViewModel model)
        {
            var result = _context.Experiences.ToList();

            if (result != null)
            {
                if (model.FirstQuestion != null)
                {
                    result = result.Where(e =>
                    e.ShortDescription.ToUpper().Contains(model.FirstQuestion.ToUpper())).Distinct().ToList();
                }

                //if (model.SecondQuestion != null)
                //{
                //    result = result.Where(e =>
                //    e.Price.Equals(model.SecondQuestion)).Distinct().ToList();
                //}

                //if (model.ThirdQuestion != null)
                //{
                //    result = result.Where(e =>
                //    e.IsAvailable.Equals(model.ThirdQuestion.ToUpper())).Distinct().ToList();
                //}

            }

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SearchExperiences(string search = "")
        {
            List<Experience> result = null;
            if (search != null && search != string.Empty)
            {
               result = _context.Experiences.Where(e => e.Name.ToUpper().Contains(search.ToUpper())).Distinct().ToList();
            }
            return View("Index", result);
        }
    }
}
