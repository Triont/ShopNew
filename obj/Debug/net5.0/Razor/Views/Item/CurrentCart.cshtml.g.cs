#pragma checksum "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2ffbf6ff92419843e5df6375fba8951c4f3e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_CurrentCart), @"mvc.1.0.view", @"/Views/Item/CurrentCart.cshtml")]
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
#line 1 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\_ViewImports.cshtml"
using NewShopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
using NewShopApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
using NewShopApp.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2ffbf6ff92419843e5df6375fba8951c4f3e0d", @"/Views/Item/CurrentCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd579fb10b5eeb8509b7e8674aa8d535410bfb11", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_CurrentCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n    <div>\r\n        <div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 13 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
 if(Model!=null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
     if(Model.Products!=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"         <table class=""table table-striped"">
              <thead>
    <tr>
    
      <th scope=""col"">Id</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Image</th>
       <th scope=""col"">Price</th>
       
     
  
    </tr>
  </thead>
        
");
#nullable restore
#line 31 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
         foreach(var i in Model.Products)
        {
          

#line default
#line hidden
#nullable disable
            WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 36 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 37 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
                  Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>\r\n                        <img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 847, "\"", 884, 2);
            WriteAttributeValue("", 853, "/uploads/", 853, 9, true);
#nullable restore
#line 39 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
WriteAttributeValue("", 862, Url.Content(@i.Image), 862, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"64\" width=\"64\" />   \r\n                   </td>\r\n                     <td>");
#nullable restore
#line 41 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
                    Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
                   Write(Html.ActionLink("Remove", "RemoveFromCart","Item", new {id=@i.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  \r\n\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 47 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Total price</td>\r\n            <td>\r\n                \r\n            </td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
           Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n           </table>\r\n");
#nullable restore
#line 60 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\CurrentCart.cshtml"
     
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    </div>\r\n    </div>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
