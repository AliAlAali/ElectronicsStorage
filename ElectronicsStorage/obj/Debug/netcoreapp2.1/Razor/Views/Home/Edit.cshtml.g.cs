#pragma checksum "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ea1783d8036b5a2626026bd465d04c454ae475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
#line 1 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\_ViewImports.cshtml"
using ElectronicsStorage;

#line default
#line hidden
#line 2 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\_ViewImports.cshtml"
using ElectronicsStorage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ea1783d8036b5a2626026bd465d04c454ae475", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1146028e188f1e9f72097508a8b9b7869c81e42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ES.Data.Model.StorageBox>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(33, 41, true);
            WriteLiteral("\r\n    <h4>StorageBox</h4>\r\n    <hr />\r\n\r\n");
            EndContext();
            BeginContext(360, 68, true);
            WriteLiteral("\r\n\r\n    \r\n    <table class=\"storagebox\" num_rows=\"10\" num_col=\"6\">\r\n");
            EndContext();
#line 19 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
          
            for (int r = 0; r < 10; r++)
            {

#line default
#line hidden
            BeginContext(497, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 23 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
                      
                            for (int c = 0; c < 6; c++)
                            {
                                var prefix = String.Format("btn_{0}_{1}_", c, r);
                                var btn_top_id = prefix + "top";
                                var btn_right_id = prefix + "right";
                                var btn_bottom_id = prefix + "bottom";
                                var btn_left_id = prefix + "left";

                                var position = String.Format("({0}, {1})", c, r);

#line default
#line hidden
            BeginContext(1075, 407, true);
            WriteLiteral(@"                            <td>
                                <div class=""drawer-editable"">
                                    <label>Drawer</label>
                                    <table>
                                        <tr>
                                            <td></td>
                                            <td>
                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1482, "\"", 1498, 1);
#line 40 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1487, btn_top_id, 1487, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1499, 18, true);
            WriteLiteral(" class=\"merge-btn\"");
            EndContext();
            BeginWriteAttribute("grid", " grid=\"", 1517, "\"", 1533, 1);
#line 40 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1524, position, 1524, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 402, true);
            WriteLiteral(@" merge_type=""top""><i class=""fas fa-table""></i> <i class=""fas fa-long-arrow-alt-up""></i></button>
                                            </td>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1936, "\"", 1953, 1);
#line 46 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1941, btn_left_id, 1941, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1954, 18, true);
            WriteLiteral(" class=\"merge-btn\"");
            EndContext();
            BeginWriteAttribute("grid", "  grid=\"", 1972, "\"", 1989, 1);
#line 46 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1980, position, 1980, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1990, 312, true);
            WriteLiteral(@" merge_type=""left""><i class=""fas fa-table""></i> <i class=""fas fa-long-arrow-alt-left""></i></button>
                                            </td>
                                            <td></td>
                                            <td>
                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2302, "\"", 2320, 1);
#line 50 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 2307, btn_right_id, 2307, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2321, 18, true);
            WriteLiteral(" class=\"merge-btn\"");
            EndContext();
            BeginWriteAttribute("grid", "  grid=\"", 2339, "\"", 2356, 1);
#line 50 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 2347, position, 2347, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2357, 407, true);
            WriteLiteral(@" merge_type=""right""><i class=""fas fa-table""></i> <i class=""fas fa-long-arrow-alt-right""></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td>
                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2764, "\"", 2783, 1);
#line 56 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 2769, btn_bottom_id, 2769, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2784, 18, true);
            WriteLiteral(" class=\"merge-btn\"");
            EndContext();
            BeginWriteAttribute("grid", "  grid=\"", 2802, "\"", 2819, 1);
#line 56 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
WriteAttributeValue("", 2810, position, 2810, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2820, 377, true);
            WriteLiteral(@" merge_type=""bottom""><i class=""fas fa-table""></i> <i class=""fas fa-long-arrow-alt-down""></i></button>
                                            </td>
                                            <td></td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
");
            EndContext();
#line 63 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3247, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 66 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3296, 77, true);
            WriteLiteral("\r\n\r\n    </table>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n\r\n");
            EndContext();
            BeginContext(3688, 49, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(3737, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596bd24b958a4c1eaf0bdce2941e665e", async() => {
                BeginContext(3759, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3775, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3813, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 89 "C:\Users\PC_KhanSenpi\Source\Repos\AliAlAali\ElectronicsStorage\ElectronicsStorage\Views\Home\Edit.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3887, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ES.Data.Model.StorageBox> Html { get; private set; }
    }
}
#pragma warning restore 1591
