#pragma checksum "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e66373605745dad85a71c7b4e173d24619b3f56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllOrders), @"mvc.1.0.view", @"/Views/Admin/GetAllOrders.cshtml")]
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
#line 4 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
using NewShopApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
using NewShopApp.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e66373605745dad85a71c7b4e173d24619b3f56", @"/Views/Admin/GetAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd579fb10b5eeb8509b7e8674aa8d535410bfb11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StatusFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n<div id=\"select\">\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e66373605745dad85a71c7b4e173d24619b3f564900", async() => {
                WriteLiteral(@"
            
                      <input  type=""checkbox"" name=""Filter0""  value=""Unconfirmed"" />
                      <label>Unconfirmed</label> <br />
                       <input  type=""checkbox"" name=""Filter1"" value=""Confirmed"" />
                       <label>Confirmed</label><br />
                        <input  type=""checkbox"" name=""Filter2"" value=""Done"" />
                        <label>Done</label>
                  <input type=""submit"" />
              
           
               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               </div>\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 26 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
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
      <th scope=""col"">Second Name</th>
       <th scope=""col"">Phone</th>
        <th scope=""col"">Email</th>
        <th scope=""col"">TotalPrice</th>
        <th scope=""col"">Status</th>
        <th scope=""col""> create date time </th>
        <th scope=""col"">Action</th>
  
    </tr>
  </thead>
        <tbody id=""refresh"">
");
#nullable restore
#line 45 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
         foreach(var i in Model)
        {
            
          

#line default
#line hidden
#nullable disable
            WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 51 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 52 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 53 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 54 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 55 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 56 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 57 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 58 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(i.CreateDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>\r\n                       ");
#nullable restore
#line 60 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(Html.ActionLink("Confirm", "OrderConfirm", "Admin", new {id=i.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       ");
#nullable restore
#line 61 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
                  Write(Html.ActionLink("Remove", "RemoveOrder", "Admin", new {id=i.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     \r\n\r\n                   </td>\r\n             </tr>\r\n");
#nullable restore
#line 66 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
      
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n           </table>\r\n");
#nullable restore
#line 70 "C:\Users\user\source\repos\NewShopApp\NewShopApp\Views\Admin\GetAllOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e66373605745dad85a71c7b4e173d24619b3f5611785", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        
       $(document).ready(function () {
    var myInterval = setInterval(function () {
        getProgress();
    }, 5000);
});
var test;
function getProgress() {
   

    $.ajax({
        type: ""GET"",      
        url:'/Admin/GetAllOrdersJson' ,
      
  
        success: function (response) {
        
       
           var q_tb= document.getElementById(""refresh"");
         $('#refresh').empty();
      console.log(response);
         for(var i=0; i<response.length;i++)

         {
             if(response[i].status==""Confirmed"")
             {
            
                   $('#refresh').append(`<tr><td>${response[i].id}</td><td>${response[i].name}</td><td>${response[i].secondName}</td>
                <td>${response[i].phone}</td><td>${response[i].email}</td><td>${response[i].totalPrice}</td>
                <td>${response[i].status}</td><td>${response[i].createDateTime}</td>
                <td><a href=""/Admin/OrderDone/${respo");
                WriteLiteral(@"nse[i].id}"">Done</a> </td>
               </tr>`);
               }
               else if(response[i].status=""Uncofirmed"")
               {
                      $('#refresh').append(`<tr><td>${response[i].id}</td><td>${response[i].name}</td><td>${response[i].secondName}</td>
                <td>${response[i].phone}</td><td>${response[i].email}</td><td>${response[i].totalPrice}</td>
                <td>${response[i].status}</td><td>${response[i].createDateTime}</td>
                <td><a href=""/Admin/OrderConfirm/${response[i].id}"">Confirm</a>
                <a href=""/Admin/RemoveOrder/${response[i].id}"">Remove</a>
                </td>
               </tr>`);
               }
               else if(response[i].status=""Done"")
               {
                      $('#refresh').append(`<tr><td>${response[i].id}</td><td>${response[i].name}</td><td>${response[i].secondName}</td>
                <td>${response[i].phone}</td><td>${response[i].email}</td><td>${response[i].totalPrice}</td>
     ");
                WriteLiteral(@"           <td>${response[i].status}</td><td>${response[i].createDateTime}</td>
                <td><a href=""/Admin/RemoveOrder/${response[i].id}"">Remove</a> </td>
               </tr>`);

               }
               console.log(response[i].id);
               
             
         }
   
   

            
          
        },
        error: function () {
           alert(""error"")   
        }

    });
}

    </script>
 ");
            }
            );
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
