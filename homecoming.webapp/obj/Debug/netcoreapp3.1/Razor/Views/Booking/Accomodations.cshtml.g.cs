#pragma checksum "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42fb3129b4dc183c3cc4687747ab9e28dc992f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Accomodations), @"mvc.1.0.view", @"/Views/Booking/Accomodations.cshtml")]
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
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
using homecoming.webapp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fb3129b4dc183c3cc4687747ab9e28dc992f70", @"/Views/Booking/Accomodations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b6caf8dd4338175d51ef9c15eacd1d128426b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Accomodations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<homecoming.webapp.ViewModel.AccomodationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
  
    string stringUrl = "https://fileblob20.blob.core.windows.net/cloud-upload";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <section");
            BeginWriteAttribute("class", " class=\"", 240, "\"", 248, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-top:40px\">     \r\n           \r\n");
#nullable restore
#line 12 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 377, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"row-by-row2\">\r\n            <div class=\"location-image3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 487, "\"", 524, 3);
#nullable restore
#line 17 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
WriteAttributeValue("", 493, stringUrl, 493, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 503, "/", 503, 1, true);
#nullable restore
#line 17 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
WriteAttributeValue("", 504, Model[i].CoverPhoto, 504, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"img-descript\">\r\n                <a>\r\n                    <h3> ");
#nullable restore
#line 21 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
                    Write(Model[i].GeoLocation.LocationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </a>\r\n                <p>\r\n                    ");
#nullable restore
#line 24 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
               Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div class=\"form-group\" style=\"left:25px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42fb3129b4dc183c3cc4687747ab9e28dc992f707125", async() => {
                WriteLiteral("Show Prices");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
                                                                           WriteLiteral(Model[i].AccomodationRooms.First().RoomId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
                }                    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
#nullable restore
#line 34 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""margin-top:100px"">
        <div class=""mt-4 p-5 bg-info text-white rounded"">
            <h1>Sorry no accomodation Found</h1>
            <p class=""text-center"" style=""margin-top:80px; font-size:20px; font-weight:bold"">No Registered Business under this Location offering services through homecoming.com</p>
        </div>
    </div>
");
#nullable restore
#line 44 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
 if (ViewBag.price > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        alert(\"");
#nullable restore
#line 51 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
          Write(ViewBag.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n    </script>\r\n");
#nullable restore
#line 53 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Accomodations.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<homecoming.webapp.ViewModel.AccomodationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
