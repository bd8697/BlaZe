#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d8d76dd8c57c3307f15509c0a7fa98fb6b530b"
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
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "p");
                __builder2.AddContent(3, "Welcome, ");
                __builder2.AddContent(4, 
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                         context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(5, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<p> Please Sign in.</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.AddMarkupContent(8, @"<div class=""row p-0 m-0""><div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li></ol>
            <div class=""carousel-inner""><div class=""carousel-item active""><img class=""d-block w-100"" src=""images/slide1.jpg"" alt=""First slide""></div>
                <div class=""carousel-item""><img class=""d-block w-100"" src=""images/slide2.jpg"" alt=""Second slide""></div></div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span></a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span></a></div></div>

    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                               SaveInitData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row p-0 mx-0 mt-4");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-12 col-md-5  offset-md-1 pl-2  pr-2 pr-md-0");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "<label>Check In Date</label>\r\n                    ");
                __Blazor.BlaZe_Client.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 20, 21, 
#nullable restore
#line 46 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                     DateTime.Now.ToString("yyyy--MM--dd")

#line default
#line hidden
#nullable disable
                , 22, "text", 23, "form-control", 24, 
#nullable restore
#line 46 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                                                         HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 26, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-8 col-md-3 pl-2 pr-2");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label>No. of nights</label>\r\n                    ");
                __builder2.OpenElement(33, "select");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                        HomeModel.noOfDays

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.noOfDays = __value, HomeModel.noOfDays));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 54 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                         for (var i = 1; i <= 10; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "option");
                __builder2.AddAttribute(38, "value", 
#nullable restore
#line 56 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                            i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, 
#nullable restore
#line 56 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                                                i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 57 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n            ");
                __builder2.AddMarkupContent(41, "<div class=\"col-4 col-md-2 p-0 pr-2\"><div class=\"form-group\"><label>&nbsp;</label>\r\n\r\n                    <input type=\"submit\" value=\"Go\" class=\"btn btn-success btn-block\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Index.razor"
       
    public HomeVM HomeModel { get; set; } = new HomeVM();

    private async Task SaveInitData ()
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
    }
}
#pragma warning restore 1591
