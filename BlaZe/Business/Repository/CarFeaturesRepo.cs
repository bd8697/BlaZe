using AutoMapper;
using Business.Repository.IRepository;
using DataAcces.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CarFeaturesRepo : ICarFeaturesRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CarFeaturesRepo(ApplicationDbContext dbPar, IMapper mapperPar)
        {
            db = dbPar;
            mapper = mapperPar;
        }

        //returns instance if exists
        public async Task<CarFeatureDTO> IsCarFeatureUnique(string name, int carId = 0)
        {
            try
            {
                if (carId == 0)
                {
                    CarFeatureDTO carFeatureDTO = mapper.Map<CarFeature, CarFeatureDTO>(await db.CarFeatures.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));
                    return carFeatureDTO;
                }
                else
                {
                    CarFeatureDTO carFeatureDTO = mapper.Map<CarFeature, CarFeatureDTO>(await db.CarFeatures.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() && x.Id != carId));
                    return carFeatureDTO;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CarFeatureDTO> CreateCarFeature(CarFeatureDTO carFeatureDTO)
        {
            CarFeature carFeature = mapper.Map<CarFeatureDTO, CarFeature>(carFeatureDTO);
            var addedCarFeature = await db.CarFeatures.AddAsync(carFeature);
            await db.SaveChangesAsync();
            return mapper.Map<CarFeature, CarFeatureDTO>(addedCarFeature.Entity);
        }

        public async Task<IEnumerable<CarFeatureDTO>> GetAllCarFeatures()
        {
            try
            {
                IEnumerable<CarFeatureDTO> carFeatureDTOs = mapper.Map<IEnumerable<CarFeature>, IEnumerable<CarFeatureDTO>>(db.CarFeatures);
                return carFeatureDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CarFeatureDTO> GetCarFeature(int carFeatureId)
        {
            try
            {
                CarFeatureDTO carFeatureDTO = mapper.Map<CarFeature, CarFeatureDTO>(await db.CarFeatures.FirstOrDefaultAsync(x => x.Id == carFeatureId));
                return carFeatureDTO;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CarFeatureDTO> UpdateCarFeature(int carFeatureId, CarFeatureDTO carFeatureDTO)
        {
            try
            {
                if (carFeatureId == carFeatureDTO.Id)
                {
                    CarFeature carFeatureFromDb = await db.CarFeatures.FindAsync(carFeatureId);
                    CarFeature carFeature = mapper.Map<CarFeatureDTO, CarFeature>(carFeatureDTO, carFeatureFromDb);
                    var updatedCarFeature = db.CarFeatures.Update(carFeature);
                    await db.SaveChangesAsync();
                    return mapper.Map<CarFeature, CarFeatureDTO>(updatedCarFeature.Entity);
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

        public async Task<int> DeleteCarFeature(int carFeatureId)
        {
            CarFeature carFeature = await db.CarFeatures.FindAsync(carFeatureId);
            if (carFeature != null)
            {
                db.CarFeatures.Remove(carFeature);

                return await db.SaveChangesAsync();
            }
            else
            {
                return 0;
            }
        }
    }
}
