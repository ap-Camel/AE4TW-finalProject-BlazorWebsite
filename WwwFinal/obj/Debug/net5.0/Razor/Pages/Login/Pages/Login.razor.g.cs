#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1af187c6e48cd8ca038f734c8d14ba52fc7c161"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwFinal.Pages.Login.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using WwwFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\_Imports.razor"
using WwwFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login as</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container mt-5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row d-flex justify-content-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card px-5 py-5");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-data");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "mb-4");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "submit");
            __builder.AddAttribute(15, "class", "btn btn-dark w-100");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
                                                                                   () => Redirect(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Student");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mb-4");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "submit");
            __builder.AddAttribute(23, "class", "btn btn-dark w-100");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
                                                                                   () => Redirect(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Teacher");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
 if (choice == 2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WwwFinal.Pages.Login.Components.TeacherLoginComponent>(26);
            __builder.CloseComponent();
#nullable restore
#line 35 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
} else if (choice == 1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WwwFinal.Pages.Login.Components.StudentLoginComponent>(27);
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Pages\Login.razor"
       

    private int choice;

    protected override async Task OnInitializedAsync()
    {

    }

    private async Task Redirect(int id)
    {
        if (id == 1)
        {
            choice = 1;
        }
        else if (id == 2)
        {
            choice = 2;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider asp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
    }
}
#pragma warning restore 1591
