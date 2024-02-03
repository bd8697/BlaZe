#pragma checksum "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e03fc747e98088d9e6adf3aff952567ceb775fe"
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
#nullable restore
#line 4 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "logreg-forms");
            __builder.AddAttribute(2, "class", "bg-dark border");
            __builder.AddMarkupContent(3, "<h1 class=\"h3 mb-3 pt-3 font-weight-normal text-primary\" style=\"text-align:center;\">Sign In</h1>\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                         User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                              LoginMe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
#nullable restore
#line 14 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
             if (ShowErrors)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "p");
                __builder2.AddAttribute(10, "class", "text-center text-danger");
                __builder2.AddContent(11, 
#nullable restore
#line 16 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                                    Errors

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 17 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "email");
                __builder2.AddAttribute(14, "placeholder", "Email...");
                __builder2.AddAttribute(15, "class", "form-control mb-2");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                    User.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserName = __value, User.UserName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.BlaZe_Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 20 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                    (()=>User.UserName)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "type", "password");
                __builder2.AddAttribute(25, "placeholder", "Password...");
                __builder2.AddAttribute(26, "id", "password");
                __builder2.AddAttribute(27, "class", "form-control mb-2");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                    User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Password = __value, User.Password))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.BlaZe_Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 22 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
                                    (()=>User.Password)

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 24 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
             if (IsProcessing)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(34, "<button type=\"submit\" class=\"btn btn-success btn-block disabled\"><i class=\"fas fa-sign-in-alt\"></i>...</button>");
#nullable restore
#line 27 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "<button type=\"submit\" class=\"btn btn-success btn-block\"><i class=\"fas fa-sign-in-alt\"></i>Sign in</button>");
#nullable restore
#line 31 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(36, "<a href=\"/register\" class=\"btn btn-primary text-white mt-3\"><i class=\"fas fa-user-plus\"></i>Register</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Work\BlaZe\BlaZe\BlaZe_Client\Pages\Authentication\Login.razor"
           
        private AuthDTO User = new AuthDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowErrors { get; set; }
        public string Errors { get; set; }
        public string ReturnUrl { get; set; }

        private async Task LoginMe()
        {
            ShowErrors = false;
            IsProcessing = true;
            var result = await authService.Login(User);
            if (result.isAuthSucc)
            {
                IsProcessing = false;

                var absoluteUri = new Uri(navigationManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absoluteUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    navigationManager.NavigateTo("/");
                }
                else
                {
                    navigationManager.NavigateTo("/" + ReturnUrl);
                }
            }
            else
            {
                IsProcessing = false;
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
namespace __Blazor.BlaZe_Client.Pages.Authentication.Login
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
    }
}
#pragma warning restore 1591