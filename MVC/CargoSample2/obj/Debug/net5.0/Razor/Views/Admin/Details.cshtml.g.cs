#pragma checksum "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b5316cd7bd378f39e5b5498d03aee79c7d8a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b5316cd7bd378f39e5b5498d03aee79c7d8a82", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d71276d44184c8de3d796ac12cc8e1e00eb37b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#37517e;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b5316cd7bd378f39e5b5498d03aee79c7d8a823738", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css""
          rel=""stylesheet"" />
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap""
          rel=""stylesheet"" />
    <!-- MDB -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.1.0/mdb.min.css""
          rel=""stylesheet"" />
    <title>Document</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b5316cd7bd378f39e5b5498d03aee79c7d8a825327", async() => {
                WriteLiteral(@"
   
            
            
                <div class=""container py-5"">
                    <div class=""row"">
                        <div class=""col"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""card mb-4"">
                                <div class=""card-body text-center"" style=""background-color:lightgray;"">
                                    <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp"" alt=""avatar""
                                         class=""rounded-circle img-fluid"" style=""width: 150px;"">
                                    <h5 class=""my-3"">");
#nullable restore
#line 60 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Admin\Details.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                    <p class=""text-muted mb-1"">Admin</p>
                                    

                                </div>
                            </div>

                        </div>
                        <div class=""col-lg-8"">
                            <div class=""card mb-4"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <p class=""mb-0"">User Name</p>
                                        </div>
                                        <div class=""col-sm-9"">
                                            <p class=""text-muted mb-0"">");
#nullable restore
#line 76 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Admin\Details.cshtml"
                                                                  Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <p class=""mb-0"">Email</p>
                                        </div>
                                        <div class=""col-sm-9"">
                                            <p class=""text-muted mb-0"">");
#nullable restore
#line 85 "C:\Users\dilipk\Source\Repos\CargoProjectMVC\CargoSample2\Views\Admin\Details.cshtml"
                                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <p class=""mb-0"">Phone</p>
                                        </div>
                                        <div class=""col-sm-9"">
                                            <p class=""text-muted mb-0"">(097) 234-5678</p>
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <p class=""mb-0"">Mobile</p>
                                        </div>
                                        <div class=""col-sm-9"">
                                            <p class=""");
                WriteLiteral(@"text-muted mb-0"">(098) 765-4321</p>
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <p class=""mb-0"">Address</p>
                                        </div>
                                        <div class=""col-sm-9"">
                                            <p class=""text-muted mb-0"">Bay Area, San Francisco, CA</p>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
            </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
