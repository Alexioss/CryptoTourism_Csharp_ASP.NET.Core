using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptotourism.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string LongDescription { get; set; }

        public string TripDescription { get; set; }

        public string ShortDescription { get; set; }

        public float Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageUrl2 { get; set; }

        public string ImageUrl3 { get; set; }

        [Required]
        public string ImageThumbnailUrl { get; set; }

        public bool IsAvailable { get; set; }

        public ICollection<FavoriteExperience> Favorites { get; set; }

    }
}
