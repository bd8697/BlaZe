#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb8a53a576b4c049f77bb239334ab75c8ed6d8c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Client.Pages.Stripe
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
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
           [Authorize(Roles = "Customer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/successful-payment")]
    public partial class Successful_payment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
 if (!isPaymentComplete)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div id=\"app\"><div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px;\"><img src=\"images/ajax-loader.gif\"></div></div>");
#nullable restore
#line 11 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-4 pt-4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-10 offset-1 text-center");
            __builder.AddMarkupContent(5, "<h1 class=\"text-warning\">Order confirmed</h1>\r\n            ");
            __builder.OpenElement(6, "h5");
            __builder.AddContent(7, "The car has been rented successfully with order id ");
            __builder.AddContent(8, 
#nullable restore
#line 17 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
                                                                    OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ".");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-8 offset-2");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 20 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
                       rndImg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "style", "border-radius:30px; max-width:100%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Stripe\Successful_payment.razor"
       
    private bool isPaymentComplete = false;
    private int OrderId { get; set; }

    private string rndImg;

    protected override async Task OnInitializedAsync()
    {
        var order = await localStorage.GetItemAsync<OrderDTO>(Static.Order);

        var finalOrder = await orderService.MarkPaymentSucc(order);
        if (finalOrder.Status == Static.Status_Rented)
        {
            await localStorage.RemoveItemAsync(Static.Order);
            await localStorage.RemoveItemAsync(Static.initDates);

            isPaymentComplete = true;
        }

        OrderId = finalOrder.Id;
        rndImg = new Random().Next(0,2) == 0 ? "images/bg1_X_x2.png" : "images/bg2_X_x2.png";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591