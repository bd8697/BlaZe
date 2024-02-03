using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Client.Service.IService
{
    public interface IStripeService
    {
        public Task<string> CheckOut(StripeDTO stripeDTO);
    }
}
