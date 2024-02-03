#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfea45d148f18d266c4415f1665b5c234ea67a87"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class CarList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mt-4 mx-4 px-0 px-md-5 mx-md-5");
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
     foreach (var car in Cars)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row p-2 my-3 ");
            __builder.AddAttribute(4, "style", "border-radius:20px; border: 1px solid #ffffff");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12 col-lg-3 col-md-4");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "carouselExampleIndicators_" + (
#nullable restore
#line 7 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                    car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0 carousel-fade");
            __builder.AddAttribute(10, "data-ride", "carousel");
            __builder.OpenElement(11, "ol");
            __builder.AddAttribute(12, "class", "carousel-indicators");
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                          
                            int imgIdx = 0;
                            int innerImgIdx = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                         foreach (var img in car.CarImages)
                        {
                            if (imgIdx == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 17 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                             car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "data-slide-to", 
#nullable restore
#line 17 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                     imgIdx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "active");
            __builder.CloseElement();
#nullable restore
#line 18 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 22 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                             car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "data-slide-to", 
#nullable restore
#line 22 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                     imgIdx

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                            }
                            imgIdx++;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "carousel-inner");
#nullable restore
#line 30 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                         foreach (var img in car.CarImages)
                        {
                            if (innerImgIdx == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "carousel-item active");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "class", "d-block w-100");
            __builder.AddAttribute(27, "style", "border-radius:20px;");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 35 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                 img.CarImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "carousel-item");
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "class", "d-block w-100");
            __builder.AddAttribute(34, "style", "border-radius:20px;");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                 img.CarImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                            }
                            innerImgIdx++;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "carousel-control-prev");
            __builder.AddAttribute(40, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 47 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                       car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "role", "button");
            __builder.AddAttribute(42, "data-slide", "prev");
            __builder.AddMarkupContent(43, "<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n                        ");
            __builder.AddMarkupContent(44, "<span class=\"sr-only\">Previous</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "id", "carouselNext" + (
#nullable restore
#line 51 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                         + car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "carousel-control-next");
            __builder.AddAttribute(49, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 51 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                                    car.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "role", "button");
            __builder.AddAttribute(51, "data-slide", "next");
            __builder.AddMarkupContent(52, "<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                        ");
            __builder.AddMarkupContent(53, "<span class=\"sr-only\">Next</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-12 col-lg-9 col-md-8");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row pt-3");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-12 col-lg-8");
            __builder.OpenElement(61, "h3");
            __builder.AddAttribute(62, "class", "card-title text-warning");
            __builder.AddAttribute(63, "style");
            __builder.AddContent(64, 
#nullable restore
#line 60 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                      car.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "p");
            __builder.AddAttribute(67, "class", "card-text");
            __builder.AddContent(68, 
#nullable restore
#line 62 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                              (MarkupString)car.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-12 col-lg-4");
            __builder.AddAttribute(72, "style", "display: flex; flex-direction: column;");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-12 pb-5");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "class", "float-right");
            __builder.OpenElement(79, "span");
            __builder.AddAttribute(80, "class", "float-right car-prop-full");
            __builder.AddContent(81, "Seats: ");
            __builder.OpenElement(82, "span");
            __builder.AddAttribute(83, "class", "car-prop");
            __builder.AddContent(84, 
#nullable restore
#line 69 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                           car.Seats

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "<br>\r\n                                    ");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "float-right pt-1 car-prop-full");
            __builder.AddContent(88, "Transmission: ");
            __builder.OpenElement(89, "span");
            __builder.AddAttribute(90, "class", "car-prop");
            __builder.AddContent(91, 
#nullable restore
#line 70 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                                        car.IsManual ? "Manual" : "Automatic"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "<br>\r\n                                    ");
            __builder.OpenElement(93, "h4");
            __builder.AddAttribute(94, "class", "text-warning font-weight-bold pt-4");
            __builder.OpenElement(95, "span");
            __builder.AddAttribute(96, "style", "border-bottom:1px solid #ff6a00; float: right;");
            __builder.AddAttribute(97, "class", "car-prop-full");
            __builder.AddContent(98, 
#nullable restore
#line 73 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                             car.TotalPrice.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, " $\r\n                                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                    ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "float-right car-prop-full");
            __builder.AddContent(103, "Cost for ");
            __builder.OpenElement(104, "span");
            __builder.AddAttribute(105, "class", "car-prop");
            __builder.AddContent(106, 
#nullable restore
#line 76 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                                                                                             car.TotalDays

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(107, " days.");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "row pb-3 pt-2");
            __builder.AddAttribute(111, "style", "margin-top: auto;");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col-12 col-lg-11 offset-lg-1");
#nullable restore
#line 82 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                 if (car.IsRented)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "<button disabled class=\"btn btn-secondary btn-block\">Rented</button>");
#nullable restore
#line 85 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(115, "a");
            __builder.AddAttribute(116, "href", 
#nullable restore
#line 88 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                               $"car/car-details/{car.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(117, "class", "btn btn-success btn-block");
            __builder.AddContent(118, "Rent");
            __builder.CloseElement();
#nullable restore
#line 89 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Cars\CarList.razor"
       
    [Parameter]
    public IEnumerable<CarDTO> Cars { get; set; } = new List<CarDTO>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
