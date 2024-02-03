using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IOrderRepo
    {
        public Task<OrderDTO> Create(OrderDTO orderDTO);
        public Task<OrderDTO> MarkPaymentSucc(int id);
        public Task<OrderDTO> GetOrder(int id);
        public Task<IEnumerable<OrderDTO>> GetOrders();
        public Task<bool> UpdateOrderStatus(int OrderId, string status);
    }
}
