#pragma checksum "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b5af7a586d278657af573d21f40953eff393cf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BinQuery), @"mvc.1.0.view", @"/Views/Home/BinQuery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BinQuery.cshtml", typeof(AspNetCore.Views_Home_BinQuery))]
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
#line 1 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml"
using Wirecard.DeveloperPortal.Core.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b5af7a586d278657af573d21f40953eff393cf0", @"/Views/Home/BinQuery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BinQuery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml"
  
    ViewBag.Title = "BIN Sorgulama";

#line default
#line hidden
            BeginContext(159, 689, true);
            WriteLiteral(@"

<h2>BIN Sorgulama</h2>


<fieldset>
    <legend><label style=""font-weight:bold;width:250px;"">BIN Sorgulama Bilgileri</label></legend>
    <label style=""font-weight:bold;"">Servis Adı &nbsp; :   &nbsp; </label> MerchantQueries<br>
    <label style=""font-weight:bold;"">Operasyon Adı &nbsp; :&nbsp; </label> BinQueryOperation <br>
    <label style=""font-weight:bold;"">UserCode  &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">Pin &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">BIN &nbsp;:&nbsp;  </label> Kredi kartı numaranızın ilk 6 hanesi <br>


</fieldset>

<br />
");
            EndContext();
            BeginContext(848, 808, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f0c7f713e39486a86231f028e4f7344", async() => {
                BeginContext(902, 747, true);
                WriteLiteral(@"
    <fieldset>
        <!-- Form Name -->
        <legend><label style=""font-weight:bold;width:250px;"">BIN Sorgulama Detayları</label></legend>

        <!-- Text input-->

        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Kredi kartı numaranızın ilk 6 hanesi</label>
            <div class=""col-md-4"">
                <input name=""bin"" class=""form-control input-md"">
            </div>
        </div>

    </fieldset>


    <!-- Button -->
    <div class=""form-group"">
        <label class=""col-md-4 control-label"" for=""""></label>
        <div class=""col-md-4"">
            <button type=""submit"" id="""" name="""" class=""btn btn-success"">BIN Sorgula</button>
        </div>
    </div>
");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1656, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 50 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(1684, 19, true);
            WriteLiteral("    <pre>\r\n        ");
            EndContext();
            BeginContext(1704, 40, false);
#line 53 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml"
   Write(Html.Raw(Html.Encode(Model.XmlResponse)));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 14, true);
            WriteLiteral("\r\n    </pre>\r\n");
            EndContext();
#line 55 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BinQuery.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
