#pragma checksum "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19593be810cc9156877d47eefb8d1fc3ee6b520a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Dashboard), @"mvc.1.0.view", @"/Views/Employees/Dashboard.cshtml")]
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
#line 1 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\_ViewImports.cshtml"
using CargoSample2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\_ViewImports.cshtml"
using CargoSample2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19593be810cc9156877d47eefb8d1fc3ee6b520a", @"/Views/Employees/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d71276d44184c8de3d796ac12cc8e1e00eb37b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employees_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CargoOrderViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PendingOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchCusByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dashboard</h1>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .nav-link {
        background-color: #ddd;
        padding: 10px;
        text-align: center;
        margin-bottom: 5px;
    }

    .col-3 {
        position: absolute;
        left: 0;
    }
</style>


<div class=""container-fluid"">


    <div class=""row"">
        <div class=""col-3 bg-light d-flex flex-row flex-wrap"">
            <ul class=""nav flex-column w-25"">
                <li class=""nav-item"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19593be810cc9156877d47eefb8d1fc3ee6b520a5903", async() => {
                WriteLiteral("Pending Orders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19593be810cc9156877d47eefb8d1fc3ee6b520a7443", async() => {
                WriteLiteral("Customers");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>


            </ul>
        </div>


        <div class=""col-9"">
            <div class=""card-deck mb-3 mt-4"">
                <div class=""card text-center"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">");
#nullable restore
#line 51 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                                          Write(ViewBag.YetToDeliverOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <p class=""card-text"">Yet to Deliver  </p>
                    </div>
                </div>
                <div class=""card text-center"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">");
#nullable restore
#line 57 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                                          Write(ViewBag.OrderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <p class=""card-text"">Total Orders:</p>
                    </div>
                </div>
            </div>

            <table class=""table table-bordered table-striped table-hover"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 67 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 70 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 73 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 76 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.ReceiverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 79 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.ReceiverEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 82 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.ReceiverPhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 85 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.IsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 88 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.CargoType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 91 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.CustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 94 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.CargoTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 97 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 100 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 103 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n");
#nullable restore
#line 108 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n");
#nullable restore
#line 111 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 115 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 118 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 121 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 124 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ReceiverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 127 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ReceiverEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 130 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ReceiverPhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 133 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 136 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CargoStatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 139 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 142 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CargoTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 145 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 148 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 151 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n\r\n");
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19593be810cc9156877d47eefb8d1fc3ee6b520a21339", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 162 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n");
#nullable restore
#line 164 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Employees\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CargoOrderViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
