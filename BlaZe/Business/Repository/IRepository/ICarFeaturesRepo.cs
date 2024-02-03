using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICarFeaturesRepo
    {
        public Task<CarFeatureDTO> CreateCarFeature(CarFeatureDTO carFeatureDTO);

        public Task<CarFeatureDTO> UpdateCarFeature(int carId, CarFeatureDTO carFeatureDTO);

        public Task<CarFeatureDTO> GetCarFeature(int carId);

        public Task<int> DeleteCarFeature(int carId);

        public Task<IEnumerable<CarFeatureDTO>> GetAllCarFeatures();

        public Task<CarFeatureDTO> IsCarFeatureUnique(string name, int carId = 0);
    }
}
