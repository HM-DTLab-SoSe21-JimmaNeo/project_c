#pragma checksum "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10f74adbd00271491add0264b89874bdf78b4da"
// <auto-generated/>
#pragma warning disable 1591
namespace eNeoAuth.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using eNeoAuth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using eNeoAuth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor"
           [Authorize(Roles = "CanViewCounterPage")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Roles", "CanClickCounterButton");
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "class", "btn btn-primary");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor"
                                                  IncrementCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(11, "Click me");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        You do not have permission to click the counter button. Please ask for permission.\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "color:red");
            __builder.AddMarkupContent(17, "<br>\r\n    ");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor"
     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Daniel\source\repos\eNeoAuth\eNeoAuth\Client\Pages\Counter.razor"
       

    private ClaimsPrincipal User;
    private string Message = "";
    private int currentCount = 0;

    private void IncrementCount()
    {
        Message = "";

        if (User.Identity.IsAuthenticated && User.IsInRole("CanIncrementCounter"))
            currentCount++;
        else
            Message = "You do not have permission to increment the counter!";
    }

    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider
           .GetAuthenticationStateAsync();

        User = authState.User;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
