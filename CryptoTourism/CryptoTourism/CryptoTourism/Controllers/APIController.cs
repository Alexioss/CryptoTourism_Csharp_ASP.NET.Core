using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cryptotourism.Data;
using Cryptotourism.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cryptotourism.Controllers
{
    [Route("api")]
    public class APIController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public APIController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Route("AddFavorite")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddFavorite(int id)
        {
            if (!_context.Experiences.Any(m => m.Id == id))
                return NotFound();
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            Experience experience = _context.Experiences.Include(x => x.Favorites).First(m => m.Id == id);

            FavoriteExperience favoriteExperience = new FavoriteExperience
            {
                UserId = user.Id,
                User = user,
                ExperienceId = id,
                Experience = experience
            };
            _context.FavoriteExperiences.Add(favoriteExperience);

            if(user.Favorites == null)
                user.Favorites = new List<FavoriteExperience>();
            user.Favorites.Add(favoriteExperience);

            if(experience.Favorites == null)
                experience.Favorites = new List<FavoriteExperience>();
            experience.Favorites.Add(favoriteExperience);

            await _userManager.UpdateAsync(user);

            _context.SaveChanges();

            return Created("test", user.Favorites.Select(fav => fav.ExperienceId));
        }

        [Route("RemoveFavorite")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RemoveFavorite(int id)
        {
            if (!_context.Experiences.Any(m => m.Id == id))
                return NotFound();

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Favorites = _context.FavoriteExperiences.Where(f => f.UserId == user.Id).ToList();
            if (user.Favorites == null || !user.Favorites.Any(fav => fav.ExperienceId == id))
                return NotFound();

            Experience experience = _context.Experiences.First(m => m.Id == id);

            FavoriteExperience favoriteExperience = user.Favorites.First(fav => fav.ExperienceId == id);
            user.Favorites.Remove(favoriteExperience);
            experience.Favorites.Remove(favoriteExperience);
            _context.FavoriteExperiences.Remove(favoriteExperience);

            await _userManager.UpdateAsync(user);

            _context.SaveChanges();

            return Created("test", user.Favorites.Select(f => f.ExperienceId));
        }
    }
}