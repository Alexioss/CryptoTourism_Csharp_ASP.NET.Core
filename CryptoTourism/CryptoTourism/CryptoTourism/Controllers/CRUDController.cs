using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cryptotourism.Data;
using Cryptotourism.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cryptotourism.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CRUDController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CRUDController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewResult Index() => View(_context.Experiences);

        public ViewResult Create()
        {
            ViewBag.Experiences = new SelectList(_context.Experiences.Select(g => g.Name).Distinct());
            return View("Edit");
        }

        [Route("Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.Experiences = new SelectList(_context.Experiences.Select(g => g.Name).Distinct());
            Experience experience = _context.Experiences.FirstOrDefault(m => m.Id == id);

            return View(experience);
        }

        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                if (_context.Experiences.Any(m => m.Id == experience.Id))
                {
                    _context.Experiences.Remove(_context.Experiences.FirstOrDefault(m => m.Id == experience.Id));
                }
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                TempData["message"] = $"{experience.Name} has been saved";
                return RedirectToAction("Index");
            }
            else if(ModelState.IsValid)
            {
                if (_context.Experiences.Any(m => m.Id == experience.Id))
                {
                    _context.Experiences.Remove(_context.Experiences.FirstOrDefault(m => m.Id == experience.Id));
                }
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                TempData["message"] = $"{experience.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(experience);
            }
        }

        [HttpPost]
        public IActionResult Delete(int experienceId)
        {
            Experience experience = _context.Experiences.FirstOrDefault(m => m.Id == experienceId);
            if (experience != null)
            {
                _context.Experiences.Remove(experience);
                _context.SaveChanges();
                TempData["message"] = $"{experience.Name} was deleted";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Read(int experienceId)
        {
            Experience experience = _context.Experiences.FirstOrDefault(m => m.Id == experienceId);
            if (experience != null)
            {

            }
            return RedirectToAction("Index");
        }

    }
}