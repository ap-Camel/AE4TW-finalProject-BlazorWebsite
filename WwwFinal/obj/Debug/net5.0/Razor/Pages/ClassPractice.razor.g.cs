#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdfc7dd8d3818fb052c014a95508d425a6a89823"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
using WwwFinal.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/class")]
    public partial class ClassPractice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped");
            __builder.AddMarkupContent(2, "<thead><tr><th>id</th>\r\n            <th>price</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 15 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
         foreach (Product p in productList.Where(product => product.price >= 20))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
                     p.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
                     p.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-striped");
            __builder.AddMarkupContent(13, "<thead><tr><th>id</th>\r\n            <th>price</th></tr></thead>\r\n    ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 34 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
         foreach (User u in userList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 37 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
                     u.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 38 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
                     u.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\ClassPractice.razor"
              

    private List<Product> productList;
    private List<User> userList;
    protected override void OnInitialized()
    {

        productList = new List<Product>
        {
            new Product(1, 10),
            new Product(2, 100),
            new Product(3, 400)
        };

        userList = new List<User>
        {
            new User(1, "name1"),
            new User(2, "name2"),
            new User(3, "name3")
        };
}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
