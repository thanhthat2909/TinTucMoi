#pragma checksum "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a49406505d8455c60002fa5e172f267e504d3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_bantin_Index), @"mvc.1.0.view", @"/Views/bantin/Index.cshtml")]
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
#line 1 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\_ViewImports.cshtml"
using HeThongTinTuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\_ViewImports.cshtml"
using HeThongTinTuc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a49406505d8455c60002fa5e172f267e504d3bd", @"/Views/bantin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d378065e87d55e62df38340c335cf861e08ab8f2", @"/Views/_ViewImports.cshtml")]
    public class Views_bantin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HeThongTinTuc.Models.bantin>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-8 my-3\">\r\n        <h2 class=\"text-primary\">Danh Sách Bản Tin</h2>\r\n    </div>\r\n    <div class=\"col-4 my-3\">\r\n        <div class=\"row \">\r\n");
#nullable restore
#line 13 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
             using (Html.BeginForm("Index", "bantin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"fsearch input-group m-1 p-1\">\r\n                    ");
#nullable restore
#line 16 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.TextBox("Searching", "", new { @class = "fs border-primary rounded-left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button class=\"btn btn-primary\" type=\"submit\">Tìm Kiếm</button>\r\n                </p>\r\n");
#nullable restore
#line 19 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a49406505d8455c60002fa5e172f267e504d3bd7622", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" style=\"border: 1px\">\r\n    <thead>\r\n        <tr class=\"text-dark text-center\" style=\"background-color:yellow\">\r\n            <th width=\"2%\">\r\n                ");
#nullable restore
#line 31 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tieude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th >\r\n            <th width=\"3%\">\r\n                ");
#nullable restore
#line 34 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tomtat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 37 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.noidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"8%\">\r\n                ");
#nullable restore
#line 40 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ngaydang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"2%\">\r\n                ");
#nullable restore
#line 43 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nguoidang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.hinhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tieudehinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"3%\">\r\n                ");
#nullable restore
#line 52 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.luotxem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"3%\">\r\n                ");
#nullable restore
#line 55 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.noibat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"3%\">\r\n                ");
#nullable restore
#line 58 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.kichhoat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"7%\">\r\n                ");
#nullable restore
#line 61 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.chuyenmuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th width=\"5%\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 67 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.tieude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.tomtat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.noidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ngaydang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nguoidang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a49406505d8455c60002fa5e172f267e504d3bd14465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2807, "~/images/", 2807, 9, true);
#nullable restore
#line 86 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
AddHtmlAttributeValue("", 2816, Html.DisplayFor(modelItem => item.hinhanh), 2816, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.tieudehinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.luotxem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.noibat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.kichhoat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.chuyenmuc.tenchuyenmuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a49406505d8455c60002fa5e172f267e504d3bd17819", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
                                                                           WriteLiteral(item.bantinid);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a49406505d8455c60002fa5e172f267e504d3bd20101", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
                                                                           WriteLiteral(item.bantinid);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a49406505d8455c60002fa5e172f267e504d3bd22386", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
                                                                            WriteLiteral(item.bantinid);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 109 "D:\New folder\HeThongTinTuc\HeThongTinTuc\Views\bantin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HeThongTinTuc.Models.bantin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
