#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50ad04997cd5c29986097b2bf1a9fa1752a7ab4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Server.Pages.tut.tutComponents
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
    public partial class CarComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5 offset-1");
            __builder.OpenElement(2, "h4");
            __builder.AddContent(3, "No.: ");
            __builder.AddContent(4, 
#nullable restore
#line 2 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                          CarParam.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n                ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 3 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                                                  SelectedCarsChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddContent(10, 
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                 CarParam.Model

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "><br>\r\n                ");
            __builder.AddContent(12, 
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                 CarParam.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "><br>\r\n                ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "checkbox");
            __builder.AddAttribute(16, "IsActive");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                                                     CarParam.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CarParam.IsActive = __value, CarParam.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>\r\n                ");
            __builder.OpenElement(20, "span");
            __builder.AddContent(21, " Masina ");
            __builder.AddContent(22, 
#nullable restore
#line 7 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                                CarParam.IsActive?"activa":"bulita"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ><br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenComponent<BlaZe_Server.Pages.tut.tutComponents.MyBtn>(25);
            __builder.AddAttribute(26, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\tutComponents\CarComp.razor"
       
    [Parameter]
    public Car CarParam { get; set; }

    [Parameter]
    public EventCallback<bool> OnCarSelection { get; set; }

    private async Task SelectedCarsChanged(ChangeEventArgs e) {
        await OnCarSelection.InvokeAsync((bool) e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
