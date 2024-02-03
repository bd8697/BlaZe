using Business.Repository.IRepository;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepo orderRepo;
        private readonly IEmailSender emailSender;
        public OrderController(IOrderRepo repo, IEmailSender emailSenderPar)
        {
            orderRepo = repo;
            emailSender = emailSenderPar;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderDTO orderDTO)
        {
            if(ModelState.IsValid)
            {
                var result = await orderRepo.Create(orderDTO);

                await emailSender.SendEmailAsync(orderDTO.Email, "Car rented succesfully!", "Order id:" + orderDTO.Id);

                return Ok(result);
            }
            else
            {
                return BadRequest("Error while creating order.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> SuccessfulPayment([FromBody] OrderDTO orderDTO)
        {
            var service = new SessionService();
            var session = service.Get(orderDTO.StripeSessionId);

            if(session.PaymentStatus == "paid")
            {
                var result = await orderRepo.MarkPaymentSucc(orderDTO.Id);
                if(result == null)
                {
                    return BadRequest("Payment error.");
                }
                else
                {
                    return Ok(result);
                }
            }
            else
            {
                return BadRequest("Payment error.");
            }
        }
    }
}
