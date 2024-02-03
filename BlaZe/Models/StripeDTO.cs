using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StripeDTO
    {
        public string ProductName { get; set; }
        public long Price { get; set; }
        public string ImgUrl { get; set; }
        public string  ReturnUrl { get; set; }
    }
}
