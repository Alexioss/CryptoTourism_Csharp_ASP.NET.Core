using System;
using System.Threading.Tasks;
using Cryptotourism.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptotourism.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<FavoriteExperience> FavoriteExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FavoriteExperience>()
                .HasKey(x => new { x.ExperienceId, x.UserId });
            builder.Entity<FavoriteExperience>()
                .HasOne(x => x.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(x => x.UserId);
            builder.Entity<FavoriteExperience>()
                .HasOne(x => x.Experience)
                .WithMany(m => m.Favorites)
                .HasForeignKey(x => x.ExperienceId);

        }

        public static async Task CreateAdminAccountAndRoles(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string adminUsername = configuration["Data:AdminUser:Name"];
            string adminEmail = configuration["Data:AdminUser:Email"];
            string adminPassword = configuration["Data:AdminUser:Password"];
            string adminRole = configuration["Data:AdminUser:Role"];
            string userRole = configuration["Data:UserRole"];

            if (await userManager.FindByNameAsync(adminUsername) == null)
            {
                if (await roleManager.FindByNameAsync(adminRole) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(adminRole));
                }

                User adminUser = new User
                {
                    UserName = adminUsername,
                    Email = adminEmail
                };

                IdentityResult result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }

            if (await roleManager.FindByNameAsync(userRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(userRole));
            }
        }

    }
}

