using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Client.Service.IService
{
    interface ICarService
    {
        public Task<IEnumerable<CarDTO>> GetCars(string startDate, string endDate);
        public Task<CarDTO> GetCar(int carID, string startDate, string endDate);
    }
}
