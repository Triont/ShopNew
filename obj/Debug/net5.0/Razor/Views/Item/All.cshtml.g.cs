#pragma checksum "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c571161ae24e3a4d3bce565d6d792c5f4d84c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_All), @"mvc.1.0.view", @"/Views/Item/All.cshtml")]
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
#line 4 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
using NewShopApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
using NewShopApp.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c571161ae24e3a4d3bce565d6d792c5f4d84c3", @"/Views/Item/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd579fb10b5eeb8509b7e8674aa8d535410bfb11", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c571161ae24e3a4d3bce565d6d792c5f4d84c34125", async() => {
                WriteLiteral("\r\n        \r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 14 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
     if(Model!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         <table class=""table table-striped"">
              <thead>
    <tr>
    
      <th scope=""col"">Id</th>
      <th scope=""col"">Name</th>
       <th scope=""col"">Count</th>
        <th scope=""col"">Price</th>
        <th scope=""col"">Image</th>
        <th scope=""col""></th>
  
    </tr>
  </thead>
        
");
#nullable restore
#line 30 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
         foreach(var i in Model)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 35 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 36 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                  Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                 \r\n");
#nullable restore
#line 38 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                       if(@i.Quantity==0)
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <td>\r\n                         Not available\r\n                          \r\n                       </td>   \r\n");
#nullable restore
#line 44 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                      }
                      else
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <td>\r\n                           ");
#nullable restore
#line 48 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                      Write(i.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                       </td>\r\n");
#nullable restore
#line 50 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
                       Write(i.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                            <td>\r\n                            \r\n");
                WriteLiteral("                    <img class=\"img\"");
                BeginWriteAttribute("src", " src=\"", 1497, "\"", 1533, 2);
                WriteAttributeValue("", 1503, "/uploads/", 1503, 9, true);
#nullable restore
#line 58 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
WriteAttributeValue("", 1512, Url.Content(i.Image), 1512, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"64\" width=\"64\" />                    \r\n                      </td>\r\n                      <td>\r\n                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c571161ae24e3a4d3bce565d6d792c5f4d84c38079", async() => {
                    WriteLiteral("\r\n                               <input type=\"hidden\" name=\"ProductId\"");
                    BeginWriteAttribute("value", " value=\"", 1786, "\"", 1799, 1);
#nullable restore
#line 62 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
WriteAttributeValue("", 1794, i.Id, 1794, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                              <input type=\"submit\" value=\"Buy\" />\r\n                          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                      </td>\r\n\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 70 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </table>\r\n");
#nullable restore
#line 75 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Item\All.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
                WriteLiteral("       \r\n</div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
