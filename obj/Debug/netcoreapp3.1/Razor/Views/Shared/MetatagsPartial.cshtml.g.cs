#pragma checksum "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297c46b0df5cb1ab09afe24f418da49ef1385cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297c46b0df5cb1ab09afe24f418da49ef1385cb8", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3eb6070df14287fbf59745d8acd9ee41cb8dbb", @"/Views/_Viewimports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 3 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 5 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 6 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<title>");
#nullable restore
#line 9 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
  Write(Collections.Service.Config.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 10 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 320, "\"", 350, 1);
#nullable restore
#line 13 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 330, ViewBag.Description, 330, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 14 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 419, "\"", 446, 1);
#nullable restore
#line 17 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 429, ViewBag.Keywords, 429, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 18 "C:\Users\zaben\Desktop\Попытка2\Collections\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
