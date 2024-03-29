#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db0e64e041a9aa7ef08a04ddabc8f52e0f780957"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Server.Pages.Car
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
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
using Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
using Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/car")]
    public partial class CarList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\"> Cars</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "car/create");
            __builder.AddAttribute(7, "class", " btn btn-info form-control");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            Add car\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>Model</th>\r\n                    <th>Description</th>\r\n                    <th>IsManual</th>\r\n                    <th>Seats</th>\r\n                    <th>Price</th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 35 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                 if (Cars.Any())
                {
                    foreach (var car in Cars)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                         car.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 44 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                         car.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 47 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                         car.IsManual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 50 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                         car.Seats

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 53 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                         car.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 56 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                                         $"car/edit/{car.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger mt-3");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                                                                      () => HandleDelete(car.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<tr><td>No cars yet.</td></tr>");
#nullable restore
#line 65 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __builder.OpenComponent<BlaZe_Server.Shared.ConfirmDelete>(48);
            __builder.AddAttribute(49, "IsParentComponentProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                                            IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 71 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
                                                                               HandleConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\Car\CarList.razor"
       
    private IEnumerable<CarDTO> Cars { get; set; } = new List<CarDTO>();

    private int? DeleteCarId { get; set; }

    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        Cars = await CarRepo.GetAllCars();
    }

    private async Task HandleDelete(int carId)
    {
        DeleteCarId = carId;
        await IJsRuntime.InvokeVoidAsync("ShowConfirmDelete");
    }

    public async Task HandleConfirmDelete(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteCarId != null)
        {
            CarDTO car = await CarRepo.GetCar(DeleteCarId.Value);
            foreach (var img in car.CarImages)
            {
                var imgName = img.CarImgUrl.Replace($"{NavigationManager.BaseUri}CarImages/", "");
                FileUpload.DeleteFile(imgName);
            }

            await CarRepo.DeleteCar(DeleteCarId.Value);
            await IJsRuntime.ToasterSuccess("Car deleted.");
            Cars = await CarRepo.GetAllCars();
        }
        await IJsRuntime.InvokeVoidAsync("HideConfirmDelete");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarRepo CarRepo { get; set; }
    }
}
#pragma warning restore 1591
