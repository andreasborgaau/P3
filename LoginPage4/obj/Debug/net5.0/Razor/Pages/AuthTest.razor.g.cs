#pragma checksum "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AuthTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedad7f4d60af930e743c90e42afa17aead43c5b"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginPage4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using LoginPage4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\_Imports.razor"
using LoginPage4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AuthTest.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authtest")]
    public partial class AuthTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Authorization Example</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h2>You can only see this if you\'re logged in</h2>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Policy", "IsAdmin");
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "<h2>You can only see this if your email ends with @admin</h2>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Policy", "IsEditor");
            __builder.AddAttribute(12, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<h2>You can only see this if your email ends with @editor</h2>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
