#pragma checksum "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d53b4b3ffae1eea47879a564605b0edeb566f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechnicalAssistance_Details), @"mvc.1.0.view", @"/Views/TechnicalAssistance/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\_ViewImports.cshtml"
using Application.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
using Core.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d53b4b3ffae1eea47879a564605b0edeb566f78", @"/Views/TechnicalAssistance/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de81a9dcf4deac5d0e8436f3f9ea977ccf96001", @"/Views/_ViewImports.cshtml")]
    public class Views_TechnicalAssistance_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechnicalAssistanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui form confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TechnicalAssistance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeTaskState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui button basic green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui button basic yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
  
    ViewData["Title"] = "Details";

    string titleClasses = "ui small header";
    string icon = @"<i class='fas fa-play'></i>";
    string buttonText = "Iniciar Tarea";
    string action = "ChangeTaskState";
    State nextState = State.Iniciada;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Detalle de la tarea</h4>\r\n\r\n<div class=\"ui segment\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 437, "\"", 445, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"ui top attached tabular menu\">\r\n            <a class=\"item active\" data-tab=\"first\">Tarea</a>\r\n            <a class=\"item\" data-tab=\"second\">Solución</a>\r\n");
#nullable restore
#line 24 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
             if (Model.State == State.Iniciada)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"item\" data-tab=\"third\">Finalizar Tarea</a>\r\n");
#nullable restore
#line 27 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"ui bottom attached tab segment active\" data-tab=\"first\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h2 class=\"ui header medium\">\r\n");
            WriteLiteral("                        <div class=\"content\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TaskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a href=\"#\" class=\"sub header\">\r\n");
#nullable restore
#line 37 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                 if (Model.ProblemTypeId == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Sin clasificar</p>\r\n");
#nullable restore
#line 40 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                               Write(ViewBag.ProblemName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                        
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </a>
                        </div>
                    </h2>
                    <br />
                </div>
                <br />
                <div class=""ui two column divided grid"">
                    <div class=""stretched row"">
                        <div class=""column"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 1944, "\"", 1952, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                <table class=\"ui basic celled selectable  table\">\r\n                                    <tr>\r\n                                        <td>\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 2177, "\"", 2185, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 60 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 69 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>\r\n                                            <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 77 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.EstimatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 80 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.EstimatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>\r\n                                            <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 85 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.ActualTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 88 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.ActualTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    <tr>\r\n                                        <td>\r\n                                            <i class=\"far fa-question-circle\"></i> ");
#nullable restore
#line 92 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 95 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    <tr>\r\n                                        <td>\r\n                                            <i class=\"fas fa-exclamation-circle\"></i> ");
#nullable restore
#line 99 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                                 Write(Html.DisplayNameFor(model => model.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 102 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>\r\n                                            <i class=\"fas fa-tasks\"></i> ");
#nullable restore
#line 107 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.TaskType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 110 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.TaskType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"column\">\r\n");
#nullable restore
#line 117 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                             if (Model.State != State.Finalizada)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7820011", async() => {
                WriteLiteral(@"
                                    <div class=""field"">
                                        <div class=""waiting"">
                                            <div class=""field"">
                                                <label>Estado de la tarea</label>
                                                <div class=""ui small input"">
                                                    <select id=""State"" class=""ui fluid dropdown"" name=""State"">
");
#nullable restore
#line 127 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                         if (Model.State == State.Pendiente)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7821159", async() => {
                    WriteLiteral(" Iniciada ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7822707", async() => {
                    WriteLiteral(" Detenida ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                                                        \r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7824047", async() => {
                    WriteLiteral(" Cancelada ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </select>
                                                </div>
                                            </div>
                                            <input style=""display: none;"" id=""EstimatedValue"" type=""number"" name=""EstimatedTime"" placeholder=""Tiempo estimado"">
                                            <input type=""hidden"" name=""TaskId""");
                BeginWriteAttribute("value", " value=\"", 7390, "\"", 7411, 1);
#nullable restore
#line 137 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
WriteAttributeValue("", 7398, Model.TaskId, 7398, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"field\">\r\n                                        <input class=\"fluid ui button primary\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 7658, "\"", 7677, 1);
#nullable restore
#line 141 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
WriteAttributeValue("", 7666, buttonText, 7666, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <br />\r\n            </div>\r\n        </div>\r\n        <div class=\"ui bottom attached tab segment\" data-tab=\"second\">\r\n\r\n");
#nullable restore
#line 154 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
             if (Model.ProblemTypeId == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7829229", async() => {
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Mostrar la solución</p>\r\n");
#nullable restore
#line 162 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"ui bottom attached tab segment\" data-tab=\"third\">            \r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7831562", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
                                                         WriteLiteral(Model.TaskId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d53b4b3ffae1eea47879a564605b0edeb566f7833831", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script type=\"text/javascript\">\r\n\r\n    const task = ");
#nullable restore
#line 176 "C:\Users\mike2c\Source\Repos\SAT-E\Application\Views\TechnicalAssistance\Details.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";    

    var result = $(""#State"").children(""option[value=1]"").prop(""disabled"", true);

    if (task.StartDate != null) {
        var result = $(""#State"").children(""option[value=2]"").prop(""disabled"", true);
    }    



    $(""#State"").change((e) => {
        if (e.target.value == States.Iniciada) {
            $(""#EstimatedValue"").show();
        } else {
            $(""#EstimatedValue"").hide();
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechnicalAssistanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
