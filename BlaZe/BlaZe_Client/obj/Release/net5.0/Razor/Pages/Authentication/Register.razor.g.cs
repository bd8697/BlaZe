#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9009812445e6772934275887587cc69c6c2d698b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaZe_Client.Pages.Authentication
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                 User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                      RegisterMe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "pt-4");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "py-4");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", " row form-group ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-6 offset-3 ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card border");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card-body px-lg-5 pt-4");
                __builder2.AddMarkupContent(17, "<h3 class=\"col-12 text-success text-center py-2\"><strong>Sign Up</strong></h3>");
#nullable restore
#line 16 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                         if (ShowErrors)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(18, "div");
#nullable restore
#line 19 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                 foreach (var error in Errors)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "p");
                __builder2.AddAttribute(20, "class", "text-danger text-center");
                __builder2.AddContent(21, 
#nullable restore
#line 21 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                                        error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 22 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 24 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(22, "<hr style=\"background-color:limegreen\">\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "py-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Name...");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    User.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Name = __value, User.Name))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __Blazor.BlaZe_Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 29 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    (()=>User.Name)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "py-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Email...");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    User.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Email = __value, User.Email))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __Blazor.BlaZe_Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 34 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    (()=>User.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "py-2 input-group");
                __builder2.AddMarkupContent(49, "<div class=\"input-group-prepend\"><span class=\"input-group-text\"> +1</span></div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "placeholder", "Phone...");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    User.PhoneNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.PhoneNo = __value, User.PhoneNo))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.PhoneNo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __Blazor.BlaZe_Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 42 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                    (()=>User.PhoneNo)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-row py-2");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "type", "password");
                __builder2.AddAttribute(66, "id", "password");
                __builder2.AddAttribute(67, "placeholder", "Password...");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                        User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Password = __value, User.Password))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                                ");
                __Blazor.BlaZe_Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_3(__builder2, 73, 74, 
#nullable restore
#line 48 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                        (()=>User.Password)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(78);
                __builder2.AddAttribute(79, "type", "password");
                __builder2.AddAttribute(80, "id", "confirm");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Confirm Password...");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                        User.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.ConfirmPassword = __value, User.ConfirmPassword))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __Blazor.BlaZe_Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_4(__builder2, 87, 88, 
#nullable restore
#line 52 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                                                        (()=>User.ConfirmPassword)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                        <hr style=\"background-color:aliceblue\">\r\n                        ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "py-2");
#nullable restore
#line 58 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                             if (IsProcessing)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(92, "<button type=\"submit\" class=\"btn btn-success btn-block disabled\"><i class=\"fas fa-sign-in-alt\"></i>...</button>");
#nullable restore
#line 61 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(93, "<button type=\"submit\" class=\"btn btn-success btn-block\"><i class=\"fas fa-sign-in-alt\"></i>Register</button>");
#nullable restore
#line 65 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Register.razor"
       
    private UserRequestDTO User = new UserRequestDTO();
    public bool IsProcessing { get; set; } = false;
    public bool ShowErrors { get; set; }
    public IEnumerable<string> Errors { get; set; }

    private async Task RegisterMe()
    {
        ShowErrors = false;
        IsProcessing = true;
        var result = await authService.RegisterUser(User);
        IsProcessing = false;
        if (result.isRegSucc)
        {
            navigationManager.NavigateTo("/login");
        }
        else
        {
            Errors = result.Errors;
            ShowErrors = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService authService { get; set; }
    }
}
namespace __Blazor.BlaZe_Client.Pages.Authentication.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
