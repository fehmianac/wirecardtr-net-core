#pragma checksum "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceDeactiveSubPartner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1490324002f179efd6fd1eb5a5ca9eb75f059756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MarketPlaceDeactiveSubPartner), @"mvc.1.0.view", @"/Views/Home/MarketPlaceDeactiveSubPartner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MarketPlaceDeactiveSubPartner.cshtml", typeof(AspNetCore.Views_Home_MarketPlaceDeactiveSubPartner))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1490324002f179efd6fd1eb5a5ca9eb75f059756", @"/Views/Home/MarketPlaceDeactiveSubPartner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MarketPlaceDeactiveSubPartner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceDeactiveSubPartner.cshtml"
  
    ViewBag.Title = "Pazaryeri Kapatma";

#line default
#line hidden
            BeginContext(51, 588, true);
            WriteLiteral(@"
<h2>Deactive Sub Partner</h2>
<fieldset>
    <legend><label style=""font-weight:bold;width:250px;"">MarketPlace Bilgileri</label></legend>
    <label style=""font-weight:bold;"">Servis Adı &nbsp; :   &nbsp; </label> CCMarketPlace<br>
    <label style=""font-weight:bold;"">Operasyon Adı &nbsp; :&nbsp; </label> DeactivateSubPartner <br>
    <label style=""font-weight:bold;"">UserCode  &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">Pin &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
   
</fieldset>
<br />
<br />
");
            EndContext();
            BeginContext(639, 773, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b37b87df6c843d7b99a72ccca5f18cb", async() => {
                BeginContext(693, 712, true);
                WriteLiteral(@"
    <fieldset>
        <!-- Form Name -->
        <legend><label style=""font-weight:bold;width:250px;"">UniqueId Değeri </label></legend>

      
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">UniqueId</label>
            <div class=""col-md-4"">
                <input name=""uniqueId"" class=""form-control input-md"" required="""">
            </div>
        </div>

    </fieldset>
  

    <!-- Button -->
    <div class=""form-group"">
        <label class=""col-md-4 control-label"" for=""""></label>
        <div class=""col-md-4"">
            <button type=""submit"" id="""" name="""" class=""btn btn-success"">Mağazayı Kapat</button>
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
            BeginContext(1412, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 42 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceDeactiveSubPartner.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(1440, 19, true);
            WriteLiteral("    <pre>\r\n        ");
            EndContext();
            BeginContext(1460, 40, false);
#line 45 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceDeactiveSubPartner.cshtml"
   Write(Html.Raw(Html.Encode(Model.XmlResponse)));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 14, true);
            WriteLiteral("\r\n    </pre>\r\n");
            EndContext();
#line 47 "C:\Projects\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceDeactiveSubPartner.cshtml"
}

#line default
#line hidden
            BeginContext(1517, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
