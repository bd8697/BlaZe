using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICarRepo
    {
        public Task<CarDTO> CreateCar(CarDTO carDTO);

        public Task<CarDTO> UpdateCar(int carId, CarDTO carDTO);

        public Task<CarDTO> GetCar(int carId, string startDate = null, string endDate = null);

        public Task<int> DeleteCar(int carId);

        public Task<IEnumerable<CarDTO>> GetAllCars(string startDate = null, string endDate = null);

        public Task<CarDTO> IsCarUnique(string name, int carId = 0);

        public Task<bool> IsCarRented(int CarId, string startDate, string endDate);
    }
}
