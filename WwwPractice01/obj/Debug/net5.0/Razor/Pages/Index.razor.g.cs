#pragma checksum "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8812bbbabf1256ff5f1ceed42a15d86587324c22"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwPractice01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using WwwPractice01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using WwwPractice01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\Index.razor"
using WwwPractice01.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "p");
                __builder2.AddContent(4, "you are authorized ");
                __builder2.AddContent(5, 
#nullable restore
#line 11 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\Index.razor"
                               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<p>you are signed out</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
