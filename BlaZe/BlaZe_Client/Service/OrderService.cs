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
    public class OrderService : IOrderService
    {
        private readonly HttpClient client;

        public OrderService(HttpClient cli)
        {
            client = cli;
        }

        public async Task<OrderDTO> MarkPaymentSucc(OrderDTO orderDTO)
        {
            var content = JsonConvert.SerializeObject(orderDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/order/successfulpayment", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<OrderDTO>(contentTemp);
                return result;
            }
            else
            {
                // throw new Exception(contentTemp);
                return new OrderDTO();
            }
        }

        public async Task<OrderDTO> SaveOrder(OrderDTO orderDTO)
        {
            var content = JsonConvert.SerializeObject(orderDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/order/create", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<OrderDTO>(contentTemp);
                return result;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<string>(contentTemp);
                throw new Exception(error);
            }
        }
    }
}
