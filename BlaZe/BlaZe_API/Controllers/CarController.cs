using BlaZe_Server.Areas.Identity.Pages;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarRepo _carRepo;

        public CarController(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars(string startDate, string endDate)
        {
            if(string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
            {
                return BadRequest(StatusCodes.Status400BadRequest + ": Need all params.");
            }
            if (!DateTime.TryParseExact(startDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtStartDate) ||
                !DateTime.TryParseExact(endDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtEndDate))
            {
                return BadRequest(StatusCodes.Status400BadRequest + ": Invalid format.");
            }
            var allCars = await _carRepo.GetAllCars();
            return Ok(allCars);
        }

        [HttpGet("{carId}")]
        public async Task<IActionResult> GetCar(int? carId, string startDate, string endDate)
        {
            if (carId == null)
            {
                return BadRequest("Invalid car id." + StatusCodes.Status400BadRequest);
            }
            if (string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
            {
                return BadRequest(StatusCodes.Status400BadRequest + ": Need all params.");
            }
            if (!DateTime.TryParseExact(startDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtStartDate) ||
                !DateTime.TryParseExact(endDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtEndDate))
            {
                return BadRequest(StatusCodes.Status400BadRequest + ": Invalid format.");
            }
            var carDetails = await _carRepo.GetCar(carId.Value);

            if (carDetails == null)
            {
                return BadRequest("Invalid car id." + StatusCodes.Status404NotFound);
            }

            return Ok(carDetails);
        }
    }
}
