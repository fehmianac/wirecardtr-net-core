#pragma checksum "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247189929ab2a9553bc39c27f8a7f831f784db8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Fail), @"mvc.1.0.view", @"/Views/Home/Fail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Fail.cshtml", typeof(AspNetCore.Views_Home_Fail))]
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
#line 1 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247189929ab2a9553bc39c27f8a7f831f784db8c", @"/Views/Home/Fail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Fail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.WDTicketPaymentFormBaseResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
  
    ViewBag.Title = "Fail";

#line default
#line hidden
            BeginContext(115, 35, true);
            WriteLiteral("\r\n<h2>Ödemeniz Başarısız</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
 if (Model.OrderId != null)
{

#line default
#line hidden
            BeginContext(182, 363, true);
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
            BeginContext(546, 13, false);
#line 20 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(559, 199, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">MPay:</label>\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 26 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                     if (Model.MPay != string.Empty)
                {
                        

#line default
#line hidden
            BeginContext(856, 10, false);
#line 28 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                   Write(Model.MPay);

#line default
#line hidden
            EndContext();
#line 28 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                                   
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(966, 3, false);
#line 32 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                    Write("-");

#line default
#line hidden
            EndContext();
#line 32 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                              
                    }

#line default
#line hidden
            BeginContext(995, 226, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">  StatusCode</label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1222, 16, false);
#line 40 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.StatusCode);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 228, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> Result Code: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1467, 16, false);
#line 46 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.ResultCode);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 232, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\">  Result Message: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1716, 19, false);
#line 52 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.ResultMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1735, 236, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> LastTransactionDate: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1972, 25, false);
#line 58 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.LastTransactionDate);

#line default
#line hidden
            EndContext();
            BeginContext(1997, 227, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> MaskedCCNo: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(2225, 16, false);
#line 64 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.MaskedCCNo);

#line default
#line hidden
            EndContext();
            BeginContext(2241, 226, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> CCTokenId: </label>\r\n                <div class=\"col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(2468, 15, false);
#line 70 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
               Write(Model.CCTokenId);

#line default
#line hidden
            EndContext();
            BeginContext(2483, 207, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <label class=\"col-md-4 control-label\" for=\"\"> ExtraParam: </label>\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 76 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                     if (Model.ExtraParam != string.Empty)
                {
                        

#line default
#line hidden
            BeginContext(2794, 16, false);
#line 78 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                   Write(Model.ExtraParam);

#line default
#line hidden
            EndContext();
#line 78 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                                         
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(2910, 3, false);
#line 82 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                    Write("-");

#line default
#line hidden
            EndContext();
#line 82 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
                              
                    }

#line default
#line hidden
            BeginContext(2939, 77, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </fieldset>\r\n    </div>\r\n");
            EndContext();
#line 88 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\Fail.cshtml"
}

#line default
#line hidden
            BeginContext(3019, 2, true);
            WriteLiteral("\r\n");
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
