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
    public class CarFeaturesService: ICarFeaturesService
    {
        private readonly HttpClient client;

        public CarFeaturesService(HttpClient clientPar)
        {
            client = clientPar;
        }

        public async Task<IEnumerable<CarFeatureDTO>> GetCarFeatures()
        {
            var response = await client.GetAsync($"api/carfeature");
            var content = await response.Content.ReadAsStringAsync();
            var features = JsonConvert.DeserializeObject<IEnumerable<CarFeatureDTO>>(content);
            return features;
        }
    }
}
