using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoTourism.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}