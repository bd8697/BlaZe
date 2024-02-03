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
    public class CarImagesRepo: ICarImagesRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CarImagesRepo(ApplicationDbContext dbPar, IMapper mapperPar)
        {
            db = dbPar;
            mapper = mapperPar;
        }

        public async Task<int> CreateCarImage(CarImageDTO imageDTO)
        {
            var image = mapper.Map<CarImageDTO, CarImage>(imageDTO);
            await db.CarImgs.AddAsync(image);
            return await db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarImageByCarId(int carId)
        {
            var images = await db.CarImgs.Where(x => x.CarId == carId).ToListAsync();
            db.CarImgs.RemoveRange(images);
            return await db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarImageById(int imgId)
        {
            var image = await db.CarImgs.FindAsync(imgId);
            db.CarImgs.Remove(image);
            return await db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarImageByUrl(string imgUrl)
        {
            var img = await db.CarImgs.FirstOrDefaultAsync(x => x.CarImgUrl == imgUrl);

            if(img == null)
            {
                return 0;
            }

            db.CarImgs.Remove(img);
            return await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarImageDTO>> GetCarImages(int carId)
        {
            return mapper.Map<IEnumerable<CarImage>, IEnumerable<CarImageDTO>>(await db.CarImgs.Where(x => x.CarId == carId).ToListAsync());
        }
    }
}
