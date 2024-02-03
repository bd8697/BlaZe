using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Client.Helper
{
    public static class IJSRuntimeExtensions
    {
        public static async ValueTask ToasterFail(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
        public static async ValueTask ToasterSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        //public static async ValueTask RedirectToCheckOut(this IJSRuntime JSRuntime, string message)
        //{
        //    await JSRuntime.InvokeVoidAsync("redirectToCheckOut", message);
        //}
    }
}
