using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Client.Service.IService
{
    public interface IOrderService
    {
        public Task<OrderDTO> SaveOrder(OrderDTO orderDTO);
        public Task<OrderDTO> MarkPaymentSucc(OrderDTO orderDTO);
    }
}
