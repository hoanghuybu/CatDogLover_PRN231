#pragma checksum "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Posts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49629edb23e28ff065de5aefcdb4af888159f73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Create), @"mvc.1.0.view", @"/Views/Posts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49629edb23e28ff065de5aefcdb4af888159f73e", @"/Views/Posts/Create.cshtml")]
    #nullable restore
    public class Views_Posts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BussinessObjects.Post>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Posts\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Post</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label""></label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-validation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Content"" class=""control-label""></label>
                <input asp-for=""Content"" class=""form-control"" />
                <span asp-validation-for=""Content"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OwnerId"" class=""control-label""></label>
                <select asp-for=""OwnerId"" class =""form-control"" asp-items=""ViewBag.OwnerId""></select>
            </div>
            <div class=""form-group""");
            WriteLiteral(@">
                <label asp-for=""Type"" class=""control-label""></label>
                <input asp-for=""Type"" class=""form-control"" />
                <span asp-validation-for=""Type"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateDate"" class=""control-label""></label>
                <input asp-for=""CreateDate"" class=""form-control"" />
                <span asp-validation-for=""CreateDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Status"" /> ");
#nullable restore
#line 41 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Posts\Create.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Posts\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BussinessObjects.Post> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
