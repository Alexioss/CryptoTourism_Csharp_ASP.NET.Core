using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptotourism.Models
{
    public class FavoriteExperience
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
