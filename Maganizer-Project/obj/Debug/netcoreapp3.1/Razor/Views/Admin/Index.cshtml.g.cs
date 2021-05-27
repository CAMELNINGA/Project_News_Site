#pragma checksum "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2726805c0842b42fbff8d0609d16be96292e8386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\_ViewImports.cshtml"
using Maganizer_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2726805c0842b42fbff8d0609d16be96292e8386", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453525a32fad66d68d7c3da0bc175a93fafb212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganizer_Project.Models.AdminIndexViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
  
  Layout = "_AdminLayout";
  ViewData["Active"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2726805c0842b42fbff8d0609d16be96292e83863195", async() => {
                WriteLiteral(@"
  <!--Основные таблицы-->
  <div class=""lime-container"">
    <div class=""lime-body"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-8"">
            <div class=""card"">
              <div class=""card-body"">
                <h5 class=""card-title"">Users</h5>
                <div class=""table-responsive"">
                  <table class=""table"">
                    <thead>
                      <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Username</th>
                      </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 28 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       foreach (var item in Model.Users)
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <tr>\r\n                        <td>");
#nullable restore
#line 31 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       </tr>\r\n");
#nullable restore
#line 35 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                  </table>
                </div>
              </div>
            </div>
          </div>
          <div class=""col-md-4"">
            <div class=""card"">
              <div class=""card-body"">
                <h5 class=""card-title"">Tags</h5>
                <div class=""social-media-list"">
");
#nullable restore
#line 47 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                   foreach (var item in Model.Tags)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"social-media-item\">\r\n                    <div class=\"social-text\">\r\n                      <p>");
#nullable restore
#line 51 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                  </div>\r\n");
#nullable restore
#line 54 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  
                </div>
              </div>
            </div>
          </div>
        </div>

      </div>
    </div>
    <div class=""lime-footer"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <span class=""footer-text"">2021 © develop</span>
          </div>
        </div>
      </div>
    </div>
  </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganizer_Project.Models.AdminIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591