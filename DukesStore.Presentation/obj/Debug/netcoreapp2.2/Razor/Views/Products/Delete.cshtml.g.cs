#pragma checksum "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef47de0d787ed17a22d758c2428fb0ee4a809bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Delete.cshtml", typeof(AspNetCore.Views_Products_Delete))]
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
#line 1 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\_ViewImports.cshtml"
using DukesStore.Presentation;

#line default
#line hidden
#line 2 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\_ViewImports.cshtml"
using DukesStore.ApplicationCore.Entities;

#line default
#line hidden
#line 3 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\_ViewImports.cshtml"
using DukesStore.ApplicationCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef47de0d787ed17a22d758c2428fb0ee4a809bd", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c42e2ad5fe6530617f702e962ac1b4b7ead7df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(61, 205, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\"><strong>DELETE PRODUCT: ");
            EndContext();
            BeginContext(267, 27, false);
#line 11 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                             Write(Model.ProductName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(294, 588, true);
            WriteLiteral(@"</strong></h1>
        <h3>
            <strong>Please click a Delete Buttn below to Erase product</strong>
        </h3>
    </div>

    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-primary shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">");
            EndContext();
            BeginContext(883, 47, false);
#line 25 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                                                              Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(930, 88, true);
            WriteLiteral("</div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">");
            EndContext();
            BeginContext(1019, 43, false);
#line 26 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                                           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 748, true);
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                ");
            EndContext();
            BeginContext(1811, 45, false);
#line 43 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 118, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">");
            EndContext();
            BeginContext(1975, 41, false);
#line 45 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                                           Write(Html.DisplayFor(model => model.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 745, true);
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                                ");
            EndContext();
            BeginContext(2762, 51, false);
#line 62 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(2813, 264, true);
            WriteLiteral(@"
                            </div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(3078, 47, false);
#line 66 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(3125, 828, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Pending Requests Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                ");
            EndContext();
            BeginContext(3954, 44, false);
#line 85 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(3998, 152, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                ");
            EndContext();
            BeginContext(4151, 53, false);
#line 88 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(4204, 618, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">

        <div class=""col-lg-3"">

            <!-- Product price-->
            <!-- Basic card-->
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary""> ");
            EndContext();
            BeginContext(4823, 41, false);
#line 108 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                              Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4864, 92, true);
            WriteLiteral("</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(4957, 44, false);
#line 111 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Price.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(5001, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5003, 59, false);
#line 111 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
                                                             Write(Html.DisplayFor(model => model.Price.Currency.CurrencyUnit));

#line default
#line hidden
            EndContext();
            BeginContext(5062, 273, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""col-lg-9"">
            <!-- Product Description -->
            <!-- Default Card -->
            <div class=""card mb-4"">
                <div class=""card-header"">
                    ");
            EndContext();
            BeginContext(5336, 39, false);
#line 121 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
               Write(Html.DisplayNameFor(p => p.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5375, 87, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(5463, 35, false);
#line 124 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
               Write(Html.DisplayFor(p => p.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5498, 146, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"offset-10\">\r\n            ");
            EndContext();
            BeginContext(5644, 707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef47de0d787ed17a22d758c2428fb0ee4a809bd15976", async() => {
                BeginContext(5670, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(5688, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ef47de0d787ed17a22d758c2428fb0ee4a809bd16377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 134 "D:\Phong\Demo\DukesStore\DukesStore.Presentation\Views\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5731, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(5749, 284, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef47de0d787ed17a22d758c2428fb0ee4a809bd18217", async() => {
                    BeginContext(5808, 221, true);
                    WriteLiteral("\r\n                    <span class=\"icon text-gray-600\">\r\n                        <i class=\"fas fa-arrow-left\"></i>\r\n                    </span>\r\n                    <span class=\"text\">Back to List</span>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6033, 311, true);
                WriteLiteral(@"
                <button type=""submit"" class=""btn btn-danger btn-icon-split"">
                    <span class=""icon text-white-50"">
                        <i class=""fas fa-trash""></i>
                    </span>
                    <span class=""text"">Delete</span>
                </button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6351, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
