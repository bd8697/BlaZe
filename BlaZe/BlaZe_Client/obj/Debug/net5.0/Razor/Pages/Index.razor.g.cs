#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd365064b6dd75b6b99a554fef165a770f9200fa"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Client.Pages
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
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
using BlaZe_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row p-0 m-0");
            __builder.AddAttribute(2, "style", "visibility:" + " " + (
#nullable restore
#line 8 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                              IsProcessing? "hidden" : "visible"

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "carouselExampleIndicators");
            __builder.AddAttribute(5, "class", "carousel slide carousel-fade");
            __builder.AddAttribute(6, "data-ride", "carousel");
            __builder.AddMarkupContent(7, "<ol class=\"carousel-indicators\"><li data-target=\"#carouselExampleIndicators\" data-slide-to=\"0\" class=\"active\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"1\"></li></ol>\r\n        ");
            __builder.AddMarkupContent(8, @"<div class=""carousel-inner""><div class=""carousel-item active img-fluid""><img class=""d-block w-100"" src=""images/bg1_X_x2.png"" alt=""First slide""></div>
            <div class=""carousel-item img-fluid""><img class=""d-block w-100"" src=""images/bg2_X_x2.png"" alt=""Second slide""></div></div>
        ");
            __builder.AddMarkupContent(9, "<a class=\"carousel-control-prev\" href=\"#carouselExampleIndicators\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Previous</span></a>\r\n        ");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "id", 
#nullable restore
#line 26 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                carouselId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "carousel-control-next");
            __builder.AddAttribute(13, "href", "#carouselExampleIndicators");
            __builder.AddAttribute(14, "role", "button");
            __builder.AddAttribute(15, "data-slide", "next");
            __builder.AddMarkupContent(16, "<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            ");
            __builder.AddMarkupContent(17, "<span class=\"sr-only\">Next</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
 if (IsProcessing)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<div style=\"position:fixed;top:50%;left:50%;margin-top:50px;margin-left:-100px;\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 38 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 50 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                               SaveInitData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row p-0 mx-0 mt-4");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-12 col-md-5  offset-md-1 pl-2  pr-2 pr-md-0");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label class=\"input-label\">Rent date</label>\r\n                    ");
                __Blazor.BlaZe_Client.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 30, 31, 
#nullable restore
#line 55 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                     DateTime.Now.ToString("yyyy--MM--dd")

#line default
#line hidden
#nullable disable
                , 32, "text", 33, "form-control", 34, 
#nullable restore
#line 55 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                                                         HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 36, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-8 col-md-3 pl-2 pr-2");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label class=\"input-label\">No. of days</label>\r\n                    ");
                __Blazor.BlaZe_Client.Pages.Index.TypeInference.CreateInputNumber_1(__builder2, 43, 44, "0", 45, "form-control", 46, 
#nullable restore
#line 68 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                      HomeModel.noOfDays

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.noOfDays = __value, HomeModel.noOfDays)), 48, () => HomeModel.noOfDays);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n            ");
                __builder2.AddMarkupContent(50, "<div class=\"col-4 col-md-2 p-0 pr-2\"><div class=\"form-group\"><label>&nbsp;</label>\r\n\r\n                    <input type=\"submit\" value=\"Go\" class=\"btn btn-success btn-block\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "<br>\r\n    <hr>\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "container pt-4");
            __builder.AddMarkupContent(54, @"<div class=""row""><div class=""col-md-8 offset-md-2 text-center""><p class=""lead"" style=""font-size: 200%"">Cars today aren’t just cars anymore; they’ve become four-wheeled technological hubs, fitted with a dizzying array of tech features for you to enjoy.</p>
                <h2 class=""text-warning"">Features</h2></div></div>
        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
#nullable restore
#line 95 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
             foreach (var feature in CarFeatures)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-4 col-6 p-4");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "border:1px solid #d5d5d5; border-radius:20px;");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row col-4 offset-4 p-4");
            __builder.OpenElement(63, "i");
            __builder.AddAttribute(64, "class", (
#nullable restore
#line 100 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                       feature.Icon

#line default
#line hidden
#nullable disable
            ) + " fa-4x");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "text-center justify-content-center");
            __builder.OpenElement(68, "h5");
            __builder.AddAttribute(69, "class", "text-warning");
            __builder.AddContent(70, 
#nullable restore
#line 103 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                      feature.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "p");
            __builder.AddContent(73, 
#nullable restore
#line 104 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                feature.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 109 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 112 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
       
    public HomeVM HomeModel { get; set; } = new HomeVM();
    public IEnumerable<CarFeatureDTO> CarFeatures { get; set; } = new List<CarFeatureDTO>();
    public bool IsProcessing { get; set; } = false;
    public string carouselId = "carouselNext";
    protected override async Task OnInitializedAsync()
    {
        IsProcessing = true;
        CarFeatures = await carFeatureService.GetCarFeatures();
        IsProcessing = false;
        // StartCarousel(); // not awaited on purpose
    }
    private async Task SaveInitData()
    {
        try
        {
            HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.noOfDays);

            await localStorage.SetItemAsync(Static.initDates, HomeModel);
            navigationManager.NavigateTo("cars", true);
        }
        catch (Exception e)
        {
            await jsRuntime.ToasterFail(e.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarFeaturesService carFeatureService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.BlaZe_Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
