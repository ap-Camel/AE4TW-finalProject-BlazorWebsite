// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
using WwwFinal.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
           [Authorize(Roles = "teacher")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teacher/questions")]
    public partial class Questions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Teacher\Questions.razor"
       
    private List<QuestionModel> list;
    private QuestionPagesModel web_question;
    private QuestionModel db_question;

    protected override async Task OnInitializedAsync()
    {
        web_question = new QuestionPagesModel();
        db_question = new QuestionModel();

        list = await _db.GetQuestions(loginState.LoginID);
    }

    private async Task InsertQuestion()
    {
        db_question.question = web_question.question;
        db_question.Canswer = web_question.Canswer;
        db_question.Ranswer01 = web_question.Ranswer01;
        db_question.Ranswer02 = web_question.Ranswer02;
        db_question.Ranswer03 = web_question.Ranswer03;
        db_question.teacherID = loginState.LoginID;

        await _db.InsertQuestion(db_question);
        db_question = await _db.GetLastQuestion();
        await _db.AddExamQuestion(0, db_question.questionID);

        nvm.NavigateTo("/teacher/questions", forceLoad: true);
    }

    private async Task DeleteQuestion(QuestionModel q)
    {
        await _db.DeleteQuestion(q);

        nvm.NavigateTo("/teacher/questions", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionData _db { get; set; }
    }
}
#pragma warning restore 1591
