#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0519f0c6cc9b1e015c1f5e647b64f5be9d53c8ba"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwFinal.Pages.Login.Components
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
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
using WwwFinal.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
    public partial class TeacherLoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Component</h3>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                  web_teacher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                                               VerifyTeacher

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.AddMarkupContent(9, "<h3>teracher login</h3>\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container mt-5");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "card px-5 py-5");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-data");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "forms-inputs mb-4");
                __builder2.AddMarkupContent(22, "<span>Email <br></span>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "email");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                                                               web_teacher.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_teacher.email = __value, web_teacher.email))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_teacher.email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "forms-inputs mb-4");
                __builder2.AddMarkupContent(31, "<span>password <br></span>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "password");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                                                                  web_teacher.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_teacher.password = __value, web_teacher.password))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_teacher.password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "mb-3");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "type", "submit");
                __builder2.AddAttribute(42, "class", "btn btn-dark w-100");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                                                                                        VerifyTeacher

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                            ");
                __builder2.OpenElement(46, "p");
                __builder2.AddAttribute(47, "id", "incorrectEntry");
                __builder2.AddAttribute(48, "hidden", 
#nullable restore
#line 39 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
                                                            hideElement

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(49, "the email or password is incorrect");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Login\Components\TeacherLoginComponent.razor"
       

    private TeacherPagesModel web_teacher;
    private TeacherModel db_teacher;

    private bool hideElement;

    protected override async Task OnInitializedAsync()
    {
        web_teacher = new TeacherPagesModel();
        db_teacher = new TeacherModel();

        hideElement = true;
    }

    private async Task VerifyTeacher()
    {
        db_teacher.email = web_teacher.email;
        db_teacher.password = web_teacher.password;

        if(await _db.VerifyTeacher(db_teacher))
        {
            db_teacher = await _db.GetTeacher(db_teacher);
            ((CustomeAuthenticationStateProvider)asp).AuthenticateTeacher(db_teacher);

            await ss.SetItemAsync("email", db_teacher.email);
            await ss.SetItemAsync("role", "teacher");

            loginState.LoginTeacher(db_teacher);

            nvm.NavigateTo("/");

        } else
        {
            hideElement = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WwwFinal.Controllers.LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService ss { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider asp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
    }
}
#pragma warning restore 1591
