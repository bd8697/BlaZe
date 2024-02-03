using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string StripeSessionId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DateTime TrueStartDate { get; set; }
        public DateTime TrueEndDate { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public int CarId { get; set; }
        public bool IsPaymentSucc { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }
        public string Status { get; set; }

    }
}
