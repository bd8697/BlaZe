// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using BlaZe_Server.Pages.tut.tutComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
using BlaZe_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Work\BlaZe\BlaZe\BlaZe_Server\_Imports.razor"
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
