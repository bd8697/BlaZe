#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\ParentComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a65a25adaebe58c36930c54f79c6e64db693cef"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Server.Pages.tut
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentComp")]
    public partial class ParentComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-danger\"> Parent comp</div>\r\n\r\n ");
            __builder.OpenComponent<BlaZe_Server.Pages.tut.tutComponents.ChildComp>(1);
            __builder.AddAttribute(2, "Title", "this is passed from parent");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "RF");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n ");
            __builder.OpenComponent<BlaZe_Server.Pages.tut.tutComponents.ChildComp>(6);
            __builder.AddAttribute(7, "Title", "this is passed from parent");
            __builder.AddAttribute(8, "MyOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\ParentComp.razor"
                                                          ShowMess

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n ");
            __builder.OpenComponent<BlaZe_Server.Pages.tut.tutComponents.O_O>(10);
            __builder.AddAttribute(11, "InputAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 7 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\ParentComp.razor"
                        InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n ");
            __builder.OpenElement(13, "h1");
            __builder.AddContent(14, 
#nullable restore
#line 8 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\ParentComp.razor"
      mess

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Work\BlaZe\BlaZe\BlaZe_Server\Pages\tut\ParentComp.razor"
       
    private string mess = "-_-";

    public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>()
    {
        {"placeholder", "init input parent"},
        { "maxLength", 10}
    };

    private void ShowMess(MouseEventArgs e) {
        mess = "i am ur father";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
