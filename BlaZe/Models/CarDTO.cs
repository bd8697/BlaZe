using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }
        public string Details { get; set; }
        public bool IsManual { get; set; }
        [Range(1, 99999)]
        public int Seats { get; set; }
        [Required(ErrorMessage = "Please enter a price")]
        public int Price { get; set; }
        public virtual ICollection<CarImageDTO> CarImages { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public double TotalDays { get; set; }
        public double TotalPrice { get; set; }

        public bool IsRented { get; set; }
    }
}
