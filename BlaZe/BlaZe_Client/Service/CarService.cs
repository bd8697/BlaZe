using BlaZe_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlaZe_Client.Service
{
    public class CarService : ICarService
    {
        private readonly HttpClient _client;

        public CarService (HttpClient client)
        {
            _client = client;
        }
        public async Task<CarDTO> GetCar(int carID, string startDate, string endDate)
        {
            var response = await _client.GetAsync($"api/car/{carID}?startDate={startDate}&endDate={endDate}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var car = JsonConvert.DeserializeObject<CarDTO>(content);
                return car;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<string>(content);
                throw new Exception(error);
            }
        }

        public async Task<IEnumerable<CarDTO>> GetCars(string startDate, string endDate)
        {
            var response = await _client.GetAsync($"api/car?startDate={startDate}&endDate={endDate}");
            var content = await response.Content.ReadAsStringAsync();
            var cars = JsonConvert.DeserializeObject<IEnumerable<CarDTO>>(content);

            return cars;
        }
    }
}
