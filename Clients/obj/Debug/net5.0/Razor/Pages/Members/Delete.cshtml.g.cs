#pragma checksum "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2adb990cb6630bec11ec0e147a1663ba6170005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clients.Pages.Members.Pages_Members_Delete), @"mvc.1.0.razor-page", @"/Pages/Members/Delete.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Delete.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2adb990cb6630bec11ec0e147a1663ba6170005", @"/Pages/Members/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65637445812cdcb904636f1e248130f0d3402a5d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Members_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mary\Desktop\Todo\Clients\Clients\Pages\Members\Delete.cshtml"
  
    try
    {
        String id = Request.Query["id"];

        String connectionString = "Data Source=localhost;Initial Catalog=clients;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            String sql = "DELETE FROM members WHERE id=@id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        
    }

    Response.Redirect("/Members/Index");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Members_Delete> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Members_Delete> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Members_Delete>)PageContext?.ViewData;
        public Pages_Members_Delete Model => ViewData.Model;
    }
}
#pragma warning restore 1591
