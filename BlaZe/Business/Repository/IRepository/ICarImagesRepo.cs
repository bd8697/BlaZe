using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICarImagesRepo
    {
        public Task<int> CreateCarImage(CarImageDTO image);
        public Task<int> DeleteCarImageById(int imgId);
        public Task<int> DeleteCarImageByCarId(int carId);
        public Task<int> DeleteCarImageByUrl(string imgUrl);
        public Task<IEnumerable<CarImageDTO>> GetCarImages(int carId);
    }
}
