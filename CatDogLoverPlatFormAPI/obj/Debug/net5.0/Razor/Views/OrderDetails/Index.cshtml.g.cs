#pragma checksum "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ada0a2fb08c248de094c542d2ceeaba9ef1b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_Index), @"mvc.1.0.view", @"/Views/OrderDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ada0a2fb08c248de094c542d2ceeaba9ef1b4f", @"/Views/OrderDetails/Index.cshtml")]
    #nullable restore
    public class Views_OrderDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BussinessObjects.OrderDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Item.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1370, "\"", 1404, 1);
#nullable restore
#line 52 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
WriteAttributeValue("", 1385, item.OrderDetailId, 1385, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1457, "\"", 1491, 1);
#nullable restore
#line 53 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
WriteAttributeValue("", 1472, item.OrderDetailId, 1472, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1546, "\"", 1580, 1);
#nullable restore
#line 54 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
WriteAttributeValue("", 1561, item.OrderDetailId, 1561, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "E:\Tailieu\Ki8\PRN231\Group\CatDogLoverPlatForm\CatDogLoverPlatFormAPI\Views\OrderDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BussinessObjects.OrderDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
