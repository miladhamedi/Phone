#pragma checksum "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b114f59584129dda8258b1dde46472b8843dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagContact_List), @"mvc.1.0.view", @"/Views/ManagContact/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b114f59584129dda8258b1dde46472b8843dbb", @"/Views/ManagContact/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108661fe3d1107a7bd992543bb7a80233719581c", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagContact_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
  
    ViewData["Title"] = " لیست مخاطبین";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">نام</th>
            <th scope=""col"">نام خانوادگی</th>
            <th scope=""col"">کدملی</th>
            <th scope=""col"">شماره موبایل</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 26 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
               Write(item.ContactId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
               Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
               Write(item.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n\r\n\r\n");
#nullable restore
#line 33 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
                     foreach (var item2 in item.PhoneContacts)

                    {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
                     if (item.PhoneContacts.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge\"> ");
#nullable restore
#line 38 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
                                    Write(item2.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
                       

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n\r\n\r\n                <td>\r\n\r\n                    <a onclick=\"return confirm( \'ایا مایل ب حذف کاربر هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1184, 2);
            WriteAttributeValue("", 1138, "/ManagContact/Delete?ContactId=", 1138, 31, true);
#nullable restore
#line 49 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
WriteAttributeValue("", 1169, item.ContactId, 1169, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"> حذف کاربر</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1254, "\"", 1307, 2);
            WriteAttributeValue("", 1261, "/ManagContact/Update?ContactID=", 1261, 31, true);
#nullable restore
#line 50 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"
WriteAttributeValue("", 1292, item.ContactId, 1292, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش کاربر</a>\r\n                    <a href=\"/ManagContact/ListPhoneNumber\" class=\"btn btn-info btn-sm\">ویرایش/حذف شماره</a>\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 56 "F:\PhoneApp\PhoneApp\Views\ManagContact\List.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
