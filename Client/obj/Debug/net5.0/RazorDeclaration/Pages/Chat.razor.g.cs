// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChatApp.Client.Pages
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
#line 3 "D:\С#\Deploy\ChatApp\Client\Pages\Chat.razor"
using ChatApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\С#\Deploy\ChatApp\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\С#\Deploy\ChatApp\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat/{ToUserId}")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\С#\Deploy\ChatApp\Client\Pages\Chat.razor"
       
    [Parameter]
    public string ToUserId { get; set; }
    public User ToUser { get; set; } = new User();
    public string FromUserId { get; set; }
    public string MessageText { get; set; }
    public List<Message> Messages { get; set; } = new List<Message>();

    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }
    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        var claimsPrincipal = (await authenticationStateTask).User;

        if (!claimsPrincipal.Identity.IsAuthenticated)
            _navigationManager.NavigateTo("/");

        FromUserId = (await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser")).UserId.ToString();

        if (Convert.ToInt32(ToUserId) > 0)
            ToUser = await _httpClient.GetFromJsonAsync<User>("profile/getprofile/" + ToUserId);

        hubConnection = new HubConnectionBuilder()
            .WithUrl(_navigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<Message>("ReceiveMessage", (message) =>
        {
            if (message.FromUserId == FromUserId ||
            (message.ToUserId == FromUserId && message.FromUserId == ToUserId))
            {
                Messages.Add(message);
                StateHasChanged();
            }
        });

        await hubConnection.StartAsync();

    }

    public async Task Send()
    {
        if (MessageText.Length > 0)
        {
            Message message = new Message();
            message.ToUserId = ToUserId;
            message.FromUserId = FromUserId;
            message.MessageText = MessageText;

            await hubConnection.SendAsync("SendMessage", message);
            MessageText = "";
        }
    }

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    var module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./js/site.js");
    //    await module.InvokeVoidAsync("setScroll");
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591