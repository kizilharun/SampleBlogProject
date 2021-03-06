#pragma checksum "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078876418821231a6acdf06062f059e605612c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\_ViewImports.cshtml"
using SampleCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\_ViewImports.cshtml"
using SampleCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078876418821231a6acdf06062f059e605612c8d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1162530011c609a8f817252ca464199f50633e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">New Blogs</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 584, "\"", 621, 2);
            WriteAttributeValue("", 591, "/Blog/BlogReadAll/", 591, 18, true);
#nullable restore
#line 18 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 609, item.BlogId, 609, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                     ,           <img");
            BeginWriteAttribute("src", " src=\"", 662, "\"", 683, 1);
#nullable restore
#line 19 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 668, item.BlogImage, 668, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 715, "\"", 721, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 25 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 35 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1896, "\"", 1933, 2);
            WriteAttributeValue("", 1903, "/Blog/BlogReadAll/", 1903, 18, true);
#nullable restore
#line 41 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1921, item.BlogId, 1921, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 43 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                                                      Write(item.BlogContent.Length > 130 ? item.BlogContent.Substring(0,item.BlogContent.Substring(0,100).LastIndexOf(" "))+".." : item.BlogContent+"..");

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2239, "\"", 2276, 2);
            WriteAttributeValue("", 2246, "/Blog/BlogReadAll/", 2246, 18, true);
#nullable restore
#line 44 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2264, item.BlogId, 2264, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\kizil\source\repos\SampleCoreProject\SampleCoreProject\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
