#pragma checksum "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95fc2fafc231b36bc12ba2e4528253fbb137839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddOrUpdate), @"mvc.1.0.view", @"/Views/Product/AddOrUpdate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/AddOrUpdate.cshtml", typeof(AspNetCore.Views_Product_AddOrUpdate))]
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
#line 1 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\_ViewImports.cshtml"
using DemoProject;

#line default
#line hidden
#line 2 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\_ViewImports.cshtml"
using DemoProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95fc2fafc231b36bc12ba2e4528253fbb137839", @"/Views/Product/AddOrUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5c02823e45e62b1549594c69f9b51e88914cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_AddOrUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoProject.Models.ProductViewModel>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(86, 92, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Product</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 13 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
         using (Html.BeginForm("AddOrUpdate", "Product", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {
            

#line default
#line hidden
            BeginContext(329, 25, false);
#line 15 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(358, 46, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(405, 57, false);
#line 18 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.LabelFor(m => m.Name, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(462, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(477, 61, false);
#line 19 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(538, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(553, 74, false);
#line 20 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(627, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(692, 64, false);
#line 23 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.LabelFor(m => m.ProductType, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(756, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(773, 68, false);
#line 25 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.TextBoxFor(m => m.ProductType, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(841, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(856, 81, false);
#line 26 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.ValidationMessageFor(m => m.ProductType, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(937, 68, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1006, 58, false);
#line 31 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.LabelFor(m => m.Brand, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(1081, 62, false);
#line 33 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.TextBoxFor(m => m.Brand, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1158, 75, false);
#line 34 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.ValidationMessageFor(m => m.Brand, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 68, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1302, 58, false);
#line 39 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.LabelFor(m => m.Price, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(1377, 79, false);
#line 41 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.TextBoxFor(m => m.Price, new { type = "number", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1471, 75, false);
#line 42 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.ValidationMessageFor(m => m.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 68, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1615, 58, false);
#line 47 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.LabelFor(m => m.Stock, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1688, 79, false);
#line 48 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.TextBoxFor(m => m.Stock, new { type = "number", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1782, 75, false);
#line 49 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
       Write(Html.ValidationMessageFor(m => m.Stock, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 22, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n");
            EndContext();
            BeginContext(1881, 125, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n\r\n        </div>\r\n");
            EndContext();
#line 58 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
    }

#line default
#line hidden
            BeginContext(2013, 33, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2046, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95fc2fafc231b36bc12ba2e4528253fbb13783911573", async() => {
                BeginContext(2068, 12, true);
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
            BeginContext(2084, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "C:\Users\Matias\Desktop\DemoProject\DemoProject\DemoProject\Views\Product\AddOrUpdate.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoProject.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
