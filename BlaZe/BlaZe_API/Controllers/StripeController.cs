using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StripeController : Controller
    {
        private readonly IConfiguration config;

        public StripeController(IConfiguration cfg)
        {
            config = cfg;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StripeDTO payment)
        {
            try
            {
                var domain = config.GetValue<string>("BlaZe_Client_URL");

                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string>
                    {
                        "card"
                    },
                    LineItems = new List<SessionLineItemOptions>
                    {
                        new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                                {
                                    UnitAmount = payment.Price,
                                    Currency = "usd",
                                    ProductData = new SessionLineItemPriceDataProductDataOptions
                                    {
                                        Name = payment.ProductName
                                    }
                                },
                            Quantity = 1
                        }
                    },
                    Mode = "payment",
                    SuccessUrl = domain + "successful-payment?session_id={{CHECKOUT_SESSION_ID}}",
                    CancelUrl = domain + payment.ReturnUrl
                };

                var service = new SessionService();
                Session session = await service.CreateAsync(options);

                return Ok(session.Id);
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
