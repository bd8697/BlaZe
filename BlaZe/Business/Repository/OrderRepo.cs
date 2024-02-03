using AutoMapper;
using Business.Repository.IRepository;
using Common;
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
    public class OrderRepo : IOrderRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public OrderRepo(ApplicationDbContext dbPar, IMapper mapperPar)
        {
            db = dbPar;
            mapper = mapperPar;
        }

        public async Task<OrderDTO> Create(OrderDTO orderDTO)
        {
            try
            {
                //orderDTO.StartDate = orderDTO.StartDate.Date;
                //orderDTO.EndDate = orderDTO.EndDate.Date;
                var order = mapper.Map<OrderDTO, Order>(orderDTO);
                order.Status = Static.Status_Pending;
                var result = await db.Order.AddAsync(order);
                await db.SaveChangesAsync();
                return mapper.Map<Order, OrderDTO>(result.Entity);
            } 
            catch(Exception e) {
                return null;
            }
        }

        public async Task<OrderDTO> GetOrder(int id)
        {
            try
            {
                Order order = await db.Order.Include(u => u.Car).ThenInclude(x => x.CarImages)
                    .FirstOrDefaultAsync(u => u.Id == id);
                OrderDTO orderDTO = mapper.Map<Order, OrderDTO>(order);
                orderDTO.CarDTO.TotalDays = orderDTO.EndDate.Subtract(orderDTO.StartDate).Days;
                orderDTO.CarDTO.TotalPrice = orderDTO.CarDTO.TotalDays * orderDTO.CarDTO.Price;

                return orderDTO;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            try
            {
                IEnumerable<OrderDTO> orders = mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(db.Order.Include(u => u.Car));
                return orders;
            }
            catch (Exception)
            {
                return null;
            }
        } 

        public async Task<OrderDTO> MarkPaymentSucc(int id)
        {
            var order = await db.Order.FindAsync(id);
            if(order == null)
            {
                return null;
            }
            else if(!order.IsPaymentSucc)
            {
                order.IsPaymentSucc = true;
                order.Status = Static.Status_Rented;
                var succPayment = db.Order.Update(order);
                await db.SaveChangesAsync();
                return mapper.Map<Order, OrderDTO>(succPayment.Entity);
            }
            else
            {
                return new OrderDTO();
            }
        }

        public async Task<bool> UpdateOrderStatus(int OrderId, string status)
        {
            try
            {
                var order = await db.Order.FirstOrDefaultAsync(x => x.Id == OrderId);
                if (order == null)
                {
                    return false;
                }
                else
                {
                    order.Status = status;
                }

                if(order.Status == Static.Status_Rented)
                {
                    order.TrueStartDate = DateTime.Now;
                }
                if (order.Status == Static.Status_Completed)
                {
                    order.TrueEndDate = DateTime.Now;
                }

                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
