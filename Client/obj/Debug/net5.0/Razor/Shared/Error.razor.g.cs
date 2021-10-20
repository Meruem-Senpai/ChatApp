#pragma checksum "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b09f7732a88dbf1a16a8a0ef09e23e4c81b3ba8"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using ChatApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using ChatApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.ChatApp.Client.Shared.Error.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 8 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
                      this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 9 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\С#\Deploy\ChatApp\Client\Shared\Error.razor"
      

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public void ProcessError(Exception ex)
    {
        if (!_webAssemblyHostEnvironment.IsDevelopment())
            _toastService.ShowError("Oops, something has gone wrong. Please contact system admin");
        else
            _toastService.ShowError("Oops, something has gone wrong. Please check the logs");

        _logger.LogError(ex, "");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebAssemblyHostEnvironment _webAssemblyHostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Error> _logger { get; set; }
    }
}
namespace __Blazor.ChatApp.Client.Shared.Error
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591