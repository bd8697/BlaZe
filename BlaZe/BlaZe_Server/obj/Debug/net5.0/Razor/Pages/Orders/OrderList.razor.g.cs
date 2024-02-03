#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0102fb6097c80ac46958625fd728a7cbce9349c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Server.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using BlaZe_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using BlaZe_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using BlaZe_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order")]
    public partial class OrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"row mt-4\"><div class=\"col-8\"><h4 class=\"carFeatured-title text-info\"> Orders</h4></div></div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(7, "<thead><tr><th>Name</th>\r\n                        <th>Email</th>\r\n                        <th>Start date</th>\r\n                        <th>End date</th>\r\n                        <th>Status</th></tr></thead>\r\n                ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 29 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                     if (Orders.Any())
                    {
                        foreach (var order in Orders)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 35 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                             order.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 38 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                             order.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                             order.StartDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 44 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                             order.EndDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 47 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                             order.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 50 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                                             $"order/edit/{order.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<tr><td>No orders.</td></tr>");
#nullable restore
#line 58 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<p>loading...</p>");
#nullable restore
#line 67 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Orders\OrderList.razor"
       
    private IEnumerable<OrderDTO> Orders { get; set; } = new List<OrderDTO>();
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        Orders = await orderRepo.GetOrders();
        IsLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderRepo orderRepo { get; set; }
    }
}
#pragma warning restore 1591