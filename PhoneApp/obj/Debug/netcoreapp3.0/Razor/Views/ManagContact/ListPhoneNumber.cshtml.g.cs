#pragma checksum "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "068ff2a6a09aa1bf8986a1d9179bd5a791375ee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagContact_ListPhoneNumber), @"mvc.1.0.view", @"/Views/ManagContact/ListPhoneNumber.cshtml")]
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
#line 1 "F:\PhoneApp\PhoneApp\Views\_ViewImports.cshtml"
using PhoneApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PhoneApp\PhoneApp\Views\_ViewImports.cshtml"
using PhoneApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PhoneApp\PhoneApp\Views\_ViewImports.cshtml"
using PhoneApp.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\PhoneApp\PhoneApp\Views\_ViewImports.cshtml"
using PhoneApp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"068ff2a6a09aa1bf8986a1d9179bd5a791375ee5", @"/Views/ManagContact/ListPhoneNumber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108661fe3d1107a7bd992543bb7a80233719581c", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagContact_ListPhoneNumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhoneContact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">شماره تلفن</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 17 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"
               Write(item.PhoneContactId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <span class=\"badge\"> ");
#nullable restore
#line 19 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"
                                    Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                </td>\r\n\r\n\r\n\r\n                <td>\r\n                   \r\n                    <a onclick=\"return confirm( \'ایا مایل ب حذف شماره هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 672, 2);
            WriteAttributeValue("", 611, "/ManagContact/DeletePhone?PhoneContactId=", 611, 41, true);
#nullable restore
#line 27 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"
WriteAttributeValue("", 652, item.PhoneContactId, 652, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"> حذف شماره</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 742, "\"", 810, 2);
            WriteAttributeValue("", 749, "/ManagContact/UpdatePhone?PhoneContactId=", 749, 41, true);
#nullable restore
#line 28 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"
WriteAttributeValue("", 790, item.PhoneContactId, 790, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">ویرایش شماره</a>\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 33 "F:\PhoneApp\PhoneApp\Views\ManagContact\ListPhoneNumber.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhoneContact>> Html { get; private set; }
    }
}
#pragma warning restore 1591