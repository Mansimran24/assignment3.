#pragma checksum "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "460b2c5bbaeebfc209799839f9e1016fc50a9ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fooddelivery.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace fooddelivery.Pages
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
#line 1 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\_ViewImports.cshtml"
using fooddelivery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460b2c5bbaeebfc209799839f9e1016fc50a9ca8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2b312bf54cb75da0aaaccadecd983695297438", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
  
    var items = new[]{
        new{
            Fitem="Burger",
            Price="$7",
            TotalItems= "1"
        },
        new{
            Fitem="Combo Veg Meal",
            Price="$22.88",
            TotalItems="6"
        },
        new{
            Fitem="Grilled Sandwich",
            Price="$6.25",
            TotalItems="2"
        },
        new{
            Fitem="Chicken Nuggets",
            Price="$12.25",
            TotalItems="8 pieces"
        },
        new{
            Fitem="Pizza",
            Price="$8.75",
            TotalItems="1"
        }
    };

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
 for (var i = 0; i <items.Length; i++)
{
    var pro =items[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong> Food Item :");
#nullable restore
#line 43 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
                          Write(pro.Fitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br/> </strong>\r\n            Price:");
#nullable restore
#line 44 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
             Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n            Total Items:");
#nullable restore
#line 45 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
                   Write(pro.TotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/> ");
#nullable restore
#line 45 "C:\Users\HP\Downloads\onlinedelivery\fooddelivery\Pages\Index.cshtml"
                                                     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591