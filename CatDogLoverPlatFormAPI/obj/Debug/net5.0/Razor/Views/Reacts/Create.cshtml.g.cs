#pragma checksum "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Reacts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d929cc0a524f6be4da9f1144941d733cee042c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reacts_Create), @"mvc.1.0.view", @"/Views/Reacts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d929cc0a524f6be4da9f1144941d733cee042c", @"/Views/Reacts/Create.cshtml")]
    #nullable restore
    public class Views_Reacts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BussinessObjects.React>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Reacts\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>React</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""AccountId"" class=""control-label""></label>
                <select asp-for=""AccountId"" class =""form-control"" asp-items=""ViewBag.AccountId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostId"" class=""control-label""></label>
                <select asp-for=""PostId"" class =""form-control"" asp-items=""ViewBag.PostId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReactTypeId"" class=""control-label""></label>
                <select asp-for=""ReactTypeId"" class =""form-control"" asp-items=""ViewBag.ReactTypeId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""bt");
            WriteLiteral("n btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Reacts\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BussinessObjects.React> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591