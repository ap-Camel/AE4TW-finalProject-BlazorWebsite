#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb61b6e56a67e7cac7d480544410b09b94643f12"
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
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
using WwwFinal.Controllers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teacher/exams/addQuestion/{examID}")]
    public partial class AddExamQuestion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddExamQuestion</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "the id is ");
            __builder.AddContent(3, 
#nullable restore
#line 15 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
              examID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "submit");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                                        () => Redirect(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "add new question");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "submit");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                                        () => Redirect(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "add from existing questions");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
 if (choice == 1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                     web_question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                                   AddQuestion

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "<p>question</p>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "question");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                              web_question.question

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_question.question = __value, web_question.question))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_question.question));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<p>correct answer</p>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "Canswer");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                             web_question.Canswer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_question.Canswer = __value, web_question.Canswer))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_question.Canswer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.AddMarkupContent(34, "<p>wrong answer01</p>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "Ranswer01");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                               web_question.Ranswer01

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_question.Ranswer01 = __value, web_question.Ranswer01))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_question.Ranswer01));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<p>wrong answer02</p>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "Ranswer02");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                               web_question.Ranswer02

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_question.Ranswer02 = __value, web_question.Ranswer02))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_question.Ranswer02));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.AddMarkupContent(48, "<p>wrong answer03</p>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "id", "Ranswer03");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                               web_question.Ranswer03

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => web_question.Ranswer03 = __value, web_question.Ranswer03))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => web_question.Ranswer03));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n\r\n        ");
                __builder2.AddMarkupContent(55, "<button type=\"submit\" class=\"btn btn-primary\">submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 39 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"

}
else if (choice == 2)
{

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<h3>exam questions</h3>");
#nullable restore
#line 48 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
 if (list is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<p><em>loading ...</em></p>");
#nullable restore
#line 51 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "table");
            __builder.AddAttribute(59, "class", "table table-striped");
            __builder.AddMarkupContent(60, "<thead><tr><th>question</th>\r\n                <th>correct answer</th>\r\n                <th>wrong answer 01</th>\r\n                <th>wrong answer 02</th>\r\n                <th>wrong answer 03</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(61, "tbody");
#nullable restore
#line 66 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
             foreach (var q in list)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "tr");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 69 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                         q.question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 70 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                         q.Canswer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 71 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                         q.Ranswer01

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 72 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                         q.Ranswer02

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 73 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                         q.Ranswer03

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "type", "submit");
            __builder.AddAttribute(81, "class", "btn btn-primary");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
                                                                                () => RemoveQuestion(q)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\AddExamQuestion.razor"
       
    [Parameter]
    public string examID { get; set; }
    private int choice { get; set; }

    private List<QuestionModel> list;
    private QuestionPagesModel web_question;
    private QuestionModel db_question;

    protected override async Task OnInitializedAsync()
    {
        list = new List<QuestionModel>();
        web_question = new QuestionPagesModel();
        db_question = new QuestionModel();

        list = await _db.GetExamQuestions(loginState.LoginID, int.Parse(examID));
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

    private async Task AddQuestion()
    {
        db_question.question = web_question.question;
        db_question.Canswer = web_question.Canswer;
        db_question.Ranswer01 = web_question.Ranswer01;
        db_question.Ranswer02 = web_question.Ranswer02;
        db_question.Ranswer03 = web_question.Ranswer03;
        db_question.teacherID = loginState.LoginID;

        await _db.InsertQuestion(db_question);
        db_question = await _db.GetLastQuestion();


        if (await _db.AddExamQuestion(int.Parse(examID), db_question.questionID))
        {
            await js.InvokeVoidAsync("alert", "question was added");
        }
        else
        {
            await js.InvokeVoidAsync("alert", "question was not added");
        }

        nvm.NavigateTo($"/teacher/exams/addQuestion/{examID}", forceLoad: true);
    }

    private async Task RemoveQuestion(QuestionModel q)
    {
        await _db.RemoveQuestion(int.Parse(examID), q);

        nvm.NavigateTo($"/teacher/exams/addQuestion/{examID}", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionData _db { get; set; }
    }
}
#pragma warning restore 1591
