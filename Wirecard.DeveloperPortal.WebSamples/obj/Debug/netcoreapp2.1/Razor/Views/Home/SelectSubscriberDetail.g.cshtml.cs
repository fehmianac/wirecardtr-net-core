#pragma checksum "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe6d3eed46bbf9ba2c5db03008513c2b6bef550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectSubscriberDetail), @"mvc.1.0.view", @"/Views/Home/SelectSubscriberDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SelectSubscriberDetail.cshtml", typeof(AspNetCore.Views_Home_SelectSubscriberDetail))]
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
#line 1 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
using System.Xml.Linq;

#line default
#line hidden
#line 2 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
using Wirecard.DeveloperPortal.Core;

#line default
#line hidden
#line 3 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 4 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
using SubscriberService;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe6d3eed46bbf9ba2c5db03008513c2b6bef550", @"/Views/Home/SelectSubscriberDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectSubscriberDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MSubscriberDetailOutput>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
  
    ViewBag.Title = "SelectSubscriberDetail";

#line default
#line hidden
            BeginContext(200, 43, true);
            WriteLiteral("\r\n<h2> Abone Detay Bilgileri</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(243, 946, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9aade443a9413e8fad35bf53d2c3cc", async() => {
                BeginContext(273, 633, true);
                WriteLiteral(@"

    <!-- Text input-->
    <div class=""form-group"">
        <label class=""col-md-12 control-label"" for="""">Abonelik Numarası:</label>
        <div class=""col-md-6"">
            <input name=""subscriberId"" type=""text"" value="""" class=""form-control"" required="""">
        </div>
        <label class=""col-md-12 control-label"" for=""""></label>
        <div class=""col-md-4"">
            <br />
            <button type=""submit"" id="""" name="""" class=""btn btn-danger"">Abone Detay Sorgula</button>
        </div>
        <label class=""col-md-12 control-label"" for=""""></label>
        <div class=""col-md-6"">
            <pre>

");
                EndContext();
#line 30 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
             if (Model!= null)
            {
                string xmlFormatted = XDocument.Parse(XmlBuilder.GetXMLFromObjectWCFService(Model)).ToString();
                

#line default
#line hidden
                BeginContext(1083, 35, false);
#line 33 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
           Write(Html.Raw(Html.Encode(xmlFormatted)));

#line default
#line hidden
                EndContext();
#line 33 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\SelectSubscriberDetail.cshtml"
                                                    ;
            }

#line default
#line hidden
                BeginContext(1136, 46, true);
                WriteLiteral("        </pre>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1189, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MSubscriberDetailOutput> Html { get; private set; }
    }
}
#pragma warning restore 1591
