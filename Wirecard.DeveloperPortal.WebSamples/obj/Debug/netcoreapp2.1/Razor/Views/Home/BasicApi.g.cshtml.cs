#pragma checksum "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BasicApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e88397b51c713c3f5039afa43838876b65ae7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BasicApi), @"mvc.1.0.view", @"/Views/Home/BasicApi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BasicApi.cshtml", typeof(AspNetCore.Views_Home_BasicApi))]
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
#line 1 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e88397b51c713c3f5039afa43838876b65ae7a0", @"/Views/Home/BasicApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BasicApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\BasicApi.cshtml"
  
    ViewBag.Title = "BasicApi";

#line default
#line hidden
            BeginContext(42, 1596, true);
            WriteLiteral(@"



<h2>BasicApi</h2>

<div class=""alert alert-warning"">

    <p>Bu satış türünü kullanabilmeiniz için öncelikli olarak Mikro Ödeme| 3Pay müşteri panelinden bir ürün tanımlamanız ve bu ürün için onay aldıktan sonra, satış linkini sitenize ekleyebilirsiniz. </p>
</div>
<h2>Ürün Bilgileri</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>
               Ürün Adı
            </th>
            <th>
               Kategori
            </th>
            <th>
               Satış Türü
            </th>
            <th>
                Fiyat (Turkcell)
            </th>
            <th>
                Fiyat (AVEA)
            </th>
            <th>
                Fiyat (CreditCardPayment)
            </th>
            <th>
                Fiyat (VodafoneMobilePayment)
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                Mobil uygulama
            </td>
            <td>
                Mobil Uygulama / Stor");
            WriteLiteral(@"e
            </td>
            <td>
                Tekil Ürün
            </td>
            <td>
                0,01 TL
            </td>
            <td>
                0,01 TL
            </td> 
            <td>
                0,01 TL
            </td> 
             <td>
                0,01 TL
            </td>
        </tr>

    </tbody>
</table>
<div>
  
    <p>
        <strong><a class=""btn btn-danger"" href=""http://www.mikro-odeme.com/sale-api/tr/step1.aspx?partner=20923&product=11391"">Satın Al </a></strong>
    </p>
</div>


");
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