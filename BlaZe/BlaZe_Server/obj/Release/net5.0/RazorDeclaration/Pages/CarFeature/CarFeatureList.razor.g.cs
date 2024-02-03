// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlaZe_Server.Pages.CarFeature
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
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
using Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
using Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/carFeature")]
    public partial class CarFeatureList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\CarFeature\CarFeatureList.razor"
       
    private IEnumerable<CarFeatureDTO> CarFeatures { get; set; } = new List<CarFeatureDTO>();

    private int? DeleteCarFeatureId { get; set; }

    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        CarFeatures = await CarFeaturesRepo.GetAllCarFeatures();
    }

    private async Task HandleDelete(int carFeatureId)
    {
        DeleteCarFeatureId = carFeatureId;
        await IJsRuntime.InvokeVoidAsync("ShowConfirmDelete");
    }

    public async Task HandleConfirmDelete(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteCarFeatureId != null)
        {
            CarFeatureDTO carFeature = await CarFeaturesRepo.GetCarFeature(DeleteCarFeatureId.Value);

            await CarFeaturesRepo.DeleteCarFeature(DeleteCarFeatureId.Value);
            await IJsRuntime.ToasterSuccess("CarFeature deleted.");
            CarFeatures = await CarFeaturesRepo.GetAllCarFeatures();
        }
        await IJsRuntime.InvokeVoidAsync("HideConfirmDelete");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarFeaturesRepo CarFeaturesRepo { get; set; }
    }
}
#pragma warning restore 1591
