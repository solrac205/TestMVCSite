#pragma checksum "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/Home/CovidReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "365d21a686b9611e0c2b34ea3c96e2b9ad175715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CovidReport), @"mvc.1.0.view", @"/Views/Home/CovidReport.cshtml")]
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
#line 1 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/_ViewImports.cshtml"
using TestMVCSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/_ViewImports.cshtml"
using TestMVCSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"365d21a686b9611e0c2b34ea3c96e2b9ad175715", @"/Views/Home/CovidReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156ad8fcd85ebfd7f8a8f1a68bc15ba1993ed084", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CovidReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SelectListItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/Home/CovidReport.cshtml"
  
    ViewData["Title"] = "COVID Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>PRUEBA</h1>\n<h3>");
#nullable restore
#line 7 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/Home/CovidReport.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<style>
.button {
  border: none;
  color: white;
  width: 100px;
  height: 38px;
  padding: 6px 10px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 12px;
  margin: 4px 2px;
  transition-duration: 0.4s;
  cursor: pointer;
}

.button1 {
  background-color: white; 
  color: black; 
  border: 2px solid #4CAF50;
}

.button1:hover {
  background-color: #4CAF50;
  color: white;
}
.button2 {
  background-color: white; 
  color: black; 
  border: 2px solid #002752;
}

.button2:hover {
  background-color: #002752;
  color: white;
}
table{

width: 980px;
padding: 5px 5px;
border-bottom: 2px solid black;
border-top: 2px solid black;
border-left: 2px solid black;
border-right: 2px solid black;
}
td{
height: 8px;

}
tr{
width: 980px;
border: 2px solid black;
}
</style>
<div class=""form-group"">
    <table>
        <tr>
            <td style=""width: 300px;"">
                TOP 10 COVID CASES
            </td>
            <td>
               &nbsp;     
            </td>
        ");
            WriteLiteral(@"    <td>
               &nbsp;
            </td>
            <td>
               &nbsp;     
            </td>
            <td>
                &nbsp;                        
            </td>
            <td>
                &nbsp;                        
            </td>    
        </tr>
        <tr>
            <td style=""width: 300px;"">

                ");
#nullable restore
#line 87 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/Home/CovidReport.cshtml"
           Write(Html.DropDownList("Regions", Model, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    
            </td>
            <td>
                <button class=""button button1"">Report</button>
            </td>
            <td style=""width: 50px;"">
            
            </td>
            <td>
                <button class=""button button2"">XML</button>
            </td>
            <td>
                <button class=""button button2"">JSON</button>
            </td>
            <td>
                <button class=""button button2"">CSV</button>
            </td>
        </tr>
        <tr>
            <td style=""width: 300px;"">
                TOP 10 COVID CASES TO PROVINCES
            </td>
            <td>
               &nbsp;                         
            </td>
            <td>
               &nbsp;     
            </td>
            <td>
                &nbsp;                        
            </td>
            <td>
                &nbsp;                     
            </td>
            <td>
                &nbsp;                        
            </td>    
        ");
            WriteLiteral("</tr>\n        <tr>\n            <td style=\"width: 300px;\">\n\n                ");
#nullable restore
#line 129 "/Users/secureip/Projects/TestMVCSite/TestMVCSite/Views/Home/CovidReport.cshtml"
           Write(Html.DropDownList("Regions", Model, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    
            </td>
            <td>
                <button class=""button button1"">Report</button>
            </td>
            <td style=""width: 50px;"">
            
            </td>
            <td>
                <button class=""button button2"">XML</button>
            </td>
            <td>
                <button class=""button button2"">JSON</button>
            </td>
            <td>
                <button class=""button button2"">CSV</button>
            </td>
        </tr>
    </table>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SelectListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
