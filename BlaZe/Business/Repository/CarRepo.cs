using AutoMapper;
using Business.Repository.IRepository;
using DataAcces.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CarRepo : ICarRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CarRepo(ApplicationDbContext dbPar, IMapper mapperPar)
        {
            db = dbPar;
            mapper = mapperPar;
        }

        public async Task<bool> IsCarRented(int CarId, string startDatePar, string endDatePar)
        {
            try
            {
                var status = false;
                if (!string.IsNullOrEmpty(startDatePar) && !string.IsNullOrEmpty(endDatePar))
                {
                    DateTime startDate = DateTime.ParseExact(startDatePar, "MM/dd/yyyy", null);
                    DateTime endDate = DateTime.ParseExact(endDatePar, "MM/dd/yyyy", null);


                    var existingOrder = await db.Order.Where(x => x.Id == CarId && x.IsPaymentSucc &&
                    ((startDate.Date < x.EndDate && startDate.Date >= x.StartDate) || (endDate.Date > startDate.Date && startDate.Date <= x.StartDate.Date))).
                    FirstOrDefaultAsync();

                    if (existingOrder != null)
                    {
                        status = true;
                    }
                }
                return status;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //returns instance if exists
        public async Task<CarDTO> IsCarUnique(string name, int carId = 0)
        {
            try
            {
                if(carId == 0)
                {
                    CarDTO carDTO = mapper.Map<Car, CarDTO>(await db.Cars.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));
                    return carDTO;
                }
                else
                {
                    CarDTO carDTO = mapper.Map<Car, CarDTO>(await db.Cars.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() && x.Id != carId));
                    return carDTO;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CarDTO> CreateCar(CarDTO carDTO)
        {
            Car car = mapper.Map<CarDTO, Car>(carDTO);
            car.CreatedDate = DateTime.Now;
            car.CreatedBy = "";
            var addedCar = await db.Cars.AddAsync(car);
            await db.SaveChangesAsync();
            return mapper.Map<Car, CarDTO> (addedCar.Entity);
        }

        public async Task<IEnumerable<CarDTO>> GetAllCars(string startDate, string endDate)
        {
            try
            {
                IEnumerable<CarDTO> carDTOs = mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(db.Cars.Include(x => x.CarImages));
                if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
                {
                    foreach(CarDTO car in carDTOs)
                    {
                        car.IsRented = await IsCarRented(car.Id, startDate, endDate);
                    }
                }
                return carDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CarDTO> GetCar(int carId, string startDate, string endDate)
        {
            try
            {
                CarDTO carDTO = mapper.Map<Car, CarDTO>(await db.Cars.Include(x => x.CarImages).FirstOrDefaultAsync(x => x.Id == carId));

                if(!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
                {
                    carDTO.IsRented =await IsCarRented(carId, startDate, endDate);
                }
                return carDTO;
            }
            catch (Exception)
            {
                return null;  
            }
        }

        public async Task<CarDTO> UpdateCar(int carId, CarDTO carDTO)
        {
            try
            {
                if (carId == carDTO.Id)
                {
                    Car carFromDb = await db.Cars.FindAsync(carId);
                    Car car = mapper.Map<CarDTO, Car>(carDTO, carFromDb);
                    car.UpdatedBy = "";
                    car.UpdatedDate = DateTime.Now;
                    var updatedCar = db.Cars.Update(car);
                    await db.SaveChangesAsync();
                    return mapper.Map<Car, CarDTO>(updatedCar.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> DeleteCar(int carId)
        {
            Car car = await db.Cars.FindAsync(carId);
            if(car != null)
            {
                var imgs = await db.CarImgs.Where(x => x.CarId == carId).ToListAsync();
                db.CarImgs.RemoveRange(imgs);

                db.Cars.Remove(car);

                return await db.SaveChangesAsync();
            } 
            else
            {
                return 0;
            }
        }
    }
}
