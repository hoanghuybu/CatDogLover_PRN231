#pragma checksum "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268918ef38d35b4722597e1059043dfca432d03d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Create), @"mvc.1.0.view", @"/Views/Orders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268918ef38d35b4722597e1059043dfca432d03d", @"/Views/Orders/Create.cshtml")]
    #nullable restore
    public class Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BussinessObjects.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Order</h4>
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
                <label asp-for=""TotalPrice"" class=""control-label""></label>
                <input asp-for=""TotalPrice"" class=""form-control"" />
                <span asp-validation-for=""TotalPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderDate"" class=""control-label""></label>
                <input asp-for=""OrderDate"" class=""form-control"" />
                <span asp-validation-for=""OrderDate"" class=""text-danger""></span>
            </div>
       ");
            WriteLiteral("     <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"Status\" /> ");
#nullable restore
#line 31 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Orders\Create.cshtml"
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
#line 46 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\Orders\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BussinessObjects.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591