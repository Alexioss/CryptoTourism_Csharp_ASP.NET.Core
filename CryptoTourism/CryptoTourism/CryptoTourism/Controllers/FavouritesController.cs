using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cryptotourism.Data;
using Cryptotourism.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cryptotourism.Controllers
{
    public class FavouritesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public FavouritesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.Favorites = _context.FavoriteExperiences.Where(fav => fav.UserId == user.Id).ToList();
            List<Experience> model = user.Favorites.Select(el => _context.Experiences.Where(f => f.Id == el.ExperienceId).First()).ToList();

            return View(model);
        }
    }
}