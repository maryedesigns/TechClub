#pragma checksum "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a51822e4dbfdd2b4dbe773611a980e230cd9f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clients.Pages.Members.Pages_Members_Index), @"mvc.1.0.razor-page", @"/Pages/Members/Index.cshtml")]
namespace Clients.Pages.Members
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
#line 1 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\_ViewImports.cshtml"
using Clients;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a51822e4dbfdd2b4dbe773611a980e230cd9f0b", @"/Pages/Members/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65637445812cdcb904636f1e248130f0d3402a5d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Members_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<h2>List of Members</h2>
<a class=""btn btn-primary btn-sm"" href=""/Members/Create"">New Member</a>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Created At</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
         foreach(var item in Model.listMembers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
               Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\" href=\"/Members/Edit?id=\">Edit</a>\r\n                    <a class=\"btn btn-danger btn-sm\" href=\"/Members/Delete?id=\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clients.Pages.Members.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clients.Pages.Members.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clients.Pages.Members.IndexModel>)PageContext?.ViewData;
        public Clients.Pages.Members.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
