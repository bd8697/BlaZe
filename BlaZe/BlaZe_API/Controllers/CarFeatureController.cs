using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Controllers
{
    [Route("api/[controller]")]
    public class CarFeatureController : Controller
    {
        private readonly ICarFeaturesRepo carFeaturesRepo;

        public CarFeatureController(ICarFeaturesRepo carFeaturesRepoPar)
        {
            carFeaturesRepo = carFeaturesRepoPar;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarFeatures()
        {
            var allFeatures = await carFeaturesRepo.GetAllCarFeatures();
            return Ok(allFeatures);
        }
    }
}
