#pragma checksum "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580db96948b3cb878dac5088dc46f8c0d5b6ac9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580db96948b3cb878dac5088dc46f8c0d5b6ac9e", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.WDTicketPaymentFormBaseResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
  
    ViewBag.Title = "Başarılı Ödeme İşlemi";

#line default
#line hidden
            BeginContext(132, 52, true);
            WriteLiteral("\r\n<h2>Ödemeniz Başarıyla gerçekleştirildi</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
 if (Model.OrderId != null)
{

#line default
#line hidden
            BeginContext(216, 363, true);
            WriteLiteral(@"    <div class=""col-md-6"">
        <fieldset>
            <!-- Form Name -->
            <legend>Ödemenize ait sonuçları aşağıdaki gibidir.</legend>
            <!-- Text input-->
            <div class=""col-md-12"">
                <label class=""col-md-4 control-label"" for="""">OrderId:</label>
                <div class=""col-md-4"">

                    ");
            EndContext();
            BeginContext(580, 13, false);
#line 20 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(593, 199, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">MPay:</label>\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 26 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                     if (Model.MPay != string.Empty)
                {
                        

#line default
#line hidden
            BeginContext(890, 10, false);
#line 28 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                   Write(Model.MPay);

#line default
#line hidden
            EndContext();
#line 28 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                                   
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1000, 3, false);
#line 32 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                    Write("-");

#line default
#line hidden
            EndContext();
#line 32 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                              
                    }

#line default
#line hidden
            BeginContext(1029, 226, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">  StatusCode</label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1256, 16, false);
#line 40 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.StatusCode);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 228, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> Result Code: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1501, 16, false);
#line 46 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.ResultCode);

#line default
#line hidden
            EndContext();
            BeginContext(1517, 232, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">  Result Message: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1750, 19, false);
#line 52 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.ResultMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1769, 236, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> LastTransactionDate: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(2006, 25, false);
#line 58 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.LastTransactionDate);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 227, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> MaskedCCNo: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(2259, 16, false);
#line 64 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.MaskedCCNo);

#line default
#line hidden
            EndContext();
            BeginContext(2275, 226, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> CCTokenId: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(2502, 15, false);
#line 70 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
               Write(Model.CCTokenId);

#line default
#line hidden
            EndContext();
            BeginContext(2517, 207, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> ExtraParam: </label>\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 76 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                     if (Model.ExtraParam != string.Empty)
                {
                        

#line default
#line hidden
            BeginContext(2828, 16, false);
#line 78 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                   Write(Model.ExtraParam);

#line default
#line hidden
            EndContext();
#line 78 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                                         
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(2944, 3, false);
#line 82 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                    Write("-");

#line default
#line hidden
            EndContext();
#line 82 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
                              
                    }

#line default
#line hidden
            BeginContext(2973, 77, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </fieldset>\r\n    </div>\r\n");
            EndContext();
#line 88 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Success.cshtml"
}

#line default
#line hidden
            BeginContext(3053, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wirecard.DeveloperPortal.Core.Response.WDTicketPaymentFormBaseResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
