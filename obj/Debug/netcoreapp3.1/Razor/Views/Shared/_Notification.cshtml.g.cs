#pragma checksum "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\Shared\_Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d412d028698ee74c5b88a9be4f2a97edebe410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Notification), @"mvc.1.0.view", @"/Views/Shared/_Notification.cshtml")]
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
#line 1 "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\_ViewImports.cshtml"
using BulkyBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d412d028698ee74c5b88a9be4f2a97edebe410", @"/Views/Shared/_Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b283f6c8c7163b5f5d1f909d7b66a1ed4e3ccc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\Shared\_Notification.cshtml"
 if (TempData["Success"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\Shared\_Notification.cshtml"
Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ShubhamK\source\repos\BulkyBook\BulkyBook\Views\Shared\_Notification.cshtml"
                        ;
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
