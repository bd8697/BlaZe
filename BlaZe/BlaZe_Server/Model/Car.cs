using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Server.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<CarSpecs> Specs { get; set; }
    }
}
