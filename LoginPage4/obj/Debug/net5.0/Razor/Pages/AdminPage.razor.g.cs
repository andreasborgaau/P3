#pragma checksum "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93f76d11ba9a7757e75b4d95ba53aa612293b5b"
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
#line 4 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class AdminPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>This is the admin page</h1>");
#nullable restore
#line 13 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor"
 foreach (var user in UserManager.Users.ToList())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 15 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor"
         user

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\45606\source\repos\LoginPage4\LoginPage4\Pages\AdminPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
