using BlaZe_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlaZe_Client.Service
{
    public class StripeService: IStripeService
    {
        private readonly HttpClient client;

        public StripeService(HttpClient cli)
        {
            client = cli;
        }

        public async Task<string> CheckOut(StripeDTO stripeDTO)
        {
            var content = JsonConvert.SerializeObject(stripeDTO);
            Console.WriteLine(content.Length); 
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/stripe/create", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                // var result = JsonConvert.DeserializeObject<SuccesModel>(contentTemp);
                return contentTemp;
            }
            else
            {

                // var error = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(contentTemp);
            }
        }
    }
}
