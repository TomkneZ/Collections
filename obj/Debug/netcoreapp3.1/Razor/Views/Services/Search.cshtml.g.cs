#pragma checksum "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69794633fde8ee52d4c0e16a171615c99fc7bc91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Search), @"mvc.1.0.view", @"/Views/Services/Search.cshtml")]
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
#line 2 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\_Viewimports.cshtml"
using Collections.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\_Viewimports.cshtml"
using Collections.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\_Viewimports.cshtml"
using Collections.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69794633fde8ee52d4c0e16a171615c99fc7bc91", @"/Views/Services/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3eb6070df14287fbf59745d8acd9ee41cb8dbb", @"/Views/_Viewimports.cshtml")]
    public class Views_Services_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"div-box\">\r\n        <table width=\"100%\" cellpadding=\"5\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
             foreach (Item i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 9 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 12 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                   Write(i.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 14 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 1) == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 16 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Num1Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 17 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 2) == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 20 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Num2Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 4) == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Num3Value</td>\r\n");
#nullable restore
#line 25 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 8) == 8)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 28 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Input1Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 16) == 16)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 32 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Input2Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 32) == 32)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 36 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Input3Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 64) == 64)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 40 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Textarea1Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 128) == 128)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 44 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Textarea2Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 256) == 256)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 48 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Textarea3Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 512) == 512)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 52 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Date1Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 1024) == 1024)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 56 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Date2Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 2048) == 2048)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 60 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Date3Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 4096) == 4096)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 64 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Checkbox1Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 8192) == 8192)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 68 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Checkbox2Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                     if ((i.itemFields & 16384) == 16384)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 72 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                       Write(i.Checkbox3Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 73 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Services\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
