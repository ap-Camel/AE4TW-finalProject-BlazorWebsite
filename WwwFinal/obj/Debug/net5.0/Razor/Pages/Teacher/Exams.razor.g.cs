#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9607102f5b87789a53dab36aa64ea20a8913b8b3"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwFinal.Pages.Teacher
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
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
           [Authorize(Roles = "teacher")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teacher/exams")]
    public partial class Exams : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Exams</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                 web_exam

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                           InsertExam

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<p>title</p>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "firstName");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                           web_exam.title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_exam.title = __value, web_exam.title))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_exam.title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.AddMarkupContent(12, "<p>status</p>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "lastName");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                          web_exam.status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_exam.status = __value, web_exam.status))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_exam.status));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.AddMarkupContent(19, "<button type=\"submit\" class=\"btn btn-primary\">submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 26 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
 if (list is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p><em>loading ...</em></p>");
#nullable restore
#line 29 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-striped");
            __builder.AddMarkupContent(23, "<thead><tr><th>id</th>\r\n                <th>title</th>\r\n                <th>status</th>\r\n                <th>taecherID</th>\r\n                <th></th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 45 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
             foreach (var e in list)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 48 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                     e.examID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 49 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                     e.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 50 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                     e.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 51 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                     e.teacherID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "submit");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                                                            () => DeleteExam(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "submit");
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                                                            () => GoToAddQuestion(e.examID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "add question");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "submit");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
                                                                            () => ChangeStatus(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "change status");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Exams.razor"
       

    private List<ExamModel> list;
    private ExamPagesModel web_exam;
    private ExamModel db_exam;

    protected async override Task OnInitializedAsync()
    {
        web_exam = new ExamPagesModel();
        db_exam = new ExamModel();

        list = await _db.GetExams();
    }

    private async Task ChangeStatus(ExamModel e)
    {
        await _db.ChangeStatus(e);

        nvm.NavigateTo("/teacher/exams", forceLoad: true);
    }

    private async Task InsertExam()
    {
        db_exam.title = web_exam.title;
        db_exam.status = web_exam.status;
        db_exam.teacherID = 1;

        await _db.InsertExam(db_exam);

        nvm.NavigateTo("/teacher/exams", forceLoad: true);
    }

    private async Task DeleteExam(ExamModel e)
    {
        await _db.DeleteExam(e);

        nvm.NavigateTo("/teacher/exams", forceLoad: true);
    }

    private async Task GoToAddQuestion(int id)
    {
        nvm.NavigateTo($"/teacher/exams/addQuestion/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExamData _db { get; set; }
    }
}
#pragma warning restore 1591
