#pragma checksum "/Users/lda49/OneDrive - Sky/University/RiderProjects/DogShelter/AnimalShelter/Pages/Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d725b7436de30755dcdf8bf94a8e766a2a1ac38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AnimalShelter.Pages.Pages_Payment), @"mvc.1.0.razor-page", @"/Pages/Payment.cshtml")]
namespace AnimalShelter.Pages
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
#line 1 "/Users/lda49/OneDrive - Sky/University/RiderProjects/DogShelter/AnimalShelter/Pages/_ViewImports.cshtml"
using AnimalShelter;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d725b7436de30755dcdf8bf94a8e766a2a1ac38", @"/Pages/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d34a21b73591f772b30d46752c1dd2e123af4d8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/lda49/OneDrive - Sky/University/RiderProjects/DogShelter/AnimalShelter/Pages/Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""card"" style=""width: 18rem;"">
        <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 class=""card-title"">Card title</h5>
            <p class=""card-text"">DESCRIPTION</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
    </div>
    <div class=""card"" style=""width: 18rem;"">
        <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 class=""card-title"">Card title</h5>
            <p class=""card-text"">DESCRIPTION</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
    </div>
    <div class=""card"" style=""width: 18rem;"">
        <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 class=""card-title"">Invite a pet for dinner!</h5>
            <p class=""card-text"">Please donate £2.5 and invite a pet for tasty dinner</p>
            <button
                cla");
            WriteLiteral(@"ss=""btn btn-primary""
                id=""checkout-button-sku_GNvCSExh60khi5""
                role=""link"">
                I want to donate £2.5!
            </button>
        </div>
    </div>
</div>

<div>
    <div id=""error-message""></div>
</div>
<script>
(function() {
  var stripe = Stripe('pk_test_Wo3igAYKGtt9805nnsnmPC3n00WBO61Fyw');

  var checkoutButton = document.getElementById('checkout-button-sku_GNvCSExh60khi5');
  checkoutButton.addEventListener('click', function () {
    stripe.redirectToCheckout({
      items: [{sku: 'sku_GNvCSExh60khi5', quantity: 1}],

      successUrl: 'https://localhost:5001/',
      cancelUrl: 'https://localhost:5001/',
    })
    .then(function (result) {
      if (result.error) {
        var displayError = document.getElementById('error-message');
        displayError.textContent = result.error.message;
      }
    });
  });
})();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelter.Pages.Payment> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelter.Pages.Payment> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelter.Pages.Payment>)PageContext?.ViewData;
        public AnimalShelter.Pages.Payment Model => ViewData.Model;
    }
}
#pragma warning restore 1591
