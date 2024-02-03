// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlaZe_Client.Pages.Cars
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using BlaZe_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using BlaZe_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using BlaZe_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using BlaZe_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using BlaZe_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Work\BlaZe\BlaZe\BlaZe_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarDetails.razor"
           [Authorize(Roles = "Customer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/car/car-details/{Id:int}")]
    public partial class CarDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarDetails.razor"
       
    [Parameter]
    public int? Id { get; set; }

    public OrderVM OrderVM { get; set; } = new OrderVM();
    private int noOfDays;

    protected async override Task OnInitializedAsync()
    {
        try
        {
            OrderVM.OrderDTO = new OrderDTO();
            if(Id != null)
            {
                var carInitInfo = await localStorage.GetItemAsync<HomeVM>(Static.initDates);
                if (carInitInfo != null)
                {
                    OrderVM.OrderDTO.CarDTO = await carService.GetCar(
                        Id.Value, carInitInfo.StartDate.ToString("MM/dd/yyyy"), carInitInfo.EndDate.ToString("MM/dd/yyyy")
                        );
                    noOfDays = carInitInfo.noOfDays;
                    OrderVM.OrderDTO.StartDate = carInitInfo.StartDate;
                    OrderVM.OrderDTO.EndDate = carInitInfo.EndDate;
                    OrderVM.OrderDTO.CarDTO.TotalDays = carInitInfo.noOfDays;
                    OrderVM.OrderDTO.CarDTO.TotalPrice = carInitInfo.noOfDays * OrderVM.OrderDTO.CarDTO.Price;
                }
                else
                {
                    OrderVM.OrderDTO.CarDTO = await carService.GetCar(
                        Id.Value, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.AddDays(1).ToString("MM/dd/yyyy")
                        );
                    noOfDays = 1;
                    OrderVM.OrderDTO.StartDate = DateTime.Now;
                    OrderVM.OrderDTO.EndDate = DateTime.Now.AddDays(1);
                    OrderVM.OrderDTO.CarDTO.TotalDays = 1;
                    OrderVM.OrderDTO.CarDTO.TotalDays = 1 * OrderVM.OrderDTO.CarDTO.Price;
                }

                var user = await localStorage.GetItemAsync<UserDTO>(Static.User);

                if (user != null)
                {
                    OrderVM.OrderDTO.UserId = user.Id;
                    OrderVM.OrderDTO.Name = user.Name;
                    OrderVM.OrderDTO.Email = user.Email;
                    OrderVM.OrderDTO.Phone = user.PhoneNo;
                }
            }
        }
        catch (Exception e)
        {
            await JsRuntime.ToasterFail(e.Message);
        }
    }

    private async Task HandleDaysChange(ChangeEventArgs e)
    {
        noOfDays = Convert.ToInt32(e.Value.ToString());
        OrderVM.OrderDTO.CarDTO = await carService.GetCar(
            Id.Value, OrderVM.OrderDTO.StartDate.ToString("MM/dd/yyy"), OrderVM.OrderDTO.StartDate.AddDays(noOfDays).ToString("MM/dd/yyy"));

        OrderVM.OrderDTO.EndDate = OrderVM.OrderDTO.StartDate.AddDays(noOfDays);
        OrderVM.OrderDTO.CarDTO.TotalDays = noOfDays;
        OrderVM.OrderDTO.CarDTO.TotalPrice = noOfDays * OrderVM.OrderDTO.CarDTO.Price;
    }

    private async Task HandleOrder()
    {
        if (!await HandleValidation())
        {
            return;
        }

        try
        {
            var paymentDTO = new StripeDTO()
            {
                Price = Convert.ToInt32(OrderVM.OrderDTO.CarDTO.TotalPrice * 100),
                ProductName = OrderVM.OrderDTO.CarDTO.Name,
                ReturnUrl = "/car/" + Id
            };

            var result = await stripe.CheckOut(paymentDTO);

            OrderVM.OrderDTO.StripeSessionId = result;
            OrderVM.OrderDTO.CarId = OrderVM.OrderDTO.CarDTO.Id;
            OrderVM.OrderDTO.TotalPrice = OrderVM.OrderDTO.CarDTO.TotalPrice;

            var orderSaved = await orderService.SaveOrder(OrderVM.OrderDTO);
            await localStorage.SetItemAsync(Static.Order, orderSaved);

            await JsRuntime.InvokeVoidAsync("redirectToCheckOut", result);
        }
        catch (Exception e)
        {
            await JsRuntime.ToasterFail(e.Message);
        }
    }

    private async Task<bool> HandleValidation()
    {
        if(string.IsNullOrEmpty(OrderVM.OrderDTO.Name))
        {
            await JsRuntime.ToasterFail("Empty name.");
            return false;
        }
        if (string.IsNullOrEmpty(OrderVM.OrderDTO.Phone))
        {
            await JsRuntime.ToasterFail("Empty phone.");
            return false;
        }
        if (string.IsNullOrEmpty(OrderVM.OrderDTO.Email))
        {
            await JsRuntime.ToasterFail("Empty email.");
            return false;
        }
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStripeService stripe { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarService carService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
