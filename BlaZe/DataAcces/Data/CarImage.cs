using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data
{
    public class CarImage
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string CarImgUrl { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
