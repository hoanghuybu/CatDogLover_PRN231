#pragma checksum "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Accounts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d30bf1bae687eb779f48f9769584d13a29ddd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Create), @"mvc.1.0.view", @"/Views/Accounts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d30bf1bae687eb779f48f9769584d13a29ddd1", @"/Views/Accounts/Create.cshtml")]
    #nullable restore
    public class Views_Accounts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BussinessObjects.Account>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Accounts\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Account</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FullName"" class=""control-label""></label>
                <input asp-for=""FullName"" class=""form-control"" />
                <span asp-validation-for=""FullName"" class=""text-danger""></span>
   ");
            WriteLiteral(@"         </div>
            <div class=""form-group"">
                <label asp-for=""DateOfBirth"" class=""control-label""></label>
                <input asp-for=""DateOfBirth"" class=""form-control"" />
                <span asp-validation-for=""DateOfBirth"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RoleId"" class=""control-label""></label>
                <select asp-for=""RoleId"" class =""form-control"" asp-items=""ViewBag.RoleId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Phone"" class=""control-label""></label>
                <input asp-for=""Phone"" class=""form-control"" />
                <span asp-validation-for=""Phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BanReason"" class=""control-label""></label>
                <input asp-for=""BanReason"" class=""form-control"" />
                <span asp-validatio");
            WriteLiteral(@"n-for=""BanReason"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateDate"" class=""control-label""></label>
                <input asp-for=""CreateDate"" class=""form-control"" />
                <span asp-validation-for=""CreateDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address"" class=""control-label""></label>
                <input asp-for=""Address"" class=""form-control"" />
                <span asp-validation-for=""Address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AvatarLink"" class=""control-label""></label>
                <input asp-for=""AvatarLink"" class=""form-control"" />
                <span asp-validation-for=""AvatarLink"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></l");
            WriteLiteral(@"abel>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Status"" /> ");
#nullable restore
#line 71 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Accounts\Create.cshtml"
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
#line 86 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Accounts\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BussinessObjects.Account> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591