#pragma checksum "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c78f2330c8dd5c3152277a51167206c6096583"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwFinal.Pages.Student
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
#line 3 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
using WwwFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
using WwwFinal.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student/takeExam/{examID}")]
    public partial class TakeExam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
 if (list == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>loading ...</p>");
#nullable restore
#line 18 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
}
else
{
    foreach(QuestionPagesModel q in webList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h4");
            __builder.AddContent(2, 
#nullable restore
#line 23 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
             q.question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row justify-content-start");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-1");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "submit");
            __builder.AddAttribute(12, "class", "btn btn-primary align-self-center");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                                                                                              () => ChooseAnswer(q, 0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "A");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-11");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 30 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                        ListOfQuestionAnswers[q.index][0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row justify-content-start");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-1");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "submit");
            __builder.AddAttribute(29, "class", "btn btn-primary align-self-center");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                                                                                              () => ChooseAnswer(q, 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "B");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-11");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, 
#nullable restore
#line 40 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                        ListOfQuestionAnswers[q.index][1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "container");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row justify-content-start");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-md-1");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "submit");
            __builder.AddAttribute(46, "class", "btn btn-primary align-self-center");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                                                                                              () => ChooseAnswer(q, 2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "C");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-md-11");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 50 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                        ListOfQuestionAnswers[q.index][2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "container");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row justify-content-start");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-1");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "submit");
            __builder.AddAttribute(63, "class", "btn btn-primary align-self-center");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                                                                                              () => ChooseAnswer(q, 3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "D");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-11");
            __builder.OpenElement(69, "p");
            __builder.AddContent(70, 
#nullable restore
#line 60 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                        ListOfQuestionAnswers[q.index][3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
    }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "submit");
            __builder.AddAttribute(73, "class", "btn btn-primary align-self-center");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
                                                                               Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "submit");
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Ayman\source\repos\WwwFinal\WwwFinal\Pages\Student\TakeExam.razor"
       
    [Parameter]
    public string examID { get; set; }

    private List<QuestionModel> list;
    private List<QuestionPagesModel> webList;
    private List<QuestionData> returnList;
    private List<string[]> ListOfQuestionAnswers = new List<string[]>();
    private List<ChoosenAnswersModel> choosenAnswers = new List<ChoosenAnswersModel>();
    private string choosenAnswer;
    string[] answers = new string[4];
    private int index;


    protected async override Task OnInitializedAsync()
    {
        index = 0;
        list = await _db.GetExamingQuestions(1, 1);
        webList = new List<QuestionPagesModel>();

        for(int i = 0; i < list.Count; i++)
        {
            webList.Add(new QuestionPagesModel(list[i].questionID, list[i].question, list[i].Canswer, list[i].Ranswer01, list[i].Ranswer02, list[i].Ranswer03, i));

            answers = randomize(list[i]);
            ListOfQuestionAnswers.Add(answers);
            choosenAnswers.Add(new ChoosenAnswersModel());
        }
    }

    private async Task incriment()
    {
        index++;
    }

    private async Task Submit()
    {
        int mark = await _db.verify(choosenAnswers);

        await _db2.AddMark(mark, loginState.LoginID, int.Parse(examID));

        await js.InvokeVoidAsync("alert", $"your mark was {mark}");

        nvm.NavigateTo("/");
    }

    private async Task ChooseAnswer(QuestionPagesModel q, int ans)
    {
        choosenAnswer = ListOfQuestionAnswers[q.index][ans];
        choosenAnswers[q.index].answer = choosenAnswer;
        choosenAnswers[q.index].questionID = q.questionID;
        choosenAnswer = null;
    }

    private string[] randomize(QuestionModel q)
    {
        string[] answers = new string[4];

        int[] puttedAnswers = new int[4] { 9, 9, 9, 9 };
        Random rand = new Random();
        int random;

        bool found = false;

        random = rand.Next(4);
        puttedAnswers[0] = random;
        answers[random] = q.Canswer;

        while (true)
        {
            found = false;
            random = rand.Next(4);
            for (int i = 0; i < 4; i++)
            {
                if(puttedAnswers[i] == random)
                {
                    found = true;
                }
            }
            if(!found)
            {
                puttedAnswers[1] = random;
                answers[random] = q.Ranswer01;
                break;
            }
        }

        while (true)
        {
            found = false;
            random = rand.Next(4);
            for (int i = 0; i < 4; i++)
            {
                if (puttedAnswers[i] == random)
                {
                    found = true;
                }
            }
            if (!found)
            {
                puttedAnswers[2] = random;
                answers[random] = q.Ranswer02;
                break;
            }
        }

        while (true)
        {
            found = false;
            random = rand.Next(4);
            for (int i = 0; i < 4; i++)
            {
                if (puttedAnswers[i] == random)
                {
                    found = true;
                }
            }
            if (!found)
            {
                puttedAnswers[3] = random;
                answers[random] = q.Ranswer03;
                break;
            }
        }

        return answers;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMarkData _db2 { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvm { get; set; }
    }
}
#pragma warning restore 1591